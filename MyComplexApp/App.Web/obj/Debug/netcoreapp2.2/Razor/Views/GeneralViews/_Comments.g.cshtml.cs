#pragma checksum "D:\Git\Internship\MyComplexApp\App.Web\Views\GeneralViews\_Comments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e903c4241a78e090993f22cf201cd27497ffa0cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GeneralViews__Comments), @"mvc.1.0.view", @"/Views/GeneralViews/_Comments.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/GeneralViews/_Comments.cshtml", typeof(AspNetCore.Views_GeneralViews__Comments))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e903c4241a78e090993f22cf201cd27497ffa0cd", @"/Views/GeneralViews/_Comments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"318e3f39db2ff1ae05875ff9df478f1dbb239071", @"/Views/_ViewImports.cshtml")]
    public class Views_GeneralViews__Comments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<App.Web.Models.ComplexViewModel.Intern.CurrentDataInternViewModel>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Git\Internship\MyComplexApp\App.Web\Views\GeneralViews\_Comments.cshtml"
  
    ViewData["Title"] = "_Comments";

#line default
#line hidden
            BeginContext(119, 258, true);
            WriteLiteral(@"
<div class=""tab-pane fade general-div"" id=""v-pills-messages"" role=""tabpanel"" aria-labelledby=""v-pills-messages-tab"">
    <div class=""row"">
        <div class=""col-md-3 col-xs-5 theme-div"">
            <select class=""form-control"" id=""theme"" size=""20"">
");
            EndContext();
#line 10 "D:\Git\Internship\MyComplexApp\App.Web\Views\GeneralViews\_Comments.cshtml"
                 foreach (var item in Model.Themes)
                {

#line default
#line hidden
            BeginContext(449, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(469, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e903c4241a78e090993f22cf201cd27497ffa0cd4003", async() => {
                BeginContext(493, 7, false);
#line 12 "D:\Git\Internship\MyComplexApp\App.Web\Views\GeneralViews\_Comments.cshtml"
                                      Write(item.Id);

#line default
#line hidden
                EndContext();
                BeginContext(500, 2, true);
                WriteLiteral("  ");
                EndContext();
                BeginContext(503, 9, false);
#line 12 "D:\Git\Internship\MyComplexApp\App.Web\Views\GeneralViews\_Comments.cshtml"
                                                Write(item.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 12 "D:\Git\Internship\MyComplexApp\App.Web\Views\GeneralViews\_Comments.cshtml"
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
            BeginContext(521, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 13 "D:\Git\Internship\MyComplexApp\App.Web\Views\GeneralViews\_Comments.cshtml"
                }

#line default
#line hidden
            BeginContext(542, 109, true);
            WriteLiteral("            </select>\r\n        </div>\r\n        <div id=\"comment-div\" class=\"col-md-9 col-xs-7\">\r\n            ");
            EndContext();
            BeginContext(652, 62, false);
#line 17 "D:\Git\Internship\MyComplexApp\App.Web\Views\GeneralViews\_Comments.cshtml"
       Write(await Html.PartialAsync("../GeneralViews/_GetComments", Model));

#line default
#line hidden
            EndContext();
            BeginContext(714, 38, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<App.Web.Models.ComplexViewModel.Intern.CurrentDataInternViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
