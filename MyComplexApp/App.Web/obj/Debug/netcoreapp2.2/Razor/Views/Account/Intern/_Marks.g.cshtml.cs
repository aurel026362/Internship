#pragma checksum "D:\Git\Internship\MyComplexApp\App.Web\Views\Account\Intern\_Marks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1bb40bd505ae658b9a4131e84873202dba65d03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Intern__Marks), @"mvc.1.0.view", @"/Views/Account/Intern/_Marks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Intern/_Marks.cshtml", typeof(AspNetCore.Views_Account_Intern__Marks))]
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
#line 1 "D:\Git\Internship\MyComplexApp\App.Web\Views\_ViewImports.cshtml"
using App.Web;

#line default
#line hidden
#line 2 "D:\Git\Internship\MyComplexApp\App.Web\Views\_ViewImports.cshtml"
using App.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1bb40bd505ae658b9a4131e84873202dba65d03", @"/Views/Account/Intern/_Marks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"318e3f39db2ff1ae05875ff9df478f1dbb239071", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Intern__Marks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<App.Web.Models.ComplexViewModel.Intern.CurrentUserDataViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Chart.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Git\Internship\MyComplexApp\App.Web\Views\Account\Intern\_Marks.cshtml"
  
    ViewData["Title"] = "_Marks";

#line default
#line hidden
            BeginContext(114, 977, true);
            WriteLiteral(@"
<div class=""tab-pane fade"" id=""v-pills-profile"" role=""tabpanel"" aria-labelledby=""v-pills-profile-tab"">
    <nav>
        <div class=""nav nav-tabs"" id=""nav-tab"" role=""tablist"">
            <a class=""nav-item nav-link active"" id=""nav-home-tab"" data-toggle=""tab"" href=""#divTMarks"" role=""tab"" aria-controls=""nav-home"" aria-selected=""true"">Theme Marks</a>
            <a class=""nav-item nav-link"" id=""nav-profile-tab"" data-toggle=""tab"" href=""#divEMarks"" role=""tab"" aria-controls=""nav-profile"" aria-selected=""false"">Exam Marks</a>
        </div>
    </nav>
    <div class=""container-fluid text-center"">
        <div class=""row bg-first"">
            <p>
                My problem is that after translating up the image, the div that contains it remains
                unchanged, and has lots of white space in the place where the image used to be.
            </p>
        </div>
        <select name=""modules"" style=""width:100%"" class=""form-control"" id=""module"">
");
            EndContext();
#line 21 "D:\Git\Internship\MyComplexApp\App.Web\Views\Account\Intern\_Marks.cshtml"
             foreach (var item in Model.Modules)
            {

#line default
#line hidden
            BeginContext(1156, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1172, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1bb40bd505ae658b9a4131e84873202dba65d035539", async() => {
                BeginContext(1196, 9, false);
#line 23 "D:\Git\Internship\MyComplexApp\App.Web\Views\Account\Intern\_Marks.cshtml"
                                  Write(item.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 23 "D:\Git\Internship\MyComplexApp\App.Web\Views\Account\Intern\_Marks.cshtml"
                  WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1214, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 24 "D:\Git\Internship\MyComplexApp\App.Web\Views\Account\Intern\_Marks.cshtml"
            }

#line default
#line hidden
            BeginContext(1231, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(1243, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1bb40bd505ae658b9a4131e84873202dba65d037690", async() => {
                BeginContext(1261, 11, true);
                WriteLiteral("All Modules");
                EndContext();
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
            EndContext();
            BeginContext(1281, 227, true);
            WriteLiteral("\r\n        </select>\r\n        <div class=\"tab-content\" id=\"nav-tabContent\">\r\n            <div @*id=\"marks-table\"*@ id=\"divTMarks\" class=\"tab-pane fade show active\" role=\"tabpanel\" aria-labelledby=\"profile-tab\">\r\n                ");
            EndContext();
            BeginContext(1509, 67, false);
#line 29 "D:\Git\Internship\MyComplexApp\App.Web\Views\Account\Intern\_Marks.cshtml"
           Write(await Html.PartialAsync("Intern/_GetMarks", Model.Marks.ThemeMarks));

#line default
#line hidden
            EndContext();
            BeginContext(1576, 743, true);
            WriteLiteral(@"
            </div>
            <div id=""divEMarks"" class=""tab-pane fade show active"" role=""tabpanel"" aria-labelledby=""profile-tab"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>
                                Module Name <a href=""#""><i class=""fas fa-sort""></i></a>
                            </th>
                            <th>
                                Mark <a href=""#""><i class=""fas fa-sort""></i></a>
                            </th>
                            <th>
                                Comment
                            </th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 47 "D:\Git\Internship\MyComplexApp\App.Web\Views\Account\Intern\_Marks.cshtml"
                         if (Model.Marks.ExamMarks != null)
                        {
                            

#line default
#line hidden
#line 49 "D:\Git\Internship\MyComplexApp\App.Web\Views\Account\Intern\_Marks.cshtml"
                             foreach (var item in Model.Marks.ExamMarks)
                            {

#line default
#line hidden
            BeginContext(2512, 120, true);
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2633, 15, false);
#line 53 "D:\Git\Internship\MyComplexApp\App.Web\Views\Account\Intern\_Marks.cshtml"
                                   Write(item.ModuleName);

#line default
#line hidden
            EndContext();
            BeginContext(2648, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2776, 9, false);
#line 56 "D:\Git\Internship\MyComplexApp\App.Web\Views\Account\Intern\_Marks.cshtml"
                                   Write(item.Mark);

#line default
#line hidden
            EndContext();
            BeginContext(2785, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2913, 12, false);
#line 59 "D:\Git\Internship\MyComplexApp\App.Web\Views\Account\Intern\_Marks.cshtml"
                                   Write(item.Comment);

#line default
#line hidden
            EndContext();
            BeginContext(2925, 84, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 62 "D:\Git\Internship\MyComplexApp\App.Web\Views\Account\Intern\_Marks.cshtml"
                            }

#line default
#line hidden
#line 62 "D:\Git\Internship\MyComplexApp\App.Web\Views\Account\Intern\_Marks.cshtml"
                             
                        }
                        else if (Model.Marks.ExamMarks == null)
                        {

#line default
#line hidden
            BeginContext(3159, 149, true);
            WriteLiteral("                            <tr>\r\n                                <td colspan=\"3\"><b>Don\'t exist marks!</b></td>\r\n                            </tr>\r\n");
            EndContext();
#line 69 "D:\Git\Internship\MyComplexApp\App.Web\Views\Account\Intern\_Marks.cshtml"
                        }

#line default
#line hidden
            BeginContext(3335, 865, true);
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
        </div>
        <div class=""container-fluid text-center"">
            <div class=""row"">
                <div class=""col-md-4 col-xs-12"">
                    <canvas id=""mychart""></canvas>
                </div>
                <div class=""col-md-6 col-xs-12"">
                    <canvas id=""mychart2""></canvas>
                </div>
            </div>
            <div class=""row"">
                <p class=""text-center text-muted"">
                    Coding Just Got Easy!

                    Free Plugin for IntelliJ,
                    Android Studio, and Eclipse: Write fast & error free code with AI code completions.
                </p>
            </div>
            <div class=""row"">
                <canvas id=""mychart3""></canvas>
                ");
            EndContext();
            BeginContext(4200, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1bb40bd505ae658b9a4131e84873202dba65d0314344", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4241, 50, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<App.Web.Models.ComplexViewModel.Intern.CurrentUserDataViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
