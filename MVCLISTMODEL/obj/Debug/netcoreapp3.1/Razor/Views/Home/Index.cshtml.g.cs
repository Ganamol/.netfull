#pragma checksum "C:\Users\Lab\source\repos\MVCLISTMODEL\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d0d480440a26cd2829065972d04b602dbb4be5f"
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
#line 1 "C:\Users\Lab\source\repos\MVCLISTMODEL\Views\_ViewImports.cshtml"
using MVCLISTMODEL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lab\source\repos\MVCLISTMODEL\Views\Home\Index.cshtml"
using MVCLISTMODEL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d0d480440a26cd2829065972d04b602dbb4be5f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65bc47fcf98359a6d940184764ada9dc46cd55d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Lab\source\repos\MVCLISTMODEL\Views\Home\Index.cshtml"
  var a=0;
    var b = 0;
    var c = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<table>\r\n    <tr>\r\n        <th>Id</th>\r\n        <th>Name</th>\r\n        <th>Mark</th>\r\n        <th>Mark1</th>\r\n        <th>Status</th>\r\n    </tr>\r\n");
#nullable restore
#line 16 "C:\Users\Lab\source\repos\MVCLISTMODEL\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 19 "C:\Users\Lab\source\repos\MVCLISTMODEL\Views\Home\Index.cshtml"
   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 20 "C:\Users\Lab\source\repos\MVCLISTMODEL\Views\Home\Index.cshtml"
   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 21 "C:\Users\Lab\source\repos\MVCLISTMODEL\Views\Home\Index.cshtml"
   Write(item.Mark);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 22 "C:\Users\Lab\source\repos\MVCLISTMODEL\Views\Home\Index.cshtml"
   Write(item.Mark1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 24 "C:\Users\Lab\source\repos\MVCLISTMODEL\Views\Home\Index.cshtml"
      

        a = Convert.ToInt32(@item.Mark);
        b = Convert.ToInt32(@item.Mark1);
        c = a + b;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <td>");
#nullable restore
#line 31 "C:\Users\Lab\source\repos\MVCLISTMODEL\Views\Home\Index.cshtml"
   Write(c);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n</tr>\r\n");
#nullable restore
#line 33 "C:\Users\Lab\source\repos\MVCLISTMODEL\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n<style>\r\n    table,tr,th,td{\r\n        border:1px solid black;\r\n    }\r\n</style>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
