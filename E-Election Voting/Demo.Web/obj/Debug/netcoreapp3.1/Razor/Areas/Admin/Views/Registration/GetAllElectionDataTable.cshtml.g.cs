#pragma checksum "E:\6_DIU\DIU PROJECT\Project Final\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\Registration\GetAllElectionDataTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4654235e70b9357fc5f57a01ab3c3d0117195902"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Registration_GetAllElectionDataTable), @"mvc.1.0.view", @"/Areas/Admin/Views/Registration/GetAllElectionDataTable.cshtml")]
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
#line 1 "E:\6_DIU\DIU PROJECT\Project Final\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Demo.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\6_DIU\DIU PROJECT\Project Final\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Demo.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\6_DIU\DIU PROJECT\Project Final\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Demo.Foundation.BusinessObjects;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4654235e70b9357fc5f57a01ab3c3d0117195902", @"/Areas/Admin/Views/Registration/GetAllElectionDataTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00b2a19cb125cbda36186d0594e50b4d63244770", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Registration_GetAllElectionDataTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Registration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteSingleElection", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\6_DIU\DIU PROJECT\Project Final\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\Registration\GetAllElectionDataTable.cshtml"
  
    ViewData["Title"] = "Elections";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/css/bootstrap.min.css"">
<link rel=""stylesheet"" href=""https://cdn.datatables.net/1.10.24/css/dataTables.bootstrap5.min.css"">
<div class=""container"">
    <h1>Elections</h1>
    <table id=""example"" class=""table table-striped"" style=""width:100%"">
        <thead>
            <tr>
                <th>Election Name</th>
                <th>Election Date</th>
                <th>Action</th>                
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 20 "E:\6_DIU\DIU PROJECT\Project Final\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\Registration\GetAllElectionDataTable.cshtml"
             foreach (var elections in Model.ElectionsDataTable)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>                   \r\n                    <td>");
#nullable restore
#line 23 "E:\6_DIU\DIU PROJECT\Project Final\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\Registration\GetAllElectionDataTable.cshtml"
                   Write(elections.ElectionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "E:\6_DIU\DIU PROJECT\Project Final\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\Registration\GetAllElectionDataTable.cshtml"
                   Write(elections.ElectionDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4654235e70b9357fc5f57a01ab3c3d01171959026830", async() => {
                WriteLiteral("Delete");
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
#line 25 "E:\6_DIU\DIU PROJECT\Project Final\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\Registration\GetAllElectionDataTable.cshtml"
                                                                                                             WriteLiteral(elections.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>    \r\n                </tr>\r\n");
#nullable restore
#line 27 "E:\6_DIU\DIU PROJECT\Project Final\Final-Project\E-Election Voting\Demo.Web\Areas\Admin\Views\Registration\GetAllElectionDataTable.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n    </table>\r\n</div>\r\n<script>\r\n\r\n    $(document).ready(function () {\r\n        $(\'#example\').DataTable();\r\n    });\r\n\r\n</script>");
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