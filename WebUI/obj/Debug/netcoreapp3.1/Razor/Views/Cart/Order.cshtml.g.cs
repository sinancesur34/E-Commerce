#pragma checksum "C:\Users\sinan\Desktop\Katmanli-mimari-ve-MVC-ile-E-Ticaret-Sitesi-main\ShopProject\WebUI\Views\Cart\Order.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3296cdb1d9a97ee0c448b53f82a8c685f60e52f000e05c201af2a28fe28b3ba0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Order), @"mvc.1.0.view", @"/Views/Cart/Order.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"3296cdb1d9a97ee0c448b53f82a8c685f60e52f000e05c201af2a28fe28b3ba0", @"/Views/Cart/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c7272a8274deccee39d27c610aab921b9862ca2f527382cb324791a886cddb8a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cart_Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderWM>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sinan\Desktop\Katmanli-mimari-ve-MVC-ile-E-Ticaret-Sitesi-main\ShopProject\WebUI\Views\Cart\Order.cshtml"
  
    ViewData["Title"] = "Order";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\n    <h4>\n        <span class=\"text-muted\">Siparişleriniz</span>\n    </h4>\n    <ul class=\"list-group mb-3\">\n");
#nullable restore
#line 10 "C:\Users\sinan\Desktop\Katmanli-mimari-ve-MVC-ile-E-Ticaret-Sitesi-main\ShopProject\WebUI\Views\Cart\Order.cshtml"
         foreach (var item in Model.CartWM.CartItems)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"list-group-item d-flex justify-content-between\">\n                <div>\n                    <span class=\"text-muted\">\n                        ");
#nullable restore
#line 16 "C:\Users\sinan\Desktop\Katmanli-mimari-ve-MVC-ile-E-Ticaret-Sitesi-main\ShopProject\WebUI\Views\Cart\Order.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        <span> X ");
#nullable restore
#line 17 "C:\Users\sinan\Desktop\Katmanli-mimari-ve-MVC-ile-E-Ticaret-Sitesi-main\ShopProject\WebUI\Views\Cart\Order.cshtml"
                            Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                    </span>\n                </div>\n                <span class=\"text-muted\">");
#nullable restore
#line 20 "C:\Users\sinan\Desktop\Katmanli-mimari-ve-MVC-ile-E-Ticaret-Sitesi-main\ShopProject\WebUI\Views\Cart\Order.cshtml"
                                    Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</span>\n            </li>\n");
#nullable restore
#line 22 "C:\Users\sinan\Desktop\Katmanli-mimari-ve-MVC-ile-E-Ticaret-Sitesi-main\ShopProject\WebUI\Views\Cart\Order.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"list-group-item d-flex justify-content-between\">\n            <span>Toplam Tutar</span>\n            <strong>");
#nullable restore
#line 25 "C:\Users\sinan\Desktop\Katmanli-mimari-ve-MVC-ile-E-Ticaret-Sitesi-main\ShopProject\WebUI\Views\Cart\Order.cshtml"
               Write(Model.CartWM.TotalPrice());

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</strong>\n        </li>\n    </ul>\n\n    <button type=\"submit\" class=\"send\">Sipariş ver</button>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderWM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
