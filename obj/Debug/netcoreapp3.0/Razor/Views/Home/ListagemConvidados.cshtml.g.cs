#pragma checksum "D:\Projetos\Layout\UC05\Presenca_Evento_MVC\Views\Home\ListagemConvidados.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a25e32df713f0c2b943fd28289fa3559b6dbfccf"
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
#line 1 "D:\Projetos\Layout\UC05\Presenca_Evento_MVC\Views\_ViewImports.cshtml"
using Presenca_Evento_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projetos\Layout\UC05\Presenca_Evento_MVC\Views\_ViewImports.cshtml"
using Presenca_Evento_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a25e32df713f0c2b943fd28289fa3559b6dbfccf", @"/Views/Home/ListagemConvidados.cshtml")]
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
            WriteLiteral("\r\n<h2> Lista dos Convidados Cadastrados </h2>\r\n<table>\r\n   <thead>\r\n       <tr>\r\n           <th>Nome</th>\r\n           <th>Idade</th>\r\n           <th>Telefone</th>\r\n           <th>Confirção</th>\r\n       </tr>\r\n   </thead>\r\n   <tbody>\r\n");
#nullable restore
#line 14 "D:\Projetos\Layout\UC05\Presenca_Evento_MVC\Views\Home\ListagemConvidados.cshtml"
        foreach(Convidado c in Model)
       {

#line default
#line hidden
#nullable disable
            WriteLiteral("       <tr>\r\n            <p>\r\n                <td>");
#nullable restore
#line 18 "D:\Projetos\Layout\UC05\Presenca_Evento_MVC\Views\Home\ListagemConvidados.cshtml"
               Write(c.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </p>\r\n            <br>\r\n            <p>\r\n                <td>");
#nullable restore
#line 22 "D:\Projetos\Layout\UC05\Presenca_Evento_MVC\Views\Home\ListagemConvidados.cshtml"
               Write(c.Idade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </p>\r\n            <br>\r\n            <p>\r\n                <td>");
#nullable restore
#line 26 "D:\Projetos\Layout\UC05\Presenca_Evento_MVC\Views\Home\ListagemConvidados.cshtml"
               Write(c.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </p>\r\n            <br>\r\n            <p>\r\n                <td>");
#nullable restore
#line 30 "D:\Projetos\Layout\UC05\Presenca_Evento_MVC\Views\Home\ListagemConvidados.cshtml"
               Write(c.ConfirmaPresenca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </p>\r\n            <br>\r\n       </tr>\r\n");
#nullable restore
#line 34 "D:\Projetos\Layout\UC05\Presenca_Evento_MVC\Views\Home\ListagemConvidados.cshtml"
       }

#line default
#line hidden
#nullable disable
            WriteLiteral("       ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a25e32df713f0c2b943fd28289fa3559b6dbfccf5427", async() => {
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
            WriteLiteral("\r\n   </tbody>\r\n</table>");
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
