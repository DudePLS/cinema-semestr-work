#pragma checksum "C:\Users\pc\Documents\C# 3 сем\cinema-semestr-work\cinema-semestr-work\MovieTicketBooking\MovieTicketBooking\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8b0de0091e6824d4f9c6ea96a96087e13aebcb3"
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
#line 1 "C:\Users\pc\Documents\C# 3 сем\cinema-semestr-work\cinema-semestr-work\MovieTicketBooking\MovieTicketBooking\Views\_ViewImports.cshtml"
using MovieTicketBooking;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pc\Documents\C# 3 сем\cinema-semestr-work\cinema-semestr-work\MovieTicketBooking\MovieTicketBooking\Views\_ViewImports.cshtml"
using MovieTicketBooking.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8b0de0091e6824d4f9c6ea96a96087e13aebcb3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebf90e995acc677fe9e73a134efc31f9993ba4c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/index.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\pc\Documents\C# 3 сем\cinema-semestr-work\cinema-semestr-work\MovieTicketBooking\MovieTicketBooking\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!doctype html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8b0de0091e6824d4f9c6ea96a96087e13aebcb35298", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 220, "\"", 230, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    <meta name=""author"" content=""Mark Otto, Jacob Thornton, and Bootstrap contributors"">
    <meta name=""generator"" content=""Hugo 0.80.0"">
    <title>Carousel Template · Bootstrap v5.0</title>

    <link rel=""canonical"" href=""https://getbootstrap.com/docs/5.0/examples/carousel/"">



    <!-- Bootstrap core CSS -->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c8b0de0091e6824d4f9c6ea96a96087e13aebcb36199", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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

    <style>
        .bd-placeholder-img {
            font-size: 1.125rem;
            text-anchor: middle;
            -webkit-user-select: none;
            -moz-user-select: none;
            user-select: none;
        }
    </style>


    <!-- Custom styles for this template -->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c8b0de0091e6824d4f9c6ea96a96087e13aebcb37675", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8b0de0091e6824d4f9c6ea96a96087e13aebcb39558", async() => {
                WriteLiteral(@"


    <div id=""myCarousel"" class=""carousel"" data-bs-ride=""carousel"">
        <div class=""carousel-indicators"">
            <button type=""button"" data-bs-target=""#myCarousel"" data-bs-slide-to=""0"" class=""active"" aria-current=""true"" aria-label=""Slide 1""></button>
            <button type=""button"" data-bs-target=""#myCarousel"" data-bs-slide-to=""1"" aria-label=""Slide 2""></button>
            <button type=""button"" data-bs-target=""#myCarousel"" data-bs-slide-to=""2"" aria-label=""Slide 3""></button>
        </div>
        <div class=""carousel-inner"">
            <div class=""carousel-item active"">
                <svg class=""bd-placeholder-img"" width=""100%"" height=""100%"" xmlns=""http://www.w3.org/2000/svg"" aria-hidden=""true"" preserveAspectRatio=""xMidYMid slice"" focusable=""false""><rect width=""100%"" height=""100%"" fill=""#444"" /></svg>
            </div>

            <div class=""carousel-item"">
                <svg class=""bd-placeholder-img"" width=""100%"" height=""100%"" xmlns=""http://www.w3.org/2000/svg"" aria-hidde");
                WriteLiteral(@"n=""true"" preserveAspectRatio=""xMidYMid slice"" focusable=""false""><rect width=""100%"" height=""100%"" fill=""#555"" /></svg>  
            </div>

            <div class=""carousel-item"">
                <svg class=""bd-placeholder-img"" width=""100%"" height=""100%"" xmlns=""http://www.w3.org/2000/svg"" aria-hidden=""true"" preserveAspectRatio=""xMidYMid slice"" focusable=""false""><rect width=""100%"" height=""100%"" fill=""#777"" /></svg>
            </div>
        </div>
        <button class=""carousel-control-prev"" type=""button"" data-bs-target=""#myCarousel"" data-bs-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""visually-hidden"">Previous</span>
        </button>
        <button class=""carousel-control-next"" type=""button"" data-bs-target=""#myCarousel"" data-bs-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""visually-hidden"">Next</span>
        </button>
    </div>

    <a class=");
                WriteLiteral(@"""py-2 d-none d-md-inline-block"" id=""mvs"" href=""#"">Сегодня</a>
    <a></a>
    <a class=""py-2 d-none d-md-inline-block"" id=""mvs"" href=""#"">Скоро</a>

    <div class=""album py-5"">
        <div class=""container"">

            <div class=""row row-cols-1 row-cols-sm-2 row-cols-md-3 g-3"">
                <div class=""col"">
                    <div class=""card shadow-sm"">
                        <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""225"" xmlns=""http://www.w3.org/2000/svg"" role=""img"" aria-label=""Placeholder: Thumbnail"" preserveAspectRatio=""xMidYMid slice"" focusable=""false""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#55595c"" /><text x=""50%"" y=""50%"" fill=""#eceeef"" dy="".3em"">Thumbnail</text></svg>

                        <div class=""card-body"">
                            <div class=""d-flex justify-content-between align-items-center"">
                                <div class=""btn-group"">
                                    <button type=""button"" class=""btn");
                WriteLiteral(@" btn-sm btn-outline-secondary"">Подробнее</button>
                                    <button type=""button"" class=""btn btn-sm btn-outline-secondary"">Расписание и билеты</button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col"">
                    <div class=""card shadow-sm"">
                        <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""225"" xmlns=""http://www.w3.org/2000/svg"" role=""img"" aria-label=""Placeholder: Thumbnail"" preserveAspectRatio=""xMidYMid slice"" focusable=""false""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#55595c"" /><text x=""50%"" y=""50%"" fill=""#eceeef"" dy="".3em"">Thumbnail</text></svg>
                        <div class=""card-body"">
                            <div class=""d-flex justify-content-between align-items-center"">
                                <div class=""btn-group"">
                     ");
                WriteLiteral(@"               <button type=""button"" class=""btn btn-sm btn-outline-secondary"">Подробнее</button>
                                    <button type=""button"" class=""btn btn-sm btn-outline-secondary"">Расписание и билеты</button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col"">
                    <div class=""card shadow-sm"">
                        <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""225"" xmlns=""http://www.w3.org/2000/svg"" role=""img"" aria-label=""Placeholder: Thumbnail"" preserveAspectRatio=""xMidYMid slice"" focusable=""false""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#55595c"" /><text x=""50%"" y=""50%"" fill=""#eceeef"" dy="".3em"">Thumbnail</text></svg>
                        <div class=""card-body"">
                            <div class=""d-flex justify-content-between align-items-center"">
                               ");
                WriteLiteral(@" <div class=""btn-group"">
                                    <button type=""button"" class=""btn btn-sm btn-outline-secondary"">Подробнее</button>
                                    <button type=""button"" class=""btn btn-sm btn-outline-secondary"">Расписание и билеты</button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""col"">
                    <div class=""card shadow-sm"">
                        <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""225"" xmlns=""http://www.w3.org/2000/svg"" role=""img"" aria-label=""Placeholder: Thumbnail"" preserveAspectRatio=""xMidYMid slice"" focusable=""false""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#55595c"" /><text x=""50%"" y=""50%"" fill=""#eceeef"" dy="".3em"">Thumbnail</text></svg>
                        <div class=""card-body"">
                            <div class=""d-flex justify-content-between alig");
                WriteLiteral(@"n-items-center"">
                                <div class=""btn-group"">
                                    <button type=""button"" class=""btn btn-sm btn-outline-secondary"">Подробнее</button>
                                    <button type=""button"" class=""btn btn-sm btn-outline-secondary"">Расписание и билеты</button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col"">
                    <div class=""card shadow-sm"">
                        <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""225"" xmlns=""http://www.w3.org/2000/svg"" role=""img"" aria-label=""Placeholder: Thumbnail"" preserveAspectRatio=""xMidYMid slice"" focusable=""false""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#55595c"" /><text x=""50%"" y=""50%"" fill=""#eceeef"" dy="".3em"">Thumbnail</text></svg>

                        <div class=""card-body"">

                        ");
                WriteLiteral(@"    <div class=""d-flex justify-content-between align-items-center"">
                                <div class=""btn-group"">
                                    <button type=""button"" class=""btn btn-sm btn-outline-secondary"">Подробнее</button>
                                    <button type=""button"" class=""btn btn-sm btn-outline-secondary"">Расписание и билеты</button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col"">
                    <div class=""card shadow-sm"">
                        <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""225"" xmlns=""http://www.w3.org/2000/svg"" role=""img"" aria-label=""Placeholder: Thumbnail"" preserveAspectRatio=""xMidYMid slice"" focusable=""false""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#55595c"" /><text x=""50%"" y=""50%"" fill=""#eceeef"" dy="".3em"">Thumbnail</text></svg>

                        ");
                WriteLiteral(@"<div class=""card-body"">

                            <div class=""d-flex justify-content-between align-items-center"">
                                <div class=""btn-group"">
                                    <button type=""button"" class=""btn btn-sm btn-outline-secondary"">Подробнее</button>
                                    <button type=""button"" class=""btn btn-sm btn-outline-secondary"">Расписание и билеты</button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>


    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8b0de0091e6824d4f9c6ea96a96087e13aebcb319372", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
