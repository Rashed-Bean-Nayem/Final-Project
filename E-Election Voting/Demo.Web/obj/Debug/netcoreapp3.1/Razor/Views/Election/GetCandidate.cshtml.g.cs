#pragma checksum "E:\6_DIU\DIU PROJECT\Project Final\Final-Project\E-Election Voting\Demo.Web\Views\Election\GetCandidate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f47b51dae70f12bbe7bf42acc401cd59341c7eff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Election_GetCandidate), @"mvc.1.0.view", @"/Views/Election/GetCandidate.cshtml")]
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
#line 3 "E:\6_DIU\DIU PROJECT\Project Final\Final-Project\E-Election Voting\Demo.Web\Views\_ViewImports.cshtml"
using Demo.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\6_DIU\DIU PROJECT\Project Final\Final-Project\E-Election Voting\Demo.Web\Views\_ViewImports.cshtml"
using Demo.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\6_DIU\DIU PROJECT\Project Final\Final-Project\E-Election Voting\Demo.Web\Views\_ViewImports.cshtml"
using Demo.Foundation.BusinessObjects;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f47b51dae70f12bbe7bf42acc401cd59341c7eff", @"/Views/Election/GetCandidate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"863371a83d966e3b3c663b269d19b7144fce8728", @"/Views/_ViewImports.cshtml")]
    public class Views_Election_GetCandidate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Election", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetAllElection", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("btnAddMore"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\6_DIU\DIU PROJECT\Project Final\Final-Project\E-Election Voting\Demo.Web\Views\Election\GetCandidate.cshtml"
  
    ViewData["Title"] = "Get Candidate";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\6_DIU\DIU PROJECT\Project Final\Final-Project\E-Election Voting\Demo.Web\Views\Election\GetCandidate.cshtml"
  
    dynamic data = ViewBag.Data;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
   /* body {
        background: -webkit-linear-gradient(left, #3931af, #00c6ff);
    }*/

    .emp-profile {
        padding: 3%;
        margin-top: 3%;
        margin-bottom: 3%;
        border-radius: 0.5rem;
        background: #fff;
    }

    .profile-img {
        text-align: center;
    }

        .profile-img img {
            width: 30%;
            height: 10%;
        }

        .profile-img .file {
            position: relative;
            overflow: hidden;
            margin-top: -20%;
            width: 70%;
            border: none;
            border-radius: 0;
            font-size: 15px;
            background: #212529b8;
        }

            .profile-img .file input {
                position: absolute;
                opacity: 0;
                right: 0;
                top: 0;
            }

    .profile-head h5 {
        color: #333;
    }

    .profile-head h6 {
        color: #0062cc;
    }

    .profile-edit-btn {
     ");
            WriteLiteral(@"   border: none;
        border-radius: 1.5rem;
        width: 70%;
        padding: 2%;
        font-weight: 600;
        color: #6c757d;
        cursor: pointer;
    }

    .proile-rating {
        font-size: 12px;
        color: #818182;
        margin-top: 5%;
    }

        .proile-rating span {
            color: #495057;
            font-size: 15px;
            font-weight: 600;
        }

    .profile-head .nav-tabs {
        margin-bottom: 5%;
    }

        .profile-head .nav-tabs .nav-link {
            font-weight: 600;
            border: none;
        }

            .profile-head .nav-tabs .nav-link.active {
                border: none;
                border-bottom: 2px solid #0062cc;
            }

    .profile-work {
        padding: 14%;
        margin-top: -15%;
    }

        .profile-work p {
            font-size: 12px;
            color: #818182;
            font-weight: 600;
            margin-top: 10%;
        }

        .profile-work a ");
            WriteLiteral(@"{
            text-decoration: none;
            color: #495057;
            font-weight: 600;
            font-size: 14px;
        }

        .profile-work ul {
            list-style: none;
        }

    .profile-tab label {
        font-weight: 600;
    }

    .profile-tab p {
        font-weight: 600;
        color: #0062cc;
    }
</style>
    <link href=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
    <script src=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js""></script>
    <script src=""//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
   
    <div class=""container emp-profile"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f47b51dae70f12bbe7bf42acc401cd59341c7eff8583", async() => {
                WriteLiteral("\r\n            <div class=\"row\">\r\n                <div class=\"col-md-4\">\r\n                    <div class=\"profile-img\">\r\n                        <img");
                BeginWriteAttribute("src", " src=\"", 3047, "\"", 3086, 1);
#nullable restore
#line 135 "E:\6_DIU\DIU PROJECT\Project Final\Final-Project\E-Election Voting\Demo.Web\Views\Election\GetCandidate.cshtml"
WriteAttributeValue("", 3053, Model.ElectionCandidate.ImageUrl, 3053, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"100\" height=\"50\"");
                BeginWriteAttribute("alt", " alt=\"", 3111, "\"", 3117, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                       \r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"profile-head\">\r\n                        <h5>\r\n                            ");
#nullable restore
#line 142 "E:\6_DIU\DIU PROJECT\Project Final\Final-Project\E-Election Voting\Demo.Web\Views\Election\GetCandidate.cshtml"
                       Write(Model.ElectionCandidate.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </h5>
                        <h6>
                            Registered Candidate
                        </h6>
                      
                        <ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
                            <li class=""nav-item"">
                                <a class=""nav-link active"" id=""home-tab"" data-toggle=""tab"" href=""#home"" role=""tab"" aria-controls=""home"" aria-selected=""true"">About</a>
                            </li>
");
                WriteLiteral("                        </ul>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-2\">\r\n");
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f47b51dae70f12bbe7bf42acc401cd59341c7eff10883", async() => {
                    WriteLiteral("<button class=\"btn btn-primary profile-button\" type=\"button\">Back</button>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-4\">\r\n                    <div class=\"profile-work\">\r\n                        <p>Documents</p>\r\n                        <div class=\"col-md-6\">\r\n");
#nullable restore
#line 168 "E:\6_DIU\DIU PROJECT\Project Final\Final-Project\E-Election Voting\Demo.Web\Views\Election\GetCandidate.cshtml"
                             foreach (var item in Model.ElectionCandidate.PdfListUrl)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <a class=\"btn btn-outline-primary\"");
                BeginWriteAttribute("href", " href=\"", 5002, "\"", 5018, 1);
#nullable restore
#line 170 "E:\6_DIU\DIU PROJECT\Project Final\Final-Project\E-Election Voting\Demo.Web\Views\Election\GetCandidate.cshtml"
WriteAttributeValue("", 5009, item.URL, 5009, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" target=\"_blank\">Read Now</a>\r\n");
#nullable restore
#line 171 "E:\6_DIU\DIU PROJECT\Project Final\Final-Project\E-Election Voting\Demo.Web\Views\Election\GetCandidate.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </div>
                    </div>
                </div>
                <div class=""col-md-8"">
                    <div class=""tab-content profile-tab"" id=""myTabContent"">
                        <div class=""tab-pane fade show active"" id=""home"" role=""tabpanel"" aria-labelledby=""home-tab"">                           
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <label>NID</label>
                                </div>
                                <div class=""col-md-6"">
                                    <p>");
#nullable restore
#line 183 "E:\6_DIU\DIU PROJECT\Project Final\Final-Project\E-Election Voting\Demo.Web\Views\Election\GetCandidate.cshtml"
                                  Write(Model.ElectionCandidate.NID);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <label>Address</label>
                                </div>
                                <div class=""col-md-6"">
                                    <p>");
#nullable restore
#line 191 "E:\6_DIU\DIU PROJECT\Project Final\Final-Project\E-Election Voting\Demo.Web\Views\Election\GetCandidate.cshtml"
                                  Write(Model.ElectionCandidate.Address);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <label>Phone</label>
                                </div>
                                <div class=""col-md-6"">
                                    <p>");
#nullable restore
#line 199 "E:\6_DIU\DIU PROJECT\Project Final\Final-Project\E-Election Voting\Demo.Web\Views\Election\GetCandidate.cshtml"
                                  Write(Model.ElectionCandidate.Mobile);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <label>About</label>
                                </div>
                                <div class=""col-md-6"">
                                    <p>");
#nullable restore
#line 207 "E:\6_DIU\DIU PROJECT\Project Final\Final-Project\E-Election Voting\Demo.Web\Views\Election\GetCandidate.cshtml"
                                  Write(Model.ElectionCandidate.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                                </div>
                            </div>
                                <div class=""row"">
                                    <div class=""col-md-6"">
                                        <label>Motto</label>
                                    </div>
                                    <div class=""col-md-6"">
                                        <p>");
#nullable restore
#line 215 "E:\6_DIU\DIU PROJECT\Project Final\Final-Project\E-Election Voting\Demo.Web\Views\Election\GetCandidate.cshtml"
                                      Write(Model.ElectionCandidate.Motto);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-md-6"">
                                        <label>Logo</label>
                                    </div>
                                    <div class=""col-md-6"">        
                                        <img");
                BeginWriteAttribute("src", " src=\"", 7834, "\"", 7877, 1);
#nullable restore
#line 223 "E:\6_DIU\DIU PROJECT\Project Final\Final-Project\E-Election Voting\Demo.Web\Views\Election\GetCandidate.cshtml"
WriteAttributeValue("", 7840, Model.ElectionCandidate.LogoImageUrl, 7840, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"100\" height=\"50\" alt=\"Profile Photo\" />\r\n                                    </div>\r\n                                </div>\r\n");
                WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>");
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
