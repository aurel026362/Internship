#pragma checksum "D:\Git\Internship\MyComplexApp\App.Web\Views\Account\Menthor\_Marks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ffb57377f1f5553be5ae1a50001c1bb1036c6e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Menthor__Marks), @"mvc.1.0.view", @"/Views/Account/Menthor/_Marks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Menthor/_Marks.cshtml", typeof(AspNetCore.Views_Account_Menthor__Marks))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ffb57377f1f5553be5ae1a50001c1bb1036c6e1", @"/Views/Account/Menthor/_Marks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"318e3f39db2ff1ae05875ff9df478f1dbb239071", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Menthor__Marks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<App.Web.Models.ComplexViewModel.Intern.CurrentUserDataViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Git\Internship\MyComplexApp\App.Web\Views\Account\Menthor\_Marks.cshtml"
  
    ViewData["Title"] = "_Marks";

#line default
#line hidden
            BeginContext(114, 1822, true);
            WriteLiteral(@"<div class=""tab-pane fade"" id=""v-pills-profile"" role=""tabpanel"" aria-labelledby=""v-pills-profile-tab"">
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
        <div class=""tab-content"" id=""nav-tabContent"">
            <div class=""tab-pane fade show active"" role=""tabpanel"" aria-labelle");
            WriteLiteral(@"dby=""profile-tab"" id=""divTMarks"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>
                                User EMail <a href=""#""><i class=""fas fa-sort""></i></a>
                            </th>
                            <th>
                                Theme Name <a href=""#""><i class=""fas fa-sort""></i></a>
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
#line 39 "D:\Git\Internship\MyComplexApp\App.Web\Views\Account\Menthor\_Marks.cshtml"
                         if (Model.Marks.ExamMarks != null)
                        {
                            

#line default
#line hidden
#line 41 "D:\Git\Internship\MyComplexApp\App.Web\Views\Account\Menthor\_Marks.cshtml"
                             foreach (var item in Model.Marks.ThemeMarks)
                            {

#line default
#line hidden
            BeginContext(2130, 120, true);
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2251, 14, false);
#line 45 "D:\Git\Internship\MyComplexApp\App.Web\Views\Account\Menthor\_Marks.cshtml"
                                   Write(item.UserEmail);

#line default
#line hidden
            EndContext();
            BeginContext(2265, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2393, 14, false);
#line 48 "D:\Git\Internship\MyComplexApp\App.Web\Views\Account\Menthor\_Marks.cshtml"
                                   Write(item.ThemeName);

#line default
#line hidden
            EndContext();
            BeginContext(2407, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2535, 9, false);
#line 51 "D:\Git\Internship\MyComplexApp\App.Web\Views\Account\Menthor\_Marks.cshtml"
                                   Write(item.Mark);

#line default
#line hidden
            EndContext();
            BeginContext(2544, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2672, 12, false);
#line 54 "D:\Git\Internship\MyComplexApp\App.Web\Views\Account\Menthor\_Marks.cshtml"
                                   Write(item.Comment);

#line default
#line hidden
            EndContext();
            BeginContext(2684, 84, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 57 "D:\Git\Internship\MyComplexApp\App.Web\Views\Account\Menthor\_Marks.cshtml"
                            }

#line default
#line hidden
#line 57 "D:\Git\Internship\MyComplexApp\App.Web\Views\Account\Menthor\_Marks.cshtml"
                             
                        }
                        else if (Model.Marks.ExamMarks == null)
                        {

#line default
#line hidden
            BeginContext(2918, 149, true);
            WriteLiteral("                            <tr>\r\n                                <td colspan=\"3\"><b>Don\'t exist marks!</b></td>\r\n                            </tr>\r\n");
            EndContext();
#line 64 "D:\Git\Internship\MyComplexApp\App.Web\Views\Account\Menthor\_Marks.cshtml"
                        }

#line default
#line hidden
            BeginContext(3094, 943, true);
            WriteLiteral(@"                    </tbody>
                </table>
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
#line 87 "D:\Git\Internship\MyComplexApp\App.Web\Views\Account\Menthor\_Marks.cshtml"
                         foreach (var item in Model.Marks.ExamMarks)
                        {

#line default
#line hidden
            BeginContext(4134, 108, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(4243, 14, false);
#line 91 "D:\Git\Internship\MyComplexApp\App.Web\Views\Account\Menthor\_Marks.cshtml"
                               Write(item.UserEmail);

#line default
#line hidden
            EndContext();
            BeginContext(4257, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(4373, 15, false);
#line 94 "D:\Git\Internship\MyComplexApp\App.Web\Views\Account\Menthor\_Marks.cshtml"
                               Write(item.ModuleName);

#line default
#line hidden
            EndContext();
            BeginContext(4388, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(4504, 9, false);
#line 97 "D:\Git\Internship\MyComplexApp\App.Web\Views\Account\Menthor\_Marks.cshtml"
                               Write(item.Mark);

#line default
#line hidden
            EndContext();
            BeginContext(4513, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(4629, 12, false);
#line 100 "D:\Git\Internship\MyComplexApp\App.Web\Views\Account\Menthor\_Marks.cshtml"
                               Write(item.Comment);

#line default
#line hidden
            EndContext();
            BeginContext(4641, 76, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 103 "D:\Git\Internship\MyComplexApp\App.Web\Views\Account\Menthor\_Marks.cshtml"
                        }

#line default
#line hidden
            BeginContext(4744, 112, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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