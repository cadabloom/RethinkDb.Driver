












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

    public class Line : ReqlExpr {

    
    
    
/// <summary>
/// <para>Construct a geometry object of type Line. The line can be specified in one of two ways:</para>
/// <ul>
/// <li>Two or more two-item arrays, specifying longitude and latitude numbers of the line's vertices;</li>
/// <li>Two or more <a href="/api/javascript/point">Point</a> objects specifying the line's vertices.</li>
/// </ul>
/// </summary>
/// <example><para>Example: Define a line.</para>
/// <code>r.table('geo').insert({
///     id: 101,
///     route: r.line([-122.423246,37.779388], [-121.886420,37.329898])
/// }).run(conn, callback);
/// </code></example>
        public Line (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Construct a geometry object of type Line. The line can be specified in one of two ways:</para>
/// <ul>
/// <li>Two or more two-item arrays, specifying longitude and latitude numbers of the line's vertices;</li>
/// <li>Two or more <a href="/api/javascript/point">Point</a> objects specifying the line's vertices.</li>
/// </ul>
/// </summary>
/// <example><para>Example: Define a line.</para>
/// <code>r.table('geo').insert({
///     id: 101,
///     route: r.line([-122.423246,37.779388], [-121.886420,37.329898])
/// }).run(conn, callback);
/// </code></example>
        public Line (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Construct a geometry object of type Line. The line can be specified in one of two ways:</para>
/// <ul>
/// <li>Two or more two-item arrays, specifying longitude and latitude numbers of the line's vertices;</li>
/// <li>Two or more <a href="/api/javascript/point">Point</a> objects specifying the line's vertices.</li>
/// </ul>
/// </summary>
/// <example><para>Example: Define a line.</para>
/// <code>r.table('geo').insert({
///     id: 101,
///     route: r.line([-122.423246,37.779388], [-121.886420,37.329898])
/// }).run(conn, callback);
/// </code></example>
        public Line (Arguments args, OptArgs optargs)
             : this(TermType.LINE, args, optargs) {
        }

    protected Line (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    


    

    


    
    }
}
