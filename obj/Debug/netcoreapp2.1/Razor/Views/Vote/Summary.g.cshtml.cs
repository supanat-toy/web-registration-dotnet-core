#pragma checksum "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Vote/Summary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6c5d30c570ad4afc19a302a98bf9431dd5bdcfb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vote_Summary), @"mvc.1.0.view", @"/Views/Vote/Summary.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vote/Summary.cshtml", typeof(AspNetCore.Views_Vote_Summary))]
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
#line 1 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/_ViewImports.cshtml"
using web_registration;

#line default
#line hidden
#line 2 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/_ViewImports.cshtml"
using web_registration.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6c5d30c570ad4afc19a302a98bf9431dd5bdcfb", @"/Views/Vote/Summary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b658cd3870fde2ae8e059aa332989a4a50e2c00", @"/Views/_ViewImports.cshtml")]
    public class Views_Vote_Summary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TeamViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/attendee.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TopMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Vote/Summary.cshtml"
  
    ViewData["Title"] = "Summary";

#line default
#line hidden
            BeginContext(74, 102, true);
            WriteLiteral("\n<link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css\">\n");
            EndContext();
            BeginContext(176, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1c93ce8e425b45e484e925523c0ecac7", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(227, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(229, 27, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "36dbe09fa701406e822828912d9334c5", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(256, 326, true);
            WriteLiteral(@"

<div class=""container body-content"">
    <div class=""table-responsive"">
        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th>Code</th>
                    <th>Name</th>
                    <th>Amount</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 22 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Vote/Summary.cshtml"
                 foreach (var item in Model) 
                {

#line default
#line hidden
            BeginContext(646, 53, true);
            WriteLiteral("                    <tr>\n                        <td>");
            EndContext();
            BeginContext(700, 9, false);
#line 25 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Vote/Summary.cshtml"
                       Write(item.code);

#line default
#line hidden
            EndContext();
            BeginContext(709, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(744, 9, false);
#line 26 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Vote/Summary.cshtml"
                       Write(item.name);

#line default
#line hidden
            EndContext();
            BeginContext(753, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(788, 11, false);
#line 27 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Vote/Summary.cshtml"
                       Write(item.amount);

#line default
#line hidden
            EndContext();
            BeginContext(799, 32, true);
            WriteLiteral("</td>\n                    </tr>\n");
            EndContext();
#line 29 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Vote/Summary.cshtml"
                }  

#line default
#line hidden
            BeginContext(851, 55, true);
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TeamViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
