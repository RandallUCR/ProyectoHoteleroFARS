#pragma checksum "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Tarifas\TarifasCliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81a83aaf18fa3fdd95dc0eda962ea17959a6bda2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tarifas_TarifasCliente), @"mvc.1.0.view", @"/Views/Tarifas/TarifasCliente.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81a83aaf18fa3fdd95dc0eda962ea17959a6bda2", @"/Views/Tarifas/TarifasCliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88a2574cf27275204bf97baad6b0260729e88e63", @"/Views/_ViewImports.cshtml")]
    public class Views_Tarifas_TarifasCliente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Tarifas\TarifasCliente.cshtml"
  
    ViewData["Title"] = "Tarifas";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row shadow-lg p-3 mb-5 bg-transparent rounded\">\r\n    <legend style=\"font-weight: bold;  font-family:Felix Titling;\">Tarifas</legend>\r\n</div>\r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 11 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Tarifas\TarifasCliente.cshtml"
     foreach (Entidades.TipoHabitacion t in ViewBag.TiposHabitacion)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-12 col-md-12\">\r\n            <hr />\r\n            <div class=\"row\">\r\n                <div class=\"col-12 col-md-5 align-self-center\" style=\"max-width: 400px\">\r\n                    <img class=\"align-self-center\"");
            BeginWriteAttribute("src", " src=\"", 553, "\"", 620, 4);
            WriteAttributeValue("", 559, "data:image/", 559, 11, true);
#nullable restore
#line 17 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Tarifas\TarifasCliente.cshtml"
WriteAttributeValue("", 570, t.galeria.TC_Formato, 570, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 591, ";base64,", 591, 8, true);
#nullable restore
#line 17 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Tarifas\TarifasCliente.cshtml"
WriteAttributeValue("", 599, t.galeria.TV_Archivo, 599, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width: 100%; height: 300px;\">\r\n                </div>\r\n                <div class=\"col-12 col-md-5\" style=\"display:flex; flex-direction:column\">\r\n                    <h5 style=\"font-weight: bold;  font-family:Century Gothic;\">");
#nullable restore
#line 20 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Tarifas\TarifasCliente.cshtml"
                                                                           Write(t.TC_Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <div style=\"text-align:left; font-family:Century Gothic;\"><p>");
#nullable restore
#line 21 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Tarifas\TarifasCliente.cshtml"
                                                                            Write(t.TC_Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></div>\r\n                    \r\n");
#nullable restore
#line 23 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Tarifas\TarifasCliente.cshtml"
                     foreach (Entidades.Caracteristica c in t.caracteristicas)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div style=""display:flex"">
                        <p class=""text-justify text-dark font-weight-bold mr-1"">
                            ●
                        </p>
                        <p class=""text-justify text-dark font-weight-bold"">
                            ");
#nullable restore
#line 30 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Tarifas\TarifasCliente.cshtml"
                       Write(c.TC_Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n");
#nullable restore
#line 33 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Tarifas\TarifasCliente.cshtml"
                        
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"shadow-sm bg-dark rounded\" style=\"display:flex; text-align:center; justify-content:center\">\r\n                    <p class=\"mr-1 font-weight-bold text-light\">Precio: ₡");
#nullable restore
#line 37 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Tarifas\TarifasCliente.cshtml"
                                                                    Write(t.TN_Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"mr-3 text-light\">($");
#nullable restore
#line 38 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Tarifas\TarifasCliente.cshtml"
                                            Write(t.TN_Precio_Dolares);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</p>\r\n");
#nullable restore
#line 39 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Tarifas\TarifasCliente.cshtml"
                     if (t.promocion.TN_Id > -1)
                    {   

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"font-weight-bold text-success\">¡Ofertal del ");
#nullable restore
#line 41 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Tarifas\TarifasCliente.cshtml"
                                                                         Write(t.promocion.TN_Porcentaje);

#line default
#line hidden
#nullable disable
            WriteLiteral("%!</p>\r\n");
#nullable restore
#line 42 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Tarifas\TarifasCliente.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 49 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Tarifas\TarifasCliente.cshtml"


    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
