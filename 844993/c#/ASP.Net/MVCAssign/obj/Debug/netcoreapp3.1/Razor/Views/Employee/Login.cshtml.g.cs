#pragma checksum "C:\chandini\c#\ASP.Net\MVCAssign\Views\Employee\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb7f9a00d5a9198e28759020fea0b1b7d12c3e3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Login), @"mvc.1.0.view", @"/Views/Employee/Login.cshtml")]
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
#line 1 "C:\chandini\c#\ASP.Net\MVCAssign\Views\_ViewImports.cshtml"
using MVCAssign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\chandini\c#\ASP.Net\MVCAssign\Views\_ViewImports.cshtml"
using MVCAssign.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb7f9a00d5a9198e28759020fea0b1b7d12c3e3c", @"/Views/Employee/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc264cb8f1d23455cf9cb8b1e8a8298b5dd449b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\chandini\c#\ASP.Net\MVCAssign\Views\Employee\Login.cshtml"
  
    ViewData["Title"] = "Login";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Login</h1>\r\n");
#nullable restore
#line 8 "C:\chandini\c#\ASP.Net\MVCAssign\Views\Employee\Login.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-bordered\">\r\n    <tr>\r\n        <td>EMPID</td>\r\n        <td>");
#nullable restore
#line 13 "C:\chandini\c#\ASP.Net\MVCAssign\Views\Employee\Login.cshtml"
       Write(Html.TextBox("empid"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>PASSWORD</td>\r\n        <td>");
#nullable restore
#line 17 "C:\chandini\c#\ASP.Net\MVCAssign\Views\Employee\Login.cshtml"
       Write(Html.TextBox("pwd"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
    </tr>
    <tr>
        <td colspan=""2"">
            <input type=""submit"" value=""Login"" class=""btn btn-primary"" />
        </td>
    </tr>
    <tr>
        <td colspan=""2"">
            <input type=""submit"" value=""SignUp"" class=""btn btn-primary"" />
        </td>
    </tr>
    <tr>
        <td>
            <span class=""text-danger"">");
#nullable restore
#line 31 "C:\chandini\c#\ASP.Net\MVCAssign\Views\Employee\Login.cshtml"
                                 Write(ViewData["err"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </td>\r\n    </tr>\r\n</table>\r\n");
#nullable restore
#line 35 "C:\chandini\c#\ASP.Net\MVCAssign\Views\Employee\Login.cshtml"
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
