#pragma checksum "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Administrador\CambiarDescripcion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9846f006b2f7db844526174b89f22294dce7e60e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_CambiarDescripcion), @"mvc.1.0.view", @"/Views/Administrador/CambiarDescripcion.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9846f006b2f7db844526174b89f22294dce7e60e", @"/Views/Administrador/CambiarDescripcion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88a2574cf27275204bf97baad6b0260729e88e63", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_CambiarDescripcion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Administrador\CambiarDescripcion.cshtml"
   ViewData["Title"] = "Home";
    Layout = "_LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row shadow-lg p-3 mb-5 bg-white rounded"">
    <div class=""col-12"">
        <legend>Modificar habitaciones</legend>
    </div>
</div>

<div class=""row justify-content-center shadow-lg p-3 mb-5 bg-white rounded"">
    <div class=""col-11 col-md-5"">
        <label class=""font-weight-bold"">");
#nullable restore
#line 14 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Administrador\CambiarDescripcion.cshtml"
                                   Write(ViewBag.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </label>\r\n    </div>\r\n    <div class=\"col-11 col-md-5\">\r\n        Tarifa diaria: <input type=\"number\"");
            BeginWriteAttribute("value", " value=\"", 490, "\"", 513, 1);
#nullable restore
#line 17 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Administrador\CambiarDescripcion.cshtml"
WriteAttributeValue("", 498, ViewBag.Precio, 498, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <div class=\"col-11\" style=\"margin-top: 1em;\">\r\n        <label for=\"txtDesc\">Descripción</label>\r\n        <textarea class=\"form-control\" id=\"txtDesc\" name=\"txtDesc\" rows=\"4\" cols=\"50\"> ");
#nullable restore
#line 21 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Administrador\CambiarDescripcion.cshtml"
                                                                                  Write(ViewBag.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </textarea>\r\n    </div>\r\n    <div class=\"col-12 col-md-5\" style=\"margin-top: 1em;\">\r\n        Imagen actual: <br />\r\n        <img height=\"auto\" width=\"auto\" style=\"max-height:inherit; max-width:inherit\"");
            BeginWriteAttribute("src", " src=\"", 941, "\"", 989, 4);
            WriteAttributeValue("", 947, "data:", 947, 5, true);
#nullable restore
#line 25 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Administrador\CambiarDescripcion.cshtml"
WriteAttributeValue("", 952, ViewBag.Formato, 952, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 968, ";base64,", 968, 8, true);
#nullable restore
#line 25 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Administrador\CambiarDescripcion.cshtml"
WriteAttributeValue("", 976, ViewBag.Foto, 976, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
    </div>
    <div class=""col-12 col-md-5"" style=""margin-top: 1em;"">
        <label for=""inputImagen"">Subir nueva imagen</label>
        <input class=""form-control"" type=""file"" id=""inputImagen"" name=""inputImagen"" />
    </div>
    <div class=""col-12 col-md-4 align-self-end"" style=""margin-top: 1em;"">
        <button class=""btn btn-info"" type=""button"">Aceptar</button>
        <button class=""btn btn-danger"" type=""button"">Cancelar</button>
    </div>
</div>");
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
