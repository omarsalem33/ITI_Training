#pragma checksum "D:\ITI_Pro\ITI_Training\Final Task\FirstLoookD01\FirstLoook\Views\Instructor\GettAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cc08d0ef1767a0b631efa6fde617100753ff1fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Instructor_GettAll), @"mvc.1.0.view", @"/Views/Instructor/GettAll.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cc08d0ef1767a0b631efa6fde617100753ff1fc", @"/Views/Instructor/GettAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e60183e4f7ed03767e5e99f350c8d3f54052873a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Instructor_GettAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Instructor>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Instructor</h1>\r\n<table class=\"table table-hover table-bordered\">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t<th>Id</th>\r\n\t\t\t<th>Name</th>\r\n\t\t\t<th>Adress</th>\r\n\t\t\t<th>Grade</th>\r\n\t\t\t<th>Department_Id</th>\r\n\t\t\t<th>Course_Id</th>\r\n\t\t</tr>\r\n\t</thead>\r\n\t<tbody>\r\n");
#nullable restore
#line 15 "D:\ITI_Pro\ITI_Training\Final Task\FirstLoookD01\FirstLoook\Views\Instructor\GettAll.cshtml"
         foreach(var dept in Model)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 329, "\"", 363, 2);
            WriteAttributeValue("", 336, "/Instructor/getOne/", 336, 19, true);
#nullable restore
#line 19 "D:\ITI_Pro\ITI_Training\Final Task\FirstLoookD01\FirstLoook\Views\Instructor\GettAll.cshtml"
WriteAttributeValue("", 355, dept.Id, 355, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "D:\ITI_Pro\ITI_Training\Final Task\FirstLoookD01\FirstLoook\Views\Instructor\GettAll.cshtml"
                                                     Write(dept.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 22 "D:\ITI_Pro\ITI_Training\Final Task\FirstLoookD01\FirstLoook\Views\Instructor\GettAll.cshtml"
               Write(dept.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 25 "D:\ITI_Pro\ITI_Training\Final Task\FirstLoookD01\FirstLoook\Views\Instructor\GettAll.cshtml"
               Write(dept.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 28 "D:\ITI_Pro\ITI_Training\Final Task\FirstLoookD01\FirstLoook\Views\Instructor\GettAll.cshtml"
               Write(dept.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("$\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 527, "\"", 565, 2);
            WriteAttributeValue("", 534, "/Department/getOne/", 534, 19, true);
#nullable restore
#line 31 "D:\ITI_Pro\ITI_Training\Final Task\FirstLoookD01\FirstLoook\Views\Instructor\GettAll.cshtml"
WriteAttributeValue("", 553, dept.DeptId, 553, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 31 "D:\ITI_Pro\ITI_Training\Final Task\FirstLoookD01\FirstLoook\Views\Instructor\GettAll.cshtml"
                                                         Write(dept.DeptId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 613, "\"", 647, 2);
            WriteAttributeValue("", 620, "/Course/getOne/", 620, 15, true);
#nullable restore
#line 34 "D:\ITI_Pro\ITI_Training\Final Task\FirstLoookD01\FirstLoook\Views\Instructor\GettAll.cshtml"
WriteAttributeValue("", 635, dept.CrstId, 635, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 34 "D:\ITI_Pro\ITI_Training\Final Task\FirstLoookD01\FirstLoook\Views\Instructor\GettAll.cshtml"
                                                     Write(dept.CrstId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t</td>\r\n\t\t\t</tr>\r\n");
#nullable restore
#line 37 "D:\ITI_Pro\ITI_Training\Final Task\FirstLoookD01\FirstLoook\Views\Instructor\GettAll.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\r\n\t</tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Instructor>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591