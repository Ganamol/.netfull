#pragma checksum "C:\Users\Lab\source\repos\forloop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ac0366a6e7b0442f05f72e8a52e754464933c04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Lab\source\repos\forloop\Views\_ViewImports.cshtml"
using forloop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lab\source\repos\forloop\Views\_ViewImports.cshtml"
using forloop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ac0366a6e7b0442f05f72e8a52e754464933c04", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46ab9ef4b8cfe0deb56ba2275a109620962dec70", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Lab\source\repos\forloop\Views\Home\Index.cshtml"
    var a = "";

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lab\source\repos\forloop\Views\Home\Index.cshtml"
 for (int i = 1; i <= 5; i++)
{
   for (int j = 1; j <= i; j++)
    {
         a += "*";

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 7 "C:\Users\Lab\source\repos\forloop\Views\Home\Index.cshtml"
Write(a);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> \r\n");
#nullable restore
#line 8 "C:\Users\Lab\source\repos\forloop\Views\Home\Index.cshtml"
}
   
    
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 29 "C:\Users\Lab\source\repos\forloop\Views\Home\Index.cshtml"
  var price = 50;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591