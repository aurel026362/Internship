#pragma checksum "D:\Git\Internship\MyComplexApp\App.Web\Views\Intern\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f2b70a7413a0bf732a3d9f0bf9b06b3a390e42a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Intern_Index), @"mvc.1.0.view", @"/Views/Intern/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Intern/Index.cshtml", typeof(AspNetCore.Views_Intern_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f2b70a7413a0bf732a3d9f0bf9b06b3a390e42a", @"/Views/Intern/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54c602c57965ce5caca06038002963a0a362a30e", @"/Views/_ViewImports.cshtml")]
    public class Views_Intern_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<App.Web.Models.ForUser.DataCurrentUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("logoutForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Chart.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Git\Internship\MyComplexApp\App.Web\Views\Intern\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(88, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n");
            EndContext();
            BeginContext(117, 1441, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f2b70a7413a0bf732a3d9f0bf9b06b3a390e42a6015", async() => {
                BeginContext(123, 1027, true);
                WriteLiteral(@"
    <title>My App</title>

    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css""
          integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">

    <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js""
            integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo""
            crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js""
            integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1""
            crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js""
            integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM""
            crossorigin=""anonymous""></script>
    <script src=""https://use.fontawesome.com/releases/v5.0.8/js/all.js""></script");
                WriteLiteral(">\r\n");
                EndContext();
                BeginContext(1248, 303, true);
                WriteLiteral(@"    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.0/jquery.min.js""></script>

    <script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.7.3/Chart.js""></script>

    <!-- <link rel=""stylesheet"" href=""css/style.css"">
    <link rel=""stylesheet"" href=""css/UserStyle.css""> -->
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1558, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1562, 9197, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f2b70a7413a0bf732a3d9f0bf9b06b3a390e42a8725", async() => {
                BeginContext(1568, 1012, true);
                WriteLiteral(@"
    <div class=""row"" style=""width:100%"">
        <div class=""col-2"">
            <div class=""nav flex-column nav-pills"" id=""v-pills-tab"" role=""tablist"" aria-orientation=""vertical"">
                <a class=""nav-link active"" id=""v-pills-home-tab"" data-toggle=""pill"" href=""#v-pills-home"" role=""tab""
                   aria-controls=""v-pills-home"" aria-selected=""true"">Home</a>
                <a class=""nav-link"" id=""v-pills-profile-tab"" data-toggle=""pill"" href=""#v-pills-profile"" role=""tab""
                   aria-controls=""v-pills-profile"" aria-selected=""false"">Profile</a>
                <a class=""nav-link"" id=""v-pills-messages-tab"" data-toggle=""pill"" href=""#v-pills-messages"" role=""tab""
                   aria-controls=""v-pills-messages"" aria-selected=""false"">Messages</a>
                <a class=""nav-link"" id=""v-pills-settings-tab"" data-toggle=""pill"" href=""#v-pills-settings"" role=""tab""
                   aria-controls=""v-pills-settings"" aria-selected=""false"">Settings</a>
                ");
                EndContext();
                BeginContext(2580, 258, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f2b70a7413a0bf732a3d9f0bf9b06b3a390e42a10191", async() => {
                    BeginContext(2669, 162, true);
                    WriteLiteral("\r\n                    <button id=\"logout\" type=\"submit\" class=\"nav-link btn btn-link text-dark\"><span class=\"text-danger\">Logout</span></button>\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2838, 133, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"col-10\">\r\n            <div class=\"tab-content\" id=\"v-pills-tabContent\">\r\n\r\n");
                EndContext();
                BeginContext(3035, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(3052, 70, false);
#line 55 "D:\Git\Internship\MyComplexApp\App.Web\Views\Intern\Index.cshtml"
           Write(await Html.PartialAsync("../GeneralViews/Profile", Model.PersonalData));

#line default
#line hidden
                EndContext();
                BeginContext(3122, 725, true);
                WriteLiteral(@"
                <div class=""tab-pane fade"" id=""v-pills-profile"" role=""tabpanel"" aria-labelledby=""v-pills-profile-tab"">
                    <div class=""container-fluid text-center"">
                        <div class=""row bg-first"">
                            <p>
                                My problem is that after translating up the image, the div that contains it remains
                                unchanged, and has lots of white space in the place where the image used to be.
                            </p>
                        </div>
                        <div class=""row"" id=""mydiv"">
                            <select name=""modules"" style=""width:100%"" class=""form-control"" id=""module"">
");
                EndContext();
#line 66 "D:\Git\Internship\MyComplexApp\App.Web\Views\Intern\Index.cshtml"
                                 foreach (var item in Model.Modules)
                                {

#line default
#line hidden
                BeginContext(3952, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(3988, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f2b70a7413a0bf732a3d9f0bf9b06b3a390e42a14268", async() => {
                    BeginContext(4012, 9, false);
#line 68 "D:\Git\Internship\MyComplexApp\App.Web\Views\Intern\Index.cshtml"
                                                      Write(item.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 68 "D:\Git\Internship\MyComplexApp\App.Web\Views\Intern\Index.cshtml"
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
                BeginContext(4030, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 69 "D:\Git\Internship\MyComplexApp\App.Web\Views\Intern\Index.cshtml"
                                }

#line default
#line hidden
                BeginContext(4067, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(4099, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f2b70a7413a0bf732a3d9f0bf9b06b3a390e42a16577", async() => {
                    BeginContext(4117, 11, true);
                    WriteLiteral("All Modules");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4137, 140, true);
                WriteLiteral("\r\n                            </select>\r\n                            <div id=\"marks-table\" class=\"col-12\">\r\n                                ");
                EndContext();
                BeginContext(4278, 69, false);
#line 73 "D:\Git\Internship\MyComplexApp\App.Web\Views\Intern\Index.cshtml"
                           Write(await Html.PartialAsync("../Intern/GetMarks", Model.Marks.ThemeMarks));

#line default
#line hidden
                EndContext();
                BeginContext(4347, 1099, true);
                WriteLiteral(@"
                            </div>
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
              ");
                WriteLiteral("              <canvas id=\"mychart3\"></canvas>\r\n                            ");
                EndContext();
                BeginContext(5446, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f2b70a7413a0bf732a3d9f0bf9b06b3a390e42a19761", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5487, 86, true);
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
                EndContext();
                BeginContext(5870, 320, true);
                WriteLiteral(@"                <div class=""tab-pane fade general-div"" id=""v-pills-messages"" role=""tabpanel"" aria-labelledby=""v-pills-messages-tab"">
                    <div class=""row"">
                        <div class=""col-md-3 col-xs-5 theme-div"">
                            <select class=""form-control"" id=""theme"" size=""20"">
");
                EndContext();
#line 108 "D:\Git\Internship\MyComplexApp\App.Web\Views\Intern\Index.cshtml"
                                 foreach (var item in Model.Themes)
                                {

#line default
#line hidden
                BeginContext(6294, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(6330, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f2b70a7413a0bf732a3d9f0bf9b06b3a390e42a21919", async() => {
                    BeginContext(6354, 7, false);
#line 110 "D:\Git\Internship\MyComplexApp\App.Web\Views\Intern\Index.cshtml"
                                                      Write(item.Id);

#line default
#line hidden
                    EndContext();
                    BeginContext(6361, 2, true);
                    WriteLiteral("  ");
                    EndContext();
                    BeginContext(6364, 9, false);
#line 110 "D:\Git\Internship\MyComplexApp\App.Web\Views\Intern\Index.cshtml"
                                                                Write(item.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 110 "D:\Git\Internship\MyComplexApp\App.Web\Views\Intern\Index.cshtml"
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
                BeginContext(6382, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 111 "D:\Git\Internship\MyComplexApp\App.Web\Views\Intern\Index.cshtml"
                                }

#line default
#line hidden
                BeginContext(6419, 173, true);
                WriteLiteral("                            </select>\r\n                        </div>\r\n                        <div id=\"comment-div\" class=\"col-md-9 col-xs-7\">\r\n                            ");
                EndContext();
                BeginContext(6593, 72, false);
#line 115 "D:\Git\Internship\MyComplexApp\App.Web\Views\Intern\Index.cshtml"
                       Write(await Html.PartialAsync("../Intern/GetComments", Model.CurrentUserComms));

#line default
#line hidden
                EndContext();
                BeginContext(6665, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
                BeginContext(7912, 100, true);
                WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n                ");
                EndContext();
                BeginContext(8013, 71, false);
#line 138 "D:\Git\Internship\MyComplexApp\App.Web\Views\Intern\Index.cshtml"
           Write(await Html.PartialAsync("../GeneralViews/Settings", Model.PersonalData));

#line default
#line hidden
                EndContext();
                BeginContext(8084, 2668, true);
                WriteLiteral(@"
            </div>
        </div>
    </div>
    <script>
        //$('#myTab a[href=""#profile""]').tab('show');
        $('#myTab li:first-child a');
        $('#myTab li:first-child a');
        $('#myTab li:last-child a');
        $('#myTab li:nth-child(3) a');
    </script>
    <footer class=""container-fluid"" id=""footer"">
        <div class=""container-fluid"">
            <div class=""row padding text-center"">
                <div class=""col-12"">
                    <h2>Our Contacts</h2>
                </div>
                <div class=""col-12 social padding"">
                    <a href=""#""><i class=""fab fa-twitter""></i></a>
                    <a href=""#""><i class=""fab fa-instagram""></i></a>
                    <a href=""#""><i class=""fab fa-facebook""></i></a>
                    <a href=""#""><i class=""fab fa-youtube""></i></a>
                </div>
            </div>
        </div>
    </footer>

    <script>
        $(document).ready(function () {
            $(""#PersonalData""");
                WriteLiteral(@").bind(""click"", function () {
                $.ajax({
                    url: ""/Intern/EditData"",
                    type: ""POST"",
                    data: ({ fname: $(""#FName"").val(), lname: $(""#LName"").val(), phone: $(""#PhoneNumber"").val(), dbirth: $(""#DateBirthg"").val() }),
                    datatype: ""html"",
                    success: function () {
                    }
                });
            });
            //$.post(""/Intern/EditData"", { name })
            //    .done(function () {
            //        alert(""succes"");
            //    })
            //    .fail(function () {
            //        alert(""error"");
            //    }).
            //    always(function () {
            //        alert(""Always"");
            //    });

            $(""#module"").bind(""change"", function () {
                $.get(""/Intern/GetMarks"", { moduleId: $('#module').val() })
                    .done(function (data) {
                        $(""#marks-table"").html(data);
  ");
                WriteLiteral(@"                  })
                    .fail(function (data) {
                    })
                    .always(function () {
                    });
            });

            $(""#theme"").bind(""change"", function () {
                $.get(""/Intern/GetComments"", { themeId: $('#theme').val() })
                    .done(function (data) {
                        $(""#comment-div"").html(data);
                    })
                    .fail(function (data) {
                    })
                    .always(function () {
                    });
            });
        });


    </script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(10759, 13, true);
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<App.Web.Models.ForUser.DataCurrentUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
