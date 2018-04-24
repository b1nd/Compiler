using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;

namespace Pascal.Generated
{
    static class Util
    {
        private static Dictionary<string, string> OperatorsMap = new Dictionary<string, string>
        {
            ["AND"] = "&&",
            ["DIV"] = "/",
            ["MOD"] = "%",
            ["NOT"] = "!",
            ["OR"] = "||",
            ["+"] = "+",
            ["-"] = "-",
            ["*"] = "*",
            ["="] = "==",
            ["<>"] = "!=",
            ["<"] = "<",
            ["<="] = "<=",
            [">"] = ">",
            [">="] = ">=",
        };
        
        public static string GetString(IParseTree tree)
        {
            string s = tree.GetText();
            s = s.Substring(1, s.Length - 2);
            s = s.Replace("\"", "\\\"");
            s = s.Replace("''", "'");
            return $"\"{s}\"";
        }

        public static string FormatTerm(IList<IToken> operations, IEnumerable<string> operands)
        {
            using (var e = operands.GetEnumerator())
            {
                e.MoveNext();

                if (operations.Count == 0)
                    return e.Current;

                var sb = new StringBuilder("(")
                    .Append(e.Current);

                for (int i = 0; e.MoveNext(); ++i)
                    sb.Append(OperatorsMap[operations[i].Text.ToUpper()]).Append(e.Current);

                return sb.Append(")").ToString();
            }
        }
    }

    partial class PascalParser
    {
        public class PascalListener : PascalBaseListener
        {
            private readonly List<object> _codeParts = new List<object>();

            private readonly Dictionary<string, bool[]> _procedures = new Dictionary<string, bool[]>()
            {
                ["write"] = null,
                ["writeln"] = null,
                ["readln"] = new[] { true }
            };

            public string Code
            {
                get
                {
                    return string.Join("", _codeParts.Select(i => i is IParseTree ? ((IParseTree)i).GetText() : i));
                }
            }

            protected void Append(params object[] objects)
            {
                _codeParts.AddRange(objects);
            }
            protected void AppendLine(params object[] objects)
            {
                _codeParts.AddRange(objects);
                _codeParts.Add(Environment.NewLine);
            }

            private static string AsType(IParseTree tree)
            {
                return tree.GetText() == "String" ? "string" : "int";
            }

            public override void EnterProgram(ProgramContext context)
            {
                AppendLine("using System;");
                AppendLine("class Program {");
                AppendLine("static void readln<T>(ref T arg) {");
                AppendLine("    arg = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));");
                AppendLine("}");
                AppendLine("static void writeln(params object[] args) {");
                AppendLine("    Console.WriteLine(string.Join(string.Empty, args));");
                AppendLine("}");
                AppendLine("static void write(params object[] args) {");
                AppendLine("    Console.Write(string.Join(string.Empty, args));");
                AppendLine("}");

            }
            public override void ExitProgram(ProgramContext context)
            {
                AppendLine("} // program");
            }

            public override void ExitVariableDeclaration(VariableDeclarationContext context)
            {
                string variablesType = AsType(context.GetChild<TypeIdentifierContext>(0));

                IList<IParseTree> variables = context.GetChild<IdentifierListContext>(0).children;

                for (int i = 0; i < variables.Count; i += 2)
                    AppendLine(variablesType, " ", variables[i].GetText().ToLower(), " = default(", variablesType, ");");
            }

            public override void ExitProcedureHeader(ProcedureHeaderContext context)
            {
                var isRefs = new List<bool>();
                foreach (var group in context._groups)
                    isRefs.AddRange(Enumerable.Repeat(group.varToken != null, group._vars.Count));

                _procedures.Add(context.name.GetText().ToLower(), isRefs.ToArray());


                Append("void ", context.name.GetText().ToLower(), "(");

                Append(string.Join(", ", context._groups.Select(i =>
                {
                    string type = AsType(i.type);
                    string isRef = i.varToken != null ? "ref " : "";
                    return string.Join(
                        ", ",
                        i._vars.Select(j => $"{isRef}{type} {j.GetText().ToLower()}")
                    );
                })));

                AppendLine(")");
            }

            //public override void ExitProcedureIdentifier(ProcedureIdentifierContext context)
            //{
            //    Append("void ", context.GetText().ToLower());
            //}
            //public override void EnterFormalParameterList(FormalParameterListContext context)
            //{
            //    Append("(");
            //}
            //public override void ExitFormalParameterList(FormalParameterListContext context)
            //{
            //    _codeParts[_codeParts.Count - 1] = ")";
            //    AppendLine();
            //}

            //public override void ExitParameterGroup(ParameterGroupContext context)
            //{
            //    string variablesType = AsType(context.GetChild<TypeIdentifierContext>(0));

            //    IList<IParseTree> variables = context.GetChild<IdentifierListContext>(0).children;

            //    for (int i = 0; i < variables.Count; i += 2)
            //        Append(variablesType, " ", variables[i].GetText().ToLower(), ",");
            //}
            //public override void ExitRefParameterGroup(RefParameterGroupContext context)
            //{
            //    string variablesType = AsType(context.GetChild<TypeIdentifierContext>(0));

            //    IList<IParseTree> variables = context.GetChild<IdentifierListContext>(0).children;

            //    for (int i = 0; i < variables.Count; i += 2)
            //        Append("ref ", variablesType, " ", variables[i].GetText().ToLower(), ",");
            //}

            public override void EnterBlock(BlockContext context)
            {
                AppendLine("{ // block");
            }
            public override void ExitBlock(BlockContext context)
            {
                AppendLine("} // block");
            }

            public override void EnterMainCompound(MainCompoundContext context)
            {
                AppendLine("static void Main() {");
                AppendLine("    new Program().__run__();");
                AppendLine("}");
                AppendLine("void __run__() {");
            }
            public override void ExitMainCompound(MainCompoundContext context)
            {
                AppendLine("} // __run__");
            }

            public override void EnterCompoundStatement(CompoundStatementContext context)
            {
                AppendLine("{ // compound");
            }
            public override void ExitCompoundStatement(CompoundStatementContext context)
            {
                AppendLine("} // compound");
            }

            public override void ExitAssigningVariable(AssigningVariableContext context)
            {
                Append(context.GetText().ToLower(), " = ");
            }
            public override void ExitAssignmentStatement(AssignmentStatementContext context)
            {
                AppendLine(";");
            }

            public override void ExitProcedureStatement(ProcedureStatementContext context)
            {
                string name = context.name.GetText().ToLower();

                bool[] isRefs;
                if (!_procedures.TryGetValue(name, out isRefs))
                    throw new ParseCanceledException($"Undefined procedure \"{name}\"");

                if (name != "writeln" && name != "write" && isRefs.Length != context._args.Count)
                    throw new ParseCanceledException($"Wrong arguments count in procedure \"{name}\"");

                Append(name, "(");

                Append(string.Join(
                    ", ",
                    Enumerable.Range(0, context._args.Count)
                        .Select(i => isRefs != null && isRefs[i] ? $"ref {context._args[i].s}" : context._args[i].s)
                ));

                AppendLine(");");
            }

            public override void ExitEmptyStatement(EmptyStatementContext context)
            {
                AppendLine(";");
            }

            public override void ExitMulExpression(MulExpressionContext context)
            {
                context.s = Util.FormatTerm(context._operations, context._operands.Select(i => i.s));
            }
            public override void ExitAddExpression(AddExpressionContext context)
            {
                context.s = Util.FormatTerm(context._operations, context._operands.Select(i => i.s));
            }
            public override void ExitRelationExpression(RelationExpressionContext context)
            {
                context.s = Util.FormatTerm(context._operations, context._operands.Select(i => i.s));
            }

            public override void ExitExpression(ExpressionContext context)
            {
                Append(context.s);
            }
        }
    }
}