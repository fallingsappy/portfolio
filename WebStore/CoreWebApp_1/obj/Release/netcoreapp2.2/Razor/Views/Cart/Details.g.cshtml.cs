#pragma checksum "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Views\Cart\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f38ee0ac7a76418678d4ad84e7e5ece3e2f76a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Details), @"mvc.1.0.view", @"/Views/Cart/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/Details.cshtml", typeof(AspNetCore.Views_Cart_Details))]
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
#line 1 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Views\_ViewImports.cshtml"
using WebStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f38ee0ac7a76418678d4ad84e7e5ece3e2f76a4", @"/Views/Cart/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67066408fc6b1bdc8b40a1cbe0d084334331fdab", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebStore.Models.Cart.DetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Catalog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cart_quantity_up"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DecrementFromCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cart_quantity_down"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cart_quantity_delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveFromCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Views\Cart\Details.cshtml"
  
    ViewData["Title"] = "Корзина";

#line default
#line hidden
            BeginContext(89, 733, true);
            WriteLiteral(@"<section id=""cart_items"">
    <div class=""breadcrumbs"">
        <ol class=""breadcrumb"">
            <li><a href=""#""> Home </a></li>
            <li class=""active""> Shopping Cart </li>
        </ol>
    </div>
    <div class=""table-responsive cart_info"">
        <table class=""table table-condensed"">
            <thead>
                <tr class=""cart_menu"">
                    <td class=""image""> Товар </td>
                    <td class=""description""></td>
                    <td class=""price""> Цена </td>
                    <td class=""quantity""> Количество </td>
                    <td class=""total""> Итого </td>
                    <td></td>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 25 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Views\Cart\Details.cshtml"
                  
                    var sumCart = 0m;
                

#line default
#line hidden
#line 27 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Views\Cart\Details.cshtml"
                  foreach (var item in Model.CartViewModel.Items)
                {
                    sumCart += (item.Value * item.Key.Price);

#line default
#line hidden
            BeginContext(1030, 150, true);
            WriteLiteral("                    <tr>\r\n                        <td class=\"cart_product\">\r\n                            <a href=\"\">\r\n                                ");
            EndContext();
            BeginContext(1180, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7f38ee0ac7a76418678d4ad84e7e5ece3e2f76a48411", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1190, "~/Eshopper/images/shop/", 1190, 23, true);
#line 33 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Views\Cart\Details.cshtml"
AddHtmlAttributeValue("", 1213, item.Key.ImageUrl, 1213, 18, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1240, 188, true);
            WriteLiteral("\r\n                            </a>\r\n                        </td>\r\n                        <td class=\"cart_description\">\r\n                            <h4>\r\n                                ");
            EndContext();
            BeginContext(1428, 138, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f38ee0ac7a76418678d4ad84e7e5ece3e2f76a410352", async() => {
                BeginContext(1549, 13, false);
#line 39 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Views\Cart\Details.cshtml"
                                                                                   Write(item.Key.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 39 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Views\Cart\Details.cshtml"
                                                              WriteLiteral(item.Key.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1566, 204, true);
            WriteLiteral("\r\n                            </h4>\r\n                            <p> Артикул: 1089772 </p>\r\n                        </td>\r\n                        <td class=\"cart_price\">\r\n                            <p> ");
            EndContext();
            BeginContext(1772, 28, false);
#line 44 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Views\Cart\Details.cshtml"
                            Write(item.Key.Price.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(1801, 186, true);
            WriteLiteral(" </p>\r\n                        </td>\r\n                        <td class=\"cart_quantity\">\r\n                            <div class=\"cart_quantity_button\">\r\n                                ");
            EndContext();
            BeginContext(1987, 222, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f38ee0ac7a76418678d4ad84e7e5ece3e2f76a414044", async() => {
                BeginContext(2204, 1, true);
                WriteLiteral("+");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Views\Cart\Details.cshtml"
                                     WriteLiteral(item.Key.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 49 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Views\Cart\Details.cshtml"
                                                                        WriteLiteral(Context.Request.Path);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2209, 136, true);
            WriteLiteral("\r\n                                <input class=\"cart_quantity_input\" type=\"text\"\r\n                                       name=\"quantity\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2345, "\"", 2364, 1);
#line 52 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Views\Cart\Details.cshtml"
WriteAttributeValue("", 2353, item.Value, 2353, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2365, 63, true);
            WriteLiteral(" autocomplete=\"off\" size=\"2\">\r\n                                ");
            EndContext();
            BeginContext(2428, 188, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f38ee0ac7a76418678d4ad84e7e5ece3e2f76a418160", async() => {
                BeginContext(2611, 1, true);
                WriteLiteral("-");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 54 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Views\Cart\Details.cshtml"
                                                                    WriteLiteral(item.Key.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2616, 208, true);
            WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n                        <td class=\"cart_total\">\r\n                            <p class=\"cart_total_price\">\r\n                                ");
            EndContext();
            BeginContext(2826, 43, false);
#line 60 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Views\Cart\Details.cshtml"
                            Write((item.Value * item.Key.Price).ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(2870, 145, true);
            WriteLiteral("\r\n                            </p>\r\n                        </td>\r\n                        <td class=\"cart_delete\">\r\n                            ");
            EndContext();
            BeginContext(3015, 237, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f38ee0ac7a76418678d4ad84e7e5ece3e2f76a421669", async() => {
                BeginContext(3157, 91, true);
                WriteLiteral("\r\n                                <i class=\"fa fa-times\"></i>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Views\Cart\Details.cshtml"
                                                                                   WriteLiteral(item.Key.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3252, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 70 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Views\Cart\Details.cshtml"
                }   

#line default
#line hidden
            BeginContext(3334, 226, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</section> <!--/#cart_items-->\r\n<section id=\"do_action\">\r\n    <div class=\"heading\">\r\n        <h3> Оформите заказ </h3>\r\n    </div>\r\n    <div class=\"row login-form\">\r\n        ");
            EndContext();
            BeginContext(3561, 126, false);
#line 80 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Views\Cart\Details.cshtml"
   Write(Html.Partial("Partial/_OrderPartial" , Model . OrderViewModel,new ViewDataDictionary ( ViewData ) { { "sumCart" , sumCart } }));

#line default
#line hidden
            EndContext();
            BeginContext(3687, 43, true);
            WriteLiteral("\r\n    </div>\r\n</section> <!--/#do_action-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebStore.Models.Cart.DetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
