#pragma checksum "C:\Users\TechCare\Desktop\C#\LKDT\LKDT\Views\Shared\_HeaderPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d0d01a7381682e89cfbbeeb62e18ebbecc285cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__HeaderPartialView), @"mvc.1.0.view", @"/Views/Shared/_HeaderPartialView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d0d01a7381682e89cfbbeeb62e18ebbecc285cf", @"/Views/Shared/_HeaderPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc353e35344e3cb1471d583b37634d6cfb4d9226", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__HeaderPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("header-searchbox"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hm-searchbox"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<header class=""main-header_area position-relative"">
    <div class=""header-top border-bottom d-none d-md-block"">
        <div class=""container"">
            <div class=""row align-items-center"">
                <div class=""col-6"">
                    <div class=""header-top-left"">
                        <ul class=""dropdown-wrap text-matterhorn"">
                            <li class=""dropdown"">
                                <button class=""btn btn-link dropdown-toggle ht-btn"" type=""button"" id=""languageButton"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                                    English
                                </button>
                                <ul class=""dropdown-menu"" aria-labelledby=""languageButton"">
                                    <li><a class=""dropdown-item"" href=""#"">English</a></li>
                                    <li><a class=""dropdown-item"" href=""#"">日本語</a></li>
                                </ul>
                            </li>
                ");
            WriteLiteral(@"            <li class=""dropdown"">
                                <button class=""btn btn-link dropdown-toggle ht-btn"" type=""button"" id=""currencyButton"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                                    USD
                                </button>
                                <ul class=""dropdown-menu"" aria-labelledby=""currencyButton"">
                                    <li><a class=""dropdown-item"" href=""#"">GBP</a></li>
                                    <li><a class=""dropdown-item"" href=""#"">ISO</a></li>
                                </ul>
                            </li>
                            <li>
                                Hotline: 
                                <a href=""tel://0946093273"">0946093273</a>
                            </li>
                        </ul>
                    </div>
                </div>
                <div class=""col-6"">
                    <div class=""header-top-right text-matterhorn"">
                   ");
            WriteLiteral(@"     <p class=""shipping mb-0"">Miễn phí vẫn chuyển đơn hàng từ <span>500,000vnđ</span></p>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""header-middle py-5"">
        <div class=""container"">
            <div class=""row align-items-center"">
                <div class=""col-lg-12"">
                    <div class=""header-middle-wrap"">
                        <a href=""/"" class=""header-logo"">
                            <img src=""assets/images/logo/LOGO.png"" alt=""Header Logo"">
                        </a>
                        <div class=""header-search-area d-none d-lg-block"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d0d01a7381682e89cfbbeeb62e18ebbecc285cf7164", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"                                <input class=""input-field"" type=""text"" placeholder=""Tìm kiếm sản phẩm"">
                                <button class=""btn btn-outline-whisper btn-primary-hover"" type=""submit""><i class=""pe-7s-search""></i></button>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <div class=""header-right"">
                            <ul>
                                <li class=""dropdown d-none d-md-block"">
                                    <button class=""btn btn-link dropdown-toggle ht-btn p-0"" type=""button"" id=""settingButton"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                                        <i class=""pe-7s-users""></i>
                                    </button>
                                    <ul class=""dropdown-menu dropdown-menu-end"" aria-labelledby=""settingButton"">
");
#nullable restore
#line 70 "C:\Users\TechCare\Desktop\C#\LKDT\LKDT\Views\Shared\_HeaderPartialView.cshtml"
                                         if (User.Identity.IsAuthenticated)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li><a class=\"dropdown-item\" href=\"/tai-khoan-cua-toi.html\">Tài khoản của tôi</a></li>\r\n                                            <li><a class=\"dropdown-item\" href=\"dang-xuat.html\">Đăng xuất</a></li>\r\n");
#nullable restore
#line 74 "C:\Users\TechCare\Desktop\C#\LKDT\LKDT\Views\Shared\_HeaderPartialView.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li><a class=\"dropdown-item\" href=\"/dang-ky.html\">Đăng ký tài khoản</a></li>\r\n                                            <li><a class=\"dropdown-item\" href=\"/dang-nhap.html\">Đăng nhập</a></li>\r\n");
#nullable restore
#line 79 "C:\Users\TechCare\Desktop\C#\LKDT\LKDT\Views\Shared\_HeaderPartialView.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </ul>
                                </li>
                                <li class=""d-none d-md-block"">
                                    <a href=""#"">
                                        <i class=""pe-7s-like""></i>
                                    </a>
                                </li>
                                <li class=""d-block d-lg-none"">
                                    <a href=""#searchBar"" class=""search-btn toolbar-btn"">
                                        <i class=""pe-7s-search""></i>
                                    </a>
                                </li>
                                ");
#nullable restore
#line 92 "C:\Users\TechCare\Desktop\C#\LKDT\LKDT\Views\Shared\_HeaderPartialView.cshtml"
                           Write(await Component.InvokeAsync("NumberCart"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                <li class=""mobile-menu_wrap d-block d-lg-none"">
                                    <a href=""#mobileMenu"" class=""mobile-menu_btn toolbar-btn pl-0"">
                                        <i class=""pe-7s-menu""></i>
                                    </a>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""main-header header-sticky"" data-bg-color=""#bac34e"">
        <div class=""container"">
            <div class=""main-header_nav position-relative"">
                <div class=""row align-items-center"">
                    <div class=""col-lg-12 d-none d-lg-block"">
                        <div class=""main-menu"">
                            <nav class=""main-nav"">
                                <ul>
                                    <li class=""drop-holder"">
                                        <a ");
            WriteLiteral(@"href=""/"">
                                            Trang chủ
                                        </a>
                                    </li>
                                    <li>
                                        <a href=""/gioi-thieu.html"">Về chúng tôi</a>
                                    </li>
                                    <li>
                                        <a href=""/shop.html"">Shop</a>
                                    </li>
                                    <li>
                                        <a href=""/page/huong-dan-mua-hang"">Hướng dẫn mua hàng</a>
                                    </li>
                                    <li>
                                        <a href=""/blogs.html"">Tin tức</a>
                                    </li>
                                    <li>
                                        <a href=""/lien-he.html"">Liên hệ</a>
                                    </li>
                                </ul>");
            WriteLiteral(@"
                            </nav>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""mobile-menu_wrapper"" id=""mobileMenu"">
        <div class=""harmic-offcanvas-body"">
            <div class=""inner-body"">
                <div class=""harmic-offcanvas-top"">
                    <a href=""#"" class=""button-close""><i class=""pe-7s-close""></i></a>
                </div>
                <div class=""offcanvas-user-info text-center px-6 pb-5"">
                    <div class="" text-silver"">
                        <p class=""shipping mb-0"">Free delivery on order over <span class=""text-primary"">$200</span></p>
                    </div>
                    <ul class=""dropdown-wrap justify-content-center text-silver"">
                        <li class=""dropdown dropup"">
                            <button class=""btn btn-link dropdown-toggle ht-btn"" type=""button"" id=""languageButtonTwo"" data-bs-toggle=""dropdown"" aria");
            WriteLiteral(@"-expanded=""false"">
                                English
                            </button>
                            <ul class=""dropdown-menu"" aria-labelledby=""languageButtonTwo"">
                                <li><a class=""dropdown-item"" href=""#"">French</a></li>
                                <li><a class=""dropdown-item"" href=""#"">Italian</a></li>
                                <li><a class=""dropdown-item"" href=""#"">Spanish</a></li>
                            </ul>
                        </li>
                        <li class=""dropdown dropup"">
                            <button class=""btn btn-link dropdown-toggle ht-btn usd-dropdown"" type=""button"" id=""currencyButtonTwo"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                                USD
                            </button>
                            <ul class=""dropdown-menu"" aria-labelledby=""currencyButtonTwo"">
                                <li><a class=""dropdown-item"" href=""#"">GBP</a></li>
                 ");
            WriteLiteral(@"               <li><a class=""dropdown-item"" href=""#"">ISO</a></li>
                            </ul>
                        </li>
                        <li class=""dropdown dropup"">
                            <button class=""btn btn-link dropdown-toggle ht-btn p-0"" type=""button"" id=""settingButtonTwo"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                                <i class=""pe-7s-users""></i>
                            </button>
                            <ul class=""dropdown-menu dropdown-menu-end"" aria-labelledby=""settingButtonTwo"">
");
#nullable restore
#line 176 "C:\Users\TechCare\Desktop\C#\LKDT\LKDT\Views\Shared\_HeaderPartialView.cshtml"
                                 if (User.Identity.IsAuthenticated)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li><a class=\"dropdown-item\" href=\"/tai-khoan-cua-toi.html\">Tài khoản của tôi</a></li>\r\n                                    <li><a class=\"dropdown-item\" href=\"dang-xuat.html\">Đăng xuất</a></li>\r\n");
#nullable restore
#line 180 "C:\Users\TechCare\Desktop\C#\LKDT\LKDT\Views\Shared\_HeaderPartialView.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li><a class=\"dropdown-item\" href=\"/dang-ky.html\">Đăng ký tài khoản</a></li>\r\n                                    <li><a class=\"dropdown-item\" href=\"/dang-nhap.html\">Đăng nhập</a></li>\r\n");
#nullable restore
#line 185 "C:\Users\TechCare\Desktop\C#\LKDT\LKDT\Views\Shared\_HeaderPartialView.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </ul>
                        </li>
                        <li>
                            <a href=""wishlist.html"">
                                <i class=""pe-7s-like""></i>
                            </a>
                        </li>
                    </ul>
                </div>
                <div class=""offcanvas-menu_area"">
                    <nav class=""offcanvas-navigation"">
                        <ul class=""mobile-menu"">
                            <li class=""menu-item-has-children"">
                                <a href=""/"">
                                    <span class=""mm-text"">
                                        Trang chủ
                                        <i class=""pe-7s-angle-down""></i>
                                    </span>
                                </a>
                            </li>
                            <li>
                                <a href=""about.html"">
                                    <s");
            WriteLiteral(@"pan class=""mm-text"">About Us</span>
                                </a>
                            </li>
                            <li class=""menu-item-has-children"">
                                <a href=""#"">
                                    <span class=""mm-text"">
                                        Shop
                                        <i class=""pe-7s-angle-down""></i>
                                    </span>
                                </a>
                                <ul class=""sub-menu"">
                                    <li class=""menu-item-has-children"">
                                        <a href=""#"">
                                            <span class=""mm-text"">
                                                Shop Layout
                                                <i class=""pe-7s-angle-down""></i>
                                            </span>
                                        </a>
                                        <ul clas");
            WriteLiteral(@"s=""sub-menu"">
                                            <li>
                                                <a href=""shop.html"">
                                                    <span class=""mm-text"">Shop Default</span>
                                                </a>
                                            </li>
                                            <li>
                                                <a href=""shop-leftsidebar.html"">
                                                    <span class=""mm-text"">Shop Left Sidebar</span>
                                                </a>
                                            </li>
                                            <li>
                                                <a href=""shop-rightsidebar.html"">
                                                    <span class=""mm-text"">Shop Right Sidebar</span>
                                                </a>
                                            </li>
             ");
            WriteLiteral(@"                               <li>
                                                <a href=""shop-list-fullwidth.html"">
                                                    <span class=""mm-text"">Shop List Fullwidth</span>
                                                </a>
                                            </li>
                                            <li>
                                                <a href=""shop-list-left-sidebar.html"">
                                                    <span class=""mm-text"">Shop List Left Sidebar</span>
                                                </a>
                                            </li>
                                            <li>
                                                <a href=""shop-list-right-sidebar.html"">
                                                    <span class=""mm-text"">Shop List Right Sidebar</span>
                                                </a>
                                            </li");
            WriteLiteral(@">
                                        </ul>
                                    </li>
                                    <li class=""menu-item-has-children"">
                                        <a href=""#"">
                                            <span class=""mm-text"">
                                                Product Style
                                                <i class=""pe-7s-angle-down""></i>
                                            </span>
                                        </a>
                                        <ul class=""sub-menu"">
                                            <li>
                                                <a href=""single-product.html"">
                                                    <span class=""mm-text"">Single Product Default</span>
                                                </a>
                                            </li>
                                            <li>
                                       ");
            WriteLiteral(@"         <a href=""single-product-group.html"">
                                                    <span class=""mm-text"">Single Product Group</span>
                                                </a>
                                            </li>
                                            <li>
                                                <a href=""single-product-variable.html"">
                                                    <span class=""mm-text"">Single Product Variable</span>
                                                </a>
                                            </li>
                                            <li>
                                                <a href=""single-product-sale.html"">
                                                    <span class=""mm-text"">Single Product Sale</span>
                                                </a>
                                            </li>
                                            <li>
                           ");
            WriteLiteral(@"                     <a href=""single-product-sticky.html"">
                                                    <span class=""mm-text"">Single Product Sticky</span>
                                                </a>
                                            </li>
                                            <li>
                                                <a href=""single-product-affiliate.html"">
                                                    <span class=""mm-text"">Single Product Affiliate</span>
                                                </a>
                                            </li>
                                        </ul>
                                    </li>
                                    <li class=""menu-item-has-children"">
                                        <a href=""#"">
                                            <span class=""mm-text"">
                                                Product Related
                                                <i cl");
            WriteLiteral(@"ass=""pe-7s-angle-down""></i>
                                            </span>
                                        </a>
                                        <ul class=""sub-menu"">
                                            <li>
                                                <a href=""my-account.html"">
                                                    <span class=""mm-text"">My Account</span>
                                                </a>
                                            </li>
                                            <li>
                                                <a href=""login-register.html"">
                                                    <span class=""mm-text"">Login | Register</span>
                                                </a>
                                            </li>
                                            <li>
                                                <a href=""cart.html"">
                                                    <sp");
            WriteLiteral(@"an class=""mm-text"">Shopping Cart</span>
                                                </a>
                                            </li>
                                            <li>
                                                <a href=""wishlist.html"">
                                                    <span class=""mm-text"">Wishlist</span>
                                                </a>
                                            </li>
                                            <li>
                                                <a href=""compare.html"">
                                                    <span class=""mm-text"">Compare</span>
                                                </a>
                                            </li>
                                            <li>
                                                <a href=""checkout.html"">
                                                    <span class=""mm-text"">Checkout</span>
                         ");
            WriteLiteral(@"                       </a>
                                            </li>
                                        </ul>
                                    </li>
                                </ul>
                            </li>
                            <li class=""menu-item-has-children"">
                                <a href=""#"">
                                    <span class=""mm-text"">
                                        Pages
                                        <i class=""pe-7s-angle-down""></i>
                                    </span>
                                </a>
                                <ul class=""sub-menu"">
                                    <li>
                                        <a href=""faq.html"">
                                            <span class=""mm-text"">Frequently Questions</span>
                                        </a>
                                    </li>
                                    <li>
                     ");
            WriteLiteral(@"                   <a href=""404.html"">
                                            <span class=""mm-text"">Error 404</span>
                                        </a>
                                    </li>
                                </ul>
                            </li>
                            <li class=""menu-item-has-children"">
                                <a href=""#"">
                                    <span class=""mm-text"">
                                        Blog
                                        <i class=""pe-7s-angle-down""></i>
                                    </span>
                                </a>
                                <ul class=""sub-menu"">
                                    <li class=""menu-item-has-children"">
                                        <a href=""#"">
                                            <span class=""mm-text"">
                                                Blog Holder
                                                <i c");
            WriteLiteral(@"lass=""pe-7s-angle-down""></i>
                                            </span>
                                        </a>
                                        <ul class=""sub-menu"">
                                            <li>
                                                <a href=""blog.html"">
                                                    <span class=""mm-text"">Blog Default</span>
                                                </a>
                                            </li>
                                            <li>
                                                <a href=""blog-left-sidebar.html"">
                                                    <span class=""mm-text"">Blog Left Sidebar</span>
                                                </a>
                                            </li>
                                            <li>
                                                <a href=""blog-right-sidebar.html"">
                                        ");
            WriteLiteral(@"            <span class=""mm-text"">Blog Right Sidebar</span>
                                                </a>
                                            </li>
                                            <li>
                                                <a href=""blog-list-left-sidebar.html"">
                                                    <span class=""mm-text"">Blog List Left Sidebar</span>
                                                </a>
                                            </li>
                                            <li>
                                                <a href=""blog-list-right-sidebar.html"">
                                                    <span class=""mm-text"">Blog List Right Sidebar</span>
                                                </a>
                                            </li>
                                        </ul>
                                    </li>
                                    <li class=""menu-item-has-children""");
            WriteLiteral(@">
                                        <a href=""#"">
                                            <span class=""mm-text"">
                                                Blog Detail Holder
                                                <i class=""pe-7s-angle-down""></i>
                                            </span>
                                        </a>
                                        <ul class=""sub-menu"">
                                            <li>
                                                <a href=""blog-detail.html"">
                                                    <span class=""mm-text"">Blog Detail Default</span>
                                                </a>
                                            </li>
                                            <li>
                                                <a href=""blog-detail-left-sidebar.html"">
                                                    <span class=""mm-text"">Blog Detail Left Sidebar</span>
      ");
            WriteLiteral(@"                                          </a>
                                            </li>
                                            <li>
                                                <a href=""blog-detail-right-sidebar.html"">
                                                    <span class=""mm-text"">Blog Detail Right Sidebar</span>
                                                </a>
                                            </li>
                                        </ul>
                                    </li>
                                </ul>
                            </li>
                            <li>
                                <a href=""contact.html"">
                                    <span class=""mm-text"">Contact</span>
                                </a>
                            </li>
                        </ul>
                    </nav>
                </div>
            </div>
        </div>
    </div>
    <div class=""offcanvas-search_wrapp");
            WriteLiteral(@"er"" id=""searchBar"">
        <div class=""harmic-offcanvas-body"">
            <div class=""container h-100"">
                <div class=""offcanvas-search"">
                    <div class=""harmic-offcanvas-top"">
                        <a href=""#"" class=""button-close""><i class=""pe-7s-close""></i></a>
                    </div>
                    <span class=""searchbox-info"">Start typing and press Enter to search</span>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d0d01a7381682e89cfbbeeb62e18ebbecc285cf34587", async() => {
                WriteLiteral("\r\n                        <input type=\"text\" placeholder=\"Search\">\r\n                        <button class=\"search-btn\" type=\"submit\"><i class=\"pe-7s-search\"></i></button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"offcanvas-minicart_wrapper\" id=\"miniCart\">\r\n        ");
#nullable restore
#line 459 "C:\Users\TechCare\Desktop\C#\LKDT\LKDT\Views\Shared\_HeaderPartialView.cshtml"
   Write(await Component.InvokeAsync("HeaderCart"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"global-overlay\"></div>\r\n</header>");
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
