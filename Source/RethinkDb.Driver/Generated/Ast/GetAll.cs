












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

    public class GetAll : ReqlExpr {

    
    
    
/// <summary>
/// <para>Get all documents where the given value matches the value of the requested index.</para>
/// </summary>
/// <example><para>Example: Secondary index keys are not guaranteed to be unique so we cannot query via <a href="/api/javascript/get/">get</a> when using a secondary index.</para>
/// <code>r.table('marvel').getAll('man_of_steel', {index:'code_name'}).run(conn, callback)
/// </code></example>
        public GetAll (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Get all documents where the given value matches the value of the requested index.</para>
/// </summary>
/// <example><para>Example: Secondary index keys are not guaranteed to be unique so we cannot query via <a href="/api/javascript/get/">get</a> when using a secondary index.</para>
/// <code>r.table('marvel').getAll('man_of_steel', {index:'code_name'}).run(conn, callback)
/// </code></example>
        public GetAll (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Get all documents where the given value matches the value of the requested index.</para>
/// </summary>
/// <example><para>Example: Secondary index keys are not guaranteed to be unique so we cannot query via <a href="/api/javascript/get/">get</a> when using a secondary index.</para>
/// <code>r.table('marvel').getAll('man_of_steel', {index:'code_name'}).run(conn, callback)
/// </code></example>
        public GetAll (Arguments args, OptArgs optargs)
             : this(TermType.GET_ALL, args, optargs) {
        }

    protected GetAll (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    
///<summary>
/// "index": "T_STR"
///</summary>
        public GetAll optArg(string optname, object value) {
             var newOptargs = OptArgs.FromMap(this.OptArgs)
                                     .With(optname, value);
             return new GetAll (this.Args, newOptargs);
        }


    

    


    
    }
}
