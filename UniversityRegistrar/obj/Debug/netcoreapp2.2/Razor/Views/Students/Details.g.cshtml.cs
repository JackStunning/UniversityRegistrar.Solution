#pragma checksum "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Students\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcb27a4b237bf038352924c2f9fdce7303e1ce21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Details), @"mvc.1.0.view", @"/Views/Students/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Students/Details.cshtml", typeof(AspNetCore.Views_Students_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcb27a4b237bf038352924c2f9fdce7303e1ce21", @"/Views/Students/Details.cshtml")]
    public class Views_Students_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UniversityRegistrar.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Students\Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(76, 40, true);
            WriteLiteral("\r\n<h2>Student Details</h2>\r\n<hr />\r\n<h3>");
            EndContext();
            BeginContext(117, 54, false);
#line 9 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Students\Details.cshtml"
Write(Html.ActionLink($"{ Model.Name }", "Index", "Courses"));

#line default
#line hidden
            EndContext();
            BeginContext(171, 9, true);
            WriteLiteral("</h3>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Students\Details.cshtml"
 if(@Model.Courses.Count == 0)
{

#line default
#line hidden
            BeginContext(215, 50, true);
            WriteLiteral("  <p>This student does not contain any items</p>\r\n");
            EndContext();
#line 14 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Students\Details.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(277, 50, true);
            WriteLiteral("  <h4>Courses the student contains:</h4>\r\n  <ul>\r\n");
            EndContext();
#line 19 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Students\Details.cshtml"
   foreach(var join in Model.Courses)
  {

#line default
#line hidden
            BeginContext(371, 18, true);
            WriteLiteral("    <li id=\"mark\">");
            EndContext();
            BeginContext(390, 22, false);
#line 21 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Students\Details.cshtml"
             Write(join.Course.CourseName);

#line default
#line hidden
            EndContext();
            BeginContext(412, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 22 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Students\Details.cshtml"
  }

#line default
#line hidden
            BeginContext(424, 9, true);
            WriteLiteral("  </ul>\r\n");
            EndContext();
            BeginContext(435, 35, true);
            WriteLiteral("  <h4>Student Major:</h4>\r\n  <ul>\r\n");
            EndContext();
#line 27 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Students\Details.cshtml"
   foreach(var join in Model.Departments)
  {

#line default
#line hidden
            BeginContext(518, 18, true);
            WriteLiteral("    <li id=\"mark\">");
            EndContext();
            BeginContext(537, 10, false);
#line 29 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Students\Details.cshtml"
             Write(join.Major);

#line default
#line hidden
            EndContext();
            BeginContext(547, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 30 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Students\Details.cshtml"
  }

#line default
#line hidden
            BeginContext(559, 9, true);
            WriteLiteral("  </ul>\r\n");
            EndContext();
#line 32 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Students\Details.cshtml"
}

#line default
#line hidden
            BeginContext(571, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(577, 52, false);
#line 34 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Students\Details.cshtml"
Write(Html.ActionLink("Set Major", "Index", "Departments"));

#line default
#line hidden
            EndContext();
            BeginContext(629, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(639, 44, false);
#line 35 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Students\Details.cshtml"
Write(Html.ActionLink("Back to Students", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(683, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(693, 69, false);
#line 36 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Students\Details.cshtml"
Write(Html.ActionLink("Edit Student", "Edit", new { id = Model.StudentId }));

#line default
#line hidden
            EndContext();
            BeginContext(762, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(772, 73, false);
#line 37 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Students\Details.cshtml"
Write(Html.ActionLink("Delete Student", "Delete", new { id = Model.StudentId }));

#line default
#line hidden
            EndContext();
            BeginContext(845, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UniversityRegistrar.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
