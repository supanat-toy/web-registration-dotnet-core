#pragma checksum "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24cf363935eced33369e148d386418e51fa08956"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24cf363935eced33369e148d386418e51fa08956", @"/Views/Attendee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b658cd3870fde2ae8e059aa332989a4a50e2c00", @"/Views/_ViewImports.cshtml")]
    public class Views_Attendee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Attendee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/attendee.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TopMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/attendee.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
  
    ViewData["Title"] = "Attendee";

#line default
#line hidden
            BeginContext(70, 102, true);
            WriteLiteral("\n<link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css\">\n");
            EndContext();
            BeginContext(172, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9fa65daca765429fad8329836be7fb2c", async() => {
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
            BeginContext(223, 63, true);
            WriteLiteral("\n\n<style>\n  .form-control {\n    font-size: 20px;\n  }\n</style>\n\n");
            EndContext();
            BeginContext(286, 27, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c14faa4833984a3f95b6a5cfa5173564", async() => {
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
            BeginContext(313, 650, true);
            WriteLiteral(@"

<div class=""container body-content"">
    <div class=""table-responsive filterable"">
        <table class=""table table-striped"">
            <thead>
                <tr class=""filters"">
                    <th><input type=""text"" class=""form-control"" placeholder=""Code""></th>
                    <th><input type=""text"" class=""form-control"" placeholder=""Name TH""></th>
                    <th><input type=""text"" class=""form-control"" placeholder=""Division""></th>
                    <th><input type=""text"" class=""form-control"" placeholder=""Checked time""></th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 30 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
                 foreach (var item in Model) 
                {

#line default
#line hidden
            BeginContext(1027, 53, true);
            WriteLiteral("                    <tr>\n                        <td>");
            EndContext();
            BeginContext(1081, 9, false);
#line 33 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
                       Write(item.code);

#line default
#line hidden
            EndContext();
            BeginContext(1090, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(1125, 11, false);
#line 34 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
                       Write(item.nameTH);

#line default
#line hidden
            EndContext();
            BeginContext(1136, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(1171, 13, false);
#line 35 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
                       Write(item.division);

#line default
#line hidden
            EndContext();
            BeginContext(1184, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(1219, 20, false);
#line 36 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
                       Write(item.checkedDateTime);

#line default
#line hidden
            EndContext();
            BeginContext(1239, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 37 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
                          
                            if (item.isChecked ?? false) {

#line default
#line hidden
            BeginContext(1331, 38, true);
            WriteLiteral("                                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1369, "\"", 1411, 2);
            WriteAttributeValue("", 1376, "/attendee/unCheckin?code=", 1376, 25, true);
#line 39 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
WriteAttributeValue("", 1401, item.code, 1401, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1412, 21, true);
            WriteLiteral(">Uncheck-in</a></td>\n");
            EndContext();
#line 40 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
                            } else {

#line default
#line hidden
            BeginContext(1470, 38, true);
            WriteLiteral("                                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1508, "\"", 1548, 2);
            WriteAttributeValue("", 1515, "/attendee/checkin?code=", 1515, 23, true);
#line 41 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
WriteAttributeValue("", 1538, item.code, 1538, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1549, 19, true);
            WriteLiteral(">Check-in</a></td>\n");
            EndContext();
#line 42 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
                            }
                        

#line default
#line hidden
            BeginContext(1624, 26, true);
            WriteLiteral("                    </tr>\n");
            EndContext();
#line 45 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
                }  

#line default
#line hidden
            BeginContext(1670, 57, true);
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n</div>\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1745, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(1750, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0657ab0234224d4dbd779b806b271fa2", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1790, 1, true);
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
