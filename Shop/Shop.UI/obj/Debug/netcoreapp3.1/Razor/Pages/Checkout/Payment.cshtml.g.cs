#pragma checksum "E:\Routine\asp.net\3apr\Shop\shop.ui\Pages\Checkout\Payment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e39656a7f8c268ccaa200fa864073c63f910bc1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Shop.UI.Pages.Checkout.Pages_Checkout_Payment), @"mvc.1.0.razor-page", @"/Pages/Checkout/Payment.cshtml")]
namespace Shop.UI.Pages.Checkout
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e39656a7f8c268ccaa200fa864073c63f910bc1e", @"/Pages/Checkout/Payment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cd49f32f72cce44dd3f935f614c24a89157f8b5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Checkout_Payment : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private global::Shop.UI.Pages.Checkout.Pages_Checkout_Payment.__Generated__CartViewComponentTagHelper __CartViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("payment-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\Routine\asp.net\3apr\Shop\shop.ui\Pages\Checkout\Payment.cshtml"
  
    ViewData["Title"] = "Payment";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p class=\"title\">Payment</p>\r\n\r\n<div class=\"columns\">\r\n    <div class=\"column is-6\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e39656a7f8c268ccaa200fa864073c63f910bc1e4301", async() => {
                WriteLiteral(@"
        <div class=""field form-row"">
            <div id=""card-element"">
                <!-- A Stripe Element will be inserted here. -->
            </div>

            <!-- Used to display Element errors. -->
            <div id=""card-errors"" role=""alert""></div>
        </div>
        <div class=""field has-text-right"">
            <button class=""button is-success"">pay</button>
        </div>
        
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div class=\"column is-6\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:cart", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e39656a7f8c268ccaa200fa864073c63f910bc1e6305", async() => {
            }
            );
            __CartViewComponentTagHelper = CreateTagHelper<global::Shop.UI.Pages.Checkout.Pages_Checkout_Payment.__Generated__CartViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__CartViewComponentTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("Default");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __CartViewComponentTagHelper.view = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("view", __CartViewComponentTagHelper.view, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script src=\"https://js.stripe.com/v3/\"></script>\r\n\r\n    <script>\r\n        /**/\r\n        var stripe = Stripe(\"");
#nullable restore
#line 36 "E:\Routine\asp.net\3apr\Shop\shop.ui\Pages\Checkout\Payment.cshtml"
                        Write(Model.PublicKey);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""");
        /**/
        var elements = stripe.elements();

        // Custom styling can be passed to options when creating an Element.
        var style = {
            base: {
                // Add your base input styles here. For example:
                fontSize: '16px',
                color: '#32325d',
            },
        };

        // Create an instance of the card Element.
        var card = elements.create('card', { style: style });

        // Add an instance of the card Element into the `card-element` <div>.
        card.mount('#card-element');

        // Create a token or display an error when the form is submitted.
        var form = document.getElementById('payment-form');
        form.addEventListener('submit', function (event) {
            event.preventDefault();

            stripe.createToken(card).then(function (result) {
                if (result.error) {
                    // Inform the customer that there was an error.
                    var errorEle");
                WriteLiteral(@"ment = document.getElementById('card-errors');
                    errorElement.textContent = result.error.message;
                } else {
                    // Send the token to your server.
                    stripeTokenHandler(result.token);
                }
            });
        });


        function stripeTokenHandler(token) {
            // Insert the token ID into the form so it gets submitted to the server
            var form = document.getElementById('payment-form');
            var hiddenInput = document.createElement('input');
            hiddenInput.setAttribute('type', 'hidden');
            hiddenInput.setAttribute('name', 'stripeToken');
            hiddenInput.setAttribute('value', token.id);
            form.appendChild(hiddenInput);

            // Submit the form
            form.submit();
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shop.UI.Pages.Checkout.PaymentModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Shop.UI.Pages.Checkout.PaymentModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Shop.UI.Pages.Checkout.PaymentModel>)PageContext?.ViewData;
        public Shop.UI.Pages.Checkout.PaymentModel Model => ViewData.Model;
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:cart")]
        public class __Generated__CartViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__CartViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public System.String view { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("Cart", new { view });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591