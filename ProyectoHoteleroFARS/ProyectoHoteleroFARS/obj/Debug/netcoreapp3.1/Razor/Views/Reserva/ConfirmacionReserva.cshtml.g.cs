#pragma checksum "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Reserva\ConfirmacionReserva.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b43499a87aeb90f9fb2cc4b35891d25f6639d5ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reserva_ConfirmacionReserva), @"mvc.1.0.view", @"/Views/Reserva/ConfirmacionReserva.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b43499a87aeb90f9fb2cc4b35891d25f6639d5ce", @"/Views/Reserva/ConfirmacionReserva.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88a2574cf27275204bf97baad6b0260729e88e63", @"/Views/_ViewImports.cshtml")]
    public class Views_Reserva_ConfirmacionReserva : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Reserva\ConfirmacionReserva.cshtml"
  
    ViewData["Title"] = "Reserva";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row shadow-lg p-3 mb-5 bg-transparent rounded"" style=""text-align:left"">
    <legend style=""font-weight: bold;  font-family:Forte;"">Reservar en Línea</legend>
</div>

<div class=""row shadow-lg p-3 mb-5 bg-transparent rounded"" style=""text-align:left"">
    <legend style=""font-weight: bold;  font-family:Forte;"">Reservación realizada.</legend>
    <hr style=""width:100%""/>
    <legend style=""font-family:Forte;"">Gracias <b>");
#nullable restore
#line 13 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Reserva\ConfirmacionReserva.cshtml"
                                             Write(ViewBag.Confirmacion.TC_Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> <b>");
#nullable restore
#line 13 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Reserva\ConfirmacionReserva.cshtml"
                                                                                    Write(ViewBag.Confirmacion.TC_Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> Su reservacion fue realizada exitosamente.</legend>\r\n    <hr style=\"width:100%\" />\r\n    <legend style=\"font-family:Forte;\">Número de Reservación: <b>");
#nullable restore
#line 15 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Reserva\ConfirmacionReserva.cshtml"
                                                            Write(ViewBag.Confirmacion.TC_Id_Reserva);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></legend>\r\n    <hr style=\"width:100%\" />\r\n    <legend style=\"font-family:Forte;\">Acabamos de enviar esta informacion a la direccion <b>");
#nullable restore
#line 17 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Reserva\ConfirmacionReserva.cshtml"
                                                                                        Write(ViewBag.Confirmacion.TC_Correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> para mayor facilidad.</legend>\r\n    <hr style=\"width:100%\" />\r\n    <legend style=\"font-weight: bold;  font-family:Forte;\">Gracias por preferirnos.</legend>\r\n</div>\r\n\r\n\r\n");
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
