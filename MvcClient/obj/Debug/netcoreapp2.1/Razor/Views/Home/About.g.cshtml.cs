#pragma checksum "C:\Users\geoff\GitHub\quickstartIDServer4UI\MvcClient\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0dd39fdcf6c8a31cd9b6a1b946a8949066e74a33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\Users\geoff\GitHub\quickstartIDServer4UI\MvcClient\Views\_ViewImports.cshtml"
using MvcClient;

#line default
#line hidden
#line 2 "C:\Users\geoff\GitHub\quickstartIDServer4UI\MvcClient\Views\_ViewImports.cshtml"
using MvcClient.Models;

#line default
#line hidden
#line 1 "C:\Users\geoff\GitHub\quickstartIDServer4UI\MvcClient\Views\Home\About.cshtml"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dd39fdcf6c8a31cd9b6a1b946a8949066e74a33", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8143d1835352feeef7cd3c50c0d2dc4c14dbed3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\geoff\GitHub\quickstartIDServer4UI\MvcClient\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(85, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(90, 17, false);
#line 5 "C:\Users\geoff\GitHub\quickstartIDServer4UI\MvcClient\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(107, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(119, 19, false);
#line 6 "C:\Users\geoff\GitHub\quickstartIDServer4UI\MvcClient\Views\Home\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(138, 93, true);
            WriteLiteral("</h3>\r\n\r\n<p>Use this area to provide additional information.</p>\r\n\r\n<h2>Claims</h2>\r\n\r\n<dl>\r\n");
            EndContext();
#line 13 "C:\Users\geoff\GitHub\quickstartIDServer4UI\MvcClient\Views\Home\About.cshtml"
     foreach (var claim in User.Claims)
    {

#line default
#line hidden
            BeginContext(279, 12, true);
            WriteLiteral("        <dt>");
            EndContext();
            BeginContext(292, 10, false);
#line 15 "C:\Users\geoff\GitHub\quickstartIDServer4UI\MvcClient\Views\Home\About.cshtml"
       Write(claim.Type);

#line default
#line hidden
            EndContext();
            BeginContext(302, 19, true);
            WriteLiteral("</dt>\r\n        <dd>");
            EndContext();
            BeginContext(322, 11, false);
#line 16 "C:\Users\geoff\GitHub\quickstartIDServer4UI\MvcClient\Views\Home\About.cshtml"
       Write(claim.Value);

#line default
#line hidden
            EndContext();
            BeginContext(333, 7, true);
            WriteLiteral("</dd>\r\n");
            EndContext();
#line 17 "C:\Users\geoff\GitHub\quickstartIDServer4UI\MvcClient\Views\Home\About.cshtml"
    }

#line default
#line hidden
            BeginContext(347, 40, true);
            WriteLiteral("</dl>\r\n\r\n\r\n<h2>Properties</h2>\r\n\r\n<dl>\r\n");
            EndContext();
#line 24 "C:\Users\geoff\GitHub\quickstartIDServer4UI\MvcClient\Views\Home\About.cshtml"
     foreach (var prop in (await Context.AuthenticateAsync()).Properties.Items)
    {

#line default
#line hidden
            BeginContext(475, 12, true);
            WriteLiteral("        <dt>");
            EndContext();
            BeginContext(488, 8, false);
#line 26 "C:\Users\geoff\GitHub\quickstartIDServer4UI\MvcClient\Views\Home\About.cshtml"
       Write(prop.Key);

#line default
#line hidden
            EndContext();
            BeginContext(496, 19, true);
            WriteLiteral("</dt>\r\n        <dd>");
            EndContext();
            BeginContext(516, 10, false);
#line 27 "C:\Users\geoff\GitHub\quickstartIDServer4UI\MvcClient\Views\Home\About.cshtml"
       Write(prop.Value);

#line default
#line hidden
            EndContext();
            BeginContext(526, 7, true);
            WriteLiteral("</dd>\r\n");
            EndContext();
#line 28 "C:\Users\geoff\GitHub\quickstartIDServer4UI\MvcClient\Views\Home\About.cshtml"
    }

#line default
#line hidden
            BeginContext(540, 9, true);
            WriteLiteral("</dl>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
