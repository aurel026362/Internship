#pragma checksum "D:\Git\Internship\MyComplexApp\App.Web\Views\Menthor\_Marks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b46ce68a9541906e344f6fddf67be9ff9bc3a0df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menthor__Marks), @"mvc.1.0.view", @"/Views/Menthor/_Marks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Menthor/_Marks.cshtml", typeof(AspNetCore.Views_Menthor__Marks))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b46ce68a9541906e344f6fddf67be9ff9bc3a0df", @"/Views/Menthor/_Marks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"318e3f39db2ff1ae05875ff9df478f1dbb239071", @"/Views/_ViewImports.cshtml")]
    public class Views_Menthor__Marks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<App.Web.Models.ComplexViewModel.Intern.CurrentUserDataViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Git\Internship\MyComplexApp\App.Web\Views\Menthor\_Marks.cshtml"
  
    ViewData["Title"] = "_Marks";

#line default
#line hidden
            BeginContext(114, 330, true);
            WriteLiteral(@"<div class=""tab-pane fade show active"" role=""tabpanel"" aria-labelledby=""profile-tab"" id=""divTMarks"">
    <div style=""margin:20px"" class=""text-right"">
        <span class=""text-muted""><i class=""fas fa-search""></i>Search: </span> <input type=""text"" id=""search"" />
    </div>
    
    <select id=""module"" class=""form-control"">
");
            EndContext();
#line 11 "D:\Git\Internship\MyComplexApp\App.Web\Views\Menthor\_Marks.cshtml"
         foreach(var item in Model.Modules)
        {

#line default
#line hidden
            BeginContext(500, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(512, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b46ce68a9541906e344f6fddf67be9ff9bc3a0df4271", async() => {
                BeginContext(536, 9, false);
#line 13 "D:\Git\Internship\MyComplexApp\App.Web\Views\Menthor\_Marks.cshtml"
                              Write(item.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 13 "D:\Git\Internship\MyComplexApp\App.Web\Views\Menthor\_Marks.cshtml"
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
            BeginContext(554, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 14 "D:\Git\Internship\MyComplexApp\App.Web\Views\Menthor\_Marks.cshtml"
        }

#line default
#line hidden
            BeginContext(567, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(575, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b46ce68a9541906e344f6fddf67be9ff9bc3a0df6380", async() => {
                BeginContext(602, 11, true);
                WriteLiteral("All Modules");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(622, 664, true);
            WriteLiteral(@"
    </select>

    <table class=""table"" id=""tableBody"">
        <thead>
            <tr>
                <th>
                    User EMail <a href=""#"" id=""email"" class=""property""><i class=""fas fa-sort""></i></a>
                </th>
                <th>
                    Theme Name <a href=""#"" id=""theme"" class=""property""><i class=""fas fa-sort""></i></a>
                </th>
                <th>
                    Mark <a href=""#"" id=""mark"" class=""property""><i class=""fas fa-sort""></i></a>
                </th>
                <th>
                    Comment
                </th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 36 "D:\Git\Internship\MyComplexApp\App.Web\Views\Menthor\_Marks.cshtml"
             if (Model.Marks.ExamMarks != null)
            {
                

#line default
#line hidden
#line 38 "D:\Git\Internship\MyComplexApp\App.Web\Views\Menthor\_Marks.cshtml"
                 foreach (var item in Model.Marks.ThemeMarks)
                {

#line default
#line hidden
            BeginContext(1432, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1517, 14, false);
#line 42 "D:\Git\Internship\MyComplexApp\App.Web\Views\Menthor\_Marks.cshtml"
                       Write(item.UserEmail);

#line default
#line hidden
            EndContext();
            BeginContext(1531, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1623, 14, false);
#line 45 "D:\Git\Internship\MyComplexApp\App.Web\Views\Menthor\_Marks.cshtml"
                       Write(item.ThemeName);

#line default
#line hidden
            EndContext();
            BeginContext(1637, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1729, 9, false);
#line 48 "D:\Git\Internship\MyComplexApp\App.Web\Views\Menthor\_Marks.cshtml"
                       Write(item.Mark);

#line default
#line hidden
            EndContext();
            BeginContext(1738, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1830, 12, false);
#line 51 "D:\Git\Internship\MyComplexApp\App.Web\Views\Menthor\_Marks.cshtml"
                       Write(item.Comment);

#line default
#line hidden
            EndContext();
            BeginContext(1842, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 54 "D:\Git\Internship\MyComplexApp\App.Web\Views\Menthor\_Marks.cshtml"
                }

#line default
#line hidden
#line 54 "D:\Git\Internship\MyComplexApp\App.Web\Views\Menthor\_Marks.cshtml"
                 
            }
            else if (Model.Marks.ExamMarks == null)
            {

#line default
#line hidden
            BeginContext(2004, 113, true);
            WriteLiteral("                <tr>\r\n                    <td colspan=\"3\"><b>Don\'t exist marks!</b></td>\r\n                </tr>\r\n");
            EndContext();
#line 61 "D:\Git\Internship\MyComplexApp\App.Web\Views\Menthor\_Marks.cshtml"
            }

#line default
#line hidden
            BeginContext(2132, 840, true);
            WriteLiteral(@"        </tbody>
    </table>
    <div id=""footerTMarks"" style=""margin:20px"" class=""text-right"">
        <button id=""moreTMarks"" class=""btn btn-outline-primary"">More...</button>
    </div>
</div>
<div class=""tab-pane fade"" role=""tabpanel"" aria-labelledby=""profile-tab"" id=""divEMarks"">
    <table class=""table"">
        <thead>
            <tr>
                <th>
                    User EMail <a href=""#""><i class=""fas fa-sort""></i></a>
                </th>
                <th>
                    Module Name <a href=""#""><i class=""fas fa-sort""></i></a>
                </th>
                <th>
                    Mark<a href=""#""> <i class=""fas fa-sort""></i></a>
                </th>
                <th>
                    Comment
                </th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 87 "D:\Git\Internship\MyComplexApp\App.Web\Views\Menthor\_Marks.cshtml"
             if (Model.Marks.ExamMarks != null)
            {
                

#line default
#line hidden
#line 89 "D:\Git\Internship\MyComplexApp\App.Web\Views\Menthor\_Marks.cshtml"
                 foreach (var item in Model.Marks.ExamMarks)
                {

#line default
#line hidden
            BeginContext(3117, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3202, 14, false);
#line 93 "D:\Git\Internship\MyComplexApp\App.Web\Views\Menthor\_Marks.cshtml"
                       Write(item.UserEmail);

#line default
#line hidden
            EndContext();
            BeginContext(3216, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3308, 15, false);
#line 96 "D:\Git\Internship\MyComplexApp\App.Web\Views\Menthor\_Marks.cshtml"
                       Write(item.ModuleName);

#line default
#line hidden
            EndContext();
            BeginContext(3323, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3415, 9, false);
#line 99 "D:\Git\Internship\MyComplexApp\App.Web\Views\Menthor\_Marks.cshtml"
                       Write(item.Mark);

#line default
#line hidden
            EndContext();
            BeginContext(3424, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3516, 12, false);
#line 102 "D:\Git\Internship\MyComplexApp\App.Web\Views\Menthor\_Marks.cshtml"
                       Write(item.Comment);

#line default
#line hidden
            EndContext();
            BeginContext(3528, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 105 "D:\Git\Internship\MyComplexApp\App.Web\Views\Menthor\_Marks.cshtml"
                }

#line default
#line hidden
#line 105 "D:\Git\Internship\MyComplexApp\App.Web\Views\Menthor\_Marks.cshtml"
                 
            }
            else
            {

#line default
#line hidden
            BeginContext(3655, 113, true);
            WriteLiteral("                <tr>\r\n                    <td colspan=\"4\"><b>Don\'t exist marks!</b></td>\r\n                </tr>\r\n");
            EndContext();
#line 112 "D:\Git\Internship\MyComplexApp\App.Web\Views\Menthor\_Marks.cshtml"
            }

#line default
#line hidden
            BeginContext(3783, 4477, true);
            WriteLiteral(@"        </tbody>
    </table>
</div>

<script>
    var ascending = true;
    var page = 0;
    var orderbyprop=""email"";

    $(""#module"").bind(""change"", function () {
        $.ajax({
            url: ""/Menthor/GetTMarksByModule"",
            type: ""GET"",
            datatype: ""json"",
            data: ({ moduleId: $(""#module"").val(), orderby: orderbyprop, sorting: ascending}),
            success: function (data) {
                page = 0;
                try {
                    $(""#warningMarks"").remove();
                    $(""#moreTMarks"").show();
                }
                catch (Exception) {

                }
                $(""#tableBody > tbody"").empty();
                $.each(data, function (i, item) {
                    $('<tr>').append(
                        $('<td>').text(item.userEmail),
                        $('<td>').text(item.themeName),
                        $('<td>').text(item.mark),
                        $('<td>').text(item.comment)
     ");
            WriteLiteral(@"               ).appendTo('#tableBody');
                });
            },
            error: function () {

            }
        });
    });

    $(""#search"").bind(""change"", function () {
        $.ajax({
            url: ""/Menthor/GetTMarksByEmail"",
            type: ""GET"",
            datatype: ""json"",
            data: ({ email: $(""#search"").val() }),
            success: function (data) {
                page = 0;
                try {
                    $(""#warningMarks"").remove();
                    $(""#moreTMarks"").show();
                }
                catch (Exception) {

                }
                $(""#tableBody > tbody"").empty();
                $.each(data, function (i, item) {
                    $('<tr>').append(
                        $('<td>').text(item.userEmail),
                        $('<td>').text(item.themeName),
                        $('<td>').text(item.mark),
                        $('<td>').text(item.comment)
                    ).appe");
            WriteLiteral(@"ndTo('#tableBody');
                });
            },
            error: function () {

            }
        });
    });

    $("".property"").bind(""click"", function () {
        if (ascending == true) ascending = false;
        else ascending = true;
        orderbyprop = $(this).attr('id');
        $.ajax({
            url: ""/Menthor/GetTMarksSorted"",
            type: ""GET"",
            datatype: ""json"",
            data: ({ page: page, orderby: $(this).attr('id'), sorting: ascending }),
            success: function (data) {
                try {
                    $(""#warningMarks"").remove();
                    $(""#moreTMarks"").show();
                }
                catch (Exception) {

                }
                page = 0;
                $(""#moreTMarks"").show();
                $(""#tableBody > tbody"").empty();
                $.each(data, function (i, item) {
                    $('<tr>').append(
                        $('<td>').text(item.userEmail),
        ");
            WriteLiteral(@"                $('<td>').text(item.themeName),
                        $('<td>').text(item.mark),
                        $('<td>').text(item.comment)
                    ).appendTo('#tableBody');
                });
            },
            error: function () {
                alert(""Error"");
            }
        });
    });

    $(""#moreTMarks"").bind(""click"", function () {
        page++;
        $.ajax({
            url: ""/Menthor/GetMoreTMarks"",
            type: ""GET"",
            datatype: ""application/json"",
            data: ({ page: page, orderby: orderbyprop, sorting: ascending }),
            success: function (data) {
                if (data.length < 10) {
                    $(""#moreTMarks"").hide();
                    $(""#footerTMarks"").append(""<span id='warningMarks' class='text-danger'>Don't exist more Theme Mark</span>"");
                }
                $.each(data, function (i, item) {
                    $('<tr>').append(
                        $('<td>').te");
            WriteLiteral(@"xt(item.userEmail),
                        $('<td>').text(item.themeName),
                        $('<td>').text(item.mark),
                        $('<td>').text(item.comment)
                    ).appendTo('#tableBody');
                });
            },
            error: function () {
                alert(""Error"");
            }
        });
    });
</script>");
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
