#pragma checksum "C:\Users\congr\source\repos\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Administrador\AdministrarHabitacion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c71965e4e64b31d9e605ba316c69b418d8c256f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_AdministrarHabitacion), @"mvc.1.0.view", @"/Views/Administrador/AdministrarHabitacion.cshtml")]
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
#line 1 "C:\Users\congr\source\repos\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\_ViewImports.cshtml"
using ProyectoHoteleroFARS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\congr\source\repos\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\_ViewImports.cshtml"
using ProyectoHoteleroFARS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c71965e4e64b31d9e605ba316c69b418d8c256f", @"/Views/Administrador/AdministrarHabitacion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"412ee32369deb8ae8f0872df830a3dc5e89d567d", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_AdministrarHabitacion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\congr\source\repos\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Administrador\AdministrarHabitacion.cshtml"
   ViewData["Title"] = "Home";
    Layout = "_LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row shadow-lg p-3 mb-5 bg-white rounded"">
    <div class=""col-12"">
        <legend>Administrar habitaciones</legend>
    </div>
</div>

<div class=""row justify-content-center shadow-lg p-3 mb-5 bg-white rounded"">
    <div class=""col-11"">
        <p class=""text-justify"">
            Standart <a class=""btn btn-outline-primary"" type=""button"" href=""/Administrador/CambiarDescripcion/1"">Cambiar descripción</a>
        </p>
        <table class=""table"">
            <thead class=""thead-dark"">
                <tr>
                    <th scope=""col"">No. Habitación</th>
                    <th scope=""col"">Estado</th>
                </tr>
            </thead>
        </table>
    </div>
    <div class=""col-11"" style=""margin-top: 1em;"">
        <p class=""text-justify"">
            ");
#nullable restore
#line 27 "C:\Users\congr\source\repos\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Administrador\AdministrarHabitacion.cshtml"
       Write(ViewBag.prueba);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <a class=""btn btn-outline-primary"" type=""button"" href=""/Administrador/CambiarDescripcion/2"">Cambiar descripción</a>
        </p>
        <table class=""table"">
            <thead class=""thead-dark"">
                <tr>
                    <th scope=""col"">No. Habitación</th>
                    <th scope=""col"">Estado</th>
                </tr>
            </thead>
        </table>
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
