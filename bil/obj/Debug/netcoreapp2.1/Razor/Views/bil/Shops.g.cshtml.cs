#pragma checksum "C:\Users\user\source\repos\bil\bil\Views\bil\Shops.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69618cae5881ba0377c4f930c4f31b91c1f51226"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_bil_Shops), @"mvc.1.0.view", @"/Views/bil/Shops.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/bil/Shops.cshtml", typeof(AspNetCore.Views_bil_Shops))]
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
#line 1 "C:\Users\user\source\repos\bil\bil\Views\_ViewImports.cshtml"
using bil;

#line default
#line hidden
#line 2 "C:\Users\user\source\repos\bil\bil\Views\_ViewImports.cshtml"
using bil.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69618cae5881ba0377c4f930c4f31b91c1f51226", @"/Views/bil/Shops.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3e72c7e1427f60e3470c6dbc91638cb6bada90c", @"/Views/_ViewImports.cshtml")]
    public class Views_bil_Shops : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Shop>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\user\source\repos\bil\bil\Views\bil\Shops.cshtml"
  
    ViewData["Title"] = "Shops";

#line default
#line hidden
            BeginContext(43, 20, true);
            WriteLiteral("\r\n<h2>Shops</h2>\r\n\r\n");
            EndContext();
            BeginContext(89, 630, true);
            WriteLiteral(@"

<style>
    table {
        border-collapse: collapse;
        width: 100%;
    }

    th, td {
        text-align: left;
        padding: 8px;
    }

    th {
        background-color: #4CAF50;
        color: white;
    }

    tr:nth-child(even) {
        background-color: #f2f2f2;
    }

    tr:hover {
        background-color: #ddd;
    }
</style>

<h2>List of Shops</h2>

<table>
    <thead>
        <tr>
            <th>Shop ID</th>
            <th>Name</th>
            <th>Address</th>
            <th>Phone</th>
            <th>Email</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 49 "C:\Users\user\source\repos\bil\bil\Views\bil\Shops.cshtml"
         foreach (var shop in Model)
        {

#line default
#line hidden
            BeginContext(768, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(807, 13, false);
#line 52 "C:\Users\user\source\repos\bil\bil\Views\bil\Shops.cshtml"
               Write(shop.ShopName);

#line default
#line hidden
            EndContext();
            BeginContext(820, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(848, 9, false);
#line 53 "C:\Users\user\source\repos\bil\bil\Views\bil\Shops.cshtml"
               Write(shop.Name);

#line default
#line hidden
            EndContext();
            BeginContext(857, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(885, 12, false);
#line 54 "C:\Users\user\source\repos\bil\bil\Views\bil\Shops.cshtml"
               Write(shop.Address);

#line default
#line hidden
            EndContext();
            BeginContext(897, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(925, 10, false);
#line 55 "C:\Users\user\source\repos\bil\bil\Views\bil\Shops.cshtml"
               Write(shop.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(935, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(963, 10, false);
#line 56 "C:\Users\user\source\repos\bil\bil\Views\bil\Shops.cshtml"
               Write(shop.Email);

#line default
#line hidden
            EndContext();
            BeginContext(973, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 58 "C:\Users\user\source\repos\bil\bil\Views\bil\Shops.cshtml"
        }

#line default
#line hidden
            BeginContext(1010, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Shop>> Html { get; private set; }
    }
}
#pragma warning restore 1591