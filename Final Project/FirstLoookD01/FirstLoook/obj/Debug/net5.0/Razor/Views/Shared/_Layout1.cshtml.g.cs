#pragma checksum "D:\ITI_Pro\ITI_Training\Final Task\FirstLoookD01\FirstLoook\Views\Shared\_Layout1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "879eb919ced7b513127e7f7001f00ee4862d91ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout1), @"mvc.1.0.view", @"/Views/Shared/_Layout1.cshtml")]
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
#line 1 "D:\ITI_Pro\ITI_Training\Final Task\FirstLoookD01\FirstLoook\Views\_ViewImports.cshtml"
using FirstLoook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ITI_Pro\ITI_Training\Final Task\FirstLoookD01\FirstLoook\Views\_ViewImports.cshtml"
using FirstLoook.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"879eb919ced7b513127e7f7001f00ee4862d91ef", @"/Views/Shared/_Layout1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e60183e4f7ed03767e5e99f350c8d3f54052873a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Layout1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("forms/contact.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("php-email-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "879eb919ced7b513127e7f7001f00ee4862d91ef4971", async() => {
                WriteLiteral("\r\n  <meta charset=\"utf-8\">\r\n  <meta content=\"width=device-width, initial-scale=1.0\" name=\"viewport\">\r\n\r\n  <title>Amoeba Bootstrap Template - Home</title>\r\n  <meta");
                BeginWriteAttribute("content", " content=\"", 205, "\"", 215, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"description\">\r\n  <meta");
                BeginWriteAttribute("content", " content=\"", 245, "\"", 255, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""keywords"">

  <!-- Favicons -->
  <link href=""assets/img/favicon.png"" rel=""icon"">
  <link href=""assets/img/apple-touch-icon.png"" rel=""apple-touch-icon"">

  <!-- Google Fonts -->
  <link href=""https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i|Lato:400,300,700,900"" rel=""stylesheet"">

  <!-- Vendor CSS Files -->
  <link href=""assets/vendor/bootstrap/css/bootstrap.min.css"" rel=""stylesheet"">
  <link href=""assets/vendor/bootstrap-icons/bootstrap-icons.css"" rel=""stylesheet"">
  <link href=""assets/vendor/glightbox/css/glightbox.min.css"" rel=""stylesheet"">
  <link href=""assets/vendor/swiper/swiper-bundle.min.css"" rel=""stylesheet"">

  <!-- Template Main CSS File -->
  <link href=""assets/css/style.css"" rel=""stylesheet"">

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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "879eb919ced7b513127e7f7001f00ee4862d91ef7274", async() => {
                WriteLiteral(@"
    
  <!-- ======= Header ======= -->
  <header id=""header"" class=""fixed-top d-flex align-items-center"">
    <div class=""container d-flex align-items-center"">

      <div class=""logo me-auto"">
        <h1><a href=""index.html"">FCI</a></h1>
        
      </div>

      <nav id=""navbar"" class=""navbar"">
        <ul>
          <li><a class=""nav-link scrollto active"" href=""#hero"">Home</a></li>
          <li><a class=""nav-link scrollto"" href=""/Department/GettAll"">Departments</a></li>
          <li><a class=""nav-link scrollto"" href=""/Course/GettAll"">Courses</a></li>
          <li><a class=""nav-link scrollto"" href=""/Resutl/GettAll"">Results</a></li>
          <li><a class=""nav-link scrollto"" href=""#team"">Team</a></li>
          <li class=""dropdown""><a href=""#""><span>Drop Down</span> <i class=""bi bi-chevron-down""></i></a>
            <ul>
              <li><a href=""#"">Drop Down 1</a></li>
              <li class=""dropdown""><a href=""#""><span>Deep Drop Down</span> <i class=""bi bi-chevron-right""></i>");
                WriteLiteral(@"</a>
                <ul>
                  <li><a href=""#"">Deep Drop Down 1</a></li>
                  <li><a href=""#"">Deep Drop Down 2</a></li>
                  <li><a href=""#"">Deep Drop Down 3</a></li>
                  <li><a href=""#"">Deep Drop Down 4</a></li>
                  <li><a href=""#"">Deep Drop Down 5</a></li>
                </ul>
              </li>
              <li><a href=""#"">Drop Down 2</a></li>
              <li><a href=""#"">Drop Down 3</a></li>
              <li><a href=""#"">Drop Down 4</a></li>
            </ul>
          </li>
          <li><a class=""nav-link scrollto"" href=""#contact"">Contact Us</a></li>
        </ul>
        <i class=""bi bi-list mobile-nav-toggle""></i>
      </nav><!-- .navbar -->

    </div>
  </header><!-- End #header -->
  

  


  <main id=""main"">
       ");
#nullable restore
#line 78 "D:\ITI_Pro\ITI_Training\Final Task\FirstLoookD01\FirstLoook\Views\Shared\_Layout1.cshtml"
  Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <!-- ======= Call To Action Section ======= -->\r\n    <section class=\"call-to-action\">\r\n      <div class=\"container\">\r\n          ");
#nullable restore
#line 83 "D:\ITI_Pro\ITI_Training\Final Task\FirstLoookD01\FirstLoook\Views\Shared\_Layout1.cshtml"
     Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        <div class=""text-center"">
          <h3>Call To Action</h3>
          <p> Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>
          <a class=""cta-btn"" href=""#"">Call To Action</a>
        </div>

      </div>
    </section><!-- End Call To Action Section -->

     
    
    
    
    <!-- ======= Contact Us Section ======= -->
    <section id=""contact"" class=""contact section-bg"">
      <div class=""container"">

        <div class=""section-title"">
          <h2>Contact Us</h2>
          <p>Magnam dolores commodi suscipit. Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit sint consectetur velit. Quisquam quos quisquam cupiditate. Et nemo qui impedit suscipit alias ea. Quia fugiat sit in iste officiis commodi quidem hic quas.</p>
        </div>

        <div class=""row"">
           

          <div ");
                WriteLiteral(@"class=""col-lg-4 col-md-6"">
            <div class=""contact-about"">
              <h3>Amoeba</h3>
              <p>Cras fermentum odio eu feugiat. Justo eget magna fermentum iaculis eu non diam phasellus. Scelerisque felis imperdiet proin fermentum leo. Amet volutpat consequat mauris nunc congue.</p>
              <div class=""social-links"">
                <a href=""#"" class=""twitter""><i class=""bi bi-twitter""></i></a>
                <a href=""#"" class=""facebook""><i class=""bi bi-facebook""></i></a>
                <a href=""#"" class=""instagram""><i class=""bi bi-instagram""></i></a>
                <a href=""#"" class=""linkedin""><i class=""bi bi-linkedin""></i></a>
              </div>
            </div>
          </div>

          <div class=""col-lg-3 col-md-6"">
            <div class=""info"">
              <div>
                <i class=""bi bi-geo-alt""></i>
                <p>A108 Adam Street<br>New York, NY 535022</p>
              </div>

              <div>
                <i class=""bi bi-envelop");
                WriteLiteral(@"e""></i>
                <p>info@example.com</p>
              </div>

              <div>
                <i class=""bi bi-phone""></i>
                <p>+1 5589 55488 55s</p>
              </div>

            </div>
          </div>

          <div class=""col-lg-5 col-md-12"">
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "879eb919ced7b513127e7f7001f00ee4862d91ef12589", async() => {
                    WriteLiteral(@"
              <div class=""form-group"">
                <input type=""text"" name=""name"" class=""form-control"" id=""name"" placeholder=""Your Name"" required>
              </div>
              <div class=""form-group mt-3"">
                <input type=""email"" class=""form-control"" name=""email"" id=""email"" placeholder=""Your Email"" required>
              </div>
              <div class=""form-group mt-3"">
                <input type=""text"" class=""form-control"" name=""subject"" id=""subject"" placeholder=""Subject"" required>
              </div>
              <div class=""form-group mt-3"">
                <textarea class=""form-control"" name=""message"" rows=""5"" placeholder=""Message"" required></textarea>
              </div>
              <div class=""my-3"">
                <div class=""loading"">Loading</div>
                <div class=""error-message""></div>
                <div class=""sent-message"">Your message has been sent. Thank you!</div>
              </div>
              <div class=""text-center""><button typ");
                    WriteLiteral("e=\"submit\">Send Message</button></div>\r\n            ");
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
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
          </div>

        </div>

      </div>
    </section><!-- End Contact Us Section -->

    <!-- ======= Map Section ======= -->
    <section class=""map"">
      <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3024.2219901290355!2d-74.00369368400567!3d40.71312937933185!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x89c25a23e28c1191%3A0x49f75d3281df052a!2s150%20Park%20Row%2C%20New%20York%2C%20NY%2010007%2C%20USA!5e0!3m2!1sen!2sbg!4v1579767901424!5m2!1sen!2sbg"" frameborder=""0"" style=""border:0;""");
                BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 7126, "\"", 7144, 0);
                EndWriteAttribute();
                WriteLiteral(@"></iframe>
    </section><!-- End Map Section -->

  </main><!-- End #main -->

  <!-- ======= Footer ======= -->
  <footer id=""footer"">
    <div class=""container"">
      <div class=""copyright"">
        &copy; Copyright <strong><span>Amoeba</span></strong>. All Rights Reserved
      </div>
      <div class=""credits"">
        <!-- All the links in the footer should remain intact. -->
        <!-- You can delete the links only if you purchased the pro version. -->
        <!-- Licensing information: https://bootstrapmade.com/license/ -->
        <!-- Purchase the pro version with working PHP/AJAX contact form: https://bootstrapmade.com/free-one-page-bootstrap-template-amoeba/ -->
        Designed by <a href=""https://bootstrapmade.com/"">BootstrapMade</a>
      </div>
    </div>
  </footer><!-- End #footer -->

  <a href=""#"" class=""back-to-top d-flex align-items-center justify-content-center""><i class=""bi bi-arrow-up-short""></i></a>

  <!-- Vendor JS Files -->
  <script src=""assets/vendor/");
                WriteLiteral(@"bootstrap/js/bootstrap.bundle.min.js""></script>
  <script src=""assets/vendor/glightbox/js/glightbox.min.js""></script>
  <script src=""assets/vendor/isotope-layout/isotope.pkgd.min.js""></script>
  <script src=""assets/vendor/swiper/swiper-bundle.min.js""></script>
  <script src=""assets/vendor/php-email-form/validate.js""></script>

  <!-- Template Main JS File -->
  <script src=""assets/js/main.js""></script>

");
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
            WriteLiteral("\r\n\r\n</html>");
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
