#pragma checksum "C:\Users\Admin\Documents\HaiSan_Jay\DoAnWeb\HaiSan\HaiSan\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13c42ac9b3dc0ef03b376dcee58a3a60634b1bd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13c42ac9b3dc0ef03b376dcee58a3a60634b1bd3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65ac9318954244554f7f38e524e4bfb3e204f6b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HaiSan.Models.View.HomeModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success text-white mt-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("h3 text-decoration-none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<!-- Start Banner Hero -->
<div id=""template-mo-zay-hero-carousel"" class=""carousel slide"" data-bs-ride=""carousel"">
    <ol class=""carousel-indicators"">
        <li data-bs-target=""#template-mo-zay-hero-carousel"" data-bs-slide-to=""0"" class=""active""></li>
        <li data-bs-target=""#template-mo-zay-hero-carousel"" data-bs-slide-to=""1""></li>
        <li data-bs-target=""#template-mo-zay-hero-carousel"" data-bs-slide-to=""2""></li>
    </ol>
    <div class=""carousel-inner"">
        <div class=""carousel-item active"">
            <div class=""container"">
                <div class=""row p-5"">
                    <div class=""mx-auto col-md-8 col-lg-6 order-lg-last"">
                        <img class=""img-fluid""");
            BeginWriteAttribute("src", " src=\"", 758, "\"", 797, 2);
            WriteAttributeValue("", 764, "/assets/img/", 764, 12, true);
#nullable restore
#line 14 "C:\Users\Admin\Documents\HaiSan_Jay\DoAnWeb\HaiSan\HaiSan\Views\Home\Index.cshtml"
WriteAttributeValue("", 776, Model.Banner[0].Path, 776, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""123"">
                    </div>
                    <div class=""col-lg-6 mb-0 d-flex align-items-center"">
                        <div class=""text-align-left align-self-center"">
                            <h1 class=""h1 text-success""><b>Zay</b> eCommerce</h1>
                            <h3 id=""title_1"" class=""h2"">");
#nullable restore
#line 19 "C:\Users\Admin\Documents\HaiSan_Jay\DoAnWeb\HaiSan\HaiSan\Views\Home\Index.cshtml"
                                                   Write(Model.Banner[0].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <p id=\"content_1\">\r\n                                ");
#nullable restore
#line 21 "C:\Users\Admin\Documents\HaiSan_Jay\DoAnWeb\HaiSan\HaiSan\Views\Home\Index.cshtml"
                           Write(Model.Banner[0].Content);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class=""carousel-item"">
            <div class=""container"">
                <div class=""row p-5"">
                    <div class=""mx-auto col-md-8 col-lg-6 order-lg-last"">
                        <img class=""img-fluid""");
            BeginWriteAttribute("src", " src=\"", 1651, "\"", 1690, 2);
            WriteAttributeValue("", 1657, "/assets/img/", 1657, 12, true);
#nullable restore
#line 33 "C:\Users\Admin\Documents\HaiSan_Jay\DoAnWeb\HaiSan\HaiSan\Views\Home\Index.cshtml"
WriteAttributeValue("", 1669, Model.Banner[1].Path, 1669, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""123"">
                    </div>
                    <div class=""col-lg-6 mb-0 d-flex align-items-center"">
                        <div class=""text-align-left"">
                            <h1 class=""h1"">Proident occaecat</h1>
                            <h3 id=""title_2"" class=""h2"">");
#nullable restore
#line 38 "C:\Users\Admin\Documents\HaiSan_Jay\DoAnWeb\HaiSan\HaiSan\Views\Home\Index.cshtml"
                                                   Write(Model.Banner[1].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <p id=\"content_2\">\r\n                                ");
#nullable restore
#line 40 "C:\Users\Admin\Documents\HaiSan_Jay\DoAnWeb\HaiSan\HaiSan\Views\Home\Index.cshtml"
                           Write(Model.Banner[1].Content);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""carousel-item"">
            <div class=""container"">
                <div class=""row p-5"">
                    <div class=""mx-auto col-md-8 col-lg-6 order-lg-last"">
                        <img class=""img-fluid""");
            BeginWriteAttribute("src", " src=\"", 2508, "\"", 2547, 2);
            WriteAttributeValue("", 2514, "/assets/img/", 2514, 12, true);
#nullable restore
#line 51 "C:\Users\Admin\Documents\HaiSan_Jay\DoAnWeb\HaiSan\HaiSan\Views\Home\Index.cshtml"
WriteAttributeValue("", 2526, Model.Banner[2].Path, 2526, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2548, "\"", 2554, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""col-lg-6 mb-0 d-flex align-items-center"">
                        <div class=""text-align-left"">
                            <h1 class=""h1"">Repr in voluptate</h1>
                            <h3 id=""title_3"" class=""h2"">");
#nullable restore
#line 56 "C:\Users\Admin\Documents\HaiSan_Jay\DoAnWeb\HaiSan\HaiSan\Views\Home\Index.cshtml"
                                                   Write(Model.Banner[2].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <p id=\"content_3\">\r\n                                ");
#nullable restore
#line 58 "C:\Users\Admin\Documents\HaiSan_Jay\DoAnWeb\HaiSan\HaiSan\Views\Home\Index.cshtml"
                           Write(Model.Banner[2].Content);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <a class=""carousel-control-prev text-decoration-none w-auto ps-3"" href=""#template-mo-zay-hero-carousel"" role=""button"" data-bs-slide=""prev"">
        <i class=""fas fa-chevron-left""></i>
    </a>
    <a class=""carousel-control-next text-decoration-none w-auto pe-3"" href=""#template-mo-zay-hero-carousel"" role=""button"" data-bs-slide=""next"">
        <i class=""fas fa-chevron-right""></i>
    </a>
</div>
<!-- End Banner Hero -->
<!-- Start Categories of The Month -->
<section class=""container py-5"">
    <div class=""row text-center pt-3"">
        <div class=""col-lg-6 m-auto"">
            <h1 class=""h1"">Danh mục nổi bật</h1>
            <p>
                Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
            </p>
        </div>
    </div>
    <div class=""row"">
");
#nullable restore
#line 85 "C:\Users\Admin\Documents\HaiSan_Jay\DoAnWeb\HaiSan\HaiSan\Views\Home\Index.cshtml"
         foreach (var e in Model.FeatureCategories)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-12 col-md-4 p-5 mt-3\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13c42ac9b3dc0ef03b376dcee58a3a60634b1bd311976", async() => {
                WriteLiteral("<img");
                BeginWriteAttribute("src", " src=\"", 4180, "\"", 4205, 2);
                WriteAttributeValue("", 4186, "/assets/img/", 4186, 12, true);
#nullable restore
#line 88 "C:\Users\Admin\Documents\HaiSan_Jay\DoAnWeb\HaiSan\HaiSan\Views\Home\Index.cshtml"
WriteAttributeValue("", 4198, e.Path, 4198, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"rounded-circle img-fluid border\">");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 88 "C:\Users\Admin\Documents\HaiSan_Jay\DoAnWeb\HaiSan\HaiSan\Views\Home\Index.cshtml"
                   WriteLiteral(e.Maloai);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <h5 class=\"text-center mt-3 mb-3\">");
#nullable restore
#line 89 "C:\Users\Admin\Documents\HaiSan_Jay\DoAnWeb\HaiSan\HaiSan\Views\Home\Index.cshtml"
                                             Write(e.TenLoai);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"text-center\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13c42ac9b3dc0ef03b376dcee58a3a60634b1bd314642", async() => {
                WriteLiteral("Mua ngay");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 90 "C:\Users\Admin\Documents\HaiSan_Jay\DoAnWeb\HaiSan\HaiSan\Views\Home\Index.cshtml"
                                          WriteLiteral(e.Maloai);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n            </div>\r\n");
#nullable restore
#line 92 "C:\Users\Admin\Documents\HaiSan_Jay\DoAnWeb\HaiSan\HaiSan\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
</section>
<!-- End Categories of The Month -->
<!-- Start Featured Product -->
<section class=""bg-light"">
    <div class=""container py-5"">
        <div class=""row text-center py-3"">
            <div class=""col-lg-6 m-auto"">
                <h1 class=""h1"">Sản phẩm nổi bật</h1>
                <p>
                    Reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident.
                </p>
            </div>
        </div>

        <!--Start Carousel Wrapper-->
        <div id=""carousel-related-product"">
");
#nullable restore
#line 111 "C:\Users\Admin\Documents\HaiSan_Jay\DoAnWeb\HaiSan\HaiSan\Views\Home\Index.cshtml"
             foreach (var e in Model.FeatureProducts)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"p-2 pb-3\">\r\n                    <div class=\"product-wap card rounded-0\">\r\n                        <div class=\"card rounded-0\">\r\n                            <img class=\"card-img rounded-0 img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 5391, "\"", 5415, 2);
            WriteAttributeValue("", 5397, "/assets/img/", 5397, 12, true);
#nullable restore
#line 116 "C:\Users\Admin\Documents\HaiSan_Jay\DoAnWeb\HaiSan\HaiSan\Views\Home\Index.cshtml"
WriteAttributeValue("", 5409, e.Img, 5409, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"card-img-overlay rounded-0 product-overlay d-flex align-items-center justify-content-center\">\r\n                                <ul class=\"list-unstyled\">\r\n                                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13c42ac9b3dc0ef03b376dcee58a3a60634b1bd318607", async() => {
                WriteLiteral("<i class=\"far fa-eye\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-prodId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 119 "C:\Users\Admin\Documents\HaiSan_Jay\DoAnWeb\HaiSan\HaiSan\Views\Home\Index.cshtml"
                                                                                                                                       WriteLiteral(e.MaSp);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["prodId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-prodId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["prodId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                                </ul>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"card-body\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13c42ac9b3dc0ef03b376dcee58a3a60634b1bd321381", async() => {
#nullable restore
#line 124 "C:\Users\Admin\Documents\HaiSan_Jay\DoAnWeb\HaiSan\HaiSan\Views\Home\Index.cshtml"
                                                                                                                                   Write(e.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-prodId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 124 "C:\Users\Admin\Documents\HaiSan_Jay\DoAnWeb\HaiSan\HaiSan\Views\Home\Index.cshtml"
                                                                                   WriteLiteral(e.MaSp);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["prodId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-prodId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["prodId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <ul class=""w-100 list-unstyled d-flex justify-content-between mb-0"">

                                <li class=""pt-2"">
                                    <span class=""product-color-dot color-dot-red float-left rounded-circle ml-1""></span>
                                    <span class=""product-color-dot color-dot-blue float-left rounded-circle ml-1""></span>
                                    <span class=""product-color-dot color-dot-black float-left rounded-circle ml-1""></span>
                                    <span class=""product-color-dot color-dot-light float-left rounded-circle ml-1""></span>
                                    <span class=""product-color-dot color-dot-green float-left rounded-circle ml-1""></span>
                                </li>
                            </ul>

                            <p class=""text-center mb-0"">");
#nullable restore
#line 136 "C:\Users\Admin\Documents\HaiSan_Jay\DoAnWeb\HaiSan\HaiSan\Views\Home\Index.cshtml"
                                                    Write(e.Gia.ToString("0,0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("đ</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 140 "C:\Users\Admin\Documents\HaiSan_Jay\DoAnWeb\HaiSan\HaiSan\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n        </div>\r\n\r\n    </div>\r\n</section>\r\n<!-- End Featured Product -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HaiSan.Models.View.HomeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
