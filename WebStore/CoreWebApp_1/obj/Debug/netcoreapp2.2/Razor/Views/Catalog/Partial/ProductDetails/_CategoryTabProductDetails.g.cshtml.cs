#pragma checksum "E:\fallingsappy\Data\Programming\portfolio\WebStore\CoreWebApp_1\Views\Catalog\Partial\ProductDetails\_CategoryTabProductDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1b64a95f1d3531da1a05196384ae45221948836"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_Partial_ProductDetails__CategoryTabProductDetails), @"mvc.1.0.view", @"/Views/Catalog/Partial/ProductDetails/_CategoryTabProductDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Catalog/Partial/ProductDetails/_CategoryTabProductDetails.cshtml", typeof(AspNetCore.Views_Catalog_Partial_ProductDetails__CategoryTabProductDetails))]
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
#line 1 "E:\fallingsappy\Data\Programming\portfolio\WebStore\CoreWebApp_1\Views\_ViewImports.cshtml"
using WebStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1b64a95f1d3531da1a05196384ae45221948836", @"/Views/Catalog/Partial/ProductDetails/_CategoryTabProductDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67066408fc6b1bdc8b40a1cbe0d084334331fdab", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_Partial_ProductDetails__CategoryTabProductDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebStore.Models.Product.ProductViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Eshopper/images/home/gallery1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Eshopper/images/home/gallery2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Eshopper/images/home/gallery3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Eshopper/images/home/gallery4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Eshopper/images/product-details/rating.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(62, 785, true);
            WriteLiteral(@"
<div class=""category-tab shop-details-tab"">
    <!--category-tab-->
    <div class=""col-sm-12"">
        <ul class=""nav nav-tabs"">
            <li><a href=""#details"" data-toggle=""tab"">Details</a></li>
            <li><a href=""#companyprofile"" data-toggle=""tab"">Company Profile</a></li>
            <li><a href=""#tag"" data-toggle=""tab"">Tag</a></li>
            <li class=""active""><a href=""#reviews"" data-toggle=""tab"">Reviews (5)</a></li>
        </ul>
    </div>
    <div class=""tab-content"">
        <div class=""tab-pane fade"" id=""details"">
            <div class=""col-sm-3"">
                <div class=""product-image-wrapper"">
                    <div class=""single-products"">
                        <div class=""productinfo text-center"">
                            ");
            EndContext();
            BeginContext(847, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d1b64a95f1d3531da1a05196384ae452219488367105", async() => {
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
            EndContext();
            BeginContext(903, 589, true);
            WriteLiteral(@"
                            <h2>$56</h2>
                            <p>Easy Polo Black Edition</p>
                            <button type=""button"" class=""btn btn-default add-to-cart""><i class=""fa fa-shopping-cart""></i>Добавить в корзину</button>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-sm-3"">
                <div class=""product-image-wrapper"">
                    <div class=""single-products"">
                        <div class=""productinfo text-center"">
                            ");
            EndContext();
            BeginContext(1492, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d1b64a95f1d3531da1a05196384ae452219488368959", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1548, 589, true);
            WriteLiteral(@"
                            <h2>$56</h2>
                            <p>Easy Polo Black Edition</p>
                            <button type=""button"" class=""btn btn-default add-to-cart""><i class=""fa fa-shopping-cart""></i>Добавить в корзину</button>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-sm-3"">
                <div class=""product-image-wrapper"">
                    <div class=""single-products"">
                        <div class=""productinfo text-center"">
                            ");
            EndContext();
            BeginContext(2137, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d1b64a95f1d3531da1a05196384ae4522194883610814", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2193, 589, true);
            WriteLiteral(@"
                            <h2>$56</h2>
                            <p>Easy Polo Black Edition</p>
                            <button type=""button"" class=""btn btn-default add-to-cart""><i class=""fa fa-shopping-cart""></i>Добавить в корзину</button>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-sm-3"">
                <div class=""product-image-wrapper"">
                    <div class=""single-products"">
                        <div class=""productinfo text-center"">
                            ");
            EndContext();
            BeginContext(2782, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d1b64a95f1d3531da1a05196384ae4522194883612670", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2838, 664, true);
            WriteLiteral(@"
                            <h2>$56</h2>
                            <p>Easy Polo Black Edition</p>
                            <button type=""button"" class=""btn btn-default add-to-cart""><i class=""fa fa-shopping-cart""></i>Добавить в корзину</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class=""tab-pane fade"" id=""companyprofile"">
            <div class=""col-sm-3"">
                <div class=""product-image-wrapper"">
                    <div class=""single-products"">
                        <div class=""productinfo text-center"">
                            ");
            EndContext();
            BeginContext(3502, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d1b64a95f1d3531da1a05196384ae4522194883614605", async() => {
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
            EndContext();
            BeginContext(3558, 589, true);
            WriteLiteral(@"
                            <h2>$56</h2>
                            <p>Easy Polo Black Edition</p>
                            <button type=""button"" class=""btn btn-default add-to-cart""><i class=""fa fa-shopping-cart""></i>Добавить в корзину</button>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-sm-3"">
                <div class=""product-image-wrapper"">
                    <div class=""single-products"">
                        <div class=""productinfo text-center"">
                            ");
            EndContext();
            BeginContext(4147, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d1b64a95f1d3531da1a05196384ae4522194883616461", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4203, 589, true);
            WriteLiteral(@"
                            <h2>$56</h2>
                            <p>Easy Polo Black Edition</p>
                            <button type=""button"" class=""btn btn-default add-to-cart""><i class=""fa fa-shopping-cart""></i>Добавить в корзину</button>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-sm-3"">
                <div class=""product-image-wrapper"">
                    <div class=""single-products"">
                        <div class=""productinfo text-center"">
                            ");
            EndContext();
            BeginContext(4792, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d1b64a95f1d3531da1a05196384ae4522194883618317", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4848, 589, true);
            WriteLiteral(@"
                            <h2>$56</h2>
                            <p>Easy Polo Black Edition</p>
                            <button type=""button"" class=""btn btn-default add-to-cart""><i class=""fa fa-shopping-cart""></i>Добавить в корзину</button>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-sm-3"">
                <div class=""product-image-wrapper"">
                    <div class=""single-products"">
                        <div class=""productinfo text-center"">
                            ");
            EndContext();
            BeginContext(5437, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d1b64a95f1d3531da1a05196384ae4522194883620173", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5493, 653, true);
            WriteLiteral(@"
                            <h2>$56</h2>
                            <p>Easy Polo Black Edition</p>
                            <button type=""button"" class=""btn btn-default add-to-cart""><i class=""fa fa-shopping-cart""></i>Добавить в корзину</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class=""tab-pane fade"" id=""tag"">
            <div class=""col-sm-3"">
                <div class=""product-image-wrapper"">
                    <div class=""single-products"">
                        <div class=""productinfo text-center"">
                            ");
            EndContext();
            BeginContext(6146, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d1b64a95f1d3531da1a05196384ae4522194883622097", async() => {
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
            EndContext();
            BeginContext(6202, 589, true);
            WriteLiteral(@"
                            <h2>$56</h2>
                            <p>Easy Polo Black Edition</p>
                            <button type=""button"" class=""btn btn-default add-to-cart""><i class=""fa fa-shopping-cart""></i>Добавить в корзину</button>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-sm-3"">
                <div class=""product-image-wrapper"">
                    <div class=""single-products"">
                        <div class=""productinfo text-center"">
                            ");
            EndContext();
            BeginContext(6791, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d1b64a95f1d3531da1a05196384ae4522194883623953", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6847, 589, true);
            WriteLiteral(@"
                            <h2>$56</h2>
                            <p>Easy Polo Black Edition</p>
                            <button type=""button"" class=""btn btn-default add-to-cart""><i class=""fa fa-shopping-cart""></i>Добавить в корзину</button>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-sm-3"">
                <div class=""product-image-wrapper"">
                    <div class=""single-products"">
                        <div class=""productinfo text-center"">
                            ");
            EndContext();
            BeginContext(7436, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d1b64a95f1d3531da1a05196384ae4522194883625809", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7492, 589, true);
            WriteLiteral(@"
                            <h2>$56</h2>
                            <p>Easy Polo Black Edition</p>
                            <button type=""button"" class=""btn btn-default add-to-cart""><i class=""fa fa-shopping-cart""></i>Добавить в корзину</button>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-sm-3"">
                <div class=""product-image-wrapper"">
                    <div class=""single-products"">
                        <div class=""productinfo text-center"">
                            ");
            EndContext();
            BeginContext(8081, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d1b64a95f1d3531da1a05196384ae4522194883627665", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8137, 1192, true);
            WriteLiteral(@"
                            <h2>$56</h2>
                            <p>Easy Polo Black Edition</p>
                            <button type=""button"" class=""btn btn-default add-to-cart""><i class=""fa fa-shopping-cart""></i>Добавить в корзину</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class=""tab-pane fade active in"" id=""reviews"">
            <div class=""col-sm-12"">
                <ul>
                    <li><a href=""""><i class=""fa fa-user""></i>EUGEN</a></li>
                    <li><a href=""""><i class=""fa fa-clock-o""></i>12:41 PM</a></li>
                    <li><a href=""""><i class=""fa fa-calendar-o""></i>31 DEC 2014</a></li>
                </ul>
                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.Duis au");
            WriteLiteral("te irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.</p>\r\n                <p><b>Write Your Review</b></p>\r\n\r\n                ");
            EndContext();
            BeginContext(9329, 542, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1b64a95f1d3531da1a05196384ae4522194883630173", async() => {
                BeginContext(9346, 293, true);
                WriteLiteral(@"
                    <span>
                        <input type=""text"" placeholder=""Your Name"" />
                        <input type=""email"" placeholder=""Email Address"" />
                    </span>
                    <textarea name=""""></textarea>
                    <b>Rating: </b> ");
                EndContext();
                BeginContext(9639, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d1b64a95f1d3531da1a05196384ae4522194883630859", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9704, 160, true);
                WriteLiteral("\r\n                    <button type=\"button\" class=\"btn btn-default pull-right\">\r\n                        Submit\r\n                    </button>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9871, 78, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div><!--/category-tab-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebStore.Models.Product.ProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
