#pragma checksum "C:\Users\user\source\repos\bil\bil\Views\bil\Invontary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b139fa8c484e2b4e16a7b77df9c758c4a369412f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_bil_Invontary), @"mvc.1.0.view", @"/Views/bil/Invontary.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/bil/Invontary.cshtml", typeof(AspNetCore.Views_bil_Invontary))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b139fa8c484e2b4e16a7b77df9c758c4a369412f", @"/Views/bil/Invontary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3e72c7e1427f60e3470c6dbc91638cb6bada90c", @"/Views/_ViewImports.cshtml")]
    public class Views_bil_Invontary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 236, true);
            WriteLiteral("<link href=\"https://code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css\" rel=\"stylesheet\" />\r\n<script src=\"https://code.jquery.com/jquery-1.12.4.js\"></script>\r\n<script src=\"https://code.jquery.com/ui/1.12.1/jquery-ui.js\"></script>\r\n\r\n\r\n");
            EndContext();
#line 7 "C:\Users\user\source\repos\bil\bil\Views\bil\Invontary.cshtml"
  
    ViewBag.Title = "Products";

#line default
#line hidden
            BeginContext(305, 32, true);
            WriteLiteral("\r\n<h2>Products</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(338, 98, false);
#line 14 "C:\Users\user\source\repos\bil\bil\Views\bil\Invontary.cshtml"
Write(Html.ActionLink("Add Products", "Add", new { name = @ViewBag.name, shopname = @ViewBag.shopname }));

#line default
#line hidden
            EndContext();
            BeginContext(436, 13, true);
            WriteLiteral(" <br>\r\n\r\n    ");
            EndContext();
            BeginContext(450, 100, false);
#line 16 "C:\Users\user\source\repos\bil\bil\Views\bil\Invontary.cshtml"
Write(Html.ActionLink("create a bill", "Bill", new { name = @ViewBag.name, shopname = @ViewBag.shopname }));

#line default
#line hidden
            EndContext();
            BeginContext(550, 14, true);
            WriteLiteral("<br />\r\n\r\n    ");
            EndContext();
            BeginContext(565, 104, false);
#line 18 "C:\Users\user\source\repos\bil\bil\Views\bil\Invontary.cshtml"
Write(Html.ActionLink("add branchs ", "Addbranch", new { name = @ViewBag.name, shopname = @ViewBag.shopname }));

#line default
#line hidden
            EndContext();
            BeginContext(669, 169, true);
            WriteLiteral("<br />\r\n\r\n   \r\n</p>\r\n\r\n<div class=\"form-group\">\r\n    <label for=\"branch\">branch:</label>\r\n    <select id=\"branch\" name=\"branch\" class=\"form-control\"  required>\r\n        ");
            EndContext();
            BeginContext(838, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6f0c15ac98a47979510944d29e6353b", async() => {
                BeginContext(855, 13, true);
                WriteLiteral("Select branch");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(877, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 27 "C:\Users\user\source\repos\bil\bil\Views\bil\Invontary.cshtml"
         foreach (var branch in ViewBag.branchs)
        {

#line default
#line hidden
            BeginContext(940, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(952, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f8ddf16ed5f4a24ace6a9c97138e793", async() => {
                BeginContext(977, 6, false);
#line 29 "C:\Users\user\source\repos\bil\bil\Views\bil\Invontary.cshtml"
                               Write(branch);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 29 "C:\Users\user\source\repos\bil\bil\Views\bil\Invontary.cshtml"
               WriteLiteral(branch);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(992, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 30 "C:\Users\user\source\repos\bil\bil\Views\bil\Invontary.cshtml"
        }

#line default
#line hidden
            BeginContext(1005, 369, true);
            WriteLiteral(@"    </select>
</div>



<table class=""table"">
    <thead>
        <tr>
            <th>Product </th>
           
            <th>Description</th>
            <th>Category</th>
            <th>Price</th>
            <th>Quantity</th>
            <th>gst</th>
            <th>Supplier</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 51 "C:\Users\user\source\repos\bil\bil\Views\bil\Invontary.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1423, 76, true);
            WriteLiteral("            <tr>\r\n\r\n                \r\n                \r\n                <td>");
            EndContext();
            BeginContext(1500, 46, false);
#line 57 "C:\Users\user\source\repos\bil\bil\Views\bil\Invontary.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(1546, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1574, 46, false);
#line 58 "C:\Users\user\source\repos\bil\bil\Views\bil\Invontary.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1620, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1648, 43, false);
#line 59 "C:\Users\user\source\repos\bil\bil\Views\bil\Invontary.cshtml"
               Write(Html.DisplayFor(modelItem => item.Category));

#line default
#line hidden
            EndContext();
            BeginContext(1691, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1719, 40, false);
#line 60 "C:\Users\user\source\repos\bil\bil\Views\bil\Invontary.cshtml"
               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1759, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1787, 43, false);
#line 61 "C:\Users\user\source\repos\bil\bil\Views\bil\Invontary.cshtml"
               Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(1830, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1858, 38, false);
#line 62 "C:\Users\user\source\repos\bil\bil\Views\bil\Invontary.cshtml"
               Write(Html.DisplayFor(modelItem => item.gst));

#line default
#line hidden
            EndContext();
            BeginContext(1896, 45, true);
            WriteLiteral("</td>\r\n                \r\n                <td>");
            EndContext();
            BeginContext(1942, 43, false);
#line 64 "C:\Users\user\source\repos\bil\bil\Views\bil\Invontary.cshtml"
               Write(Html.DisplayFor(modelItem => item.Supplier));

#line default
#line hidden
            EndContext();
            BeginContext(1985, 28, true);
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 67 "C:\Users\user\source\repos\bil\bil\Views\bil\Invontary.cshtml"
        }

#line default
#line hidden
            BeginContext(2024, 192, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<script>\r\n    var j = jQuery.noConflict();\r\n    j(document).ready(function () {\r\n        // Define an array of available product names\r\n        var availableProducts = ");
            EndContext();
            BeginContext(2217, 41, false);
#line 74 "C:\Users\user\source\repos\bil\bil\Views\bil\Invontary.cshtml"
                           Write(Html.Raw(Json.Serialize(ViewBag.branchs)));

#line default
#line hidden
            EndContext();
            BeginContext(2258, 309, true);
            WriteLiteral(@";

        // Attach the Autocomplete widget to the text input field with ID ""branch""
        j(""#branch"").autocomplete({
            source: availableProducts,
        });
        setTimeout(function () {
            // Set the initial value of the input field to ""new""
            j(""#branch"").val(""");
            EndContext();
            BeginContext(2568, 10, false);
#line 82 "C:\Users\user\source\repos\bil\bil\Views\bil\Invontary.cshtml"
                         Write(ViewBag.br);

#line default
#line hidden
            EndContext();
            BeginContext(2578, 124, true);
            WriteLiteral("\");\r\n        }, 100);\r\n        \r\n            \r\n        j(\"#branch\").on(\"change\", function () {\r\n                var name = \"");
            EndContext();
            BeginContext(2703, 12, false);
#line 87 "C:\Users\user\source\repos\bil\bil\Views\bil\Invontary.cshtml"
                       Write(ViewBag.name);

#line default
#line hidden
            EndContext();
            BeginContext(2715, 36, true);
            WriteLiteral("\";\r\n                var shopname = \"");
            EndContext();
            BeginContext(2752, 16, false);
#line 88 "C:\Users\user\source\repos\bil\bil\Views\bil\Invontary.cshtml"
                           Write(ViewBag.shopname);

#line default
#line hidden
            EndContext();
            BeginContext(2768, 292, true);
            WriteLiteral(@""";
                var se = j(""#branch"").val();

                var url = ""/bil/Invontary?name="" + encodeURIComponent(name) + ""&shopname="" + encodeURIComponent(shopname) + ""&bran="" + encodeURIComponent(se);
                    window.location.href = url;
        });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
