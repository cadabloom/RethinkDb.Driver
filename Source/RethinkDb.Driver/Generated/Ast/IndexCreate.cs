












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

    public class IndexCreate : ReqlExpr {

    
    
    
/// <summary>
/// <para>Create a new secondary index on a table.</para>
/// </summary>
/// <example><para>Example: Create a simple index based on the field <code>postId</code>.</para>
/// <code>r.table('comments').indexCreate('postId').run(conn, callback)
/// </code></example>
        public IndexCreate (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Create a new secondary index on a table.</para>
/// </summary>
/// <example><para>Example: Create a simple index based on the field <code>postId</code>.</para>
/// <code>r.table('comments').indexCreate('postId').run(conn, callback)
/// </code></example>
        public IndexCreate (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Create a new secondary index on a table.</para>
/// </summary>
/// <example><para>Example: Create a simple index based on the field <code>postId</code>.</para>
/// <code>r.table('comments').indexCreate('postId').run(conn, callback)
/// </code></example>
        public IndexCreate (Arguments args, OptArgs optargs)
             : this(TermType.INDEX_CREATE, args, optargs) {
        }

    protected IndexCreate (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    
///<summary>
/// "multi": "T_BOOL",
///  "geo": "T_BOOL"
///</summary>
        public IndexCreate optArg(string optname, object value) {
             var newOptargs = OptArgs.FromMap(this.OptArgs)
                                     .With(optname, value);
             return new IndexCreate (this.Args, newOptargs);
        }


    

    


    
    }
}
