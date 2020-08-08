#pragma checksum "E:\Routine\asp.net\3apr\Shop\shop.ui\Pages\Admin\Stock.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4966a6b9b90efd5ce772d1b4c49d51fe39b6341"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Shop.UI.Pages.Admin.Pages_Admin_Stock), @"mvc.1.0.razor-page", @"/Pages/Admin/Stock.cshtml")]
namespace Shop.UI.Pages.Admin
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
#line 1 "E:\Routine\asp.net\3apr\Shop\shop.ui\Pages\_ViewImports.cshtml"
using Shop.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Routine\asp.net\3apr\Shop\shop.ui\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4966a6b9b90efd5ce772d1b4c49d51fe39b6341", @"/Pages/Admin/Stock.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cd49f32f72cce44dd3f935f614c24a89157f8b5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Stock : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/admin/stock.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "E:\Routine\asp.net\3apr\Shop\shop.ui\Pages\Admin\Stock.cshtml"
  
    Layout = "_AdminLayOut";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"app\">\r\n    <div class=\"columns\">\r\n        <div class=\"column is-3\">\r\n            <table class=\"table\">\r\n                <tr v-for=\"product in products\" ");
            WriteLiteral(@"@click=""selectProduct(product)"">
                    <td>{{product.description}}</td>
                </tr>
            </table>
        </div>
        <div class=""column is-6"" v-if=""selectedProduct"">
            <table class=""table"">
                <tr v-for=""(stock,index ) in selectedProduct.stock"">
                    <td>
                        <input v-model=""stock.description"" class=""input"" />
                    </td>
                    <td>
                        <input v-model=""stock.qty"" class=""input"" />
                    </td>
                    <td>
                        <a ");
            WriteLiteral("@click=\"deleteStock(stock.id,index)\" class=\"button is-danger\">delete</a>\r\n                    </td>\r\n                </tr>\r\n            </table>\r\n\r\n            <a ");
            WriteLiteral(@"@click=""updateStock"" class=""button is-warning"">Update Stock</a>
        </div>

        <div class=""column is-3"">
            <h2 class=""title"">New Stock</h2>
            <div class=""field"">
                <div class=""control"">
                    <input v-model=""newStock.description"" class=""input"" />
                </div>
            </div>
            <div class=""field"">
                <div class=""control"">
                    <input v-model=""newStock.qty"" class=""input"" />
                </div>
            </div>

            <a ");
            WriteLiteral("@click=\"addStock\" class=\"button is-success\">Add</a>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n   \r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4966a6b9b90efd5ce772d1b4c49d51fe39b63415511", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shop.UI.Pages.Admin.StockModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Shop.UI.Pages.Admin.StockModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Shop.UI.Pages.Admin.StockModel>)PageContext?.ViewData;
        public Shop.UI.Pages.Admin.StockModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
