#pragma checksum "C:\Users\FERNANDODASILVASALGA\cms\Views\Cms\DisplayTemplates\HtmlBlock.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48002009f0eb02ad269832c977c1c38de5ba9352"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cms_DisplayTemplates_HtmlBlock), @"mvc.1.0.view", @"/Views/Cms/DisplayTemplates/HtmlBlock.cshtml")]
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
#line 3 "C:\Users\FERNANDODASILVASALGA\cms\Views\_ViewImports.cshtml"
using Piranha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\FERNANDODASILVASALGA\cms\Views\_ViewImports.cshtml"
using Piranha.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\FERNANDODASILVASALGA\cms\Views\_ViewImports.cshtml"
using Piranha.Extend.Blocks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\FERNANDODASILVASALGA\cms\Views\_ViewImports.cshtml"
using cms.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48002009f0eb02ad269832c977c1c38de5ba9352", @"/Views/Cms/DisplayTemplates/HtmlBlock.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"602c266681e31fadb24751579170c927339584f8", @"/Views/_ViewImports.cshtml")]
    public class Views_Cms_DisplayTemplates_HtmlBlock : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HtmlBlock>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\FERNANDODASILVASALGA\cms\Views\Cms\DisplayTemplates\HtmlBlock.cshtml"
Write(Html.Raw(Model.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Piranha.AspNetCore.Services.IApplicationService WebApp { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HtmlBlock> Html { get; private set; }
    }
}
#pragma warning restore 1591
