using System;
using System.CodeDom.Compiler;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Microsoft.CSharp;
using Pascal.Generated;
using System.Threading;

namespace Pascal
{
    class Program
    {
        static string TranslatePascalToCSharp(string pascal)
        {
            ICharStream input = new AntlrInputStream(pascal);
            PascalLexer pascalLexer = new PascalLexer(input);
            ITokenStream tokenStream = new CommonTokenStream(pascalLexer);
            PascalParser pascalParser = new PascalParser(tokenStream) { ErrorHandler = new BailErrorStrategy() };
            
            var listener = new PascalParser.PascalListener();
            pascalParser.AddParseListener(listener);
            pascalParser.program();

            return listener.Code;
        }

        static void Compile(string csharp, string programName)
        {
            Console.WriteLine("Compiling...");
            CSharpCodeProvider provider = new CSharpCodeProvider();
            provider.CompileAssemblyFromSource(new CompilerParameters(new string[0], @"exes\" + programName) { GenerateExecutable = true}, csharp);
        }

        static void Main(string[] args)
        {
            const string path = @"tests\";
            string[] files;
            try
            {
                files = Directory.GetFiles(path, "*.txt");
            }
            catch(IOException)
            {
                Console.WriteLine("Put .exe file near tests folder");
                Thread.Sleep(1500);
                return;
            }

            for (int i = 0; i < files.Length; i++)
            {
                try
                {
                    string pascal = File.ReadAllText(files[i]);
                    string csharp = TranslatePascalToCSharp(pascal);

                    Compile(csharp, Path.GetFileNameWithoutExtension(files[i]) + ".exe");

                    Console.WriteLine("Creating cs file...");
                    File.WriteAllLines(@"css\" + Path.GetFileNameWithoutExtension(files[i]) + ".cs", new[] { csharp });
                }
                catch (ParseCanceledException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Syntax error!");
                    //Console.WriteLine(e.InnerException.Message);

                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    Thread.Sleep(1500);
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Done!");
            Console.ResetColor();
            Thread.Sleep(2000);
        }

    }
}
