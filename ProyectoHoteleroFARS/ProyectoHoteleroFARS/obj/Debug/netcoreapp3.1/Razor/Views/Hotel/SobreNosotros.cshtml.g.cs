#pragma checksum "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Hotel\SobreNosotros.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c921717cfde6d882631b74ca18ff2743a273fea7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hotel_SobreNosotros), @"mvc.1.0.view", @"/Views/Hotel/SobreNosotros.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c921717cfde6d882631b74ca18ff2743a273fea7", @"/Views/Hotel/SobreNosotros.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88a2574cf27275204bf97baad6b0260729e88e63", @"/Views/_ViewImports.cshtml")]
    public class Views_Hotel_SobreNosotros : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Hotel\SobreNosotros.cshtml"
  
    ViewData["Title"] = "Sobre Nostros";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row shadow-lg p-3 mb-5 bg-white rounded\" style=\"padding-left: 1em; padding-right: 1em; margin-right:0.5em\">\r\n    <div class=\"col-12 col-md-12\">\r\n        <legend>Sobre Nosotros</legend>\r\n        <p class=\"text-justify\">\r\n            ");
#nullable restore
#line 10 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Hotel\SobreNosotros.cshtml"
       Write(ViewBag.SobreNosotros);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </p>
    </div>
</div>

<div class=""row shadow-lg p-3 mb-5 bg-white rounded"" style=""padding-left: 1em; padding-right: 0.5em; margin-right:0.5em"">
    <legend>Galeria</legend>
</div>

<div id=""carouselExampleControls"" class=""carousel slide"" data-ride=""carousel"" style=""width:600px; height:400px"">
    <div class=""carousel-inner"">

");
#nullable restore
#line 22 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Hotel\SobreNosotros.cshtml"
         for (int i = 0; i < ViewBag.Galeria.Count; i++)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Hotel\SobreNosotros.cshtml"
             if (i == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"carousel-item active\">\r\n                    <img class=\"d-block w-100\"");
            BeginWriteAttribute("src", " src=\"", 901, "\"", 986, 4);
            WriteAttributeValue("", 907, "data:image/", 907, 11, true);
#nullable restore
#line 27 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Hotel\SobreNosotros.cshtml"
WriteAttributeValue("", 918, ViewBag.Galeria[i].TC_Formato, 918, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 948, ";base64,", 948, 8, true);
#nullable restore
#line 27 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Hotel\SobreNosotros.cshtml"
WriteAttributeValue("", 956, ViewBag.Galeria[i].TV_Archivo, 956, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"First slide\" style=\"max-width: 100%; height: 400px\">\r\n                </div>\r\n");
#nullable restore
#line 29 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Hotel\SobreNosotros.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"carousel-item\">\r\n                    <img class=\"d-block w-100\"");
            BeginWriteAttribute("src", " src=\"", 1210, "\"", 1295, 4);
            WriteAttributeValue("", 1216, "data:image/", 1216, 11, true);
#nullable restore
#line 33 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Hotel\SobreNosotros.cshtml"
WriteAttributeValue("", 1227, ViewBag.Galeria[i].TC_Formato, 1227, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1257, ";base64,", 1257, 8, true);
#nullable restore
#line 33 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Hotel\SobreNosotros.cshtml"
WriteAttributeValue("", 1265, ViewBag.Galeria[i].TV_Archivo, 1265, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"First slide\" style=\"max-width: 100%; height: 400px\">\r\n                </div>\r\n");
#nullable restore
#line 35 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Hotel\SobreNosotros.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Hotel\SobreNosotros.cshtml"
             

        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
    <a class=""carousel-control-prev"" href=""#carouselExampleControls"" role=""button"" data-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
    </a>
    <a class=""carousel-control-next"" href=""#carouselExampleControls"" role=""button"" data-slide=""next"">
        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
    </a>
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
