#pragma checksum "C:\Users\TechCare\Desktop\C#\LKDT\LKDT\Views\TinTuc\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdbda7e4dadb177d7a05c03f02df91663f3a2073"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TinTuc_Details), @"mvc.1.0.view", @"/Views/TinTuc/Details.cshtml")]
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
#line 1 "C:\Users\TechCare\Desktop\C#\LKDT\LKDT\Views\_ViewImports.cshtml"
using LKDT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TechCare\Desktop\C#\LKDT\LKDT\Views\_ViewImports.cshtml"
using LKDT.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdbda7e4dadb177d7a05c03f02df91663f3a2073", @"/Views/TinTuc/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc353e35344e3cb1471d583b37634d6cfb4d9226", @"/Views/_ViewImports.cshtml")]
    public class Views_TinTuc_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LKDT.Models.TinTuc>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-full"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\TechCare\Desktop\C#\LKDT\LKDT\Views\TinTuc\Details.cshtml"
   ViewData["Title"] = Model.TieuDe;
                Layout = "~/Views/Shared/_Layout.cshtml";
                string url = $"/tin-tuc/{Model.Url}-{Model.MaTinTuc}.html";
                List<TinTuc> Baivietlienquan = ViewBag.Baivietlienquan; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<main class=""main-content"">
    <div class=""breadcrumb-area breadcrumb-height"" data-bg-image=""assets/images/breadcrumb/bg/1-1-1920x373.jpg"">
        <div class=""container h-100"">
            <div class=""row h-100"">
                <div class=""col-lg-12"">
                    <div class=""breadcrumb-item"">
                        <h1 class=""breadcrumb-heading"">");
#nullable restore
#line 12 "C:\Users\TechCare\Desktop\C#\LKDT\LKDT\Views\TinTuc\Details.cshtml"
                                                  Write(Model.TieuDe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n                        <ul>\n                            <li>\n                                <a href=\"/\">Trang chủ <i class=\"pe-7s-angle-right\"></i></a>\n                            </li>\n                            <li>");
#nullable restore
#line 17 "C:\Users\TechCare\Desktop\C#\LKDT\LKDT\Views\TinTuc\Details.cshtml"
                           Write(Model.TieuDe);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""blog-area section-space-y-axis-100"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""blog-detail-item"">
                        <div class=""blog-img"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cdbda7e4dadb177d7a05c03f02df91663f3a20735313", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1322, "~/images/news/", 1322, 14, true);
#nullable restore
#line 30 "C:\Users\TechCare\Desktop\C#\LKDT\LKDT\Views\TinTuc\Details.cshtml"
AddHtmlAttributeValue("", 1336, Model.Avatar, 1336, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 30 "C:\Users\TechCare\Desktop\C#\LKDT\LKDT\Views\TinTuc\Details.cshtml"
AddHtmlAttributeValue("", 1356, Model.TieuDe, 1356, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <div class=""blog-content text-start pb-0"">
                            <div class=""blog-meta text-dim-gray pb-3"">
                                <ul>
                                    <li class=""date""><i class=""fa fa-calendar-o me-2""></i>May 21, 2021</li>
                                    <li>
                                        <span class=""comments me-3"">
                                            <a href=""javascript:void(0)"">2 Comments</a>
                                        </span>
                                        <span class=""link-share"">
                                            <a href=""javascript:void(0)"">Share</a>
                                        </span>
                                    </li>
                                </ul>
                            </div>
                            <h5 class=""title mb-4"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 2330, "\"", 2341, 1);
#nullable restore
#line 47 "C:\Users\TechCare\Desktop\C#\LKDT\LKDT\Views\TinTuc\Details.cshtml"
WriteAttributeValue("", 2337, url, 2337, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 47 "C:\Users\TechCare\Desktop\C#\LKDT\LKDT\Views\TinTuc\Details.cshtml"
                                          Write(Model.TieuDe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                            </h5>\n                            ");
#nullable restore
#line 49 "C:\Users\TechCare\Desktop\C#\LKDT\LKDT\Views\TinTuc\Details.cshtml"
                       Write(Html.Raw(Model.NoiDung));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            <div class=""tag-wtih-social"">
                                <div class=""tag"">
                                    <span class=""title text-primary"">Tags:</span>
                                    <ul>
                                        <li>
                                            <a href=""javascript:void(0)"">Blockchain,</a>
                                        </li>
                                        <li>
                                            <a href=""javascript:void(0)"">Máy tính,</a>
                                        </li>
                                        <li>
                                            <a href=""javascript:void(0)"">Smart phone</a>
                                        </li>
                                    </ul>
                                </div>
                                <div class=""social-link"">
                                    <ul>
                                        <li>
                             ");
            WriteLiteral(@"               <a href=""javascript:void(0)"">
                                                <i class=""fa fa-facebook""></i>
                                            </a>
                                        </li>
                                        <li>
                                            <a href=""javascript:void(0)"">
                                                <i class=""fa fa-pinterest-p""></i>
                                            </a>
                                        </li>
                                        <li>
                                            <a href=""javascript:void(0)"">
                                                <i class=""fa fa-dribbble""></i>
                                            </a>
                                        </li>
                                    </ul>
                                </div>
                            </div>

                            <div class=""feedback-area section-space-top-55"">
                      ");
            WriteLiteral(@"          <h4 class=""heading mb-1"">Bài viết liên quan</h4>
                                <hr />
                                <div class=""widgets-area mb-9"">
                                    <div class=""widgets-item"">
                                        <div class=""swiper-container widgets-list-slider style-2 swiper-container-multirow swiper-container-initialized swiper-container-horizontal swiper-container-pointer-events"">
                                            <div class=""swiper-wrapper"" id=""swiper-wrapper-62104b1dfbb1d3188"" aria-live=""polite"" style=""width: 288px; transform: translate3d(0px, 0px, 0px);"">
");
#nullable restore
#line 93 "C:\Users\TechCare\Desktop\C#\LKDT\LKDT\Views\TinTuc\Details.cshtml"
                                                 if (Baivietlienquan != null && Baivietlienquan.Count() > 0)
                                                {
                                                    foreach (var item in Baivietlienquan)
                                                    {
                                                        string _url = $"/tin-tuc/{item.Url}-{item.MaTinTuc}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""swiper-slide"" role=""group"" aria-label=""3 / 3"" style=""margin-top: 25px; width: 263px; margin-right: 25px;"">
                                        <div class=""product-list-item"">
                                            <div class=""product-img img-zoom-effect"">
                                                <a");
            BeginWriteAttribute("href", " href=\"", 5906, "\"", 5918, 1);
#nullable restore
#line 101 "C:\Users\TechCare\Desktop\C#\LKDT\LKDT\Views\TinTuc\Details.cshtml"
WriteAttributeValue("", 5913, _url, 5913, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cdbda7e4dadb177d7a05c03f02df91663f3a207313339", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6000, "~/images/news/", 6000, 14, true);
#nullable restore
#line 102 "C:\Users\TechCare\Desktop\C#\LKDT\LKDT\Views\TinTuc\Details.cshtml"
AddHtmlAttributeValue("", 6014, item.Avatar, 6014, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 102 "C:\Users\TechCare\Desktop\C#\LKDT\LKDT\Views\TinTuc\Details.cshtml"
AddHtmlAttributeValue("", 6033, item.TieuDe, 6033, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                </a>
                                            </div>
                                            <div class=""product-content"">
                                                <h5 class=""title mb-3"">
                                                    <a");
            BeginWriteAttribute("href", " href=\"", 6352, "\"", 6364, 1);
#nullable restore
#line 107 "C:\Users\TechCare\Desktop\C#\LKDT\LKDT\Views\TinTuc\Details.cshtml"
WriteAttributeValue("", 6359, _url, 6359, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 107 "C:\Users\TechCare\Desktop\C#\LKDT\LKDT\Views\TinTuc\Details.cshtml"
                                                               Write(item.TieuDe);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                                </h5>
                                                <div class=""blog-meta text-manatee pb-1"">
                                                    <ul>
                                                        <li class=""date"">");
#nullable restore
#line 111 "C:\Users\TechCare\Desktop\C#\LKDT\LKDT\Views\TinTuc\Details.cshtml"
                                                                    Write(item.NgayTao);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                                                    </ul>
                                                </div>
                                            </div>
                                        </div>
                                    </div>");
#nullable restore
#line 116 "C:\Users\TechCare\Desktop\C#\LKDT\LKDT\Views\TinTuc\Details.cshtml"
                                          }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LKDT.Models.TinTuc> Html { get; private set; }
    }
}
#pragma warning restore 1591
