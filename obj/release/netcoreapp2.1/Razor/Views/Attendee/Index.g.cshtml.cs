#pragma checksum "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a2cf810471f4e6a8f44a2fb849c6f419c197397"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a2cf810471f4e6a8f44a2fb849c6f419c197397", @"/Views/Attendee/Index.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "649cdc70f3034e40a8af10c6bf2ad2de", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d3f84bffd21440f9a35605a3ec0bc13d", async() => {
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
            BeginContext(313, 649, true);
            WriteLiteral(@"

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
#line 30 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
                 foreach (var item in Model) 
                {

#line default
#line hidden
            BeginContext(1026, 53, true);
            WriteLiteral("                    <tr>\n                        <td>");
            EndContext();
            BeginContext(1080, 9, false);
#line 33 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
                       Write(item.code);

#line default
#line hidden
            EndContext();
            BeginContext(1089, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(1124, 11, false);
#line 34 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
                       Write(item.nameEN);

#line default
#line hidden
            EndContext();
            BeginContext(1135, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(1170, 11, false);
#line 35 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
                       Write(item.nameTH);

#line default
#line hidden
            EndContext();
            BeginContext(1181, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(1216, 20, false);
#line 36 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
                       Write(item.checkedDateTime);

#line default
#line hidden
            EndContext();
            BeginContext(1236, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 37 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
                          
                            if (item.isChecked ?? false) {

#line default
#line hidden
            BeginContext(1328, 38, true);
            WriteLiteral("                                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1366, "\"", 1408, 2);
            WriteAttributeValue("", 1373, "/attendee/unCheckin?code=", 1373, 25, true);
#line 39 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
WriteAttributeValue("", 1398, item.code, 1398, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1409, 21, true);
            WriteLiteral(">Uncheck-in</a></td>\n");
            EndContext();
#line 40 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
                            } else {

#line default
#line hidden
            BeginContext(1467, 38, true);
            WriteLiteral("                                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1505, "\"", 1545, 2);
            WriteAttributeValue("", 1512, "/attendee/checkin?code=", 1512, 23, true);
#line 41 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
WriteAttributeValue("", 1535, item.code, 1535, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1546, 19, true);
            WriteLiteral(">Check-in</a></td>\n");
            EndContext();
#line 42 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
                            }
                        

#line default
#line hidden
            BeginContext(1621, 26, true);
            WriteLiteral("                    </tr>\n");
            EndContext();
#line 45 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
                }  

#line default
#line hidden
            BeginContext(1667, 57, true);
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n</div>\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1742, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(1747, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "542ec4f3c9b04382a0a3191428a7dd53", async() => {
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
                BeginContext(1787, 1, true);
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
