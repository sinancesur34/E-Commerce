#pragma checksum "C:\Users\sinan\Desktop\Katmanli-mimari-ve-MVC-ile-E-Ticaret-Sitesi-main\ShopProject\WebUI\Views\Admin\ProductLists.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "585c3aa00423640602c8b32d921801911748ff4cd2973208aa7721e8ea26c61d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ProductLists), @"mvc.1.0.view", @"/Views/Admin/ProductLists.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\sinan\Desktop\Katmanli-mimari-ve-MVC-ile-E-Ticaret-Sitesi-main\ShopProject\WebUI\Views\_ViewImports.cshtml"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sinan\Desktop\Katmanli-mimari-ve-MVC-ile-E-Ticaret-Sitesi-main\ShopProject\WebUI\Views\_ViewImports.cshtml"
using WebUI.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sinan\Desktop\Katmanli-mimari-ve-MVC-ile-E-Ticaret-Sitesi-main\ShopProject\WebUI\Views\_ViewImports.cshtml"
using Business.WebModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sinan\Desktop\Katmanli-mimari-ve-MVC-ile-E-Ticaret-Sitesi-main\ShopProject\WebUI\Views\_ViewImports.cshtml"
using Business.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sinan\Desktop\Katmanli-mimari-ve-MVC-ile-E-Ticaret-Sitesi-main\ShopProject\WebUI\Views\_ViewImports.cshtml"
using Business.Abstract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sinan\Desktop\Katmanli-mimari-ve-MVC-ile-E-Ticaret-Sitesi-main\ShopProject\WebUI\Views\_ViewImports.cshtml"
using WebUI.ViewComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sinan\Desktop\Katmanli-mimari-ve-MVC-ile-E-Ticaret-Sitesi-main\ShopProject\WebUI\Views\_ViewImports.cshtml"
using WebUI.Migrations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sinan\Desktop\Katmanli-mimari-ve-MVC-ile-E-Ticaret-Sitesi-main\ShopProject\WebUI\Views\_ViewImports.cshtml"
using WebUI.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sinan\Desktop\Katmanli-mimari-ve-MVC-ile-E-Ticaret-Sitesi-main\ShopProject\WebUI\Views\_ViewImports.cshtml"
using DataAccess.Abstract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\sinan\Desktop\Katmanli-mimari-ve-MVC-ile-E-Ticaret-Sitesi-main\ShopProject\WebUI\Views\_ViewImports.cshtml"
using DataAccess.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\sinan\Desktop\Katmanli-mimari-ve-MVC-ile-E-Ticaret-Sitesi-main\ShopProject\WebUI\Views\_ViewImports.cshtml"
using DataAccess.Migrations;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"585c3aa00423640602c8b32d921801911748ff4cd2973208aa7721e8ea26c61d", @"/Views/Admin/ProductLists.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c7272a8274deccee39d27c610aab921b9862ca2f527382cb324791a886cddb8a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_ProductLists : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListWM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm mr-2 btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/deleteproduct"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sinan\Desktop\Katmanli-mimari-ve-MVC-ile-E-Ticaret-Sitesi-main\ShopProject\WebUI\Views\Admin\ProductLists.cshtml"
  
    ViewData["Title"] = "ProductLists";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\n    <h2>Admin Ürünler</h2>\n</div>\n<hr />\n<div class=\"container\">\n");
#nullable restore
#line 10 "C:\Users\sinan\Desktop\Katmanli-mimari-ve-MVC-ile-E-Ticaret-Sitesi-main\ShopProject\WebUI\Views\Admin\ProductLists.cshtml"
     if (Model.Products.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <td>Ürün Id</td>
                    <td>Ürün Resmi</td>
                    <td>Ürün Adı</td>
                    <td>Ürün Fiyatı</td>
                    <td>Seçenekler</td>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 23 "C:\Users\sinan\Desktop\Katmanli-mimari-ve-MVC-ile-E-Ticaret-Sitesi-main\ShopProject\WebUI\Views\Admin\ProductLists.cshtml"
                 foreach (var item in Model.Products)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 26 "C:\Users\sinan\Desktop\Katmanli-mimari-ve-MVC-ile-E-Ticaret-Sitesi-main\ShopProject\WebUI\Views\Admin\ProductLists.cshtml"
                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "585c3aa00423640602c8b32d921801911748ff4cd2973208aa7721e8ea26c61d9099", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 749, "~/images/", 749, 9, true);
#nullable restore
#line 28 "C:\Users\sinan\Desktop\Katmanli-mimari-ve-MVC-ile-E-Ticaret-Sitesi-main\ShopProject\WebUI\Views\Admin\ProductLists.cshtml"
AddHtmlAttributeValue("", 758, item.Image, 758, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </td>\n                        <td>");
#nullable restore
#line 30 "C:\Users\sinan\Desktop\Katmanli-mimari-ve-MVC-ile-E-Ticaret-Sitesi-main\ShopProject\WebUI\Views\Admin\ProductLists.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 31 "C:\Users\sinan\Desktop\Katmanli-mimari-ve-MVC-ile-E-Ticaret-Sitesi-main\ShopProject\WebUI\Views\Admin\ProductLists.cshtml"
                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "585c3aa00423640602c8b32d921801911748ff4cd2973208aa7721e8ea26c61d11433", async() => {
                WriteLiteral("Düzenle");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1015, "~/admin/products/", 1015, 17, true);
#nullable restore
#line 33 "C:\Users\sinan\Desktop\Katmanli-mimari-ve-MVC-ile-E-Ticaret-Sitesi-main\ShopProject\WebUI\Views\Admin\ProductLists.cshtml"
AddHtmlAttributeValue("", 1032, item.Id, 1032, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "585c3aa00423640602c8b32d921801911748ff4cd2973208aa7721e8ea26c61d13140", async() => {
                WriteLiteral("\n                                <input type=\"hidden\" name=\"productId\"");
                BeginWriteAttribute("value", " value=\"", 1226, "\"", 1242, 1);
#nullable restore
#line 35 "C:\Users\sinan\Desktop\Katmanli-mimari-ve-MVC-ile-E-Ticaret-Sitesi-main\ShopProject\WebUI\Views\Admin\ProductLists.cshtml"
WriteAttributeValue("", 1234, item.Id, 1234, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                                <button type=\"submit\" class=\"btn btn-danger btn-sm\">Sil</button>\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n                        </td>\n                    </tr>\n");
#nullable restore
#line 41 "C:\Users\sinan\Desktop\Katmanli-mimari-ve-MVC-ile-E-Ticaret-Sitesi-main\ShopProject\WebUI\Views\Admin\ProductLists.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </tbody>\n        </table>\n");
#nullable restore
#line 46 "C:\Users\sinan\Desktop\Katmanli-mimari-ve-MVC-ile-E-Ticaret-Sitesi-main\ShopProject\WebUI\Views\Admin\ProductLists.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-warning\">\n            <h4>Ürün Yok</h4>\n        </div>\n");
#nullable restore
#line 52 "C:\Users\sinan\Desktop\Katmanli-mimari-ve-MVC-ile-E-Ticaret-Sitesi-main\ShopProject\WebUI\Views\Admin\ProductLists.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n\n\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListWM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
