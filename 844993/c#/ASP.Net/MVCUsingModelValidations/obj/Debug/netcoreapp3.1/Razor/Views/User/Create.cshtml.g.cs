#pragma checksum "C:\chandini\c#\ASP.Net\MVCUsingModelValidations\Views\User\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "546156328850debcf0db25eeac06e605007d9418"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Create), @"mvc.1.0.view", @"/Views/User/Create.cshtml")]
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
#line 1 "C:\chandini\c#\ASP.Net\MVCUsingModelValidations\Views\_ViewImports.cshtml"
using MVCUsingModelValidations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\chandini\c#\ASP.Net\MVCUsingModelValidations\Views\_ViewImports.cshtml"
using MVCUsingModelValidations.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"546156328850debcf0db25eeac06e605007d9418", @"/Views/User/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2752636966b76054d577ec495af88b364c1f411e", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVCUsingModelValidations.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\chandini\c#\ASP.Net\MVCUsingModelValidations\Views\User\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Create</h1>\r\n");
#nullable restore
#line 8 "C:\chandini\c#\ASP.Net\MVCUsingModelValidations\Views\User\Create.cshtml"
 using (Html.BeginForm())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-bordered\">\r\n    <tr>\r\n");
            WriteLiteral("        <td>");
#nullable restore
#line 13 "C:\chandini\c#\ASP.Net\MVCUsingModelValidations\Views\User\Create.cshtml"
       Write(Html.DisplayNameFor(m=>m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 14 "C:\chandini\c#\ASP.Net\MVCUsingModelValidations\Views\User\Create.cshtml"
       Write(Html.TextBoxFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 15 "C:\chandini\c#\ASP.Net\MVCUsingModelValidations\Views\User\Create.cshtml"
       Write(Html.ValidationMessageFor(m=>m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n");
            WriteLiteral("        <td>");
#nullable restore
#line 19 "C:\chandini\c#\ASP.Net\MVCUsingModelValidations\Views\User\Create.cshtml"
       Write(Html.DisplayNameFor(m => m.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 20 "C:\chandini\c#\ASP.Net\MVCUsingModelValidations\Views\User\Create.cshtml"
       Write(Html.TextBoxFor(m => m.DOB, null, new { @type = "Date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>  ");
            WriteLiteral("\r\n        <td>");
#nullable restore
#line 21 "C:\chandini\c#\ASP.Net\MVCUsingModelValidations\Views\User\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n");
            WriteLiteral("        <td>");
#nullable restore
#line 25 "C:\chandini\c#\ASP.Net\MVCUsingModelValidations\Views\User\Create.cshtml"
       Write(Html.DisplayNameFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 26 "C:\chandini\c#\ASP.Net\MVCUsingModelValidations\Views\User\Create.cshtml"
       Write(Html.TextBoxFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 27 "C:\chandini\c#\ASP.Net\MVCUsingModelValidations\Views\User\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n");
            WriteLiteral("        <td>");
#nullable restore
#line 31 "C:\chandini\c#\ASP.Net\MVCUsingModelValidations\Views\User\Create.cshtml"
       Write(Html.DisplayNameFor(m => m.Mobileno));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 32 "C:\chandini\c#\ASP.Net\MVCUsingModelValidations\Views\User\Create.cshtml"
       Write(Html.TextBoxFor(m => m.Mobileno));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 33 "C:\chandini\c#\ASP.Net\MVCUsingModelValidations\Views\User\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.Mobileno));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n");
            WriteLiteral("        <td>");
#nullable restore
#line 37 "C:\chandini\c#\ASP.Net\MVCUsingModelValidations\Views\User\Create.cshtml"
       Write(Html.DisplayNameFor(m => m.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("        <td>");
#nullable restore
#line 39 "C:\chandini\c#\ASP.Net\MVCUsingModelValidations\Views\User\Create.cshtml"
       Write(Html.DropDownListFor(m => m.Country, ViewBag.Country as SelectList));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("    </tr>\r\n    <tr>\r\n");
            WriteLiteral("        <td>");
#nullable restore
#line 44 "C:\chandini\c#\ASP.Net\MVCUsingModelValidations\Views\User\Create.cshtml"
       Write(Html.DisplayNameFor(m => m.Uname));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 45 "C:\chandini\c#\ASP.Net\MVCUsingModelValidations\Views\User\Create.cshtml"
       Write(Html.TextBoxFor(m => m.Uname));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 46 "C:\chandini\c#\ASP.Net\MVCUsingModelValidations\Views\User\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.Pwd));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n");
            WriteLiteral("        <td>");
#nullable restore
#line 50 "C:\chandini\c#\ASP.Net\MVCUsingModelValidations\Views\User\Create.cshtml"
       Write(Html.DisplayNameFor(m => m.Pwd));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 51 "C:\chandini\c#\ASP.Net\MVCUsingModelValidations\Views\User\Create.cshtml"
       Write(Html.TextBoxFor(m => m.Pwd));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 52 "C:\chandini\c#\ASP.Net\MVCUsingModelValidations\Views\User\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.Pwd));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td colspan=\"2\">\r\n            <input type=\"submit\" value=\"Register\" />\r\n        </td>\r\n    </tr>\r\n   \r\n</table>\r\n");
#nullable restore
#line 61 "C:\chandini\c#\ASP.Net\MVCUsingModelValidations\Views\User\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVCUsingModelValidations.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591