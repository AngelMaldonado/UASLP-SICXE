﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:\Dev\Repos\UASLP\Fundamentos de Sistemas\Practica 2\antlr\SICXE.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace antlr {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="SICXEParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface ISICXEVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="SICXEParser.programa"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrograma([NotNull] SICXEParser.ProgramaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SICXEParser.inicio"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInicio([NotNull] SICXEParser.InicioContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SICXEParser.fin"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFin([NotNull] SICXEParser.FinContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SICXEParser.proposicion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProposicion([NotNull] SICXEParser.ProposicionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SICXEParser.instruccion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInstruccion([NotNull] SICXEParser.InstruccionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SICXEParser.f1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitF1([NotNull] SICXEParser.F1Context context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SICXEParser.f2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitF2([NotNull] SICXEParser.F2Context context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SICXEParser.f3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitF3([NotNull] SICXEParser.F3Context context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SICXEParser.f4"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitF4([NotNull] SICXEParser.F4Context context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SICXEParser.simple"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSimple([NotNull] SICXEParser.SimpleContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SICXEParser.indirecto"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIndirecto([NotNull] SICXEParser.IndirectoContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SICXEParser.inmediato"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInmediato([NotNull] SICXEParser.InmediatoContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SICXEParser.directiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDirectiva([NotNull] SICXEParser.DirectivaContext context);
}
} // namespace antlr