#pragma checksum "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Hotel\HomeCliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7b5c1add13fdcd63183178f319baf7f851c1825"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hotel_HomeCliente), @"mvc.1.0.view", @"/Views/Hotel/HomeCliente.cshtml")]
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
#line 1 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\_ViewImports.cshtml"
using ProyectoHoteleroFARS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\_ViewImports.cshtml"
using ProyectoHoteleroFARS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7b5c1add13fdcd63183178f319baf7f851c1825", @"/Views/Hotel/HomeCliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88a2574cf27275204bf97baad6b0260729e88e63", @"/Views/_ViewImports.cshtml")]
    public class Views_Hotel_HomeCliente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Hotel\HomeCliente.cshtml"
  
    ViewData["Title"] = "Home";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row shadow-lg p-3 mb-5 bg-white rounded"" style=""padding-left: 1em; padding-right: 0.5em; margin-right:0.5em; text-align:center"">
    <legend style=""font-weight: bold;"">Bienvenido</legend>
</div>

<div class=""row shadow-lg p-3 mb-5 bg-white rounded"" style=""padding-left: 1em; padding-right: 1em; margin-right:0.5em; justify-content:center; text-align:center"">

    <div>
        <legend>");
#nullable restore
#line 13 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Hotel\HomeCliente.cshtml"
           Write(ViewBag.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</legend>\r\n        <p");
            BeginWriteAttribute("class", " class=\"", 508, "\"", 516, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
#nullable restore
#line 15 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Hotel\HomeCliente.cshtml"
       Write(ViewBag.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n\r\n    <div>\r\n        <img height=\"auto\" width=\"auto\" style=\"max-height:550px; max-width:550px\"");
            BeginWriteAttribute("src", " src=\"", 674, "\"", 725, 2);
            WriteAttributeValue("", 680, "data:image/jpeg;base64,", 680, 23, true);
#nullable restore
#line 20 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Hotel\HomeCliente.cshtml"
WriteAttributeValue("", 703, ViewBag.FotoPrincipal, 703, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
