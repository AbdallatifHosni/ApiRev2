#pragma checksum "C:\Users\Christen\Desktop\FS Intake 42\Day1\Day1\Day1\Views\Student\TestAjax.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdbd7b2f4e446b3c6772c25d509530dbbd5926ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_TestAjax), @"mvc.1.0.view", @"/Views/Student/TestAjax.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdbd7b2f4e446b3c6772c25d509530dbbd5926ab", @"/Views/Student/TestAjax.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8fc7c7812dfd7d38266b01b8349f8e331ac6748", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_TestAjax : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div style=\"background-color:burlywood\" id=\"div1\">\r\n    <!--partial Ajax-->\r\n    \r\n</div>\r\n<input type=\"text\" id=\"id\" />\r\n<input type=\"button\" onclick=\"AjaxCall()\" value=\"Show\" class=\"btn btn-success\"/>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
<script>
        function AjaxCall(){
            var id=$(""#id"").val();
            console.log(id);
            $.ajax(
                {
                    url  : ""/student/testPArtial"",
                    data :{""stdid"":id},
                    success: function(result){
                                $(""#div1"").html(result);
                        }
                }
                );
             }
    </script>
");
            }
            );
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