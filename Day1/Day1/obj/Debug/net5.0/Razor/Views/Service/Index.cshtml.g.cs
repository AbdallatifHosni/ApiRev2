#pragma checksum "C:\Users\Christen\Desktop\FS Intake 42\Day1\Day1\Day1\Views\Service\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7066abbef67c180d17a246ab1a3a436b5e9dc2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Index), @"mvc.1.0.view", @"/Views/Service/Index.cshtml")]
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
#line 1 "C:\Users\Christen\Desktop\FS Intake 42\Day1\Day1\Day1\Views\_ViewImports.cshtml"
using Day1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Christen\Desktop\FS Intake 42\Day1\Day1\Day1\Views\_ViewImports.cshtml"
using Day1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Christen\Desktop\FS Intake 42\Day1\Day1\Day1\Views\_ViewImports.cshtml"
using Day1.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Christen\Desktop\FS Intake 42\Day1\Day1\Day1\Views\_ViewImports.cshtml"
using Day1.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7066abbef67c180d17a246ab1a3a436b5e9dc2b", @"/Views/Service/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8fc7c7812dfd7d38266b01b8349f8e331ac6748", @"/Views/_ViewImports.cshtml")]
    public class Views_Service_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>From Controller service id= ");
#nullable restore
#line 3 "C:\Users\Christen\Desktop\FS Intake 42\Day1\Day1\Day1\Views\Service\Index.cshtml"
                           Write(ViewBag.serviceID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>From View service id= ");
#nullable restore
#line 4 "C:\Users\Christen\Desktop\FS Intake 42\Day1\Day1\Day1\Views\Service\Index.cshtml"
                      Write(injService.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStudentRepository injService { get; private set; }
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