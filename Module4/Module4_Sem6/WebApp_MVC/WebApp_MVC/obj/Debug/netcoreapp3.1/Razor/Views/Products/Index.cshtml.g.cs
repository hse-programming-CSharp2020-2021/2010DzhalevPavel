#pragma checksum "/home/padjal/Documents/HSE/1st Year/Programming/2010DzhalevPavel/Module4/Module4_Sem6/WebApp_MVC/WebApp_MVC/Views/Products/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "187e3cbac3367aa1827a3ae89e385a04f7afcc38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
#line 1 "/home/padjal/Documents/HSE/1st Year/Programming/2010DzhalevPavel/Module4/Module4_Sem6/WebApp_MVC/WebApp_MVC/Views/_ViewImports.cshtml"
using WebApp_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/padjal/Documents/HSE/1st Year/Programming/2010DzhalevPavel/Module4/Module4_Sem6/WebApp_MVC/WebApp_MVC/Views/_ViewImports.cshtml"
using WebApp_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"187e3cbac3367aa1827a3ae89e385a04f7afcc38", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0411096090f33c3dbf0ef9cc43ab63615c1107d", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/padjal/Documents/HSE/1st Year/Programming/2010DzhalevPavel/Module4/Module4_Sem6/WebApp_MVC/WebApp_MVC/Views/Products/Index.cshtml"
  
    ViewData["Title"] = "Список товаров";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Список товаров</h1>\r\n<div class=\"card-columns\">\n");
#nullable restore
#line 9 "/home/padjal/Documents/HSE/1st Year/Programming/2010DzhalevPavel/Module4/Module4_Sem6/WebApp_MVC/WebApp_MVC/Views/Products/Index.cshtml"
 foreach (var product in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\">\n        <div class=\"card-img\"");
            BeginWriteAttribute("style", " style=\"", 268, "\"", 316, 4);
            WriteAttributeValue("", 276, "background-image:", 276, 17, true);
            WriteAttributeValue(" ", 293, "url(\'", 294, 6, true);
#nullable restore
#line 12 "/home/padjal/Documents/HSE/1st Year/Programming/2010DzhalevPavel/Module4/Module4_Sem6/WebApp_MVC/WebApp_MVC/Views/Products/Index.cshtml"
WriteAttributeValue("", 299, product.Image, 299, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 313, "\');", 313, 3, true);
            EndWriteAttribute();
            WriteLiteral("></div>\n        <div class=\"card-body\">\n            <h5 class=\"card-title\">");
#nullable restore
#line 14 "/home/padjal/Documents/HSE/1st Year/Programming/2010DzhalevPavel/Module4/Module4_Sem6/WebApp_MVC/WebApp_MVC/Views/Products/Index.cshtml"
                              Write(product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n        </div>\n        <div class=\"card-footer\">\n            <small class=\"text-muted\"><a");
            BeginWriteAttribute("href", " href=\"", 501, "\"", 529, 3);
            WriteAttributeValue("", 508, "/product/", 508, 9, true);
#nullable restore
#line 17 "/home/padjal/Documents/HSE/1st Year/Programming/2010DzhalevPavel/Module4/Module4_Sem6/WebApp_MVC/WebApp_MVC/Views/Products/Index.cshtml"
WriteAttributeValue("", 517, product.Id, 517, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 528, "/", 528, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Перейти в карточку товара</a>\n            </small>\n        </div>\n    </div>\n");
#nullable restore
#line 21 "/home/padjal/Documents/HSE/1st Year/Programming/2010DzhalevPavel/Module4/Module4_Sem6/WebApp_MVC/WebApp_MVC/Views/Products/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
