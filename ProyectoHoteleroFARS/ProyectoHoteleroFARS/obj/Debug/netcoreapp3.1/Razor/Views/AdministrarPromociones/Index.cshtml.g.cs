#pragma checksum "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministrarPromociones\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c78bb6e3d9baf7681f1d889975b0b0fd79889a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdministrarPromociones_Index), @"mvc.1.0.view", @"/Views/AdministrarPromociones/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c78bb6e3d9baf7681f1d889975b0b0fd79889a1", @"/Views/AdministrarPromociones/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88a2574cf27275204bf97baad6b0260729e88e63", @"/Views/_ViewImports.cshtml")]
    public class Views_AdministrarPromociones_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("promInsForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-12 col-sm-6"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Insertar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdministrarPromociones", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("promModForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministrarPromociones\Index.cshtml"
   ViewData["Title"] = "Administrar Promociones";
    Layout = "_LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row shadow-lg p-3 mb-5 bg-transparent rounded"">
    <div class=""col-12"">
        <legend style=""font-weight: bold;  font-family:Felix Titling;"">Administrar Promociones</legend>
    </div>
</div>

<div class=""row shadow-lg p-3 mb-5 bg-transparent rounded"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c78bb6e3d9baf7681f1d889975b0b0fd79889a16402", async() => {
                WriteLiteral(@"
        <label for=""rangofechas"" class=""font-weight-bold"">Rango de Fechas</label>
        <input type=""text"" name=""rangofechas"" placeholder=""Rango de Fechas"" class=""form-control"" required />

        <label for=""porcentaje"" class=""font-weight-bold"">Porcentaje de Aumento</label>
        <input type=""number"" name=""porcentaje"" placeholder=""Porcentaje"" class=""form-control"" min=""0"" max=""100"" required />

        <label for=""tipo"" class=""font-weight-bold"">Tipo Habitacion</label>
        <select id=""tipo"" name=""tipo"" class=""form-control"">
");
#nullable restore
#line 21 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministrarPromociones\Index.cshtml"
             foreach (Entidades.TipoHabitacion t in ViewBag.Tipos)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c78bb6e3d9baf7681f1d889975b0b0fd79889a17574", async() => {
                    WriteLiteral("\r\n                    ");
#nullable restore
#line 24 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministrarPromociones\Index.cshtml"
               Write(t.TC_Nombre);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministrarPromociones\Index.cshtml"
                   WriteLiteral(t.TN_Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 26 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministrarPromociones\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>\r\n        <input type=\"submit\" value=\"Registrar\" class=\"btn btn-success mt-1\" />\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <div class=\"col-12 col-sm-6\">\r\n        <h5>Temporadas</h5>\r\n        <table class=\"table table-striped table-dark\" id=\"example2\">\r\n            <thead");
            BeginWriteAttribute("class", " class=\"", 1488, "\"", 1496, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <tr>
                    <th>Fecha Inicio</th>
                    <th>Fecha Final</th>
                    <th>% Descuento</th>
                    <th>Tipo Habitacion</th>
                    <th>Ver</th>
                    <th>Eliminar</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 44 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministrarPromociones\Index.cshtml"
                 foreach (Entidades.TipoHabitacion t in ViewBag.List)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 47 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministrarPromociones\Index.cshtml"
                       Write(t.promocion.TF_Inicio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 48 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministrarPromociones\Index.cshtml"
                       Write(t.promocion.TF_Final);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 49 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministrarPromociones\Index.cshtml"
                       Write(t.promocion.TN_Porcentaje);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 50 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministrarPromociones\Index.cshtml"
                       Write(t.TC_Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <button class=\"btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2256, "\"", 2388, 13);
            WriteAttributeValue("", 2266, "modalEditProm(", 2266, 14, true);
#nullable restore
#line 52 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministrarPromociones\Index.cshtml"
WriteAttributeValue("", 2280, t.promocion.TN_Id, 2280, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2298, ",", 2298, 1, true);
            WriteAttributeValue(" ", 2299, "\'", 2300, 2, true);
#nullable restore
#line 52 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministrarPromociones\Index.cshtml"
WriteAttributeValue("", 2301, t.promocion.TF_Inicio, 2301, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2323, "\',", 2323, 2, true);
            WriteAttributeValue(" ", 2325, "\'", 2326, 2, true);
#nullable restore
#line 52 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministrarPromociones\Index.cshtml"
WriteAttributeValue("", 2327, t.promocion.TF_Final, 2327, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2348, "\',", 2348, 2, true);
#nullable restore
#line 52 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministrarPromociones\Index.cshtml"
WriteAttributeValue(" ", 2350, t.promocion.TN_Porcentaje, 2351, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2377, ",", 2377, 1, true);
#nullable restore
#line 52 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministrarPromociones\Index.cshtml"
WriteAttributeValue(" ", 2378, t.TN_Id, 2379, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2387, ")", 2387, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                Ver\r\n                            </button>\r\n                        </td>\r\n                        <td><button class=\"btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2553, "\"", 2596, 3);
            WriteAttributeValue("", 2563, "EliminarPromo(", 2563, 14, true);
#nullable restore
#line 56 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministrarPromociones\Index.cshtml"
WriteAttributeValue("", 2577, t.promocion.TN_Id, 2577, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2595, ")", 2595, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Eliminar</button></td>\r\n                    </tr>\r\n");
#nullable restore
#line 58 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministrarPromociones\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>

<!--Modal para editar-->
<div class=""modal"" tabindex=""-1"" id=""modalEditProm"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5>Editar Temporada</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <span style=""color:red"" id=""span""></span>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c78bb6e3d9baf7681f1d889975b0b0fd79889a117479", async() => {
                WriteLiteral(@"
                <div class=""modal-body"">
                    <input type=""hidden"" id=""idProm"" name=""idProm"" />

                    <label for=""rangofechas"" class=""font-weight-bold"">Rango de Fechas de la Temporada:</label>
                    <input class=""form-control"" type=""text"" id=""rangofechase"" name=""rangofechas"" placeholder=""Rango de Fechas"" required />

                    <label for=""porcentaje"" class=""font-weight-bold"">Porcentaje de Descuento</label>
                    <input type=""number"" placeholder=""Porcentaje"" id=""porcentajee"" name=""porcentaje"" class=""form-control"" required />

                    <label for=""tipo"" class=""font-weight-bold"">Tipo Habitacion</label>
                    <select id=""tipoe"" name=""tipo"" class=""form-control"">
");
#nullable restore
#line 87 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministrarPromociones\Index.cshtml"
                         foreach (Entidades.TipoHabitacion t in ViewBag.Tipos)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c78bb6e3d9baf7681f1d889975b0b0fd79889a118920", async() => {
                    WriteLiteral("\r\n                                ");
#nullable restore
#line 90 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministrarPromociones\Index.cshtml"
                           Write(t.TC_Nombre);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 89 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministrarPromociones\Index.cshtml"
                               WriteLiteral(t.TN_Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 92 "D:\UCR\Ing\ProyectoHoteleroFARS\ProyectoHoteleroFARS\ProyectoHoteleroFARS\Views\AdministrarPromociones\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </select>\r\n\r\n                </div>\r\n                <div class=\"modal-footer\">\r\n                    <input type=\"submit\" class=\"btn btn-primary\" value=\"Editar\" />\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
