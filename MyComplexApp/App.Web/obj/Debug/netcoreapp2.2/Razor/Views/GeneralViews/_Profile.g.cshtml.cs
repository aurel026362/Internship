#pragma checksum "D:\Git\Internship\MyComplexApp\App.Web\Views\GeneralViews\_Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f885e73f0d824c7063dccb7c3c85576fa35b1dd5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GeneralViews__Profile), @"mvc.1.0.view", @"/Views/GeneralViews/_Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/GeneralViews/_Profile.cshtml", typeof(AspNetCore.Views_GeneralViews__Profile))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f885e73f0d824c7063dccb7c3c85576fa35b1dd5", @"/Views/GeneralViews/_Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"318e3f39db2ff1ae05875ff9df478f1dbb239071", @"/Views/_ViewImports.cshtml")]
    public class Views_GeneralViews__Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<App.Web.Models.ViewModel.UserViewModel.UserDetailedViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Git\Internship\MyComplexApp\App.Web\Views\GeneralViews\_Profile.cshtml"
  
    ViewData["Title"] = "Profile";

#line default
#line hidden
            BeginContext(112, 191, true);
            WriteLiteral("\r\n    <div class=\"tab-pane fade show active row\" id=\"v-pills-home\" role=\"tabpanel\"\r\n         aria-labelledby=\"v-pills-home-tab\">\r\n        \r\n        <div id=\'calendar\'></div>\r\n\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<App.Web.Models.ViewModel.UserViewModel.UserDetailedViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
