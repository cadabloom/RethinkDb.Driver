












//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;


namespace RethinkDb.Driver.Ast {

    public class Distinct : ReqlExpr {

    
    
    
/// <summary>
/// <para>Remove duplicate elements from the sequence.</para>
/// </summary>
/// <example><para>Example: Which unique villains have been vanquished by marvel heroes?</para>
/// <code>r.table('marvel').concatMap(function(hero) {
///     return hero('villainList')
/// }).distinct().run(conn, callback)
/// </code></example>
        public Distinct (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Remove duplicate elements from the sequence.</para>
/// </summary>
/// <example><para>Example: Which unique villains have been vanquished by marvel heroes?</para>
/// <code>r.table('marvel').concatMap(function(hero) {
///     return hero('villainList')
/// }).distinct().run(conn, callback)
/// </code></example>
        public Distinct (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Remove duplicate elements from the sequence.</para>
/// </summary>
/// <example><para>Example: Which unique villains have been vanquished by marvel heroes?</para>
/// <code>r.table('marvel').concatMap(function(hero) {
///     return hero('villainList')
/// }).distinct().run(conn, callback)
/// </code></example>
        public Distinct (Arguments args, OptArgs optargs)
             : this(TermType.DISTINCT, args, optargs) {
        }

    protected Distinct (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    
///<summary>
/// "index": "T_STR"
///</summary>
        public Distinct optArg(string optname, object value) {
             var newOptargs = OptArgs.FromMap(this.OptArgs)
                                     .With(optname, value);
             return new Distinct (this.Args, newOptargs);
        }


    

    


    
    }
}
