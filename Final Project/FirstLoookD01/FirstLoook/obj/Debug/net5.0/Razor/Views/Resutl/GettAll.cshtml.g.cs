#pragma checksum "D:\ITI_Pro\ITI_Training\Final Task\FirstLoookD01\FirstLoook\Views\Resutl\GettAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "657d1b233a88a4cf5aba93e75e65d0fc7155a368"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Resutl_GettAll), @"mvc.1.0.view", @"/Views/Resutl/GettAll.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"657d1b233a88a4cf5aba93e75e65d0fc7155a368", @"/Views/Resutl/GettAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e60183e4f7ed03767e5e99f350c8d3f54052873a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Resutl_GettAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CrsResult>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Results</h1>\r\n<table class=\"table table-hover table-bordered\">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t<th>Id</th>\r\n\t\t\t<th>Name</th>\r\n\t\t\t<th>CourseName</th>\r\n\t\t\t<th>Degree</th>\r\n\t\t\t\r\n\t\t</tr>\r\n\t</thead>\r\n\t<tbody>\r\n\t\t\r\n\t\t\r\n");
#nullable restore
#line 16 "D:\ITI_Pro\ITI_Training\Final Task\FirstLoookD01\FirstLoook\Views\Resutl\GettAll.cshtml"
          
		foreach(var dept in Model)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<tr>\r\n\t\t\t\t\t<td>\r\n");
#nullable restore
#line 21 "D:\ITI_Pro\ITI_Training\Final Task\FirstLoookD01\FirstLoook\Views\Resutl\GettAll.cshtml"
                      
                        CollegeContext Db = new CollegeContext(); 
                        var result=Db.Trainees.Where(p=>p.Id==dept.traineeId).Select(p=>p.Id).Single();
						
					

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t");
#nullable restore
#line 26 "D:\ITI_Pro\ITI_Training\Final Task\FirstLoookD01\FirstLoook\Views\Resutl\GettAll.cshtml"
               Write(result);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\r\n\t\t\t\t\t</td>\r\n\t\t\t\t\t<td>\r\n");
#nullable restore
#line 30 "D:\ITI_Pro\ITI_Training\Final Task\FirstLoookD01\FirstLoook\Views\Resutl\GettAll.cshtml"
                          
                        
                        var resultN=Db.Trainees.Where(p=>p.Id==dept.traineeId).Select(p=>p.Name).Single();
						
					

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t");
#nullable restore
#line 35 "D:\ITI_Pro\ITI_Training\Final Task\FirstLoookD01\FirstLoook\Views\Resutl\GettAll.cshtml"
               Write(resultN);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\t\t\t\t\t<td>\r\n");
#nullable restore
#line 38 "D:\ITI_Pro\ITI_Training\Final Task\FirstLoookD01\FirstLoook\Views\Resutl\GettAll.cshtml"
                          
                        
                        var resultC=Db.Courses.Where(p=>p.Id==dept.crsId).Select(p=>p.Name).Single();
						
					

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t");
#nullable restore
#line 43 "D:\ITI_Pro\ITI_Training\Final Task\FirstLoookD01\FirstLoook\Views\Resutl\GettAll.cshtml"
               Write(resultC);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t");
#nullable restore
#line 46 "D:\ITI_Pro\ITI_Training\Final Task\FirstLoookD01\FirstLoook\Views\Resutl\GettAll.cshtml"
                   Write(dept.degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\t\t\t\t\t\r\n\t\t\t\t</tr>\r\n");
#nullable restore
#line 50 "D:\ITI_Pro\ITI_Training\Final Task\FirstLoookD01\FirstLoook\Views\Resutl\GettAll.cshtml"
		}
		

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\r\n\t\t\r\n\t</tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CrsResult>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
