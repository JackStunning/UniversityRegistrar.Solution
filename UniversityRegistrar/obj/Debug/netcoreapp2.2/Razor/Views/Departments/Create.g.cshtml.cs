#pragma checksum "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Departments\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db92fe326b0fb312cb3fa2b118270c0d612aa998"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Departments_Create), @"mvc.1.0.view", @"/Views/Departments/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Departments/Create.cshtml", typeof(AspNetCore.Views_Departments_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db92fe326b0fb312cb3fa2b118270c0d612aa998", @"/Views/Departments/Create.cshtml")]
    public class Views_Departments_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UniversityRegistrar.Models.Department>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Departments\Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(78, 31, true);
            WriteLiteral("\r\n<h2>Add new Department</h2>\r\n");
            EndContext();
#line 8 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Departments\Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(144, 35, false);
#line 10 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Departments\Create.cshtml"
Write(Html.LabelFor(model => model.Major));

#line default
#line hidden
            EndContext();
            BeginContext(186, 37, false);
#line 11 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Departments\Create.cshtml"
Write(Html.TextBoxFor(model => model.Major));

#line default
#line hidden
            EndContext();
            BeginContext(225, 20, true);
            WriteLiteral("    <br>\r\n    <br>\r\n");
            EndContext();
            BeginContext(252, 28, false);
#line 15 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Departments\Create.cshtml"
Write(Html.Label("Select student"));

#line default
#line hidden
            EndContext();
            BeginContext(287, 30, false);
#line 16 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Departments\Create.cshtml"
Write(Html.DropDownList("StudentId"));

#line default
#line hidden
            EndContext();
            BeginContext(317, 6, true);
            WriteLiteral("<br>\r\n");
            EndContext();
            BeginContext(325, 71, true);
            WriteLiteral("    <input class=\"button\" type=\"submit\" value=\"Add new Department\" />\r\n");
            EndContext();
#line 19 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Departments\Create.cshtml"
}

#line default
#line hidden
            BeginContext(399, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(403, 48, false);
#line 20 "C:\Users\Stunning\Desktop\epicodusProjects\c#\UniversityRegistrar.Solution\UniversityRegistrar\Views\Departments\Create.cshtml"
Write(Html.ActionLink("Show all Departments", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(451, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UniversityRegistrar.Models.Department> Html { get; private set; }
    }
}
#pragma warning restore 1591
