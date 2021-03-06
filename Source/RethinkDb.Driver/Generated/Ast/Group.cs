












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

    public class Group : ReqlExpr {

    
    
    
/// <summary>
/// <para>Takes a stream and partitions it into multiple groups based on the
/// fields or functions provided.  Commands chained after <code>group</code> will be
/// called on each of these grouped sub-streams, producing grouped data.</para>
/// </summary>
/// <example><para>Example: What is each player's best game?</para>
/// <code>r.table('games').group('player').max('points').run(conn, callback)
/// </code></example>
        public Group (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Takes a stream and partitions it into multiple groups based on the
/// fields or functions provided.  Commands chained after <code>group</code> will be
/// called on each of these grouped sub-streams, producing grouped data.</para>
/// </summary>
/// <example><para>Example: What is each player's best game?</para>
/// <code>r.table('games').group('player').max('points').run(conn, callback)
/// </code></example>
        public Group (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Takes a stream and partitions it into multiple groups based on the
/// fields or functions provided.  Commands chained after <code>group</code> will be
/// called on each of these grouped sub-streams, producing grouped data.</para>
/// </summary>
/// <example><para>Example: What is each player's best game?</para>
/// <code>r.table('games').group('player').max('points').run(conn, callback)
/// </code></example>
        public Group (Arguments args, OptArgs optargs)
             : this(TermType.GROUP, args, optargs) {
        }

    protected Group (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    
///<summary>
/// "index": "T_STR",
///  "multi": "T_BOOL"
///</summary>
        public Group optArg(string optname, object value) {
             var newOptargs = OptArgs.FromMap(this.OptArgs)
                                     .With(optname, value);
             return new Group (this.Args, newOptargs);
        }


    

    


    
    }
}
