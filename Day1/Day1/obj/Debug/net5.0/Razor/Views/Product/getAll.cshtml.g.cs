#pragma checksum "C:\Users\Christen\Desktop\FS Intake 42\Day1\Day1\Day1\Views\Product\getAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1e9d959027a9d30c6f042a1e0006bc71f3d6609"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_getAll), @"mvc.1.0.view", @"/Views/Product/getAll.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1e9d959027a9d30c6f042a1e0006bc71f3d6609", @"/Views/Product/getAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8fc7c7812dfd7d38266b01b8349f8e331ac6748", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_getAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Christen\Desktop\FS Intake 42\Day1\Day1\Day1\Views\Product\getAll.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"border:1px solid red\">\n        ");
#nullable restore
#line 7 "C:\Users\Christen\Desktop\FS Intake 42\Day1\Day1\Day1\Views\Product\getAll.cshtml"
   Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 8 "C:\Users\Christen\Desktop\FS Intake 42\Day1\Day1\Day1\Views\Product\getAll.cshtml"
   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 9 "C:\Users\Christen\Desktop\FS Intake 42\Day1\Day1\Day1\Views\Product\getAll.cshtml"
   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 147, "\"", 172, 2);
            WriteAttributeValue("", 153, "\\images\\", 153, 8, true);
#nullable restore
#line 10 "C:\Users\Christen\Desktop\FS Intake 42\Day1\Day1\Day1\Views\Product\getAll.cshtml"
WriteAttributeValue("", 161, item.Image, 161, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:200px;height:200px\"/>\r\n    </div>\n");
#nullable restore
#line 12 "C:\Users\Christen\Desktop\FS Intake 42\Day1\Day1\Day1\Views\Product\getAll.cshtml"
}

#line default
#line hidden
#nullable disable
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
