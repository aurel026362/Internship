#pragma checksum "D:\Git\Internship\MyComplexApp\App.Web\Views\Account\Intern\_GetMarks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "276f542c830e243bd4b86fdf5ee67f7c5d16093a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Intern__GetMarks), @"mvc.1.0.view", @"/Views/Account/Intern/_GetMarks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Intern/_GetMarks.cshtml", typeof(AspNetCore.Views_Account_Intern__GetMarks))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"276f542c830e243bd4b86fdf5ee67f7c5d16093a", @"/Views/Account/Intern/_GetMarks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"318e3f39db2ff1ae05875ff9df478f1dbb239071", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Intern__GetMarks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<App.Web.Model.ViewModel.ThemeMarkViewModel.ThemeMarkViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(77, 351, true);
            WriteLiteral(@"<div id=""Tbody"">
    <table class=""table"">
        <thead>
            <tr>
                <th>
                    Theme
                </th>
                <th>
                    Mark
                </th>
                <th>
                    Comment
                </th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 18 "D:\Git\Internship\MyComplexApp\App.Web\Views\Account\Intern\_GetMarks.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(485, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(558, 14, false);
#line 22 "D:\Git\Internship\MyComplexApp\App.Web\Views\Account\Intern\_GetMarks.cshtml"
                   Write(item.ThemeName);

#line default
#line hidden
            EndContext();
            BeginContext(572, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(652, 9, false);
#line 25 "D:\Git\Internship\MyComplexApp\App.Web\Views\Account\Intern\_GetMarks.cshtml"
                   Write(item.Mark);

#line default
#line hidden
            EndContext();
            BeginContext(661, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(741, 12, false);
#line 28 "D:\Git\Internship\MyComplexApp\App.Web\Views\Account\Intern\_GetMarks.cshtml"
                   Write(item.Comment);

#line default
#line hidden
            EndContext();
            BeginContext(753, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 31 "D:\Git\Internship\MyComplexApp\App.Web\Views\Account\Intern\_GetMarks.cshtml"
            }

#line default
#line hidden
            BeginContext(820, 38, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<App.Web.Model.ViewModel.ThemeMarkViewModel.ThemeMarkViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
