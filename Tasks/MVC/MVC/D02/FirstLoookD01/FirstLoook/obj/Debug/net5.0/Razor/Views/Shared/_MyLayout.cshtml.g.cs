#pragma checksum "D:\ITI\MVC-20220809T183446Z-001\MVC\D02\FirstLoookD01\FirstLoook\Views\Shared\_MyLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3d169d257aebf10272a228fabbb884208fb1a35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__MyLayout), @"mvc.1.0.view", @"/Views/Shared/_MyLayout.cshtml")]
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
#line 1 "D:\ITI\MVC-20220809T183446Z-001\MVC\D02\FirstLoookD01\FirstLoook\Views\_ViewImports.cshtml"
using FirstLoook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ITI\MVC-20220809T183446Z-001\MVC\D02\FirstLoookD01\FirstLoook\Views\_ViewImports.cshtml"
using FirstLoook.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3d169d257aebf10272a228fabbb884208fb1a35", @"/Views/Shared/_MyLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e60183e4f7ed03767e5e99f350c8d3f54052873a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__MyLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("page-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3d169d257aebf10272a228fabbb884208fb1a353704", async() => {
                WriteLiteral("\r\n        <meta charset=\"utf-8\" />\r\n        <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\" />\r\n        <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 211, "\"", 221, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 254, "\"", 264, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
        <title>Freelancer - Start Bootstrap Theme</title>
        <!-- Favicon-->
        <link rel=""icon"" type=""image/x-icon"" href=""/assets/favicon.ico"" />
        <!-- Font Awesome icons (free version)-->
        <script src=""https://use.fontawesome.com/releases/v6.1.0/js/all.js"" crossorigin=""anonymous""></script>
        <!-- Google fonts-->
        <link href=""https://fonts.googleapis.com/css?family=Montserrat:400,700"" rel=""stylesheet"" type=""text/css"" />
        <link href=""https://fonts.googleapis.com/css?family=Lato:400,700,400italic,700italic"" rel=""stylesheet"" type=""text/css"" />
        <!-- Core theme CSS (includes Bootstrap)-->
        <link href=""/css/styles.css"" rel=""stylesheet"" />
    ");
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3d169d257aebf10272a228fabbb884208fb1a355945", async() => {
                WriteLiteral("\r\n        <!-- Navigation-->\r\n        <nav class=\"navbar navbar-expand-lg bg-secondary text-uppercase fixed-top\" id=\"mainNav\">\r\n            <div class=\"container\">\r\n            ");
#nullable restore
#line 23 "D:\ITI\MVC-20220809T183446Z-001\MVC\D02\FirstLoookD01\FirstLoook\Views\Shared\_MyLayout.cshtml"
       Write(RenderSection("MyDesign",false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                <a class=""navbar-brand"" href=""#page-top"">Start Bootstrap</a>
                <button class=""navbar-toggler text-uppercase font-weight-bold bg-primary text-white rounded"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarResponsive"" aria-controls=""navbarResponsive"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                    Menu
                    <i class=""fas fa-bars""></i>
                </button>
                <div class=""collapse navbar-collapse"" id=""navbarResponsive"">
                    <ul class=""navbar-nav ms-auto"">
                        <li class=""nav-item mx-0 mx-lg-1""><a class=""nav-link py-3 px-0 px-lg-3 rounded"" href=""/Department/Index"">Departments</a></li>
                        <li class=""nav-item mx-0 mx-lg-1""><a class=""nav-link py-3 px-0 px-lg-3 rounded"" href=""#about"">About</a></li>
                        <li class=""nav-item mx-0 mx-lg-1""><a class=""nav-link py-3 px-0 px-lg-3 rounded"" href=""#contact"">Contact</a></li>
                ");
                WriteLiteral(@"    </ul>
                </div>
            </div>
        </nav>
        <!-- Masthead-->
        <header class=""masthead bg-primary text-white text-center"">
           
            <div class=""container d-flex align-items-center flex-column"">
                <!-- Masthead Avatar Image-->
                <img class=""masthead-avatar mb-5"" src=""/assets/img/avataaars.svg"" alt=""..."" />
                <!-- Masthead Heading-->
                <h1 class=""masthead-heading text-uppercase mb-0"">Start Bootstrap</h1>
                <!-- Icon Divider-->
                <div class=""divider-custom divider-light"">
                    <div class=""divider-custom-line""></div>
                    <div class=""divider-custom-icon""><i class=""fas fa-star""></i></div>
                    <div class=""divider-custom-line""></div>
                </div>
                <!-- Masthead Subheading-->
                <p class=""masthead-subheading font-weight-light mb-0"">Graphic Artist - Web Designer - Illustrator</p>
  ");
                WriteLiteral("          </div>\r\n        </header>\r\n        <!-- Portfolio Section-->\r\n        <section class=\"page-section portfolio\" id=\"portfolio\">\r\n            <div class=\"container\">\r\n                ");
#nullable restore
#line 59 "D:\ITI\MVC-20220809T183446Z-001\MVC\D02\FirstLoookD01\FirstLoook\Views\Shared\_MyLayout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
             </div>
           </section> 

       
        
        <!-- Footer-->
        <footer class=""footer text-center"">
            <div class=""container"">
                <div class=""row"">
                    <!-- Footer Location-->
                    <div class=""col-lg-4 mb-5 mb-lg-0"">
                        <h4 class=""text-uppercase mb-4"">Location</h4>
                        <p class=""lead mb-0"">
                            2215 John Daniel Drive
                            <br />
                            Clark, MO 65243
                        </p>
                    </div>
                    <!-- Footer Social Icons-->
                    <div class=""col-lg-4 mb-5 mb-lg-0"">
                        <h4 class=""text-uppercase mb-4"">Around the Web</h4>
                        <a class=""btn btn-outline-light btn-social mx-1"" href=""#!""><i class=""fab fa-fw fa-facebook-f""></i></a>
                        <a class=""btn btn-outline-light btn-social mx-1"" href=""#!""><i class=""");
                WriteLiteral(@"fab fa-fw fa-twitter""></i></a>
                        <a class=""btn btn-outline-light btn-social mx-1"" href=""#!""><i class=""fab fa-fw fa-linkedin-in""></i></a>
                        <a class=""btn btn-outline-light btn-social mx-1"" href=""#!""><i class=""fab fa-fw fa-dribbble""></i></a>
                    </div>
                    <!-- Footer About Text-->
                    <div class=""col-lg-4"">
                        <h4 class=""text-uppercase mb-4"">About Freelancer</h4>
                        <p class=""lead mb-0"">
                            Freelance is a free to use, MIT licensed Bootstrap theme created by
                            <a href=""http://startbootstrap.com"">Start Bootstrap</a>
                            .
                        </p>
                    </div>
                </div>
            </div>
        </footer>
        <!-- Copyright Section-->
        <div class=""copyright py-4 text-center text-white"">
            <div class=""container""><small>Copyright &copy; You");
                WriteLiteral(@"r Website 2022</small></div>
        </div>
        <!-- Portfolio Modals-->
        <!-- Portfolio Modal 1-->
        <div class=""portfolio-modal modal fade"" id=""portfolioModal1"" tabindex=""-1"" aria-labelledby=""portfolioModal1"" aria-hidden=""true"">
            <div class=""modal-dialog modal-xl"">
                <div class=""modal-content"">
                    <div class=""modal-header border-0""><button class=""btn-close"" type=""button"" data-bs-dismiss=""modal"" aria-label=""Close""></button></div>
                    <div class=""modal-body text-center pb-5"">
                        <div class=""container"">
                            <div class=""row justify-content-center"">
                                <div class=""col-lg-8"">
                                    <!-- Portfolio Modal - Title-->
                                    <h2 class=""portfolio-modal-title text-secondary text-uppercase mb-0"">Log Cabin</h2>
                                    <!-- Icon Divider-->
                                    ");
                WriteLiteral(@"<div class=""divider-custom"">
                                        <div class=""divider-custom-line""></div>
                                        <div class=""divider-custom-icon""><i class=""fas fa-star""></i></div>
                                        <div class=""divider-custom-line""></div>
                                    </div>
                                    <!-- Portfolio Modal - Image-->
                                    <img class=""img-fluid rounded mb-5"" src=""/assets/img/portfolio/cabin.png"" alt=""..."" />
                                    <!-- Portfolio Modal - Text-->
                                    <p class=""mb-4"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Mollitia neque assumenda ipsam nihil, molestias magnam, recusandae quos quis inventore quisquam velit asperiores, vitae? Reprehenderit soluta, eos quod consequuntur itaque. Nam.</p>
                                    <button class=""btn btn-primary"" data-bs-dismiss=""modal"">
                                ");
                WriteLiteral(@"        <i class=""fas fa-xmark fa-fw""></i>
                                        Close Window
                                    </button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Portfolio Modal 2-->
        <div class=""portfolio-modal modal fade"" id=""portfolioModal2"" tabindex=""-1"" aria-labelledby=""portfolioModal2"" aria-hidden=""true"">
            <div class=""modal-dialog modal-xl"">
                <div class=""modal-content"">
                    <div class=""modal-header border-0""><button class=""btn-close"" type=""button"" data-bs-dismiss=""modal"" aria-label=""Close""></button></div>
                    <div class=""modal-body text-center pb-5"">
                        <div class=""container"">
                            <div class=""row justify-content-center"">
                                <div class=""col-lg-8"">
                       ");
                WriteLiteral(@"             <!-- Portfolio Modal - Title-->
                                    <h2 class=""portfolio-modal-title text-secondary text-uppercase mb-0"">Tasty Cake</h2>
                                    <!-- Icon Divider-->
                                    <div class=""divider-custom"">
                                        <div class=""divider-custom-line""></div>
                                        <div class=""divider-custom-icon""><i class=""fas fa-star""></i></div>
                                        <div class=""divider-custom-line""></div>
                                    </div>
                                    <!-- Portfolio Modal - Image-->
                                    <img class=""img-fluid rounded mb-5"" src=""/assets/img/portfolio/cake.png"" alt=""..."" />
                                    <!-- Portfolio Modal - Text-->
                                    <p class=""mb-4"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Mollitia neque assumenda ipsam nihil, molestias ");
                WriteLiteral(@"magnam, recusandae quos quis inventore quisquam velit asperiores, vitae? Reprehenderit soluta, eos quod consequuntur itaque. Nam.</p>
                                    <button class=""btn btn-primary"" data-bs-dismiss=""modal"">
                                        <i class=""fas fa-xmark fa-fw""></i>
                                        Close Window
                                    </button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Portfolio Modal 3-->
        <div class=""portfolio-modal modal fade"" id=""portfolioModal3"" tabindex=""-1"" aria-labelledby=""portfolioModal3"" aria-hidden=""true"">
            <div class=""modal-dialog modal-xl"">
                <div class=""modal-content"">
                    <div class=""modal-header border-0""><button class=""btn-close"" type=""button"" data-bs-dismiss=""modal"" aria-label=""Close""></button></div>
");
                WriteLiteral(@"                    <div class=""modal-body text-center pb-5"">
                        <div class=""container"">
                            <div class=""row justify-content-center"">
                                <div class=""col-lg-8"">
                                    <!-- Portfolio Modal - Title-->
                                    <h2 class=""portfolio-modal-title text-secondary text-uppercase mb-0"">Circus Tent</h2>
                                    <!-- Icon Divider-->
                                    <div class=""divider-custom"">
                                        <div class=""divider-custom-line""></div>
                                        <div class=""divider-custom-icon""><i class=""fas fa-star""></i></div>
                                        <div class=""divider-custom-line""></div>
                                    </div>
                                    <!-- Portfolio Modal - Image-->
                                    <img class=""img-fluid rounded mb-5"" src=""/assets/im");
                WriteLiteral(@"g/portfolio/circus.png"" alt=""..."" />
                                    <!-- Portfolio Modal - Text-->
                                    <p class=""mb-4"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Mollitia neque assumenda ipsam nihil, molestias magnam, recusandae quos quis inventore quisquam velit asperiores, vitae? Reprehenderit soluta, eos quod consequuntur itaque. Nam.</p>
                                    <button class=""btn btn-primary"" data-bs-dismiss=""modal"">
                                        <i class=""fas fa-xmark fa-fw""></i>
                                        Close Window
                                    </button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Portfolio Modal 4-->
        <div class=""portfolio-modal modal fade"" id=""portfolioModal4"" tabindex=""-1"" aria-labelledby=""portfolioModal4"" aria-h");
                WriteLiteral(@"idden=""true"">
            <div class=""modal-dialog modal-xl"">
                <div class=""modal-content"">
                    <div class=""modal-header border-0""><button class=""btn-close"" type=""button"" data-bs-dismiss=""modal"" aria-label=""Close""></button></div>
                    <div class=""modal-body text-center pb-5"">
                        <div class=""container"">
                            <div class=""row justify-content-center"">
                                <div class=""col-lg-8"">
                                    <!-- Portfolio Modal - Title-->
                                    <h2 class=""portfolio-modal-title text-secondary text-uppercase mb-0"">Controller</h2>
                                    <!-- Icon Divider-->
                                    <div class=""divider-custom"">
                                        <div class=""divider-custom-line""></div>
                                        <div class=""divider-custom-icon""><i class=""fas fa-star""></i></div>
                  ");
                WriteLiteral(@"                      <div class=""divider-custom-line""></div>
                                    </div>
                                    <!-- Portfolio Modal - Image-->
                                    <img class=""img-fluid rounded mb-5"" src=""/assets/img/portfolio/game.png"" alt=""..."" />
                                    <!-- Portfolio Modal - Text-->
                                    <p class=""mb-4"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Mollitia neque assumenda ipsam nihil, molestias magnam, recusandae quos quis inventore quisquam velit asperiores, vitae? Reprehenderit soluta, eos quod consequuntur itaque. Nam.</p>
                                    <button class=""btn btn-primary"" data-bs-dismiss=""modal"">
                                        <i class=""fas fa-xmark fa-fw""></i>
                                        Close Window
                                    </button>
                                </div>
                            </div>
                 ");
                WriteLiteral(@"       </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Portfolio Modal 5-->
        <div class=""portfolio-modal modal fade"" id=""portfolioModal5"" tabindex=""-1"" aria-labelledby=""portfolioModal5"" aria-hidden=""true"">
            <div class=""modal-dialog modal-xl"">
                <div class=""modal-content"">
                    <div class=""modal-header border-0""><button class=""btn-close"" type=""button"" data-bs-dismiss=""modal"" aria-label=""Close""></button></div>
                    <div class=""modal-body text-center pb-5"">
                        <div class=""container"">
                            <div class=""row justify-content-center"">
                                <div class=""col-lg-8"">
                                    <!-- Portfolio Modal - Title-->
                                    <h2 class=""portfolio-modal-title text-secondary text-uppercase mb-0"">Locked Safe</h2>
                                    <!-- Icon Divider-->
           ");
                WriteLiteral(@"                         <div class=""divider-custom"">
                                        <div class=""divider-custom-line""></div>
                                        <div class=""divider-custom-icon""><i class=""fas fa-star""></i></div>
                                        <div class=""divider-custom-line""></div>
                                    </div>
                                    <!-- Portfolio Modal - Image-->
                                    <img class=""img-fluid rounded mb-5"" src=""/assets/img/portfolio/safe.png"" alt=""..."" />
                                    <!-- Portfolio Modal - Text-->
                                    <p class=""mb-4"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Mollitia neque assumenda ipsam nihil, molestias magnam, recusandae quos quis inventore quisquam velit asperiores, vitae? Reprehenderit soluta, eos quod consequuntur itaque. Nam.</p>
                                    <button class=""btn btn-primary"" data-bs-dismiss=""modal"">
        ");
                WriteLiteral(@"                                <i class=""fas fa-xmark fa-fw""></i>
                                        Close Window
                                    </button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Portfolio Modal 6-->
        <div class=""portfolio-modal modal fade"" id=""portfolioModal6"" tabindex=""-1"" aria-labelledby=""portfolioModal6"" aria-hidden=""true"">
            <div class=""modal-dialog modal-xl"">
                <div class=""modal-content"">
                    <div class=""modal-header border-0""><button class=""btn-close"" type=""button"" data-bs-dismiss=""modal"" aria-label=""Close""></button></div>
                    <div class=""modal-body text-center pb-5"">
                        <div class=""container"">
                            <div class=""row justify-content-center"">
                                <div class=""col-lg-8"">");
                WriteLiteral(@"
                                    <!-- Portfolio Modal - Title-->
                                    <h2 class=""portfolio-modal-title text-secondary text-uppercase mb-0"">Submarine</h2>
                                    <!-- Icon Divider-->
                                    <div class=""divider-custom"">
                                        <div class=""divider-custom-line""></div>
                                        <div class=""divider-custom-icon""><i class=""fas fa-star""></i></div>
                                        <div class=""divider-custom-line""></div>
                                    </div>
                                    <!-- Portfolio Modal - Image-->
                                    <img class=""img-fluid rounded mb-5"" src=""/assets/img/portfolio/submarine.png"" alt=""..."" />
                                    <!-- Portfolio Modal - Text-->
                                    <p class=""mb-4"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Mollitia neque assum");
                WriteLiteral(@"enda ipsam nihil, molestias magnam, recusandae quos quis inventore quisquam velit asperiores, vitae? Reprehenderit soluta, eos quod consequuntur itaque. Nam.</p>
                                    <button class=""btn btn-primary"" data-bs-dismiss=""modal"">
                                        <i class=""fas fa-xmark fa-fw""></i>
                                        Close Window
                                    </button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Bootstrap core JS-->
        <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js""></script>
        <!-- Core theme JS-->
        <script src=""/js/scripts.js""></script>
        <!-- * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *-->
        <!-- * *                               SB Forms JS               ");
                WriteLiteral(@"                * *-->
        <!-- * * Activate your form at https://startbootstrap.com/solution/contact-forms * *-->
        <!-- * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *-->
        <script src=""https://cdn.startbootstrap.com/sb-forms-latest.js""></script>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
