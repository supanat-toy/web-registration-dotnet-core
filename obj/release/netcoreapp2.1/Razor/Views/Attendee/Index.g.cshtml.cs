#pragma checksum "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28536ad0c614e79f2a091187bcd8ae3e10436b75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Attendee_Index), @"mvc.1.0.view", @"/Views/Attendee/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Attendee/Index.cshtml", typeof(AspNetCore.Views_Attendee_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28536ad0c614e79f2a091187bcd8ae3e10436b75", @"/Views/Attendee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b658cd3870fde2ae8e059aa332989a4a50e2c00", @"/Views/_ViewImports.cshtml")]
    public class Views_Attendee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Attendee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/attendee.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:60px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/attendee.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
  
    ViewData["Title"] = "Registration";

#line default
#line hidden
            BeginContext(74, 102, true);
            WriteLiteral("\n<link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css\">\n");
            EndContext();
            BeginContext(176, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "afbe808813a44468bf08f66e14e2476f", async() => {
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
            BeginContext(227, 198, true);
            WriteLiteral("\n\n<style>\n  .form-control {\n    font-size: 20px;\n  }\n</style>\n\n<nav class=\"custom-navbar navbar navbar-expand-md bg-dark navbar-dark\">\n  <!-- Brand -->\n    <a class=\"navbar-brand\" href=\"#\">\n        ");
            EndContext();
            BeginContext(425, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "83ba437b1db54064ac0019a315ad2851", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(474, 448, true);
            WriteLiteral(@"
    </a>
  <!-- Toggler/collapsibe Button -->
  <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#collapsibleNavbar"">
    <span class=""navbar-toggler-icon""></span>
  </button>

  <!-- Navbar links -->
  <div class=""collapse navbar-collapse"" id=""collapsibleNavbar"">
    <ul class=""navbar-nav"">
      <li class=""nav-item"">
        <a class=""nav-link"" href=""/registration"" target=""_blank"">Registration</a>
      </li>
");
            EndContext();
            BeginContext(1100, 674, true);
            WriteLiteral(@"    </ul>
  </div>
</nav>

<div class=""container body-content"">
    <div class=""table-responsive filterable"">
        <table class=""table table-striped"">
            <thead>
                <tr class=""filters"">
                    <th><input type=""text"" class=""form-control"" placeholder=""Code""></th>
                    <th><input type=""text"" class=""form-control"" placeholder=""Name EN""></th>
                    <th><input type=""text"" class=""form-control"" placeholder=""Name TH""></th>
                    <th><input type=""text"" class=""form-control"" placeholder=""Checked time""></th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 54 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
                 foreach (var item in Model) 
                {

#line default
#line hidden
            BeginContext(1838, 53, true);
            WriteLiteral("                    <tr>\n                        <td>");
            EndContext();
            BeginContext(1892, 9, false);
#line 57 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
                       Write(item.code);

#line default
#line hidden
            EndContext();
            BeginContext(1901, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(1936, 11, false);
#line 58 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
                       Write(item.nameEN);

#line default
#line hidden
            EndContext();
            BeginContext(1947, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(1982, 11, false);
#line 59 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
                       Write(item.nameTH);

#line default
#line hidden
            EndContext();
            BeginContext(1993, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(2028, 20, false);
#line 60 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
                       Write(item.checkedDateTime);

#line default
#line hidden
            EndContext();
            BeginContext(2048, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 61 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
                          
                            if (item.isChecked ?? false) {

#line default
#line hidden
            BeginContext(2140, 38, true);
            WriteLiteral("                                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2178, "\"", 2220, 2);
            WriteAttributeValue("", 2185, "/attendee/unCheckin?code=", 2185, 25, true);
#line 63 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
WriteAttributeValue("", 2210, item.code, 2210, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2221, 21, true);
            WriteLiteral(">Uncheck-in</a></td>\n");
            EndContext();
#line 64 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
                            } else {

#line default
#line hidden
            BeginContext(2279, 38, true);
            WriteLiteral("                                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2317, "\"", 2357, 2);
            WriteAttributeValue("", 2324, "/attendee/checkin?code=", 2324, 23, true);
#line 65 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
WriteAttributeValue("", 2347, item.code, 2347, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2358, 19, true);
            WriteLiteral(">Check-in</a></td>\n");
            EndContext();
#line 66 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
                            }
                        

#line default
#line hidden
            BeginContext(2433, 26, true);
            WriteLiteral("                    </tr>\n");
            EndContext();
#line 69 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
                }  

#line default
#line hidden
            BeginContext(2479, 57, true);
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n</div>\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2554, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(2559, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb22f969e9d741d7af3b81048f9bb7c2", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2599, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Attendee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
