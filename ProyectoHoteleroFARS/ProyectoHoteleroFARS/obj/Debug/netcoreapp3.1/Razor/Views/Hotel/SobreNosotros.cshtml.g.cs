<<<<<<< Updated upstream
#pragma checksum "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Hotel\SobreNosotros.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0dd3627a9706f8e06ff465018155ac2fad460f69"
=======
#pragma checksum "C:\Users\congr\source\repos\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Hotel\SobreNosotros.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bba264a1ae63f0ed0b04f58b87b27e4cdb50700c"
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dd3627a9706f8e06ff465018155ac2fad460f69", @"/Views/Hotel/SobreNosotros.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88a2574cf27275204bf97baad6b0260729e88e63", @"/Views/_ViewImports.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bba264a1ae63f0ed0b04f58b87b27e4cdb50700c", @"/Views/Hotel/SobreNosotros.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"412ee32369deb8ae8f0872df830a3dc5e89d567d", @"/Views/_ViewImports.cshtml")]
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            WriteLiteral("\r\n<div class=\"row shadow-lg p-3 mb-5 bg-white rounded\" style=\"padding-left: 1em; padding-right: 1em;\">\r\n    <div class=\"col-12 col-md-12\">\r\n        <legend>Sobre Nosotros</legend>\r\n        <p class=\"text-justify\">\r\n            ");
=======
            WriteLiteral("\n<div class=\"row shadow-lg p-3 mb-5 bg-white rounded\" style=\"padding-left: 1em; padding-right: 1em;\">\n    <div class=\"col-12 col-md-12\">\n        <legend>Sobre Nosotros</legend>\n        <p class=\"text-justify\">\n            ");
>>>>>>> Stashed changes
#nullable restore
#line 10 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Hotel\SobreNosotros.cshtml"
       Write(ViewBag.SobreNosotros);

#line default
#line hidden
#nullable disable
<<<<<<< Updated upstream
            WriteLiteral(@"
        </p>
    </div>
</div>

<div class=""row shadow-lg p-3 mb-5 bg-white rounded"" style=""padding-left: 1em; padding-right: 1em;"">
    <legend>Galeria</legend>
</div>

<div id=""carouselExampleControls"" class=""row carousel slide"" data-ride=""carousel"" style=""width:600px; height:400px; align-content:center; justify-content:center; padding-left: 1em; padding-right: 0.5em;"">
    <div class=""carousel-inner"">

=======
            WriteLiteral(@"
        </p>
    </div>
</div>

<div class=""row shadow-lg p-3 mb-5 bg-white rounded"" style=""padding-left: 1em; padding-right: 1em;"">
    <legend>Galeria</legend>
</div>

<div id=""carouselExampleControls"" class=""row carousel slide"" data-ride=""carousel"" style=""width:600px; height:400px; align-content:center; justify-content:center; padding-left: 1em; padding-right: 0.5em;"">
    <div class=""carousel-inner"">

>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            WriteLiteral("                <div class=\"carousel-item active\">\r\n                    <img class=\"d-block w-100\"");
            BeginWriteAttribute("src", " src=\"", 953, "\"", 1038, 4);
            WriteAttributeValue("", 959, "data:image/", 959, 11, true);
#nullable restore
#line 27 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Hotel\SobreNosotros.cshtml"
WriteAttributeValue("", 970, ViewBag.Galeria[i].TC_Formato, 970, 30, false);
=======
            WriteLiteral("                <div class=\"carousel-item active\">\n                    <img class=\"d-block w-100\"");
            BeginWriteAttribute("src", " src=\"", 927, "\"", 1012, 4);
            WriteAttributeValue("", 933, "data:image/", 933, 11, true);
#nullable restore
#line 27 "C:\Users\congr\source\repos\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Hotel\SobreNosotros.cshtml"
WriteAttributeValue("", 944, ViewBag.Galeria[i].TC_Formato, 944, 30, false);
>>>>>>> Stashed changes

#line default
#line hidden
#nullable disable
<<<<<<< Updated upstream
            WriteAttributeValue("", 1000, ";base64,", 1000, 8, true);
#nullable restore
#line 27 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Hotel\SobreNosotros.cshtml"
WriteAttributeValue("", 1008, ViewBag.Galeria[i].TV_Archivo, 1008, 30, false);
=======
            WriteAttributeValue("", 974, ";base64,", 974, 8, true);
#nullable restore
#line 27 "C:\Users\congr\source\repos\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Hotel\SobreNosotros.cshtml"
WriteAttributeValue("", 982, ViewBag.Galeria[i].TV_Archivo, 982, 30, false);
>>>>>>> Stashed changes

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
<<<<<<< Updated upstream
            WriteLiteral("                <div class=\"carousel-item\">\r\n                    <img class=\"d-block w-100\"");
            BeginWriteAttribute("src", " src=\"", 1262, "\"", 1347, 4);
            WriteAttributeValue("", 1268, "data:image/", 1268, 11, true);
#nullable restore
#line 33 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Hotel\SobreNosotros.cshtml"
WriteAttributeValue("", 1279, ViewBag.Galeria[i].TC_Formato, 1279, 30, false);
=======
            WriteLiteral("                <div class=\"carousel-item\">\n                    <img class=\"d-block w-100\"");
            BeginWriteAttribute("src", " src=\"", 1230, "\"", 1315, 4);
            WriteAttributeValue("", 1236, "data:image/", 1236, 11, true);
#nullable restore
#line 33 "C:\Users\congr\source\repos\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Hotel\SobreNosotros.cshtml"
WriteAttributeValue("", 1247, ViewBag.Galeria[i].TC_Formato, 1247, 30, false);
>>>>>>> Stashed changes

#line default
#line hidden
#nullable disable
<<<<<<< Updated upstream
            WriteAttributeValue("", 1309, ";base64,", 1309, 8, true);
#nullable restore
#line 33 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Hotel\SobreNosotros.cshtml"
WriteAttributeValue("", 1317, ViewBag.Galeria[i].TV_Archivo, 1317, 30, false);
=======
            WriteAttributeValue("", 1277, ";base64,", 1277, 8, true);
#nullable restore
#line 33 "C:\Users\congr\source\repos\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\Hotel\SobreNosotros.cshtml"
WriteAttributeValue("", 1285, ViewBag.Galeria[i].TV_Archivo, 1285, 30, false);
>>>>>>> Stashed changes

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
<<<<<<< Updated upstream
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
</div>
=======
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
</div>
>>>>>>> Stashed changes
");
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
