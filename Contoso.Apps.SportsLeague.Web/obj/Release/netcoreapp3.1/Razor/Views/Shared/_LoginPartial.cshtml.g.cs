#pragma checksum "C:\MCW\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Shared\_LoginPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae85c628e6630f1f6b60cfc4803935d5ab596b11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LoginPartial), @"mvc.1.0.view", @"/Views/Shared/_LoginPartial.cshtml")]
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
#nullable restore
#line 1 "C:\MCW\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\_ViewImports.cshtml"
using Contoso.Apps.SportsLeague.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MCW\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\_ViewImports.cshtml"
using Contoso.Apps.SportsLeague.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae85c628e6630f1f6b60cfc4803935d5ab596b11", @"/Views/Shared/_LoginPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bf66ee1a5764bfdb85279aa9e375802bdc3af75", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LoginPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\MCW\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Shared\_LoginPartial.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <ul class=\"nav navbar-nav navbar-right\">\r\n        <li>\r\n            <a id=\"profile-link\">");
#nullable restore
#line 6 "C:\MCW\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Shared\_LoginPartial.cshtml"
                            Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            <div id=\"profile-options\" class=\"nav navbar-nav navbar-right\">\r\n                <ul class=\"profile-links\">\r\n                    <li class=\"profile-link\">\r\n                        ");
#nullable restore
#line 10 "C:\MCW\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Shared\_LoginPartial.cshtml"
                   Write(Html.ActionLink("Edit Profile", "Profile", "Account"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n        </li>\r\n        <li>\r\n            ");
#nullable restore
#line 16 "C:\MCW\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Shared\_LoginPartial.cshtml"
       Write(Html.ActionLink("Sign out", "SignOut", "Account"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </li>\r\n    </ul>\r\n");
#nullable restore
#line 19 "C:\MCW\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Shared\_LoginPartial.cshtml"
       
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<ul class=\"nav navbar-nav navbar-right\">\r\n    <li>");
#nullable restore
#line 24 "C:\MCW\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Shared\_LoginPartial.cshtml"
   Write(Html.ActionLink("Sign up", "SignUp", "Account", routeValues: null, htmlAttributes: new { id = "signUpLink" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>");
#nullable restore
#line 25 "C:\MCW\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Shared\_LoginPartial.cshtml"
   Write(Html.ActionLink("Sign in", "SignIn", "Account", routeValues: null, htmlAttributes: new { id = "loginLink" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ul>\r\n");
#nullable restore
#line 27 "C:\MCW\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Shared\_LoginPartial.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
