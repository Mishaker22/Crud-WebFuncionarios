#pragma checksum "C:\Users\miche\Downloads\Funcionarios\FuncEnCasa.App\CapaWeb.App\SitioWeb\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae5f34b8b67250c412bce83ae173d1fad36cc456"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SitioWeb.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace SitioWeb.Pages
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
#line 1 "C:\Users\miche\Downloads\Funcionarios\FuncEnCasa.App\CapaWeb.App\SitioWeb\Pages\_ViewImports.cshtml"
using SitioWeb;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae5f34b8b67250c412bce83ae173d1fad36cc456", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5496eb32caf9dae367318516bb1905814ee68b1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Cedula", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Cedula de extranjeria", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Tarjeta de identidad", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", ".\\Funcionario\\Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", ".\\Funcionario\\Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", ".\\Funcionario\\Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\miche\Downloads\Funcionarios\FuncEnCasa.App\CapaWeb.App\SitioWeb\Pages\Index.cshtml"
  
    ViewData["Title"] = "Programming Life";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""caja"">
    <div class=""labeles"">
        <b><i><label for=""lblFuncionario"">Datos Funcionario</label></i></b>
    </div>
    ><div class=""cTextos"">
        <center>
            <p>
                <font size=""5px"" color=#FFFFFF face=""Tw Cen MT"">
                    <i>Consulte Si se encuentra registrado como funcionario </i>
                </font>
            </p>
        </center>
        <br />
        <p class=""pTexto"">
            <font size=""4px"" color=#FFFFFF face=""Tw Cen MT"">
                <i>Seleccione Tipo de documento: </i>
            </font>
        </p>
        <select name=""tipoDocumento"" id=""idTipoDocumento"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae5f34b8b67250c412bce83ae173d1fad36cc4565807", async() => {
                WriteLiteral("Cedula");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae5f34b8b67250c412bce83ae173d1fad36cc4566978", async() => {
                WriteLiteral("Cedula Extranjeria");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae5f34b8b67250c412bce83ae173d1fad36cc4568161", async() => {
                WriteLiteral("Tarjeta de identidad");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </select>
        <br />
        <p class=""pTexto"">
            <font size=""4px"" color=#FFFFFF face=""Tw Cen MT"">
                <i>Numero de Documento: </i>
            </font>
        </p>
        <input type=""text"" id=""idDocumento"" placeholder=""Digite el numero"" name=""documento"" />
        <br />
        <button class=""btnConsultar"" id=""btnConsultar"">Consultar</button>
        <button class=""btnAgregar"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae5f34b8b67250c412bce83ae173d1fad36cc4569781", async() => {
                WriteLiteral("Agregar Funcionario");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</button>
    </div>
</div>
<div class=""contenedorTabla"">
    <h2>
        Tabla De Funcionarios
    </h2>
    <hr>
    <table>
        <thead>
            <tr>
                <th>Documento</th>
                <th>Nombre</th>
                <th>Apellido</th>
                <th>Genero</th>
                <th>Fecha Nacimiento</th>
                <th>RH</th>
                <th>Sucursal</th>
                <th>Correo</th>
                <th>Telefono</th>
                <th>Ciudad</th>
                <th>Direccion</th>
                <th>Acciones </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 66 "C:\Users\miche\Downloads\Funcionarios\FuncEnCasa.App\CapaWeb.App\SitioWeb\Pages\Index.cshtml"
             foreach (var funcionario in Model.funcionarios)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td style=\"font-size:12px;\">");
#nullable restore
#line 69 "C:\Users\miche\Downloads\Funcionarios\FuncEnCasa.App\CapaWeb.App\SitioWeb\Pages\Index.cshtml"
                                           Write(funcionario.usuarioId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 70 "C:\Users\miche\Downloads\Funcionarios\FuncEnCasa.App\CapaWeb.App\SitioWeb\Pages\Index.cshtml"
                   Write(funcionario.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 71 "C:\Users\miche\Downloads\Funcionarios\FuncEnCasa.App\CapaWeb.App\SitioWeb\Pages\Index.cshtml"
                   Write(funcionario.apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 72 "C:\Users\miche\Downloads\Funcionarios\FuncEnCasa.App\CapaWeb.App\SitioWeb\Pages\Index.cshtml"
                   Write(funcionario.genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 73 "C:\Users\miche\Downloads\Funcionarios\FuncEnCasa.App\CapaWeb.App\SitioWeb\Pages\Index.cshtml"
                   Write(funcionario.fechaNacimiento.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 74 "C:\Users\miche\Downloads\Funcionarios\FuncEnCasa.App\CapaWeb.App\SitioWeb\Pages\Index.cshtml"
                   Write(funcionario.tipoSanguineo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 75 "C:\Users\miche\Downloads\Funcionarios\FuncEnCasa.App\CapaWeb.App\SitioWeb\Pages\Index.cshtml"
                   Write(funcionario.sucursal.nombreSucursal);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 76 "C:\Users\miche\Downloads\Funcionarios\FuncEnCasa.App\CapaWeb.App\SitioWeb\Pages\Index.cshtml"
                     if(funcionario.correo==null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td style=\"color:red;\">Sin correo</td>\r\n");
#nullable restore
#line 79 "C:\Users\miche\Downloads\Funcionarios\FuncEnCasa.App\CapaWeb.App\SitioWeb\Pages\Index.cshtml"
                    }else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td style=\"font-size:10px;\">");
#nullable restore
#line 81 "C:\Users\miche\Downloads\Funcionarios\FuncEnCasa.App\CapaWeb.App\SitioWeb\Pages\Index.cshtml"
                                               Write(funcionario.correo.correo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />  -");
#nullable restore
#line 81 "C:\Users\miche\Downloads\Funcionarios\FuncEnCasa.App\CapaWeb.App\SitioWeb\Pages\Index.cshtml"
                                                                                   Write(funcionario.idTipoContactoCorreo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>   \r\n");
#nullable restore
#line 82 "C:\Users\miche\Downloads\Funcionarios\FuncEnCasa.App\CapaWeb.App\SitioWeb\Pages\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\miche\Downloads\Funcionarios\FuncEnCasa.App\CapaWeb.App\SitioWeb\Pages\Index.cshtml"
                     if(funcionario.telefono==null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td td style=\"color:red;\">Sin Telefono</td>\r\n");
#nullable restore
#line 86 "C:\Users\miche\Downloads\Funcionarios\FuncEnCasa.App\CapaWeb.App\SitioWeb\Pages\Index.cshtml"
                    }else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td style=\"font-size:10px;\">");
#nullable restore
#line 88 "C:\Users\miche\Downloads\Funcionarios\FuncEnCasa.App\CapaWeb.App\SitioWeb\Pages\Index.cshtml"
                                               Write(funcionario.telefono.numeroTel);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br /> - ");
#nullable restore
#line 88 "C:\Users\miche\Downloads\Funcionarios\FuncEnCasa.App\CapaWeb.App\SitioWeb\Pages\Index.cshtml"
                                                                                        Write(funcionario.idTipoContactoTelefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                      \r\n");
#nullable restore
#line 89 "C:\Users\miche\Downloads\Funcionarios\FuncEnCasa.App\CapaWeb.App\SitioWeb\Pages\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 90 "C:\Users\miche\Downloads\Funcionarios\FuncEnCasa.App\CapaWeb.App\SitioWeb\Pages\Index.cshtml"
                   Write(funcionario.ciudad.nombreCiudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 91 "C:\Users\miche\Downloads\Funcionarios\FuncEnCasa.App\CapaWeb.App\SitioWeb\Pages\Index.cshtml"
                   Write(funcionario.direccion.direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <table>\r\n                            <tr>\r\n                                <td>\r\n                                    <button class=\"btnMod\" id=\"btnModificar\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae5f34b8b67250c412bce83ae173d1fad36cc45617871", async() => {
                WriteLiteral("Modificar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 96 "C:\Users\miche\Downloads\Funcionarios\FuncEnCasa.App\CapaWeb.App\SitioWeb\Pages\Index.cshtml"
                                                                                                                WriteLiteral(funcionario._Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</button>\r\n                                </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>\r\n                                    <button class=\"btnReset\" id=\"btnEliminar\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae5f34b8b67250c412bce83ae173d1fad36cc45620361", async() => {
                WriteLiteral("Eliminar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 101 "C:\Users\miche\Downloads\Funcionarios\FuncEnCasa.App\CapaWeb.App\SitioWeb\Pages\Index.cshtml"
                                                                                                                   WriteLiteral(funcionario._Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</button>\r\n                                </td>\r\n                            </tr>\r\n                        </table>\r\n                    </td>\r\n\r\n\r\n                </tr>\r\n");
#nullable restore
#line 109 "C:\Users\miche\Downloads\Funcionarios\FuncEnCasa.App\CapaWeb.App\SitioWeb\Pages\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
