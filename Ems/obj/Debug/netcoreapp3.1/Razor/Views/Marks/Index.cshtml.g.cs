#pragma checksum "C:\Users\pawan\source\repos\Ems\Ems\Views\Marks\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2942a93f5245bd2e4810ecfe30f271dad2b73f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Marks_Index), @"mvc.1.0.razor-page", @"/Views/Marks/Index.cshtml")]
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
#line 1 "C:\Users\pawan\source\repos\Ems\Ems\Views\_ViewImports.cshtml"
using Ems;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pawan\source\repos\Ems\Ems\Views\_ViewImports.cshtml"
using Ems.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2942a93f5245bd2e4810ecfe30f271dad2b73f9", @"/Views/Marks/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65e6626f2b2997a7fceed14d3665a1b6784ed01e", @"/Views/_ViewImports.cshtml")]
    public class Views_Marks_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<br />\r\n<h1>");
#nullable restore
#line 6 "C:\Users\pawan\source\repos\Ems\Ems\Views\Marks\Index.cshtml"
Write(ViewBag.Marks);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ems.Views.Marks.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ems.Views.Marks.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ems.Views.Marks.IndexModel>)PageContext?.ViewData;
        public Ems.Views.Marks.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591