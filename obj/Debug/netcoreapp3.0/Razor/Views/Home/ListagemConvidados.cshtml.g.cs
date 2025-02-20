#pragma checksum "D:\Projetos\Layout\UC05\Presenca_Evento_Mvc\Views\Home\ListagemConvidados.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e23d4ff6e65aab9131d7637d718559c1abb2d3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListagemConvidados), @"mvc.1.0.view", @"/Views/Home/ListagemConvidados.cshtml")]
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
#line 1 "D:\Projetos\Layout\UC05\Presenca_Evento_Mvc\Views\_ViewImports.cshtml"
using Presenca_Evento_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projetos\Layout\UC05\Presenca_Evento_Mvc\Views\_ViewImports.cshtml"
using Presenca_Evento_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e23d4ff6e65aab9131d7637d718559c1abb2d3f", @"/Views/Home/ListagemConvidados.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b198f58632f1555e15f92d55210dcde76587959e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListagemConvidados : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Convidado>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Projetos\Layout\UC05\Presenca_Evento_Mvc\Views\Home\ListagemConvidados.cshtml"
  
    ViewData["Title"] = "Lista ";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h2> Lista dos Convidados Cadastrados </h2>
<table>
   <thead>
       <tr>
           <th>Nome &nbsp;&nbsp;&nbsp;&nbsp; |  &nbsp;&nbsp;&nbsp;&nbsp;</th>
           <th>Idade &nbsp;&nbsp;&nbsp;&nbsp; |  &nbsp;&nbsp;&nbsp;&nbsp;</th>
           <th>Telefone &nbsp;&nbsp;&nbsp;&nbsp; |  &nbsp;&nbsp;&nbsp;&nbsp;</th>
           <th>Estará Na Festa</th>
       </tr>
   </thead>
   <tbody>
");
#nullable restore
#line 16 "D:\Projetos\Layout\UC05\Presenca_Evento_Mvc\Views\Home\ListagemConvidados.cshtml"
        foreach(Convidado c in Model)
       {

#line default
#line hidden
#nullable disable
            WriteLiteral("       <tr>\r\n            <td>");
#nullable restore
#line 19 "D:\Projetos\Layout\UC05\Presenca_Evento_Mvc\Views\Home\ListagemConvidados.cshtml"
           Write(c.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp;&nbsp;&nbsp;&nbsp;</td><br>\r\n            <td>");
#nullable restore
#line 20 "D:\Projetos\Layout\UC05\Presenca_Evento_Mvc\Views\Home\ListagemConvidados.cshtml"
           Write(c.Idade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp;&nbsp;&nbsp;&nbsp;</td><br>\r\n            <td>");
#nullable restore
#line 21 "D:\Projetos\Layout\UC05\Presenca_Evento_Mvc\Views\Home\ListagemConvidados.cshtml"
           Write(c.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp;&nbsp;&nbsp;&nbsp;</td><br>\r\n            <td>");
#nullable restore
#line 22 "D:\Projetos\Layout\UC05\Presenca_Evento_Mvc\Views\Home\ListagemConvidados.cshtml"
           Write(c.ConfirmaPresenca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><br>\r\n       </tr>\r\n");
#nullable restore
#line 24 "D:\Projetos\Layout\UC05\Presenca_Evento_Mvc\Views\Home\ListagemConvidados.cshtml"
       }

#line default
#line hidden
#nullable disable
            WriteLiteral("   </tbody>\r\n</table>       \r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e23d4ff6e65aab9131d7637d718559c1abb2d3f5617", async() => {
                WriteLiteral("Cadastrar Novo");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Convidado>> Html { get; private set; }
    }
}
#pragma warning restore 1591
