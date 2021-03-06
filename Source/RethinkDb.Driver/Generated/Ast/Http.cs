












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

    public class Http : ReqlExpr {

    
    
    
/// <summary>
/// <para>Retrieve data from the specified URL over HTTP.  The return type depends on the <code>resultFormat</code> option, which checks the <code>Content-Type</code> of the response by default.</para>
/// </summary>
/// <example><para>Example: Perform a simple HTTP <code>GET</code> request, and store the result in a table.</para>
/// <code>r.table('posts').insert(r.http('http://httpbin.org/get')).run(conn, callback)
/// </code></example>
        public Http (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Retrieve data from the specified URL over HTTP.  The return type depends on the <code>resultFormat</code> option, which checks the <code>Content-Type</code> of the response by default.</para>
/// </summary>
/// <example><para>Example: Perform a simple HTTP <code>GET</code> request, and store the result in a table.</para>
/// <code>r.table('posts').insert(r.http('http://httpbin.org/get')).run(conn, callback)
/// </code></example>
        public Http (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Retrieve data from the specified URL over HTTP.  The return type depends on the <code>resultFormat</code> option, which checks the <code>Content-Type</code> of the response by default.</para>
/// </summary>
/// <example><para>Example: Perform a simple HTTP <code>GET</code> request, and store the result in a table.</para>
/// <code>r.table('posts').insert(r.http('http://httpbin.org/get')).run(conn, callback)
/// </code></example>
        public Http (Arguments args, OptArgs optargs)
             : this(TermType.HTTP, args, optargs) {
        }

    protected Http (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    
///<summary>
/// "timeout": "T_NUM",
///  "reattempts": "T_NUM",
///  "redirects": "T_NUM",
///  "verify": "T_BOOL",
///  "result_format": "E_RESULT_FORMAT",
///  "method": "E_HTTP_METHOD",
///  "auth": {
///    "type": "E_AUTH_TYPE",
///    "user": "T_STR",
///    "pass": "T_STR"
///  },
///  "params": "T_OBJECT",
///  "header": [
///    "T_ARRAY",
///    "T_OBJECT"
///  ],
///  "data": [
///    "T_STR",
///    "T_OBJECT"
///  ]
///</summary>
        public Http optArg(string optname, object value) {
             var newOptargs = OptArgs.FromMap(this.OptArgs)
                                     .With(optname, value);
             return new Http (this.Args, newOptargs);
        }


    

    


    
    }
}
