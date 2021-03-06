#pragma checksum "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Courses\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d293f931bdf9187cca265ec7a7f93dd1c76c2d42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_Details), @"mvc.1.0.view", @"/Views/Courses/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Courses/Details.cshtml", typeof(AspNetCore.Views_Courses_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d293f931bdf9187cca265ec7a7f93dd1c76c2d42", @"/Views/Courses/Details.cshtml")]
    public class Views_Courses_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UniversityRegistrar.Models.Course>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Courses\Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(74, 39, true);
            WriteLiteral("\r\n<h2>Course Details</h2>\r\n<hr />\r\n<h3>");
            EndContext();
            BeginContext(114, 46, false);
#line 9 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Courses\Details.cshtml"
Write(Html.DisplayNameFor(model => model.CourseName));

#line default
#line hidden
            EndContext();
            BeginContext(160, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(163, 42, false);
#line 9 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Courses\Details.cshtml"
                                                Write(Html.DisplayFor(model => model.CourseName));

#line default
#line hidden
            EndContext();
            BeginContext(205, 11, true);
            WriteLiteral("</h3>\r\n<h3>");
            EndContext();
            BeginContext(217, 48, false);
#line 10 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Courses\Details.cshtml"
Write(Html.DisplayNameFor(model => model.CourseNumber));

#line default
#line hidden
            EndContext();
            BeginContext(265, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(268, 44, false);
#line 10 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Courses\Details.cshtml"
                                                  Write(Html.DisplayFor(model => model.CourseNumber));

#line default
#line hidden
            EndContext();
            BeginContext(312, 9, true);
            WriteLiteral("</h3>\r\n\r\n");
            EndContext();
#line 12 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Courses\Details.cshtml"
 if(@Model.Students.Count == 0)
{

#line default
#line hidden
            BeginContext(357, 54, true);
            WriteLiteral("  <p>This Course does not belong to any Students</p>\r\n");
            EndContext();
#line 15 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Courses\Details.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(423, 52, true);
            WriteLiteral("  <h4>Students the Course belongs to:</h4>\r\n  <ul>\r\n");
            EndContext();
#line 20 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Courses\Details.cshtml"
   foreach(var join in Model.Students)
  {

#line default
#line hidden
            BeginContext(520, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(529, 101, false);
#line 22 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Courses\Details.cshtml"
   Write(Html.ActionLink($"{ join.Student.Name }", "Details", "Students", new { id = join.Student.StudentId }));

#line default
#line hidden
            EndContext();
            BeginContext(630, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 23 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Courses\Details.cshtml"
     using (Html.BeginForm("DeleteStudent", "Courses"))
    {
      

#line default
#line hidden
            BeginContext(708, 44, false);
#line 25 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Courses\Details.cshtml"
 Write(Html.Hidden("joinId", @join.StudentCourseId));

#line default
#line hidden
            EndContext();
            BeginContext(754, 64, true);
            WriteLiteral("      <input id=\"detailsDelete\" type=\"submit\" value=\"Delete\"/>\r\n");
            EndContext();
#line 27 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Courses\Details.cshtml"
    }

#line default
#line hidden
#line 27 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Courses\Details.cshtml"
     
  }

#line default
#line hidden
            BeginContext(830, 9, true);
            WriteLiteral("  </ul>\r\n");
            EndContext();
#line 30 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Courses\Details.cshtml"
}

#line default
#line hidden
            BeginContext(842, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(848, 40, false);
#line 32 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Courses\Details.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(888, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(898, 75, false);
#line 33 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Courses\Details.cshtml"
Write(Html.ActionLink("Add a Student", "AddStudent", new { id = Model.CourseId }));

#line default
#line hidden
            EndContext();
            BeginContext(973, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(983, 67, false);
#line 34 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Courses\Details.cshtml"
Write(Html.ActionLink("Edit Course", "Edit", new { id = Model.CourseId }));

#line default
#line hidden
            EndContext();
            BeginContext(1050, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(1060, 71, false);
#line 35 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Courses\Details.cshtml"
Write(Html.ActionLink("Delete Course", "Delete", new { id = Model.CourseId }));

#line default
#line hidden
            EndContext();
            BeginContext(1131, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UniversityRegistrar.Models.Course> Html { get; private set; }
    }
}
#pragma warning restore 1591
