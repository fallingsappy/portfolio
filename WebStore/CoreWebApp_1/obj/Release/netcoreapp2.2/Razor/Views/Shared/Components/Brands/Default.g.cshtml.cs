#pragma checksum "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Views\Shared\Components\Brands\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b737ece82030372879c0b16a589d35a2435eae71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Brands_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Brands/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Brands/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Brands_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b737ece82030372879c0b16a589d35a2435eae71", @"/Views/Shared/Components/Brands/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67066408fc6b1bdc8b40a1cbe0d084334331fdab", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Brands_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebStore.Models.Product.BrandViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Catalog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 167, true);
            WriteLiteral("<div class = \"brands_products\">\r\n    <!--brands_products-->\r\n    <h2> Бренды </h2>\r\n    <div class = \"brands-name\">\r\n        <ul class = \"nav nav-pills nav-stacked\">\r\n");
            EndContext();
#line 7 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Views\Shared\Components\Brands\Default.cshtml"
             foreach ( var brand in Model)
            {

#line default
#line hidden
            BeginContext(286, 42, true);
            WriteLiteral("                <li>\r\n                    ");
            EndContext();
            BeginContext(328, 180, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b737ece82030372879c0b16a589d35a2435eae714519", async() => {
                BeginContext(404, 58, true);
                WriteLiteral("  \r\n                        <span class = \"pull-right\" > (");
                EndContext();
                BeginContext(463, 19, false);
#line 11 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Views\Shared\Components\Brands\Default.cshtml"
                                                 Write(brand.ProductsCount);

#line default
#line hidden
                EndContext();
                BeginContext(482, 10, true);
                WriteLiteral(") </span> ");
                EndContext();
                BeginContext(493, 10, false);
#line 11 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Views\Shared\Components\Brands\Default.cshtml"
                                                                               Write(brand.Name);

#line default
#line hidden
                EndContext();
                BeginContext(503, 1, true);
                WriteLiteral(" ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-brandId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 10 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Views\Shared\Components\Brands\Default.cshtml"
                                                                         WriteLiteral(brand.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["brandId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-brandId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["brandId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(508, 25, true);
            WriteLiteral("\r\n                </li>\r\n");
            EndContext();
#line 13 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Views\Shared\Components\Brands\Default.cshtml"
            }

#line default
#line hidden
            BeginContext(548, 57, true);
            WriteLiteral("        </ul>\r\n    </div>\r\n</div> <!--/brands_products-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebStore.Models.Product.BrandViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
