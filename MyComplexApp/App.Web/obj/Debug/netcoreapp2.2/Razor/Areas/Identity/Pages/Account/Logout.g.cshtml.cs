#pragma checksum "D:\Git\Internship\MyComplexApp\App.Web\Areas\Identity\Pages\Account\Logout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3554faef47d3ce9cb48f1aeb81a46f87d0cfbe03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(App.Web.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_Logout), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Logout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/Logout.cshtml", typeof(App.Web.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_Logout), null)]
namespace App.Web.Areas.Identity.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Git\Internship\MyComplexApp\App.Web\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\Git\Internship\MyComplexApp\App.Web\Areas\Identity\Pages\_ViewImports.cshtml"
using App.Web.Areas.Identity;

#line default
#line hidden
#line 3 "D:\Git\Internship\MyComplexApp\App.Web\Areas\Identity\Pages\_ViewImports.cshtml"
using App.Data.Domain.DomainModels.Identity;

#line default
#line hidden
#line 1 "D:\Git\Internship\MyComplexApp\App.Web\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using App.Web.Areas.Identity.Pages.Account;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3554faef47d3ce9cb48f1aeb81a46f87d0cfbe03", @"/Areas/Identity/Pages/Account/Logout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca8896fc23bf1c76b79afb03d83057c95bb604e4", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6ed3e4eef04f0f53c66e9433a65659b617fd4b9", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Logout : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Git\Internship\MyComplexApp\App.Web\Areas\Identity\Pages\Account\Logout.cshtml"
  
    ViewData["Title"] = "Log out";

#line default
#line hidden
            BeginContext(70, 408, true);
            WriteLiteral(@"<script>

    $('.isLoggedOut').hide();
    $('#menuId').append(""<li class='nav - item active isLoggedIn'><a href = '/identity/account/register' class= 'nav-link' > Register</a > </li >"");
    $('#menuId').append(""<li class='nav - item active isLoggedIn'><a href = '/identity/account/login' class= 'nav-link' > Log In</a > </li >"");

</script>
<header>
    <div class=""container-fluid"">
        <h1>");
            EndContext();
            BeginContext(479, 17, false);
#line 15 "D:\Git\Internship\MyComplexApp\App.Web\Areas\Identity\Pages\Account\Logout.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(496, 105, true);
            WriteLiteral("</h1>\r\n        <p>You have successfully logged out of the application.</p>\r\n        </div>\r\n</header>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LogoutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LogoutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LogoutModel>)PageContext?.ViewData;
        public LogoutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
