#pragma checksum "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Vote/Teams.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b0e3c60e6b70c502fc124c54ed55b0c9ee7f81f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vote_Teams), @"mvc.1.0.view", @"/Views/Vote/Teams.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vote/Teams.cshtml", typeof(AspNetCore.Views_Vote_Teams))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b0e3c60e6b70c502fc124c54ed55b0c9ee7f81f", @"/Views/Vote/Teams.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b658cd3870fde2ae8e059aa332989a4a50e2c00", @"/Views/_ViewImports.cshtml")]
    public class Views_Vote_Teams : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Team>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Vote/teams.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("image-top-page"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/background-top.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("image-bottom-page"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/background-bottom.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Vote", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Completion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("vote-teams"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Vote/Teams.cshtml"
  
    ViewData["Title"] = "Teams";
    var attendeeCode = ViewData["attendeeCode"] as string;
    var teamColors = new string[] {"#36C1D6", "#FAB717", "#6E27C5", "#F86602", "#151097", "#F1352B", "#F81198", "#7ACB00", "#AFAFAF"};
    var index = 0;

#line default
#line hidden
            BeginContext(276, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(277, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "19d203c96d4d47cab3fee6401a6d105b", async() => {
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
            BeginContext(330, 20, true);
            WriteLiteral("\n\n<div id=\"teams\">\n\t");
            EndContext();
            BeginContext(350, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "630726ec06c44ff7b84f459517cf2b74", async() => {
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
            BeginContext(414, 5, true);
            WriteLiteral("\n    ");
            EndContext();
            BeginContext(419, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "302eeb528a6a4c88ab441ce646bf1ca8", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(489, 91, true);
            WriteLiteral("\n    <div class=\"team-list\">\n        <div class=\"container\">\n            <div class=\"row\">\n");
            EndContext();
#line 17 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Vote/Teams.cshtml"
                 foreach (var team in Model) 
                {
                    var color = teamColors[index];

#line default
#line hidden
            BeginContext(695, 74, true);
            WriteLiteral("                    <div class=\"col-md-4 col-12\">\n                        ");
            EndContext();
            BeginContext(769, 795, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46784673d41e49fb9c5e4a7395439ad1", async() => {
                BeginContext(854, 47, true);
                WriteLiteral("\n                            <input name=\"code\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 901, "\"", 922, 1);
#line 22 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Vote/Teams.cshtml"
WriteAttributeValue("", 909, attendeeCode, 909, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(923, 63, true);
                WriteLiteral(" hidden />\n                            <input name=\"voteTeamId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 986, "\"", 1002, 1);
#line 23 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Vote/Teams.cshtml"
WriteAttributeValue("", 994, team.id, 994, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1003, 209, true);
                WriteLiteral(" hidden />\n                            <img class=\"image\" src=\"https://www.projet-react.org/wp-content/themes/flymag/images/placeholder.png\" hidden />\n                            <div class=\"code\" hidden>Team ");
                EndContext();
                BeginContext(1213, 9, false);
#line 25 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Vote/Teams.cshtml"
                                                     Write(team.code);

#line default
#line hidden
                EndContext();
                BeginContext(1222, 56, true);
                WriteLiteral("</div>\n                            <div class=\"box-code\"");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 1278, "\"", 1309, 2);
                WriteAttributeValue("", 1286, "background-color:", 1286, 17, true);
#line 26 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Vote/Teams.cshtml"
WriteAttributeValue("", 1303, color, 1303, 6, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1310, 6, true);
                WriteLiteral(">Team ");
                EndContext();
                BeginContext(1317, 9, false);
#line 26 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Vote/Teams.cshtml"
                                                                                  Write(team.code);

#line default
#line hidden
                EndContext();
                BeginContext(1326, 53, true);
                WriteLiteral("</div>\n                            <div class=\"name\">");
                EndContext();
                BeginContext(1380, 9, false);
#line 27 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Vote/Teams.cshtml"
                                         Write(team.name);

#line default
#line hidden
                EndContext();
                BeginContext(1389, 57, true);
                WriteLiteral("</div>\n                            <div class=\"division\">");
                EndContext();
                BeginContext(1447, 13, false);
#line 28 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Vote/Teams.cshtml"
                                             Write(team.division);

#line default
#line hidden
                EndContext();
                BeginContext(1460, 97, true);
                WriteLiteral("</div>\n                            <button class=\"button\">เลือก</button>\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1564, 28, true);
            WriteLiteral("\n                    </div>\n");
            EndContext();
#line 32 "/Users/toy/Documents/Programing_Project/Web/C#/API/web-registration/Views/Vote/Teams.cshtml"
                    index++;
                }

#line default
#line hidden
            BeginContext(1639, 56, true);
            WriteLiteral("            </div>\n        </div>\n    </div>\n    \n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Team>> Html { get; private set; }
    }
}
#pragma warning restore 1591
