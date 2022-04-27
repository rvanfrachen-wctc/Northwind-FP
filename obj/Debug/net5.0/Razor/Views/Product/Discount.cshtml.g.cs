#pragma checksum "C:\Users\Andy\RiderProjects\Northwind-FP\Views\Product\Discount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "046eca9aa50f1434822a99998c1ae773104523c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Discount), @"mvc.1.0.view", @"/Views/Product/Discount.cshtml")]
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
#line 2 "C:\Users\Andy\RiderProjects\Northwind-FP\Views\_ViewImports.cshtml"
using Northwind;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Andy\RiderProjects\Northwind-FP\Views\Product\Discount.cshtml"
using Northwind.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"046eca9aa50f1434822a99998c1ae773104523c5", @"/Views/Product/Discount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a254f307deefe3c12955be9fc7971cd29a6e38c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Discount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Discount>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/client.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<ul class=\"list-group list-group-flush\">\r\n");
#nullable restore
#line 5 "C:\Users\Andy\RiderProjects\Northwind-FP\Views\Product\Discount.cshtml"
     foreach (Discount discount in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"list-group-item\">\r\n            <div class=\"col discounts px-2 py-4\">\r\n                <h3>");
#nullable restore
#line 9 "C:\Users\Andy\RiderProjects\Northwind-FP\Views\Product\Discount.cshtml"
               Write(discount.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <div class=\"mb-4\">\r\n                    ");
#nullable restore
#line 11 "C:\Users\Andy\RiderProjects\Northwind-FP\Views\Product\Discount.cshtml"
               Write(discount.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <i>Discount expires: ");
#nullable restore
#line 13 "C:\Users\Andy\RiderProjects\Northwind-FP\Views\Product\Discount.cshtml"
                                Write(discount.EndTime.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</i><br />\r\n                <a href=\"#\" class=\"code\" data-code=\"");
#nullable restore
#line 14 "C:\Users\Andy\RiderProjects\Northwind-FP\Views\Product\Discount.cshtml"
                                               Write(discount.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-product=\"");
#nullable restore
#line 14 "C:\Users\Andy\RiderProjects\Northwind-FP\Views\Product\Discount.cshtml"
                                                                             Write(discount.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i\r\n                    class=\"far fa-hand-point-right\"></i> Discount Code</a>\r\n            </div>\r\n        </li>\r\n");
#nullable restore
#line 18 "C:\Users\Andy\RiderProjects\Northwind-FP\Views\Product\Discount.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</ul>

<!-- toast -->
<div id=""toast"" class=""toast"">
    <div class=""toast-header"">
        <strong class=""mr-auto"" id=""product"">Product Name</strong>
        <button type=""button"" class=""ml-2 mb-1 close"" data-dismiss=""toast"" aria-label=""Close"">
            <span aria-hidden=""true"">&times;</span>
        </button>
    </div>
    <div class=""toast-body"">
        Discount Code: <strong id=""code"">CODE</strong>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "046eca9aa50f1434822a99998c1ae773104523c56552", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Discount>> Html { get; private set; }
    }
}
#pragma warning restore 1591
