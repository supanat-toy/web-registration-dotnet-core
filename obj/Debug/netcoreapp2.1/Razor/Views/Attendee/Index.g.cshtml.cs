#pragma checksum "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93f918b09c13d9d64d5df37611b6749c873299f2"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93f918b09c13d9d64d5df37611b6749c873299f2", @"/Views/Attendee/Index.cshtml")]
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
    var amountCheckedIn = Model.Where(x => (x.isChecked ?? false)).ToList().Count();
    var amountUnCheckIn = Model.Where(x => (x.isChecked ?? false) == false).ToList().Count();

#line default
#line hidden
            BeginContext(249, 102, true);
            WriteLiteral("\n<link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css\">\n");
            EndContext();
            BeginContext(351, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a64f6331ce0b42eda0602b72636ed05f", async() => {
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
            BeginContext(402, 63, true);
            WriteLiteral("\n\n<style>\n  .form-control {\n    font-size: 20px;\n  }\n</style>\n\n");
            EndContext();
            BeginContext(465, 27, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "79b914f8161b4833a52c7d771b57744b", async() => {
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
            BeginContext(492, 126, true);
            WriteLiteral("\n<div class=\"text-center\" style=\"margin-top: 10px\">\n    <span class=\"card-amount-value\" style=\"background-color:#000;\">Total: ");
            EndContext();
            BeginContext(619, 13, false);
#line 19 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
                                                                     Write(Model.Count());

#line default
#line hidden
            EndContext();
            BeginContext(632, 97, true);
            WriteLiteral("</span>\n    <span class=\"card-amount-value\" style=\"background-color:rgb(47, 155, 52);\">Check In: ");
            EndContext();
            BeginContext(730, 15, false);
#line 20 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
                                                                                    Write(amountCheckedIn);

#line default
#line hidden
            EndContext();
            BeginContext(745, 99, true);
            WriteLiteral("</span>\n    <span class=\"card-amount-value\" style=\"background-color:rgb(184, 33, 33);\">Uncheck In: ");
            EndContext();
            BeginContext(845, 15, false);
#line 21 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
                                                                                      Write(amountUnCheckIn);

#line default
#line hidden
            EndContext();
            BeginContext(860, 857, true);
            WriteLiteral(@"</span>
</div>

<div class=""container body-content"">
    <div class=""box-table"">
        <div class=""title"">คนเข้าร่วมงาน</div>
            <div class=""table-responsive filterable"">
                <table class=""custom-table table-striped table-bordered"">
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
#line 39 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
                         foreach (var item in Model) 
                        {

#line default
#line hidden
            BeginContext(1797, 69, true);
            WriteLiteral("                            <tr>\n                                <td>");
            EndContext();
            BeginContext(1867, 9, false);
#line 42 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
                               Write(item.code);

#line default
#line hidden
            EndContext();
            BeginContext(1876, 42, true);
            WriteLiteral("</td>\n                                <td>");
            EndContext();
            BeginContext(1919, 11, false);
#line 43 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
                               Write(item.nameTH);

#line default
#line hidden
            EndContext();
            BeginContext(1930, 42, true);
            WriteLiteral("</td>\n                                <td>");
            EndContext();
            BeginContext(1973, 13, false);
#line 44 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
                               Write(item.division);

#line default
#line hidden
            EndContext();
            BeginContext(1986, 42, true);
            WriteLiteral("</td>\n                                <td>");
            EndContext();
            BeginContext(2029, 20, false);
#line 45 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
                               Write(item.checkedDateTime);

#line default
#line hidden
            EndContext();
            BeginContext(2049, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 46 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
                                  
                                    if (item.isChecked ?? false) {

#line default
#line hidden
            BeginContext(2157, 46, true);
            WriteLiteral("                                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2203, "\"", 2245, 2);
            WriteAttributeValue("", 2210, "/attendee/unCheckin?code=", 2210, 25, true);
#line 48 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
WriteAttributeValue("", 2235, item.code, 2235, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2246, 21, true);
            WriteLiteral(">Uncheck-in</a></td>\n");
            EndContext();
#line 49 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
                                    } else {

#line default
#line hidden
            BeginContext(2312, 46, true);
            WriteLiteral("                                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2358, "\"", 2398, 2);
            WriteAttributeValue("", 2365, "/attendee/checkin?code=", 2365, 23, true);
#line 50 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
WriteAttributeValue("", 2388, item.code, 2388, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2399, 19, true);
            WriteLiteral(">Check-in</a></td>\n");
            EndContext();
#line 51 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
                                    }
                                

#line default
#line hidden
            BeginContext(2490, 34, true);
            WriteLiteral("                            </tr>\n");
            EndContext();
#line 54 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Attendee/Index.cshtml"
                        }  

#line default
#line hidden
            BeginContext(2552, 107, true);
            WriteLiteral("                    </tbody>\n                </table>\n            </div>\n        </div>\n    </div>\n</div>\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2677, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(2682, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8c32f69cf334a98899cd06729566fc1", async() => {
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
                BeginContext(2722, 1, true);
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
