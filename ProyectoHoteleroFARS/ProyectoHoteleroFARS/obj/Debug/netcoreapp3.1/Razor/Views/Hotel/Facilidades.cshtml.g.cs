#pragma checksum "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Hotel\Facilidades.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "219ac2a7795917728ccd6e5efdf1970178615015"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hotel_Facilidades), @"mvc.1.0.view", @"/Views/Hotel/Facilidades.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"219ac2a7795917728ccd6e5efdf1970178615015", @"/Views/Hotel/Facilidades.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88a2574cf27275204bf97baad6b0260729e88e63", @"/Views/_ViewImports.cshtml")]
    public class Views_Hotel_Facilidades : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Hotel\Facilidades.cshtml"
  
    ViewData["Title"] = "Facilidades";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row shadow-lg p-3 mb-5 bg-transparent rounded\">\r\n    <legend style=\"font-weight: bold;  font-family:Felix Titling;\">Facilidades</legend>\r\n</div>\r\n<div class=\"row\">\r\n");
#nullable restore
#line 10 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Hotel\Facilidades.cshtml"
     for (int i = 0; i < ViewBag.Facilidades.Count; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-12 col-md-12\">\r\n        <hr />\r\n        <div class=\"row\">\r\n            <div class=\"col-12 col-md-5 align-self-center\" style=\"max-width: 400px\">\r\n                <img class=\"align-self-center\"");
            BeginWriteAttribute("src", " src=\"", 527, "\"", 636, 4);
            WriteAttributeValue("", 533, "data:image/", 533, 11, true);
#nullable restore
#line 16 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Hotel\Facilidades.cshtml"
WriteAttributeValue("", 544, ViewBag.Facilidades[i].galeria.TC_Formato, 544, 42, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 586, ";base64,", 586, 8, true);
#nullable restore
#line 16 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Hotel\Facilidades.cshtml"
WriteAttributeValue("", 594, ViewBag.Facilidades[i].galeria.TV_Archivo, 594, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 637, "\"", 689, 1);
#nullable restore
#line 16 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Hotel\Facilidades.cshtml"
WriteAttributeValue("", 643, ViewBag.Facilidades[i].galeria.TC_Descripcion, 643, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""max-width: 100%; height: 300px;"">
            </div>
            <div class=""col-12 col-md-5"" style=""display:flex"">
                <p class=""text-justify text-dark font-weight-bold mr-1"" style=""font-family: Century Gothic;"">
                    ●
                </p>
                <p class=""text-justify text-dark font-weight-bold"" style=""font-family: Century Gothic;"">
                    ");
#nullable restore
#line 23 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Hotel\Facilidades.cshtml"
               Write(ViewBag.Facilidades[i].TC_Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n        </div>\r\n   </div>\r\n");
#nullable restore
#line 28 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Hotel\Facilidades.cshtml"
        

     }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
