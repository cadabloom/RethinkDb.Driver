﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Templates.CodeGen
{
    using System;
    
    #line 1 "..\..\CodeGen\EnumStringTemplate.cshtml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 2 "..\..\CodeGen\EnumStringTemplate.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
    using System.Text;
    
    #line 3 "..\..\CodeGen\EnumStringTemplate.cshtml"
    using RazorGenerator.Templating;
    
    #line default
    #line hidden
    
    #line 4 "..\..\CodeGen\EnumStringTemplate.cshtml"
    using Templates.CodeGen;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public partial class EnumStringTemplate : BaseTemplate
    {
#line hidden

        #line 6 "..\..\CodeGen\EnumStringTemplate.cshtml"

    public string EnumName { get; set; }
    public string[] Enums { get; set; }

    public override RazorTemplateBase UseParentLayout(RazorTemplateBase child)
    {
        return new EnumStringTemplate()
            {
                EnumName = this.EnumName,
                Enums = this.Enums,
                ChildTemplate = child
            };
    }


        #line default
        #line hidden

        public override void Execute()
        {




WriteLiteral("\r\n");


WriteLiteral("\r\n");


WriteLiteral(@"
//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace RethinkDb.Driver.Model {
    
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ");


            
            #line 34 "..\..\CodeGen\EnumStringTemplate.cshtml"
           Write(EnumName);

            
            #line default
            #line hidden
WriteLiteral(" {\r\n");


            
            #line 35 "..\..\CodeGen\EnumStringTemplate.cshtml"
     foreach( var v in this.Enums )
    {

            
            #line default
            #line hidden
WriteLiteral("        ");


            
            #line 37 "..\..\CodeGen\EnumStringTemplate.cshtml"
     Write(v);

            
            #line default
            #line hidden
WriteLiteral(",\r\n");


            
            #line 38 "..\..\CodeGen\EnumStringTemplate.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    }\r\n\r\n    ");


            
            #line 41 "..\..\CodeGen\EnumStringTemplate.cshtml"
Write(RenderSection("CustomMethods"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n}\r\n");


        }
    }
}
#pragma warning restore 1591
