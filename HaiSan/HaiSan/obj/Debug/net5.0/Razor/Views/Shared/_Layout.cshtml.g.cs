#pragma checksum "C:\Users\Admin\Documents\HaiSan_Jay\DoAnWeb\HaiSan\HaiSan\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a23bd50bf2b0e8f6abd3eae1786e6769686090c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\Admin\Documents\HaiSan_Jay\DoAnWeb\HaiSan\HaiSan\Views\_ViewImports.cshtml"
using HaiSan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Documents\HaiSan_Jay\DoAnWeb\HaiSan\HaiSan\Views\_ViewImports.cshtml"
using HaiSan.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Admin\Documents\HaiSan_Jay\DoAnWeb\HaiSan\HaiSan\Views\Shared\_Layout.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Documents\HaiSan_Jay\DoAnWeb\HaiSan\HaiSan\Views\Shared\_Layout.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a23bd50bf2b0e8f6abd3eae1786e6769686090c", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65ac9318954244554f7f38e524e4bfb3e204f6b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("modal-content modal-body border-0 p-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Admin\Documents\HaiSan_Jay\DoAnWeb\HaiSan\HaiSan\Views\Shared\_Layout.cshtml"
  
    bool isAuth = User.Identity.IsAuthenticated;
    string fullName;
    if (isAuth)
    {
        fullName = User.Claims.FirstOrDefault(c => c.Type == "Name").Value;
    }
    var session = HttpContextAccessor.HttpContext.Session;
    string jsoncart = session.GetString(HaiSan.Controllers.CartController.CARTKEY);

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"vi\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a23bd50bf2b0e8f6abd3eae1786e6769686090c5453", async() => {
                WriteLiteral(@"
    <title>Zay Shop eCommerce HTML CSS Template</title>
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">

    <link rel=""apple-touch-icon"" href=""/assets/img/apple-icon.png"">
    <link rel=""shortcut icon"" type=""image/x-icon"" href=""/assets/img/favicon.ico"">

    <link rel=""stylesheet"" href=""/assets/css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""/assets/css/templatemo.css"">
    <link rel=""stylesheet"" href=""/assets/css/custom.css"">

    <!-- Load fonts style after rendering the layout styles -->
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css2?family=Roboto:wght@100;200;300;400;500;700;900&display=swap"">
    <link rel=""stylesheet"" href=""/assets/css/fontawesome.min.css"">
    <!-- Slick -->
    <link rel=""stylesheet"" type=""text/css"" href=""/assets/css/slick.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/assets/css/slick-theme.css"">
    <!--

    <!--

    TemplateMo 559 Zay Shop

    https://templatem");
                WriteLiteral("o.com/tm-559-zay-shop\r\n\r\n    -->\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a23bd50bf2b0e8f6abd3eae1786e6769686090c7567", async() => {
                WriteLiteral(@"
    <!-- Start Top Nav -->
    <nav class=""navbar navbar-expand-lg bg-dark navbar-light d-none d-lg-block"" id=""templatemo_nav_top"">
        <div class=""container text-light"">
            <div class=""w-100 d-flex justify-content-between"">
                <div>
                    <i class=""fa fa-envelope mx-2""></i>
                    <a class=""navbar-sm-brand text-light text-decoration-none"" href=""mailto:info@company.com"">info@company.com</a>
                    <i class=""fa fa-phone mx-2""></i>
                    <a class=""navbar-sm-brand text-light text-decoration-none"" href=""tel:010-020-0340"">010-020-0340</a>
                </div>
                <div>
                    <a class=""text-light"" href=""https://fb.com/templatemo"" target=""_blank"" rel=""sponsored""><i class=""fab fa-facebook-f fa-sm fa-fw me-2""></i></a>
                    <a class=""text-light"" href=""https://www.instagram.com/"" target=""_blank""><i class=""fab fa-instagram fa-sm fa-fw me-2""></i></a>
                    <a class=""text-l");
                WriteLiteral(@"ight"" href=""https://twitter.com/"" target=""_blank""><i class=""fab fa-twitter fa-sm fa-fw me-2""></i></a>
                    <a class=""text-light"" href=""https://www.linkedin.com/"" target=""_blank""><i class=""fab fa-linkedin fa-sm fa-fw""></i></a>
                </div>
            </div>
        </div>
    </nav>
    <!-- Close Top Nav -->
    <!-- Header -->
    <nav class=""navbar navbar-expand-lg navbar-light shadow"">
        <div class=""container d-flex justify-content-between align-items-center"">

            <a class=""navbar-brand text-success logo h1 align-self-center"" href=""index.html"">
                Hải sản Zay
            </a>

            <button class=""navbar-toggler border-0"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#templatemo_main_nav"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>

            <div class=""align-self-center collapse navbar-co");
                WriteLiteral(@"llapse flex-fill  d-lg-flex justify-content-lg-between"" id=""templatemo_main_nav"">
                <div class=""flex-fill"">
                    <ul class=""nav navbar-nav d-flex justify-content-between mx-lg-auto"">
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""index.html"">Trang chủ</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""about.html"">Giới thiệu</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""shop.html"">Mặt hàng</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""contact.html"">Liên hệ</a>
                        </li>
                    </ul>
                </div>
                <div class=""navbar align-self-center d-flex"">
                    <div class=""d-lg-none flex-sm-fill mt-3 ");
                WriteLiteral(@"mb-4 col-7 col-sm-auto pr-3"">
                        <div class=""input-group"">
                            <input type=""text"" class=""form-control"" id=""inputMobileSearch"" placeholder=""Search ..."">
                            <div class=""input-group-text"">
                                <i class=""fa fa-fw fa-search""></i>
                            </div>
                        </div>
                    </div>
                    <a class=""nav-icon d-none d-lg-inline"" href=""#"" data-bs-toggle=""modal"" data-bs-target=""#templatemo_search"">
                        <i class=""fa fa-fw fa-search text-dark mr-2""></i>
                    </a>
                    <a class=""nav-icon position-relative text-decoration-none"" href=""#"">
                        <i class=""fa fa-fw fa-cart-arrow-down text-dark mr-1""></i>
");
#nullable restore
#line 110 "C:\Users\Admin\Documents\HaiSan_Jay\DoAnWeb\HaiSan\HaiSan\Views\Shared\_Layout.cshtml"
                         if (jsoncart != null)
                        {
                            var cart = JsonConvert.DeserializeObject<List<HaiSan.Models.View.CartItem>>(jsoncart);

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <span class=\"position-absolute top-0 left-100 translate-middle badge rounded-pill bg-light text-dark\">");
#nullable restore
#line 113 "C:\Users\Admin\Documents\HaiSan_Jay\DoAnWeb\HaiSan\HaiSan\Views\Shared\_Layout.cshtml"
                                                                                                                             Write(cart.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n");
#nullable restore
#line 114 "C:\Users\Admin\Documents\HaiSan_Jay\DoAnWeb\HaiSan\HaiSan\Views\Shared\_Layout.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </a>\r\n");
#nullable restore
#line 116 "C:\Users\Admin\Documents\HaiSan_Jay\DoAnWeb\HaiSan\HaiSan\Views\Shared\_Layout.cshtml"
                     if (isAuth)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <a class=""nav-icon position-relative text-decoration-none"" href=""#"">
                            <i class=""fa fa-fw fa-user text-dark mr-3""></i>
                            <span class=""position-absolute top-0 left-100 translate-middle badge rounded-pill bg-light text-dark"">+99</span>
                        </a>
");
#nullable restore
#line 122 "C:\Users\Admin\Documents\HaiSan_Jay\DoAnWeb\HaiSan\HaiSan\Views\Shared\_Layout.cshtml"

                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a class=\"nav-icon position-relative text-decoration-none\" href=\"#\">\r\n                            <i class=\"fa fa-fw fa-sign-in-alt text-primary mr-3\"></i>\r\n                        </a>\r\n");
#nullable restore
#line 129 "C:\Users\Admin\Documents\HaiSan_Jay\DoAnWeb\HaiSan\HaiSan\Views\Shared\_Layout.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </div>
            </div>

        </div>
    </nav>
    <!-- Close Header -->
    <!-- Modal -->
    <div class=""modal fade bg-white"" id=""templatemo_search"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog modal-lg"" role=""document"">
            <div class=""w-100 pt-1 mb-5 text-right"">
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a23bd50bf2b0e8f6abd3eae1786e6769686090c15005", async() => {
                    WriteLiteral(@"
                <div class=""input-group mb-2"">
                    <input type=""text"" class=""form-control"" id=""inputModalSearch"" name=""q"" placeholder=""Search ..."">
                    <button type=""submit"" class=""input-group-text bg-success text-light"">
                        <i class=""fa fa-fw fa-search text-white""></i>
                    </button>
                </div>
            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    ");
#nullable restore
#line 153 "C:\Users\Admin\Documents\HaiSan_Jay\DoAnWeb\HaiSan\HaiSan\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <!-- Start Footer -->
    <footer class=""bg-dark"" id=""tempaltemo_footer"">
        <div class=""container"">
            <div class=""row"">

                <div class=""col-md-4 pt-5"">
                    <h2 class=""h2 text-success border-bottom pb-3 border-light logo"">Hải Sản Zay</h2>
                    <ul class=""list-unstyled text-light footer-link-list"">
                        <li>
                            <i class=""fas fa-map-marker-alt fa-fw""></i> 123 Consectetur at ligula 10660
                        </li>
                        <li>
                            <i class=""fa fa-phone fa-fw""></i>
                            <a class=""text-decoration-none"" href=""tel:010-020-0340"">010-020-0340</a>
                        </li>
                        <li>
                            <i class=""fa fa-envelope fa-fw""></i>
                            <a class=""text-decoration-none"" href=""mailto:info@company.com"">info@company.com</a>
                        </li>
                  ");
                WriteLiteral(@"  </ul>
                </div>

                <div class=""col-md-4 pt-5"">
                    <h2 class=""h2 text-light border-bottom pb-3 border-light"">Sản phẩm</h2>
                    <ul class=""list-unstyled text-light footer-link-list"">
                        <li><a class=""text-decoration-none"" href=""#"">Cá</a></li>
                        <li><a class=""text-decoration-none"" href=""#"">Tôm</a></li>
                        <li><a class=""text-decoration-none"" href=""#"">Mực</a></li>
                    </ul>
                </div>

                <div class=""col-md-4 pt-5"">
                    <h2 class=""h2 text-light border-bottom pb-3 border-light"">Thông tin thêm</h2>
                    <ul class=""list-unstyled text-light footer-link-list"">
                        <li><a class=""text-decoration-none"" href=""#"">Trang chủ</a></li>
                        <li><a class=""text-decoration-none"" href=""#"">Giới thiệu</a></li>
                        <li><a class=""text-decoration-none"" href=""#"">Địa ch");
                WriteLiteral(@"ỉ</a></li>
                        <li><a class=""text-decoration-none"" href=""#"">FAQs</a></li>
                        <li><a class=""text-decoration-none"" href=""#"">Liên hệ</a></li>
                    </ul>
                </div>

            </div>

            <div class=""row text-light mb-4"">
                <div class=""col-12 mb-3"">
                    <div class=""w-100 my-3 border-top border-light""></div>
                </div>
                <div class=""col-auto me-auto"">
                    <ul class=""list-inline text-left footer-icons"">
                        <li class=""list-inline-item border border-light rounded-circle text-center"">
                            <a class=""text-light text-decoration-none"" target=""_blank"" href=""http://facebook.com/""><i class=""fab fa-facebook-f fa-lg fa-fw""></i></a>
                        </li>
                        <li class=""list-inline-item border border-light rounded-circle text-center"">
                            <a class=""text-light text-deco");
                WriteLiteral(@"ration-none"" target=""_blank"" href=""https://www.instagram.com/""><i class=""fab fa-instagram fa-lg fa-fw""></i></a>
                        </li>
                        <li class=""list-inline-item border border-light rounded-circle text-center"">
                            <a class=""text-light text-decoration-none"" target=""_blank"" href=""https://twitter.com/""><i class=""fab fa-twitter fa-lg fa-fw""></i></a>
                        </li>
                        <li class=""list-inline-item border border-light rounded-circle text-center"">
                            <a class=""text-light text-decoration-none"" target=""_blank"" href=""https://www.linkedin.com/""><i class=""fab fa-linkedin fa-lg fa-fw""></i></a>
                        </li>
                    </ul>
                </div>
                <div class=""col-auto"">
                    <label class=""sr-only"" for=""subscribeEmail"">Email address</label>
                    <div class=""input-group mb-2"">
                        <input type=""text"" class=""fo");
                WriteLiteral(@"rm-control bg-dark border-light"" id=""subscribeEmail"" placeholder=""Email address"">
                        <div class=""input-group-text btn-success text-light"">Subscribe</div>
                    </div>
                </div>
            </div>
        </div>

        <div class=""w-100 bg-black py-3"">
            <div class=""container"">
                <div class=""row pt-2"">
                    <div class=""col-12"">
                        <p class=""text-left text-light"">
                            Copyright &copy; 2021 Company Name | Designed by <a rel=""sponsored"" href=""https://templatemo.com"" target=""_blank"">TemplateMo</a>
                        </p>
                    </div>
                </div>
            </div>
        </div>

    </footer>
    <!-- End Footer -->
    <!-- Start Script -->
    <script src=""/assets/js/jquery-1.11.0.min.js""></script>
    <script src=""/assets/js/jquery-migrate-1.2.1.min.js""></script>
    <script src=""/assets/js/bootstrap.bundle.min.js""></script>");
                WriteLiteral(@"
    <script src=""/assets/js/templatemo.js""></script>
    <script src=""/assets/js/custom.js""></script>
    <!-- End Script -->
    <!-- Start Slider Script -->
    <script src=""/assets/js/slick.min.js""></script>
    <script type=""text/javascript"">
        function addCart(prod, sl) {
            var data = { MaSP: prod, Sl: sl };
            $.ajax({
                url: '/cart/addtocart',
                type: ""post"",
                contentType: 'application/json',
                data: JSON.stringify(data),
                dataType: 'json',
                success: function (result) {
                    $('#tbContent').empty();
                    $('#tbModal').modal('show');
                    var str = '<i class=""fa fa-check text-success"" style=""font-size: 60px;""></i>'
                        + '<h2 class=""text-success"">Thêm vào giỏ hàng thành công</h2>';
                    if (result == false) {
                        str = '<i class=""fa fa-times text-warning"" style=""font-size: 6");
                WriteLiteral(@"0px;""></i>'
                            + '<h2 class=""text-warning"">Thêm vào giỏ hàng thất bại</h2>';
                    }

                    $('#tbContent').append(str);
                }
            });
        }
    </script>
    <script>
        $('#carousel-related-product').slick({
            infinite: true,
            arrows: false,
            slidesToShow: 4,
            slidesToScroll: 3,
            dots: true,
            responsive: [{
                breakpoint: 1024,
                settings: {
                    slidesToShow: 3,
                    slidesToScroll: 3
                }
            }, {
                breakpoint: 600,
                settings: {
                    slidesToShow: 2,
                    slidesToScroll: 3
                }
            }, {
                breakpoint: 480,
                settings: {
                    slidesToShow: 2,
                    slidesToScroll: 3
                }
            }]
        });
    </");
                WriteLiteral("script>\r\n    <!-- End Slider Script -->\r\n    ");
#nullable restore
#line 305 "C:\Users\Admin\Documents\HaiSan_Jay\DoAnWeb\HaiSan\HaiSan\Views\Shared\_Layout.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <!-- End Slider Script -->\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
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
