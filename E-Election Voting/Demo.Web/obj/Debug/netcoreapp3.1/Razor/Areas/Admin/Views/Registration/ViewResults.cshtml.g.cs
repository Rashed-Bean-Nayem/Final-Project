#pragma checksum "E:\6_DIU\DIU PROJECT\Final Project\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\Registration\ViewResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bab1685fb65c60ab371e2ab2ce6f95f4b700f1e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Registration_ViewResults), @"mvc.1.0.view", @"/Areas/Admin/Views/Registration/ViewResults.cshtml")]
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
#line 1 "E:\6_DIU\DIU PROJECT\Final Project\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Demo.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\6_DIU\DIU PROJECT\Final Project\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Demo.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\6_DIU\DIU PROJECT\Final Project\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Demo.Foundation.BusinessObjects;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\6_DIU\DIU PROJECT\Final Project\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Demo.Web.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bab1685fb65c60ab371e2ab2ce6f95f4b700f1e1", @"/Areas/Admin/Views/Registration/ViewResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c79d12f445238b3316c34cb3469cf9829a65e141", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Registration_ViewResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\6_DIU\DIU PROJECT\Final Project\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\Registration\ViewResults.cshtml"
  
    ViewData["Title"] = "Election Results";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""container"">
        <h3><b>Election Results</b></h3>
        <div class=""row"">
            <table id=""example"" class=""table table-striped"" style=""width:100%"">
                <thead>
                    <tr>
                        <th>Election Name</th>
                        <th>Election Date</th>
                        <th>Winner</th>
                        <th>Vote</th>
                    </tr>
                </thead>
                <tbody>

");
#nullable restore
#line 22 "E:\6_DIU\DIU PROJECT\Final Project\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\Registration\ViewResults.cshtml"
                     foreach (var results in Model.ViewResults)
                    {

                        if (results.WinnerID != 0)
                        {
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 45 "E:\6_DIU\DIU PROJECT\Final Project\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\Registration\ViewResults.cshtml"
                               Write(results.ElectionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 46 "E:\6_DIU\DIU PROJECT\Final Project\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\Registration\ViewResults.cshtml"
                               Write(Convert.ToString(string.Format("{0:dd/MM/yyyy}", results.ElectionDate)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 47 "E:\6_DIU\DIU PROJECT\Final Project\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\Registration\ViewResults.cshtml"
                               Write(results.Winner);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 48 "E:\6_DIU\DIU PROJECT\Final Project\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\Registration\ViewResults.cshtml"
                               Write(results.WinnerVote);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                            </tr>\r\n");
#nullable restore
#line 51 "E:\6_DIU\DIU PROJECT\Final Project\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\Registration\ViewResults.cshtml"
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 69 "E:\6_DIU\DIU PROJECT\Final Project\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\Registration\ViewResults.cshtml"
                               Write(results.ElectionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 70 "E:\6_DIU\DIU PROJECT\Final Project\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\Registration\ViewResults.cshtml"
                               Write(Convert.ToString(string.Format("{0:dd/MM/yyyy}", results.ElectionDate)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 71 "E:\6_DIU\DIU PROJECT\Final Project\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\Registration\ViewResults.cshtml"
                               Write(results.Winner);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 72 "E:\6_DIU\DIU PROJECT\Final Project\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\Registration\ViewResults.cshtml"
                               Write(results.WinnerVote);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                            </tr>\r\n");
#nullable restore
#line 75 "E:\6_DIU\DIU PROJECT\Final Project\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\Registration\ViewResults.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
