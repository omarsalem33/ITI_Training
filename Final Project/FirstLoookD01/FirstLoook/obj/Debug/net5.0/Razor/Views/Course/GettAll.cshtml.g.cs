#pragma checksum "D:\ITI_Pro\ITI_Training\Final Task\FirstLoookD01\FirstLoook\Views\Course\GettAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad4b55c3c63207da66005f367c216c78d7562ed0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_GettAll), @"mvc.1.0.view", @"/Views/Course/GettAll.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad4b55c3c63207da66005f367c216c78d7562ed0", @"/Views/Course/GettAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e60183e4f7ed03767e5e99f350c8d3f54052873a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Course_GettAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Course>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<h1>Courses</h1>\r\n<table class=\"table table-hover table-bordered\">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t<th>Id</th>\r\n\t\t\t<th>Name</th>\r\n\t\t\t<th>Degree</th>\r\n\t\t\t<th>MinDegree</th>\r\n\t\t\t<th>Department_Id</th>\r\n\t\t</tr>\r\n\t</thead>\r\n\t<tbody>\r\n");
#nullable restore
#line 15 "D:\ITI_Pro\ITI_Training\Final Task\FirstLoookD01\FirstLoook\Views\Course\GettAll.cshtml"
         foreach(var dept in Model)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 305, "\"", 335, 2);
            WriteAttributeValue("", 312, "/Course/getIns/", 312, 15, true);
#nullable restore
#line 19 "D:\ITI_Pro\ITI_Training\Final Task\FirstLoookD01\FirstLoook\Views\Course\GettAll.cshtml"
WriteAttributeValue("", 327, dept.Id, 327, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "D:\ITI_Pro\ITI_Training\Final Task\FirstLoookD01\FirstLoook\Views\Course\GettAll.cshtml"
                                                 Write(dept.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 22 "D:\ITI_Pro\ITI_Training\Final Task\FirstLoookD01\FirstLoook\Views\Course\GettAll.cshtml"
               Write(dept.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 25 "D:\ITI_Pro\ITI_Training\Final Task\FirstLoookD01\FirstLoook\Views\Course\GettAll.cshtml"
               Write(dept.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 28 "D:\ITI_Pro\ITI_Training\Final Task\FirstLoookD01\FirstLoook\Views\Course\GettAll.cshtml"
               Write(dept.MinDegree);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 500, "\"", 538, 2);
            WriteAttributeValue("", 507, "/Department/getOne/", 507, 19, true);
#nullable restore
#line 31 "D:\ITI_Pro\ITI_Training\Final Task\FirstLoookD01\FirstLoook\Views\Course\GettAll.cshtml"
WriteAttributeValue("", 526, dept.DeptId, 526, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 31 "D:\ITI_Pro\ITI_Training\Final Task\FirstLoookD01\FirstLoook\Views\Course\GettAll.cshtml"
                                                         Write(dept.DeptId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t</td>\r\n\t\t\t</tr>\r\n");
#nullable restore
#line 34 "D:\ITI_Pro\ITI_Training\Final Task\FirstLoookD01\FirstLoook\Views\Course\GettAll.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\r\n\t</tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Course>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
