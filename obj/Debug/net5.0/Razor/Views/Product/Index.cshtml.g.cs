#pragma checksum "D:\1) WCTC - College\1) 2022-2023\Semester 1\2) .Net Web Development\Northwind FP\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f3de3b62a2743e62c2c9316e874c4ccb9111134"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 2 "D:\1) WCTC - College\1) 2022-2023\Semester 1\2) .Net Web Development\Northwind FP\Views\_ViewImports.cshtml"
using Northwind;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\1) WCTC - College\1) 2022-2023\Semester 1\2) .Net Web Development\Northwind FP\Views\Product\Index.cshtml"
using Northwind.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f3de3b62a2743e62c2c9316e874c4ccb9111134", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a254f307deefe3c12955be9fc7971cd29a6e38c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Category>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<table class=""table table-hover"">
    <thead>
        <tr>
            <th scope=""col"">
                <div class=""form-row"">
                    <div class=""form-group col-md-8 mb-0"">
                        <select class=""form-control form-control-sm"" id=""CategoryId"">
");
#nullable restore
#line 11 "D:\1) WCTC - College\1) 2022-2023\Semester 1\2) .Net Web Development\Northwind FP\Views\Product\Index.cshtml"
                         foreach (Category c in Model)
                        {
                            if (c.CategoryId == ViewBag.id)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f3de3b62a2743e62c2c9316e874c4ccb91111343864", async() => {
#nullable restore
#line 14 "D:\1) WCTC - College\1) 2022-2023\Semester 1\2) .Net Web Development\Northwind FP\Views\Product\Index.cshtml"
                                                                    Write(c.CategoryName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "D:\1) WCTC - College\1) 2022-2023\Semester 1\2) .Net Web Development\Northwind FP\Views\Product\Index.cshtml"
                                     WriteLiteral(c.CategoryId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" ");
#nullable restore
#line 14 "D:\1) WCTC - College\1) 2022-2023\Semester 1\2) .Net Web Development\Northwind FP\Views\Product\Index.cshtml"
                                                                                                  }
                            else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f3de3b62a2743e62c2c9316e874c4ccb91111346461", async() => {
#nullable restore
#line 16 "D:\1) WCTC - College\1) 2022-2023\Semester 1\2) .Net Web Development\Northwind FP\Views\Product\Index.cshtml"
                                                           Write(c.CategoryName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "D:\1) WCTC - College\1) 2022-2023\Semester 1\2) .Net Web Development\Northwind FP\Views\Product\Index.cshtml"
                                     WriteLiteral(c.CategoryId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" ");
#nullable restore
#line 16 "D:\1) WCTC - College\1) 2022-2023\Semester 1\2) .Net Web Development\Northwind FP\Views\Product\Index.cshtml"
                                                                                         }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </select>
                    </div>
                    <div class=""form-group col-md-4 mb-0"">
                        <div class=""form-check text-right"">
                            <input class=""form-check-input"" type=""checkbox"" id=""Discontinued"">
                            <label class=""form-check-label"" for=""Discontinued"">Discontinued</label>
                        </div>
                    </div>
                </div>
            </th>
            <th scope=""col"" class=""text-right"">Price ($)</th>
            <th scope=""col"" class=""text-right"">Stock</th>
        </tr>
    </thead>
    <tbody id=""product_rows"" data-id=""");
#nullable restore
#line 32 "D:\1) WCTC - College\1) 2022-2023\Semester 1\2) .Net Web Development\Northwind FP\Views\Product\Index.cshtml"
                                 Write(ViewBag.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></tbody>\r\n</table>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
<script>
    $(function () {
        getProducts()
        function getProducts() {
            var id = $('#product_rows').data('id');
            var discontinued = $('#Discontinued').prop('checked') ? """" : ""/discontinued/false"";
            $.getJSON({
                url: `../../api/category/${id}/product${discontinued}`,
                success: function (response, textStatus, jqXhr) {
                    $('#product_rows').html("""");
                    for (var i = 0; i < response.length; i++) {
                        var css = response[i].discontinued ? "" class=\""discontinued\"""" : """";
                        var row = `<tr${css}>
                            <td>${response[i].productName}</td>
                            <td class=""text-right"">${response[i].unitPrice.toFixed(2)}</td>
                            <td class=""text-right"">${response[i].unitsInStock}</td>
                            </tr>`;
                        $('#product_rows').append(row);
                    }
   ");
                WriteLiteral(@"             },
                error: function (jqXHR, textStatus, errorThrown) {
                    // log the error to the console
                    console.log(""The following error occured: "" + textStatus, errorThrown);
                }
            });
        }
        $('#CategoryId').on('change', function(){
            $('#product_rows').data('id', $(this).val());
            getProducts();
        });
        $('#Discontinued').on('change', function(){
            getProducts();
        });
    });
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591