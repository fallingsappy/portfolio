#pragma checksum "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Areas\Admin\Views\Home\ProductList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00404c9b6a2beeb6375706d2d9cc5f188a278da2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_ProductList), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/ProductList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Home/ProductList.cshtml", typeof(AspNetCore.Areas_Admin_Views_Home_ProductList))]
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
#line 1 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Areas\Admin\Views\_ViewImports.cshtml"
using WebStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00404c9b6a2beeb6375706d2d9cc5f188a278da2", @"/Areas/Admin/Views/Home/ProductList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67066408fc6b1bdc8b40a1cbe0d084334331fdab", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_ProductList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebStore.DomainNew.Entities.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Areas\Admin\Views\Home\ProductList.cshtml"
  
    ViewData["Title"] = "Список продуктов";

#line default
#line hidden
            BeginContext(109, 147, true);
            WriteLiteral("\r\n<p>\r\n    <a asp-action = \"Create\" > Create New </a>\r\n</p>\r\n<table class = \"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(257, 39, false);
#line 13 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Areas\Admin\Views\Home\ProductList.cshtml"
           Write(Html.DisplayNameFor( model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(296, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(352, 41, false);
#line 16 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Areas\Admin\Views\Home\ProductList.cshtml"
           Write(Html.DisplayNameFor( model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(393, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(449, 42, false);
#line 19 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Areas\Admin\Views\Home\ProductList.cshtml"
           Write(Html.DisplayNameFor( model => model.Order));

#line default
#line hidden
            EndContext();
            BeginContext(491, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(547, 46, false);
#line 22 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Areas\Admin\Views\Home\ProductList.cshtml"
           Write(Html.DisplayNameFor( model => model.SectionId));

#line default
#line hidden
            EndContext();
            BeginContext(593, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(649, 44, false);
#line 25 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Areas\Admin\Views\Home\ProductList.cshtml"
           Write(Html.DisplayNameFor( model => model.BrandId));

#line default
#line hidden
            EndContext();
            BeginContext(693, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(749, 45, false);
#line 28 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Areas\Admin\Views\Home\ProductList.cshtml"
           Write(Html.DisplayNameFor( model => model.ImageUrl));

#line default
#line hidden
            EndContext();
            BeginContext(794, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(850, 42, false);
#line 31 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Areas\Admin\Views\Home\ProductList.cshtml"
           Write(Html.DisplayNameFor( model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(892, 102, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 39 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Areas\Admin\Views\Home\ProductList.cshtml"
     foreach ( var item in Model ) 
    {

#line default
#line hidden
            BeginContext(1038, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1087, 38, false);
#line 43 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Areas\Admin\Views\Home\ProductList.cshtml"
           Write(Html.DisplayFor( modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1125, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1181, 40, false);
#line 46 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Areas\Admin\Views\Home\ProductList.cshtml"
           Write(Html.DisplayFor( modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1221, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1277, 41, false);
#line 49 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Areas\Admin\Views\Home\ProductList.cshtml"
           Write(Html.DisplayFor( modelItem => item.Order));

#line default
#line hidden
            EndContext();
            BeginContext(1318, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1374, 45, false);
#line 52 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Areas\Admin\Views\Home\ProductList.cshtml"
           Write(Html.DisplayFor( modelItem => item.SectionId));

#line default
#line hidden
            EndContext();
            BeginContext(1419, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1475, 43, false);
#line 55 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Areas\Admin\Views\Home\ProductList.cshtml"
           Write(Html.DisplayFor( modelItem => item.BrandId));

#line default
#line hidden
            EndContext();
            BeginContext(1518, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1574, 43, false);
#line 58 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Areas\Admin\Views\Home\ProductList.cshtml"
           Write(Html.DisplayFor(modelItem => item.ImageUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1617, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1673, 41, false);
#line 61 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Areas\Admin\Views\Home\ProductList.cshtml"
           Write(Html.DisplayFor( modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1714, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1770, 68, false);
#line 64 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Areas\Admin\Views\Home\ProductList.cshtml"
           Write(Html.ActionLink( "Edit" , "Edit" , new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1838, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1859, 73, false);
#line 65 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Areas\Admin\Views\Home\ProductList.cshtml"
           Write(Html.ActionLink( "Details" , "Details" , new { /* id=item.PrimaryKey*/ }));

#line default
#line hidden
            EndContext();
            BeginContext(1932, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1953, 72, false);
#line 66 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Areas\Admin\Views\Home\ProductList.cshtml"
           Write(Html.ActionLink( "Delete" , "Delete" , new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2025, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 69 "E:\fallingsappy\Data\Programming\CSharpASP.NET_MVC_6.Level_1\Homework\Homework8\WebStore_Stable\CoreWebApp_1\Areas\Admin\Views\Home\ProductList.cshtml"
    }

#line default
#line hidden
            BeginContext(2068, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebStore.DomainNew.Entities.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
