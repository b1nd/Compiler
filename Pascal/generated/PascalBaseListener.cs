//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:/dev/java/py/src\Pascal.g4 by ANTLR 4.7

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Pascal.Generated {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IPascalListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public partial class PascalBaseListener : IPascalListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="PascalParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProgram([NotNull] PascalParser.ProgramContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PascalParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProgram([NotNull] PascalParser.ProgramContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PascalParser.mainCompound"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMainCompound([NotNull] PascalParser.MainCompoundContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PascalParser.mainCompound"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMainCompound([NotNull] PascalParser.MainCompoundContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PascalParser.programHeading"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProgramHeading([NotNull] PascalParser.ProgramHeadingContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PascalParser.programHeading"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProgramHeading([NotNull] PascalParser.ProgramHeadingContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PascalParser.identifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentifier([NotNull] PascalParser.IdentifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PascalParser.identifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentifier([NotNull] PascalParser.IdentifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PascalParser.block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBlock([NotNull] PascalParser.BlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PascalParser.block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBlock([NotNull] PascalParser.BlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PascalParser.unsignedInteger"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnsignedInteger([NotNull] PascalParser.UnsignedIntegerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PascalParser.unsignedInteger"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnsignedInteger([NotNull] PascalParser.UnsignedIntegerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PascalParser.string"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterString([NotNull] PascalParser.StringContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PascalParser.string"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitString([NotNull] PascalParser.StringContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PascalParser.typeIdentifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeIdentifier([NotNull] PascalParser.TypeIdentifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PascalParser.typeIdentifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeIdentifier([NotNull] PascalParser.TypeIdentifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PascalParser.variableDeclarationPart"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariableDeclarationPart([NotNull] PascalParser.VariableDeclarationPartContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PascalParser.variableDeclarationPart"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariableDeclarationPart([NotNull] PascalParser.VariableDeclarationPartContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PascalParser.variableDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariableDeclaration([NotNull] PascalParser.VariableDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PascalParser.variableDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariableDeclaration([NotNull] PascalParser.VariableDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PascalParser.procedureDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProcedureDeclaration([NotNull] PascalParser.ProcedureDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PascalParser.procedureDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProcedureDeclaration([NotNull] PascalParser.ProcedureDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PascalParser.procedureHeader"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProcedureHeader([NotNull] PascalParser.ProcedureHeaderContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PascalParser.procedureHeader"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProcedureHeader([NotNull] PascalParser.ProcedureHeaderContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PascalParser.parameterGroup"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParameterGroup([NotNull] PascalParser.ParameterGroupContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PascalParser.parameterGroup"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParameterGroup([NotNull] PascalParser.ParameterGroupContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PascalParser.identifierList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentifierList([NotNull] PascalParser.IdentifierListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PascalParser.identifierList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentifierList([NotNull] PascalParser.IdentifierListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PascalParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatement([NotNull] PascalParser.StatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PascalParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatement([NotNull] PascalParser.StatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PascalParser.assignmentStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignmentStatement([NotNull] PascalParser.AssignmentStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PascalParser.assignmentStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignmentStatement([NotNull] PascalParser.AssignmentStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PascalParser.assigningVariable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssigningVariable([NotNull] PascalParser.AssigningVariableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PascalParser.assigningVariable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssigningVariable([NotNull] PascalParser.AssigningVariableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PascalParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpression([NotNull] PascalParser.ExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PascalParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpression([NotNull] PascalParser.ExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PascalParser.relationExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRelationExpression([NotNull] PascalParser.RelationExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PascalParser.relationExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRelationExpression([NotNull] PascalParser.RelationExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PascalParser.addExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAddExpression([NotNull] PascalParser.AddExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PascalParser.addExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAddExpression([NotNull] PascalParser.AddExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PascalParser.mulExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMulExpression([NotNull] PascalParser.MulExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PascalParser.mulExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMulExpression([NotNull] PascalParser.MulExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PascalParser.signedFactor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSignedFactor([NotNull] PascalParser.SignedFactorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PascalParser.signedFactor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSignedFactor([NotNull] PascalParser.SignedFactorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PascalParser.factor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFactor([NotNull] PascalParser.FactorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PascalParser.factor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFactor([NotNull] PascalParser.FactorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PascalParser.notFactor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNotFactor([NotNull] PascalParser.NotFactorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PascalParser.notFactor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNotFactor([NotNull] PascalParser.NotFactorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PascalParser.procedureStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProcedureStatement([NotNull] PascalParser.ProcedureStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PascalParser.procedureStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProcedureStatement([NotNull] PascalParser.ProcedureStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PascalParser.emptyStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEmptyStatement([NotNull] PascalParser.EmptyStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PascalParser.emptyStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEmptyStatement([NotNull] PascalParser.EmptyStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PascalParser.compoundStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCompoundStatement([NotNull] PascalParser.CompoundStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PascalParser.compoundStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCompoundStatement([NotNull] PascalParser.CompoundStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PascalParser.statements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatements([NotNull] PascalParser.StatementsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PascalParser.statements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatements([NotNull] PascalParser.StatementsContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace Pascal.Generated
