#pragma checksum "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\GeneralViews\Settings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d446baaa1ee3388b8349d549f6ec3331810a391a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GeneralViews_Settings), @"mvc.1.0.view", @"/Views/GeneralViews/Settings.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/GeneralViews/Settings.cshtml", typeof(AspNetCore.Views_GeneralViews_Settings))]
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
#line 1 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\_ViewImports.cshtml"
using App.Web;

#line default
#line hidden
#line 2 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\_ViewImports.cshtml"
using App.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d446baaa1ee3388b8349d549f6ec3331810a391a", @"/Views/GeneralViews/Settings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54c602c57965ce5caca06038002963a0a362a30e", @"/Views/_ViewImports.cshtml")]
    public class Views_GeneralViews_Settings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<App.Web.Models.ForUser.PersonalData>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\GeneralViews\Settings.cshtml"
  
    ViewData["Title"] = "Settings";

#line default
#line hidden
            BeginContext(88, 2105, true);
            WriteLiteral(@"
<div class=""tab-pane fade"" id=""v-pills-settings"" role=""tabpanel"" aria-labelledby=""v-pills-settings-tab"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-12"" style=""padding:20px"">
                <img src=""https://w2w.fund/Content/img/default.png""
                     class=""rounded-circle mx-auto d-block"">
                <br>
                <button class=""btn btn-outline-primary mx-auto d-block"">
                    Change Profile
                    Photo
                </button>
            </div>
            <div class=""row col-12 d-flex justify-content-center"">
                <div class=""col-sm-8 text-center"">
                    <table class=""table"">
                        <tr>
                            <th>Personal Data</th>
                            <th>
                                <div class=""modal fade"" id=""modalLoginForm"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel""
                                     aria-hidde");
            WriteLiteral(@"n=""true"">
                                    <div class=""modal-dialog"" role=""document"">
                                        <div class=""modal-content text-left"">
                                            <div class=""modal-header text-center"">
                                                <h4 class=""modal-title w-100 font-weight-bold"">Personal Data</h4>
                                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                                    <span aria-hidden=""true"">&times;</span>
                                                </button>
                                            </div>
                                            <div class=""modal-body mx-4"">
                                                <div class=""md-form mb-4"">
                                                    <i class=""fas fa-file-signature indigo-text""></i><p>First Name</p>
                                                    <i");
            WriteLiteral("nput type=\"text\" id=\"FName\" class=\"form-control validate\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 2193, "", 2216, 1);
#line 37 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\GeneralViews\Settings.cshtml"
WriteAttributeValue("", 2200, Model.FirstName, 2200, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2216, 427, true);
            WriteLiteral(@">
                                                </div>

                                                <div class=""md-form mb-4"">
                                                    <i class=""fas fa-file-signature""></i> <label data-error=""wrong"" data-success=""right"" for=""defaultForm-pass"">Last Name</label>
                                                    <input type=""text"" id=""LName"" class=""form-control validate""");
            EndContext();
            BeginWriteAttribute("value", " value=", 2643, "", 2665, 1);
#line 42 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\GeneralViews\Settings.cshtml"
WriteAttributeValue("", 2650, Model.LastName, 2650, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2665, 432, true);
            WriteLiteral(@">
                                                </div>

                                                <div class=""md-form mb-4"">
                                                    <i class=""fas fa-mobile-alt""></i> <label data-error=""wrong"" data-success=""right"" for=""defaultForm-pass"">Phone Number</label>
                                                    <input type=""text"" id=""PhoneNumber"" class=""form-control validate""");
            EndContext();
            BeginWriteAttribute("value", " value=", 3097, "", 3122, 1);
#line 47 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\GeneralViews\Settings.cshtml"
WriteAttributeValue("", 3104, Model.PhoneNumber, 3104, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3122, 434, true);
            WriteLiteral(@">
                                                </div>

                                                <div class=""md-form mb-4"">
                                                    <i class=""fas fa-birthday-cake""></i> <label data-error=""wrong"" data-success=""right"" for=""defaultForm-pass"">Date Of Birth</label>
                                                    <input type=""date"" id=""DateBirth"" class=""form-control validate""");
            EndContext();
            BeginWriteAttribute("value", " value=", 3556, "", 3581, 1);
#line 52 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\GeneralViews\Settings.cshtml"
WriteAttributeValue("", 3563, Model.DateOfBirth, 3563, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3581, 1010, true);
            WriteLiteral(@">
                                                </div>
                                            </div>
                                            <div class=""modal-footer d-flex justify-content-center"">
                                                <button id=""PersonalData"" class=""btn btn-default"">Change Data</button>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                                <div>
                                    <a class=""btn btn-outline-primary"" href="""" data-toggle=""modal"" data-target=""#modalLoginForm"">
                                        Change Personal Data
                                    </a>
                                </div>
                            </th>
                        </tr>
                        <tr>
                            <td>First Name</td>
                            <td>");
            EndContext();
            BeginContext(4592, 15, false);
#line 71 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\GeneralViews\Settings.cshtml"
                           Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(4607, 148, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Last Name</td>\r\n                            <td>");
            EndContext();
            BeginContext(4756, 14, false);
#line 75 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\GeneralViews\Settings.cshtml"
                           Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(4770, 152, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Date of Birth</td>\r\n                            <td>");
            EndContext();
            BeginContext(4923, 17, false);
#line 79 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\GeneralViews\Settings.cshtml"
                           Write(Model.DateOfBirth);

#line default
#line hidden
            EndContext();
            BeginContext(4940, 151, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Number Phone</td>\r\n                            <td>");
            EndContext();
            BeginContext(5092, 17, false);
#line 83 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\GeneralViews\Settings.cshtml"
                           Write(Model.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(5109, 144, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>EMail</td>\r\n                            <td>");
            EndContext();
            BeginContext(5254, 11, false);
#line 87 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\GeneralViews\Settings.cshtml"
                           Write(Model.EMail);

#line default
#line hidden
            EndContext();
            BeginContext(5265, 1389, true);
            WriteLiteral(@"</td>
                        </tr>
                        <tr>
                            <th>Account Data</th>
                            <th>
                                <div class=""modal fade"" id=""modalRegisterForm"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel""
                                     aria-hidden=""true"">
                                    <div class=""modal-dialog"" role=""document"">
                                        <div class=""modal-content text-left"">
                                            <div class=""modal-header"">
                                                <h4 class=""modal-title w-100 font-weight-bold"">Sign up</h4>
                                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                                    <span aria-hidden=""true"">&times;</span>
                                                </button>
                                            </div>
    ");
            WriteLiteral(@"                                        <div class=""modal-body mx-3"">
                                                <div class=""md-form mb-5"">
                                                    <i class=""fas fa-user prefix grey-text""></i><label>EMail</label>
                                                    <input type=""text"" class=""form-control validate""");
            EndContext();
            BeginWriteAttribute("value", " value=", 6654, "", 6673, 1);
#line 105 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\GeneralViews\Settings.cshtml"
WriteAttributeValue("", 6661, Model.EMail, 6661, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6673, 361, true);
            WriteLiteral(@">
                                                </div>
                                                <div class=""md-form mb-5"">
                                                    <i class=""fas fa-envelope prefix grey-text""></i><label>Password</label>
                                                    <input type=""email"" class=""form-control validate""");
            EndContext();
            BeginWriteAttribute("value", " value=", 7034, "", 7053, 1);
#line 109 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\GeneralViews\Settings.cshtml"
WriteAttributeValue("", 7041, Model.EMail, 7041, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7053, 989, true);
            WriteLiteral(@">
                                                </div>
                                            </div>
                                            <div class=""modal-footer d-flex justify-content-center"">
                                                <button class=""btn btn-deep-orange"">Sign up</button>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                                <div>
                                    <a href="""" class=""btn btn-outline-primary"" data-toggle=""modal"" data-target=""#modalRegisterForm"">
                                        Change Account Data
                                    </a>
                                </div>
                            </th>
                        </tr>
                        <tr>
                            <td>Login</td>
                            <td>");
            EndContext();
            BeginContext(8043, 11, false);
#line 128 "C:\Users\Aurel\Desktop\Got\Internship\MyComplexApp\App.Web\Views\GeneralViews\Settings.cshtml"
                           Write(Model.EMail);

#line default
#line hidden
            EndContext();
            BeginContext(8054, 1734, true);
            WriteLiteral(@"</td>
                        </tr>
                        <tr>
                            <td>Password</td>
                            <td>********</td>
                        </tr>
                        <tr>
                            <td colspan=""2"">
                                <button class=""btn btn-danger"">Delete Account</button>
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </div>
</div>
<script>
        //$(document).ready(function () {
        //    $(""#PersonalData"").bind(""click"", function () {
        //            alert(name);
        //            $.ajax({
        //                url: ""/Intern/EditData"",
        //                type: ""POST"",
        //                data: ({ fname: $(""#FName"").val(), lname: $(""#LName"").val(), phone: $(""#PhoneNumber"").val(), dbirth: $(""#DateBirth"").val() }),
        //                datatype: ""html"",
        //      ");
            WriteLiteral(@"          success: function () { alert(""success""); }
        //            });

        //    //$.post(""/Intern/EditData"", { name })
        //    //    .done(function () {
        //    //        alert(""succes"");
        //    //    })
        //    //    .fail(function () {
        //    //        alert(""error"");
        //    //    }).
        //    //    always(function () {
        //    //        alert(""Always"");
        //    //    });
        //    });
        //});

    //function myfunction(var fname) {
    //    var request = new XMLHttpRequest();
    //alert(fname);
    //    request.open('Post', 'Intern/EditData');
    //    request.send(fname);
    //}

</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<App.Web.Models.ForUser.PersonalData> Html { get; private set; }
    }
}
#pragma warning restore 1591
