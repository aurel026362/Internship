#pragma checksum "D:\Git\Internship\MyComplexApp\App.Web\Views\GeneralViews\_Comments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d238ef214a804cb669dbfa23ce27c33fcf7341c7"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d238ef214a804cb669dbfa23ce27c33fcf7341c7", @"/Views/GeneralViews/_Comments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"318e3f39db2ff1ae05875ff9df478f1dbb239071", @"/Views/_ViewImports.cshtml")]
    public class Views_GeneralViews__Comments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<App.Web.Models.ComplexViewModel.General.UserProfileViewModel>
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
            BeginContext(114, 268, true);
            WriteLiteral(@"
<div class=""tab-pane fade div-padding-vertical"" id=""v-pills-messages"" role=""tabpanel"" aria-labelledby=""v-pills-messages-tab"">
    <div class=""row"">
        <div class=""col-md-3 col-xs-12 theme-div"">
            <select class=""form-control"" id=""theme"" size=""20"">
");
            EndContext();
#line 10 "D:\Git\Internship\MyComplexApp\App.Web\Views\GeneralViews\_Comments.cshtml"
                 foreach (var item in Model.Themes)
                {

#line default
#line hidden
            BeginContext(454, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(474, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d238ef214a804cb669dbfa23ce27c33fcf7341c74008", async() => {
                BeginContext(498, 7, false);
#line 12 "D:\Git\Internship\MyComplexApp\App.Web\Views\GeneralViews\_Comments.cshtml"
                                      Write(item.Id);

#line default
#line hidden
                EndContext();
                BeginContext(505, 2, true);
                WriteLiteral("  ");
                EndContext();
                BeginContext(508, 9, false);
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
            BeginContext(526, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 13 "D:\Git\Internship\MyComplexApp\App.Web\Views\GeneralViews\_Comments.cshtml"
                }

#line default
#line hidden
            BeginContext(547, 3669, true);
            WriteLiteral(@"            </select>
        </div>
        <div id=""div-comment"" class=""col-md-9 col-xs-12"">
            <style>
                .my-comment {
                    margin:5px;
                    margin-top:10px;
                    margin-bottom:10px;
                    padding: 5px;
                    border-radius: 5px;
                    background-color:#ccebff;
                    color: black;
                    height: auto;
                    width: 100%;
                    float: left;
                }

                .other-comment {
                    margin:5px;
                    padding: 5px;
                    margin-left: 30px;
                    border-radius: 5px;
                    background-color: #d9d9d9;
                    color: black;
                    height: auto;
                    width: 100%;
                    float: right;
                }
            </style>
            <div class=""div-comment-header"">
                <div cl");
            WriteLiteral(@"ass=""row content-input-div div-padding-vertical"">
                    <div class=""col-md-8 col-sm-12"">
                        <input class=""form-control"" id=""myComment"" />
                    </div>
                    <div class=""col-md-4 col-sm-12"">
                        <button class=""btn btn-primary"" id=""submitComment"">Add Comment</button>
                    </div>
                </div>
                <div class=""div-comment-content"">
                    <div>
                        <div class=""form-group"">
                            <br />
                            <h5>Comments</h5>
                            <hr />
                            <div class=""col-12"" id=""allcomments"">
                            </div>
                        </div>
                    </div>
                    <div id=""bottom-div"" style=""margin:20px"">
                        <button id=""MoreComments"" class=""btn btn-outline-primary btn-sm form-control"">Show more comments...</button>
          ");
            WriteLiteral(@"          </div>
                </div>
            </div>

        </div>
    </div>
</div>
<script>
    $(document).ready(function () {

        $(""#MoreComments"").hide();

         $(""#theme"").bind(""change"", function () {
        $.ajax({
            url: ""/Comment/GetComments"",
            type: ""Get"",
            data: ({ themeId: $('#theme').val() }),
            datatype: ""json"",
            success: function (data) {
                pageNr = 0;
                $(""#allcomments"").empty();
                $(""#MoreComments"").show();
                
                try {
                    $(""#endMarks"").remove();
                    if (data.length < 10) {
                        $(""#bottom-div"").prepend(""<span class='text-danger' id='endMarks'>No more comments!</span>"");
                        $(""#MoreComments"").hide();
                    }
                }
                catch (Exception) {

                }

                AppendComment(data);
            },
");
            WriteLiteral(@"            error: function (data) {
                alert(""error"");
            }
        });
        });

        $(""#submitComment"").click(function () {
            $.ajax({
                url: ""/Comment/SubmitComment"",
                type: ""POST"",
                data: ({ comment: $(""#myComment"").val(), themeId: $(""#theme"").val() }),
                datatype: ""html"",
                success: function () {
                    $(""#allcomments"").prepend(""<div class='my-comment'>"" +
                        ""<i class='far fa-user-circle'></i> "" +
                        ""<b>");
            EndContext();
            BeginContext(4217, 18, false);
#line 115 "D:\Git\Internship\MyComplexApp\App.Web\Views\GeneralViews\_Comments.cshtml"
                       Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4235, 120, true);
            WriteLiteral("</b><span class=\'text-body\'> : \" + $(\"#myComment\").val() +\r\n                        \" </span><small class=\'text-muted\'>(");
            EndContext();
            BeginContext(4356, 23, false);
#line 116 "D:\Git\Internship\MyComplexApp\App.Web\Views\GeneralViews\_Comments.cshtml"
                                                       Write(DateTime.Now.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(4379, 1052, true);
            WriteLiteral(@")</span></div>"");
                    $(""#myComment"").val("""");
                },
                error: function () {
                    alert(""Error! Choose a theme!"");
                }
            });
        });

        $(""#MoreComments"").click(function () {
            pageNr++;
            $.ajax({
                url: ""/Comment/GetMoreComments"",
                type: ""GET"",
                data: ({ themeId: $(""#theme"").val(), pageNr: pageNr }),
                datatype: ""application/json"",
                success: function (data) {
                    if (data.length < 10) {
                        $(""#bottom-div"").prepend(""<span class='text-danger' id='endMarks'>No more comments!</span>"");
                        $(""#MoreComments"").hide();
                    }
                    AppendComment(data);
                }
            });
        });
    });

    function AppendComment(data) {
        $.each(data, function (i, item) {
            var classcomment = """";
   ");
            WriteLiteral("         if (item.eMail == \'");
            EndContext();
            BeginContext(5432, 18, false);
#line 146 "D:\Git\Internship\MyComplexApp\App.Web\Views\GeneralViews\_Comments.cshtml"
                          Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(5450, 359, true);
            WriteLiteral(@"') classcomment = ""my-comment"";
            else classcomment = ""other-comment"";
            $('#allcomments').append(""<div class='"" + classcomment + ""'> <i class='far fa-user-circle'></i> <b>"" + item.eMail + ""</b> : ""
                + item.content + "" <small class='text-muted'> ("" + item.dateComment + "")</span></div>"");
        });
    }

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<App.Web.Models.ComplexViewModel.General.UserProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
