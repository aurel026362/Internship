#pragma checksum "D:\Git\Internship\MyComplexApp\App.Web\Views\Menthor\GetTMarksByUserId.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35fd80e6dce826aa7e025f402a19f0b5ebbfeba2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menthor_GetTMarksByUserId), @"mvc.1.0.view", @"/Views/Menthor/GetTMarksByUserId.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Menthor/GetTMarksByUserId.cshtml", typeof(AspNetCore.Views_Menthor_GetTMarksByUserId))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35fd80e6dce826aa7e025f402a19f0b5ebbfeba2", @"/Views/Menthor/GetTMarksByUserId.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"318e3f39db2ff1ae05875ff9df478f1dbb239071", @"/Views/_ViewImports.cshtml")]
    public class Views_Menthor_GetTMarksByUserId : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<App.Web.Model.ViewModel.ThemeMarkViewModel.ThemeMarkViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Git\Internship\MyComplexApp\App.Web\Views\Menthor\GetTMarksByUserId.cshtml"
  
    ViewData["Title"] = "_GetTMarksByUserId";

#line default
#line hidden
#line 5 "D:\Git\Internship\MyComplexApp\App.Web\Views\Menthor\GetTMarksByUserId.cshtml"
 foreach(var item in Model)
{

#line default
#line hidden
            BeginContext(163, 19, true);
            WriteLiteral("    <div>\r\n        ");
            EndContext();
            BeginContext(183, 14, false);
#line 8 "D:\Git\Internship\MyComplexApp\App.Web\Views\Menthor\GetTMarksByUserId.cshtml"
   Write(item.ThemeName);

#line default
#line hidden
            EndContext();
            BeginContext(197, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(199, 9, false);
#line 8 "D:\Git\Internship\MyComplexApp\App.Web\Views\Menthor\GetTMarksByUserId.cshtml"
                   Write(item.Mark);

#line default
#line hidden
            EndContext();
            BeginContext(208, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(210, 12, false);
#line 8 "D:\Git\Internship\MyComplexApp\App.Web\Views\Menthor\GetTMarksByUserId.cshtml"
                              Write(item.Comment);

#line default
#line hidden
            EndContext();
            BeginContext(222, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 10 "D:\Git\Internship\MyComplexApp\App.Web\Views\Menthor\GetTMarksByUserId.cshtml"
}

#line default
#line hidden
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
