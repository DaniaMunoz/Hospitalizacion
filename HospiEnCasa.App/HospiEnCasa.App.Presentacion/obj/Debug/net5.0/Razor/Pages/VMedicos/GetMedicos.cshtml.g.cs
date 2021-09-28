#pragma checksum "C:\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.Presentacion\Pages\VMedicos\GetMedicos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "302ed8d966893183c328db43624e00a24b6f78bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HospiEnCasa.App.Presentacion.Pages.VMedicos.Pages_VMedicos_GetMedicos), @"mvc.1.0.razor-page", @"/Pages/VMedicos/GetMedicos.cshtml")]
namespace HospiEnCasa.App.Presentacion.Pages.VMedicos
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
#line 1 "C:\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.Presentacion\Pages\_ViewImports.cshtml"
using HospiEnCasa.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"302ed8d966893183c328db43624e00a24b6f78bd", @"/Pages/VMedicos/GetMedicos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"980668fccca30b420f458647ca7657270f532196", @"/Pages/_ViewImports.cshtml")]
    public class Pages_VMedicos_GetMedicos : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./GetMedico", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:#F0F8FF;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "302ed8d966893183c328db43624e00a24b6f78bd3830", async() => {
                WriteLiteral(@"

<table class=""table""> 
  <div class=""p-3 mb-2 bg-info text-dark""><h1>Lista de médicos</h1></div>
  <thead>

    <tr>
      <th scope=""col"">Id</th>
      <th scope=""col"">Nombre</th>
      <th scope=""col"">Apellidos</th>
      <th scope=""col"">Número telefono</th>
      <th scope=""col"">Especialidad</th>
      <th scope=""col"">Detalles</th> 
    </tr>

  </thead>

  <tbody>
");
#nullable restore
#line 24 "C:\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.Presentacion\Pages\VMedicos\GetMedicos.cshtml"
   foreach (var medico in Model.ListaMedicos)
  {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <tr>\r\n      \r\n      <td>");
#nullable restore
#line 28 "C:\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.Presentacion\Pages\VMedicos\GetMedicos.cshtml"
     Write(medico.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 29 "C:\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.Presentacion\Pages\VMedicos\GetMedicos.cshtml"
     Write(medico.Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 30 "C:\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.Presentacion\Pages\VMedicos\GetMedicos.cshtml"
     Write(medico.Apellidos);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 31 "C:\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.Presentacion\Pages\VMedicos\GetMedicos.cshtml"
     Write(medico.NumeroTelefono);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>  \r\n      <td>");
#nullable restore
#line 32 "C:\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.Presentacion\Pages\VMedicos\GetMedicos.cshtml"
     Write(medico.Especialidad);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 33 "C:\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.Presentacion\Pages\VMedicos\GetMedicos.cshtml"
     Write(medico.Codigo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 34 "C:\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.Presentacion\Pages\VMedicos\GetMedicos.cshtml"
     Write(medico.RegistroRethus);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n      <td> ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "302ed8d966893183c328db43624e00a24b6f78bd6633", async() => {
                    WriteLiteral("Details");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.Presentacion\Pages\VMedicos\GetMedicos.cshtml"
                                         WriteLiteral(medico.Id);

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
                WriteLiteral("</td> \r\n    </tr>\r\n");
#nullable restore
#line 37 "C:\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.Presentacion\Pages\VMedicos\GetMedicos.cshtml"

  }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n  </tbody>\r\n\r\n    \r\n\r\n</table>\r\n<img alt=\"doctor\" src=\"https://d2lcsjo4hzzyvz.cloudfront.net/blog/wp-content/uploads/2020/10/07114553/me%CC%81dicos-influencers-en-Instagram.jpg\" />\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HospiEnCasa.App.Presentacion.Pages.GetMedicosModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiEnCasa.App.Presentacion.Pages.GetMedicosModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiEnCasa.App.Presentacion.Pages.GetMedicosModel>)PageContext?.ViewData;
        public HospiEnCasa.App.Presentacion.Pages.GetMedicosModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
