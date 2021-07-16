#pragma checksum "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministradorEstadoHotel\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96f874ac92bc11d992421609e7cbcfca34d98522"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdministradorEstadoHotel_Index), @"mvc.1.0.view", @"/Views/AdministradorEstadoHotel/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96f874ac92bc11d992421609e7cbcfca34d98522", @"/Views/AdministradorEstadoHotel/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88a2574cf27275204bf97baad6b0260729e88e63", @"/Views/_ViewImports.cshtml")]
    public class Views_AdministradorEstadoHotel_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministradorEstadoHotel\Index.cshtml"
   
    ViewData["Title"] = "Estado del hotel";
    Layout = "_LayoutAdmin"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row shadow-lg p-3 mb-5 bg-transparent rounded"">
    <div class=""col-12"">
        <legend style=""font-weight: bold;  font-family:Felix Titling;"">Estado de las habitaciones</legend>
        <span style=""font-family: Century Gothic; margin-top: 1em;"">Fecha y hora del servidor: ");
#nullable restore
#line 9 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministradorEstadoHotel\Index.cshtml"
                                                                                          Write(ViewBag.Fecha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n</div>\r\n\r\n<div style=\"display:flex; justify-content:flex-end\">\r\n    <button class=\"btn btn-secondary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 512, "\"", 554, 3);
            WriteAttributeValue("", 522, "reporteEstados(\'", 522, 16, true);
#nullable restore
#line 14 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministradorEstadoHotel\Index.cshtml"
WriteAttributeValue("", 538, ViewBag.Fecha, 538, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 552, "\')", 552, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">Reporte</button>
</div>

<table class=""table table-striped"" id=""testados"">
    <thead>
        <tr>
            <th scope=""col"">ID</th>
            <th scope=""col"">Número</th>
            <th scope=""col"">Activa</th>
            <th scope=""col"">Tipo</th>
            <th scope=""col"">Estado</th>
        </tr>
    </thead>
    <tbody id=""estadoHotelHoy"">
");
#nullable restore
#line 28 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministradorEstadoHotel\Index.cshtml"
         for (int i = 0; i < ViewBag.Habitaciones.Count; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 31 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministradorEstadoHotel\Index.cshtml"
                           Write(ViewBag.Habitaciones[i].TN_Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td> ");
#nullable restore
#line 32 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministradorEstadoHotel\Index.cshtml"
                Write(ViewBag.Habitaciones[i].TN_Numero);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 33 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministradorEstadoHotel\Index.cshtml"
                 if (@ViewBag.Habitaciones[i].TB_Estado) { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td> Sí </td>\r\n");
#nullable restore
#line 35 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministradorEstadoHotel\Index.cshtml"
                }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td> No </td>\r\n");
#nullable restore
#line 37 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministradorEstadoHotel\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td> ");
#nullable restore
#line 38 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministradorEstadoHotel\Index.cshtml"
                Write(ViewBag.Habitaciones[i].tipo.TC_Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td> ");
#nullable restore
#line 39 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministradorEstadoHotel\Index.cshtml"
                Write(ViewBag.Habitaciones[i].TC_Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            </tr>\r\n");
#nullable restore
#line 41 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministradorEstadoHotel\Index.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
