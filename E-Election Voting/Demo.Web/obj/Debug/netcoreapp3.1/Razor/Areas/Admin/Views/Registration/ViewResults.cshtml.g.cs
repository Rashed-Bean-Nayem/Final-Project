#pragma checksum "E:\6_DIU\DIU FINAL PROJECT\PROJECT\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\Registration\ViewResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d470314ec53fede6b2103c130e0b0586bbfe40d6"
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
#line 1 "E:\6_DIU\DIU FINAL PROJECT\PROJECT\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Demo.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\6_DIU\DIU FINAL PROJECT\PROJECT\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Demo.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\6_DIU\DIU FINAL PROJECT\PROJECT\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Demo.Foundation.BusinessObjects;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\6_DIU\DIU FINAL PROJECT\PROJECT\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Demo.Web.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d470314ec53fede6b2103c130e0b0586bbfe40d6", @"/Areas/Admin/Views/Registration/ViewResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c79d12f445238b3316c34cb3469cf9829a65e141", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Registration_ViewResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Candidate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetCandidate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\6_DIU\DIU FINAL PROJECT\PROJECT\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\Registration\ViewResults.cshtml"
  
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
                        <th><h5><b>Election Name</b></h5></th>
                        <th><h5><b>Election Date</b></h5></th>
                        <th><h5><b>Winner</b></h5></th>
                        <th><h5><b>Vote</b></h5></th>
                    </tr>
                </thead>
                <tbody>

");
#nullable restore
#line 22 "E:\6_DIU\DIU FINAL PROJECT\PROJECT\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\Registration\ViewResults.cshtml"
                     foreach (var results in Model.ViewResults)
                    {

                        if (results.WinnerID != 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td><b>");
#nullable restore
#line 28 "E:\6_DIU\DIU FINAL PROJECT\PROJECT\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\Registration\ViewResults.cshtml"
                                  Write(results.ElectionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                                <td><b>");
#nullable restore
#line 29 "E:\6_DIU\DIU FINAL PROJECT\PROJECT\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\Registration\ViewResults.cshtml"
                                  Write(Convert.ToString(string.Format("{0:dd/MM/yyyy}", results.ElectionDate)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                                <td><b>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d470314ec53fede6b2103c130e0b0586bbfe40d66785", async() => {
#nullable restore
#line 30 "E:\6_DIU\DIU FINAL PROJECT\PROJECT\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\Registration\ViewResults.cshtml"
                                                                                                                                          Write(results.Winner);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "E:\6_DIU\DIU FINAL PROJECT\PROJECT\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\Registration\ViewResults.cshtml"
                                                                                                                 WriteLiteral(results.WinnerID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</b></td>\r\n                                <td><b>");
#nullable restore
#line 31 "E:\6_DIU\DIU FINAL PROJECT\PROJECT\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\Registration\ViewResults.cshtml"
                                  Write(results.WinnerVote);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                            </tr>\r\n");
#nullable restore
#line 33 "E:\6_DIU\DIU FINAL PROJECT\PROJECT\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\Registration\ViewResults.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td><b>");
#nullable restore
#line 37 "E:\6_DIU\DIU FINAL PROJECT\PROJECT\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\Registration\ViewResults.cshtml"
                                  Write(results.ElectionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                                <td><b>");
#nullable restore
#line 38 "E:\6_DIU\DIU FINAL PROJECT\PROJECT\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\Registration\ViewResults.cshtml"
                                  Write(Convert.ToString(string.Format("{0:dd/MM/yyyy}", results.ElectionDate)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                                <td><b>");
#nullable restore
#line 39 "E:\6_DIU\DIU FINAL PROJECT\PROJECT\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\Registration\ViewResults.cshtml"
                                  Write(results.Winner);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                                <td><b>");
#nullable restore
#line 40 "E:\6_DIU\DIU FINAL PROJECT\PROJECT\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\Registration\ViewResults.cshtml"
                                  Write(results.WinnerVote);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                            </tr> \r\n");
#nullable restore
#line 42 "E:\6_DIU\DIU FINAL PROJECT\PROJECT\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\Registration\ViewResults.cshtml"
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
