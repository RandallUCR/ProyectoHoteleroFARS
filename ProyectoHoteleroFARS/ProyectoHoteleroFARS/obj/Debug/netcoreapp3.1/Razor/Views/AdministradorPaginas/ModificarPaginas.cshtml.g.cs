#pragma checksum "C:\Users\congr\source\repos\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministradorPaginas\ModificarPaginas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce6a379ec56b9330a9a4f217e396b83ecaec627b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdministradorPaginas_ModificarPaginas), @"mvc.1.0.view", @"/Views/AdministradorPaginas/ModificarPaginas.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce6a379ec56b9330a9a4f217e396b83ecaec627b", @"/Views/AdministradorPaginas/ModificarPaginas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"412ee32369deb8ae8f0872df830a3dc5e89d567d", @"/Views/_ViewImports.cshtml")]
    public class Views_AdministradorPaginas_ModificarPaginas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-bottom: 1em;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\congr\source\repos\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministradorPaginas\ModificarPaginas.cshtml"
   ViewData["Title"] = "Home";
    Layout = "_LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    form {
        width: 600px;
        background: #ccc;
        margin: 0 auto;
        padding: 20px;
        border: 1px solid black;
    }

    form ol {
        padding-left: 0;
    }

    form li, div > p {
        background: #eee;
        display: flex;
        justify-content: space-between;
        margin-bottom: 10px;
        list-style-type: none;
        border: 1px solid black;
    }

    form img {
        height: 64px;
        order: 1;
    }

    form p {
        line-height: 32px;
        padding-left: 10px;
    }

    form label, form button {
        background-color: #7F9CCB;
        padding: 5px 10px;
        border-radius: 5px;
        border: 1px ridge black;
        font-size: 0.8rem;
        height: auto;
    }

        form label:hover, form button:hover {
            background-color: #2D5BA3;
            color: white;
        }

        form label:active, form button:active {
            background-color: #0D3F8F;
            color: white;
        }
</style>


<div clas");
            WriteLiteral(@"s=""row shadow-lg p-3 mb-5 bg-transparent rounded"">
    <div class=""col-12"">
        <legend style=""font-weight: bold;  font-family:Felix Titling;"">Modificar páginas</legend>
        <span style=""font-family: Century Gothic; margin-top: 1em;"">Seleccione el nombre de una página para poder modificar la información</span>
    </div>
</div>

<div class=""accordion bg-transparent rounded"" id=""accordionModificarPaginas"">
    <!--Edición para la página home-->
    <div class=""card"">
        <div class=""card-header"" id=""cabeceraHome"">
            <h2 class=""mb-0"">
                <button class=""btn btn-block text-center"" type=""button"" data-toggle=""collapse"" data-target=""#collapseHome"" aria-expanded=""true"" aria-controls=""collapseHome"">
                    Home
                </button>
            </h2>
        </div>

        <div id=""collapseHome"" class=""collapse"" aria-labelledby=""cabeceraHome"" data-parent=""#accordionModificarPaginas"">
            <div class=""card-body"">
                Opciones para editar la página ");
            WriteLiteral(@"home
            </div>
        </div>
    </div>

    <!--Edición para la página sobre nosotros-->
    <div class=""card"">
        <div class=""card-header"" id=""cabeceraSobreNosotros"">
            <h2 class=""mb-0"">
                <button class=""btn btn-block text-center"" type=""button"" data-toggle=""collapse"" data-target=""#collapseSobreNosotros"" aria-expanded=""true"" aria-controls=""collapseSobreNosotros"">
                    Sobre Nosotros
                </button>
            </h2>
        </div>

        <div id=""collapseSobreNosotros"" class=""collapse"" aria-labelledby=""cabeceraSobreNosotros"" data-parent=""#accordionModificarPaginas"">
            <div class=""card-body"">
                <span style=""font-family: Century Gothic; margin-top: 1em;"">Texto de la página Sobre Nosotros</span>
                <!--Cargar el texto que está en la base de datos-->
                <textarea class=""form-control"" style=""font-family: Century Gothic; margin-top: 0.5em"" id=""taSobreNosotros"" name=""taSobreNosotros"" rows=""4"" cols=""50");
            WriteLiteral("\">");
#nullable restore
#line 97 "C:\Users\congr\source\repos\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministradorPaginas\ModificarPaginas.cshtml"
                                                                                                                                                                Write(ViewBag.SobreNosotros);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</textarea>
                <div class=""col-12 col-md-4 align-self-end"" style=""margin-top: 1em;"">
                    <button class=""btn btn-info"" type=""button"" onclick=""aceptarModificarSobreNosotros()"">Aceptar</button>
                    <button class=""btn btn-danger"" type=""button"">Cancelar</button>
                </div>
                <br /> <span id=""respuestaSN""></span>
            </div>
        </div>
    </div>
    <!--Edición para la descripción de la página-->
    <div class=""card"">
        <div class=""card-header"" id=""cabeceraHomeDescripcion"">
            <h2 class=""mb-0"">
                <button class=""btn btn-block text-center"" type=""button"" data-toggle=""collapse"" data-target=""#collapseDescripcion"" aria-expanded=""true"" aria-controls=""collapseDescripcion"">
                    Descripcion
                </button>
            </h2>
        </div>

        <div id=""collapseDescripcion"" class=""collapse"" aria-labelledby=""cabeceraDescripcion"" data-parent=""#accordionModificarPaginas"">
            <div");
            WriteLiteral(@" class=""card-body"">
                <span style=""font-family: Century Gothic; margin-top: 1em;"">Texto de la página Descripcion</span>
                <!--Cargar el texto que está en la base de datos-->
                <textarea class=""form-control"" style=""font-family: Century Gothic; margin-top: 0.5em"" id=""taDescripcion"" name=""taDescripcion"" rows=""4"" cols=""50"">");
#nullable restore
#line 120 "C:\Users\congr\source\repos\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministradorPaginas\ModificarPaginas.cshtml"
                                                                                                                                                            Write(ViewBag.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</textarea>
                <div class=""col-12 col-md-4 align-self-end"" style=""margin-top: 1em;"">
                    <button class=""btn btn-info"" type=""button"" onclick=""aceptarModificarDescripcion()"">Aceptar</button>
                    <button class=""btn btn-danger"" type=""button"">Cancelar</button>
                </div>
                <br /> <span id=""respuestaSN""></span>
            </div>
        </div>
    </div>
    <!--Edición para la descripción de la página-->
    <div class=""card"">
        <div class=""card-header"" id=""cabeceracComoLlegar"">
            <h2 class=""mb-0"">
                <button class=""btn btn-block text-center"" type=""button"" data-toggle=""collapse"" data-target=""#collapseComoLlegar"" aria-expanded=""true"" aria-controls=""collapseComoLlegar"">
                    Como LLegar
                </button>
            </h2>
        </div>

        <div id=""collapseComoLlegar"" class=""collapse"" aria-labelledby=""cabeceraComoLlegar"" data-parent=""#accordionModificarPaginas"">
            <div class=""ca");
            WriteLiteral(@"rd-body"">
                <span style=""font-family: Century Gothic; margin-top: 1em;"">Texto del URL del Mapa</span>
                <!--Cargar el texto que está en la base de datos-->
                <textarea class=""form-control"" style=""font-family: Century Gothic; margin-top: 0.5em"" id=""taMaps"" name=""taMaps"" rows=""4"" cols=""50"">");
#nullable restore
#line 143 "C:\Users\congr\source\repos\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministradorPaginas\ModificarPaginas.cshtml"
                                                                                                                                              Write(ViewBag.Hotel.TC_Maps);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</textarea>
                <span style=""font-family: Century Gothic; margin-top: 1em;"">Texto de la ubicacion</span>
                <!--Cargar el texto que está en la base de datos-->
                <textarea class=""form-control"" style=""font-family: Century Gothic; margin-top: 0.5em"" id=""taUbicacion"" name=""taUbicacion"" rows=""4"" cols=""50"">");
#nullable restore
#line 146 "C:\Users\congr\source\repos\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministradorPaginas\ModificarPaginas.cshtml"
                                                                                                                                                        Write(ViewBag.Hotel.TC_Ubicacion);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</textarea>

                <div class=""col-12 col-md-4 align-self-end"" style=""margin-top: 1em;"">
                    <button class=""btn btn-info"" type=""button"" onclick=""aceptarModificarComoLlegar()"">Aceptar</button>
                    <button class=""btn btn-danger"" type=""button"">Cancelar</button>
                </div>
                <br /> <span id=""respuestaSN""></span>
            </div>
        </div>
    </div>

    <!--Edición para la página sobre nosotros (Galería)-->
    <div class=""card"">
        <div class=""card-header"" id=""cabeceraGaleria"">
            <h2 class=""mb-0"">
                <button class=""btn btn-block text-center"" type=""button"" data-toggle=""collapse"" data-target=""#collapseGaleria"" aria-expanded=""true"" aria-controls=""collapseGaleria"">
                    Galería
                </button>
            </h2>
        </div>

        <div id=""collapseGaleria"" class=""collapse"" aria-labelledby=""cabeceraGaleria"" data-parent=""#accordionModificarPaginas"">
            <div class=""card-body"">
  ");
            WriteLiteral("              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce6a379ec56b9330a9a4f217e396b83ecaec627b13527", async() => {
                WriteLiteral(@"
                    <div>
                        <label for=""image_uploads"">Seleccione una imagen para guardarla en la galería</label>
                        <input class=""formGalery"" type=""file"" id=""image_uploads"" name=""image_uploads"" accept=""image/*"">  <!-- accept="".jpg, .jpeg, .png"" -->
                    </div>
                    <div class=""preview"">
                        <p>No se ha seleccionado ningún archivo</p>
                    </div>
                    <div>
                        <button type=""button"" onclick=""guardarImgGaleria()"">Guardar</button>
                        <br />
                        <span id=""respuestaGL""></span>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                <span style=""font-family: Century Gothic; margin-top: 1em;"">Imágenes en Galería</span>
                <table class=""table table-striped"">
                    <thead>
                        <tr>
                            <th scope=""col"">ID</th>
                            <th scope=""col"">Imagen</th>
                            <th scope=""col"">Acción</th>
                        </tr>
                    </thead>
                    <tbody id=""contenidoTablaGaleria"">
");
#nullable restore
#line 194 "C:\Users\congr\source\repos\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministradorPaginas\ModificarPaginas.cshtml"
                         for (int i = 0; i < ViewBag.Galeria.Count; i++) { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <th scope=\"row\">");
#nullable restore
#line 196 "C:\Users\congr\source\repos\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministradorPaginas\ModificarPaginas.cshtml"
                                           Write(ViewBag.Galeria[i].TN_Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                <td>\n                                    <img height=\"200\" width=\"250\" style=\"max-height:inherit; max-width:inherit\"");
            BeginWriteAttribute("src", " src=\"", 8924, "\"", 9009, 4);
            WriteAttributeValue("", 8930, "data:image/", 8930, 11, true);
#nullable restore
#line 198 "C:\Users\congr\source\repos\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministradorPaginas\ModificarPaginas.cshtml"
WriteAttributeValue("", 8941, ViewBag.Galeria[i].TC_Formato, 8941, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8971, ";base64,", 8971, 8, true);
#nullable restore
#line 198 "C:\Users\congr\source\repos\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministradorPaginas\ModificarPaginas.cshtml"
WriteAttributeValue("", 8979, ViewBag.Galeria[i].TV_Archivo, 8979, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\n                                </td>\n                                <td>\n                                    <button class=\"btn btn-danger\"");
            BeginWriteAttribute("id", " id=\"", 9154, "\"", 9184, 1);
#nullable restore
#line 201 "C:\Users\congr\source\repos\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministradorPaginas\ModificarPaginas.cshtml"
WriteAttributeValue("", 9159, ViewBag.Galeria[i].TN_Id, 9159, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"eliminarImgGaleria(this)\">Eliminar</button>\n                                </td>\n                            </tr>\n");
#nullable restore
#line 204 "C:\Users\congr\source\repos\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministradorPaginas\ModificarPaginas.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>
                <!--
                <div class=""col-12 col-md-4 align-self-end"" style=""margin-top: 1em;"">
                    <button class=""btn btn-info"" type=""button"">Aceptar</button>
                    <button class=""btn btn-danger"" type=""button"">Cancelar</button>
                </div>
                -->
            </div>
        </div>
    </div>

    <!--Edición para la página Facilidades-->
    <div class=""card"">
        <div class=""card-header"" id=""cabeceraFacilidades"">
            <h2 class=""mb-0"">
                <button class=""btn btn-block text-center"" type=""button"" data-toggle=""collapse"" data-target=""#collapseFacilidades"" aria-expanded=""true"" aria-controls=""collapseFacilidades"">
                    Facilidades
                </button>
            </h2>
        </div>

        <div id=""collapseFacilidades"" class=""collapse"" aria-labelledby=""cabeceraFacilidades"" data-parent=""#accordionModificarPaginas"">
            <div class=""card-body"">
  ");
            WriteLiteral("              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce6a379ec56b9330a9a4f217e396b83ecaec627b19977", async() => {
                WriteLiteral(@"
                    <div style=""margin-bottom: 1em;"">
                        <span>Descripción</span><br />
                        <textarea class=""form-control"" style=""font-family: Century Gothic; margin-top: 0.5em"" id=""ta_facilidad"" name=""ta_facilidad"" rows=""4"" cols=""40""></textarea>
                    </div>
                    <div>
                        <label for=""image_facilidad"">Seleccione una imagen para guardarla en la galería</label>
                        <input class=""formFacilidad"" type=""file"" id=""image_facilidad"" name=""image_facilidad"" accept=""image/*"">  <!-- accept="".jpg, .jpeg, .png"" -->
                    </div>
                    <div class=""previewFacilidad"">
                        <p>No se ha seleccionado ningún archivo</p>
                    </div>
                    <div>
                        <button type=""button"" onclick=""agregarFacilidad()"">Guardar</button>
                        <br />
                        <span id=""respuestaNFL""></span>
                    </div>
 ");
                WriteLiteral("               ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <span style=""font-family: Century Gothic; margin-top: 1em;"">Imágenes y texto en Facilidades</span>
                <table class=""table table-striped"">
                    <thead>
                        <tr>
                            <th scope=""col"">ID</th>
                            <th scope=""col"">Imagen</th>
                            <th scope=""col"">Edición</th>
                            <th scope=""col"">Acción</th>
                        </tr>
                    </thead>
                    <tbody id=""contenidoTablaFacilidades"">
");
#nullable restore
#line 258 "C:\Users\congr\source\repos\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministradorPaginas\ModificarPaginas.cshtml"
                         for (int i = 0; i < ViewBag.Facilidad.Count; i++) { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <th scope=\"row\">");
#nullable restore
#line 260 "C:\Users\congr\source\repos\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministradorPaginas\ModificarPaginas.cshtml"
                                           Write(ViewBag.Facilidad[i].TN_Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                <td>\n                                    <img height=\"200\" width=\"250\" style=\"max-height:inherit; max-width:inherit\"");
            BeginWriteAttribute("src", " src=\"", 12331, "\"", 12436, 4);
            WriteAttributeValue("", 12337, "data:image/", 12337, 11, true);
#nullable restore
#line 262 "C:\Users\congr\source\repos\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministradorPaginas\ModificarPaginas.cshtml"
WriteAttributeValue("", 12348, ViewBag.Facilidad[i].galeria.TC_Formato, 12348, 40, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 12388, ";base64,", 12388, 8, true);
#nullable restore
#line 262 "C:\Users\congr\source\repos\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministradorPaginas\ModificarPaginas.cshtml"
WriteAttributeValue("", 12396, ViewBag.Facilidad[i].galeria.TV_Archivo, 12396, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\n                                </td>\n                                <td>\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce6a379ec56b9330a9a4f217e396b83ecaec627b24843", async() => {
                WriteLiteral("\n                                        <div>\n                                            <span>Descripción</span><br />\n                                            <textarea class=\"form-control\" style=\"font-family: Century Gothic; margin-top: 0.5em\"");
                BeginWriteAttribute("id", " id=\"", 12808, "\"", 12847, 2);
                WriteAttributeValue("", 12813, "ta_fac_", 12813, 7, true);
#nullable restore
#line 268 "C:\Users\congr\source\repos\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministradorPaginas\ModificarPaginas.cshtml"
WriteAttributeValue("", 12820, ViewBag.Facilidad[i].TN_Id, 12820, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 12848, "\"", 12889, 2);
                WriteAttributeValue("", 12855, "ta_fac_", 12855, 7, true);
#nullable restore
#line 268 "C:\Users\congr\source\repos\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministradorPaginas\ModificarPaginas.cshtml"
WriteAttributeValue("", 12862, ViewBag.Facilidad[i].TN_Id, 12862, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rows=\"4\" cols=\"40\">");
#nullable restore
#line 268 "C:\Users\congr\source\repos\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministradorPaginas\ModificarPaginas.cshtml"
                                                                                                                                                                                                                                  Write(ViewBag.Facilidad[i].TC_Descripcion);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\n                                        </div>\n                                        <div>\n                                            <button type=\"button\"");
                BeginWriteAttribute("id", " id=\"", 13116, "\"", 13148, 1);
#nullable restore
#line 271 "C:\Users\congr\source\repos\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministradorPaginas\ModificarPaginas.cshtml"
WriteAttributeValue("", 13121, ViewBag.Facilidad[i].TN_Id, 13121, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" onclick=\"editarFacilidad(this)\">Guardar</button>\n                                            <br />\n                                            <span");
                BeginWriteAttribute("id", " id=\"", 13299, "\"", 13343, 2);
                WriteAttributeValue("", 13304, "respuestaFL_", 13304, 12, true);
#nullable restore
#line 273 "C:\Users\congr\source\repos\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministradorPaginas\ModificarPaginas.cshtml"
WriteAttributeValue("", 13316, ViewBag.Facilidad[i].TN_Id, 13316, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></span>\n                                        </div>\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                </td>\n                                <td>\n                                    <button class=\"btn btn-danger\"");
            BeginWriteAttribute("id", " id=\"", 13585, "\"", 13617, 1);
#nullable restore
#line 278 "C:\Users\congr\source\repos\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministradorPaginas\ModificarPaginas.cshtml"
WriteAttributeValue("", 13590, ViewBag.Facilidad[i].TN_Id, 13590, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"eliminarFacilidad(this)\">Eliminar</button>\n                                </td>\n                            </tr>\n");
#nullable restore
#line 281 "C:\Users\congr\source\repos\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministradorPaginas\ModificarPaginas.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n                </table>\n            </div>\n        </div>\n    </div>\n\n   \n");
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
