#pragma checksum "E:\6_DIU\DIU FINAL PROJECT\PROJECT\Final-Project\E-Election Voting\Demo.Web\Views\Election\GetCandidate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe80805e76718d993b879dbc828fc8bf237cd167"
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
#line 3 "E:\6_DIU\DIU FINAL PROJECT\PROJECT\Final-Project\E-Election Voting\Demo.Web\Views\_ViewImports.cshtml"
using Demo.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\6_DIU\DIU FINAL PROJECT\PROJECT\Final-Project\E-Election Voting\Demo.Web\Views\_ViewImports.cshtml"
using Demo.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\6_DIU\DIU FINAL PROJECT\PROJECT\Final-Project\E-Election Voting\Demo.Web\Views\_ViewImports.cshtml"
using Demo.Foundation.BusinessObjects;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe80805e76718d993b879dbc828fc8bf237cd167", @"/Views/Election/GetCandidate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"863371a83d966e3b3c663b269d19b7144fce8728", @"/Views/_ViewImports.cshtml")]
    public class Views_Election_GetCandidate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\6_DIU\DIU FINAL PROJECT\PROJECT\Final-Project\E-Election Voting\Demo.Web\Views\Election\GetCandidate.cshtml"
  
    ViewData["Title"] = "Candidate Details";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\6_DIU\DIU FINAL PROJECT\PROJECT\Final-Project\E-Election Voting\Demo.Web\Views\Election\GetCandidate.cshtml"
  
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
            WriteLiteral(@"    border: none;
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

        .profile-work a");
            WriteLiteral(@" {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe80805e76718d993b879dbc828fc8bf237cd1679165", async() => {
                WriteLiteral("\r\n        <div class=\"row\">\r\n            <div class=\"col-md-4\">\r\n                <div class=\"profile-img\">\r\n                    <img");
                BeginWriteAttribute("src", " src=\"", 3013, "\"", 3052, 1);
#nullable restore
#line 135 "E:\6_DIU\DIU FINAL PROJECT\PROJECT\Final-Project\E-Election Voting\Demo.Web\Views\Election\GetCandidate.cshtml"
WriteAttributeValue("", 3019, Model.ElectionCandidate.ImageUrl, 3019, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"100\" height=\"50\"");
                BeginWriteAttribute("alt", " alt=\"", 3077, "\"", 3083, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                <div class=\"profile-head\">\r\n                    <h5>\r\n                        ");
#nullable restore
#line 142 "E:\6_DIU\DIU FINAL PROJECT\PROJECT\Final-Project\E-Election Voting\Demo.Web\Views\Election\GetCandidate.cshtml"
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
                WriteLiteral(@"                    </ul>
                </div>
            </div>
            <div class=""col-md-2"">
                <input type=""button"" onclick=""history.go(-1)"" value=""Back"" />
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-4"">
                <div class=""profile-work"">
                    <p><b>Documents</b></p>
                    <div class=""col-md-8"">
");
#nullable restore
#line 167 "E:\6_DIU\DIU FINAL PROJECT\PROJECT\Final-Project\E-Election Voting\Demo.Web\Views\Election\GetCandidate.cshtml"
                         foreach (var item in Model.ElectionCandidate.PdfListUrl)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <a class=\"btn btn-outline-primary\"");
                BeginWriteAttribute("href", " href=\"", 4589, "\"", 4605, 1);
#nullable restore
#line 169 "E:\6_DIU\DIU FINAL PROJECT\PROJECT\Final-Project\E-Election Voting\Demo.Web\Views\Election\GetCandidate.cshtml"
WriteAttributeValue("", 4596, item.URL, 4596, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" target=\"_blank\">");
#nullable restore
#line 169 "E:\6_DIU\DIU FINAL PROJECT\PROJECT\Final-Project\E-Election Voting\Demo.Web\Views\Election\GetCandidate.cshtml"
                                                                                           Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                            <p></p>\r\n");
#nullable restore
#line 171 "E:\6_DIU\DIU FINAL PROJECT\PROJECT\Final-Project\E-Election Voting\Demo.Web\Views\Election\GetCandidate.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </div>
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
#line 183 "E:\6_DIU\DIU FINAL PROJECT\PROJECT\Final-Project\E-Election Voting\Demo.Web\Views\Election\GetCandidate.cshtml"
                              Write(Model.ElectionCandidate.NID);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <label>Date Of Birtg</label>
                            </div>
                            <div class=""col-md-6"">
                                <p>");
#nullable restore
#line 191 "E:\6_DIU\DIU FINAL PROJECT\PROJECT\Final-Project\E-Election Voting\Demo.Web\Views\Election\GetCandidate.cshtml"
                              Write(Model.ElectionCandidate.DateOfBirth);

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
#line 199 "E:\6_DIU\DIU FINAL PROJECT\PROJECT\Final-Project\E-Election Voting\Demo.Web\Views\Election\GetCandidate.cshtml"
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
#line 207 "E:\6_DIU\DIU FINAL PROJECT\PROJECT\Final-Project\E-Election Voting\Demo.Web\Views\Election\GetCandidate.cshtml"
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
#line 215 "E:\6_DIU\DIU FINAL PROJECT\PROJECT\Final-Project\E-Election Voting\Demo.Web\Views\Election\GetCandidate.cshtml"
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
#line 223 "E:\6_DIU\DIU FINAL PROJECT\PROJECT\Final-Project\E-Election Voting\Demo.Web\Views\Election\GetCandidate.cshtml"
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
                BeginWriteAttribute("src", " src=\"", 7547, "\"", 7590, 1);
#nullable restore
#line 231 "E:\6_DIU\DIU FINAL PROJECT\PROJECT\Final-Project\E-Election Voting\Demo.Web\Views\Election\GetCandidate.cshtml"
WriteAttributeValue("", 7553, Model.ElectionCandidate.LogoImageUrl, 7553, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"100\" height=\"50\" alt=\"Profile Photo\" />\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fe80805e76718d993b879dbc828fc8bf237cd16719410", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fe80805e76718d993b879dbc828fc8bf237cd16720525", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe80805e76718d993b879dbc828fc8bf237cd16721640", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe80805e76718d993b879dbc828fc8bf237cd16722680", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
