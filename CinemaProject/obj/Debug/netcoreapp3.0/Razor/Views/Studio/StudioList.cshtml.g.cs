#pragma checksum "C:\Projects\CinemaProject\CinemaProject\Views\Studio\StudioList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7289f4404ff65899aa906b8084a816a31af5e76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Studio_StudioList), @"mvc.1.0.view", @"/Views/Studio/StudioList.cshtml")]
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
#line 1 "C:\Projects\CinemaProject\CinemaProject\Views\Studio\StudioList.cshtml"
using CinemaProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7289f4404ff65899aa906b8084a816a31af5e76", @"/Views/Studio/StudioList.cshtml")]
    public class Views_Studio_StudioList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Studio>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Projects\CinemaProject\CinemaProject\Views\Studio\StudioList.cshtml"
  
    ViewBag.Title = "All Actors";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 8 "C:\Projects\CinemaProject\CinemaProject\Views\Studio\StudioList.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@".</h2>
<div class=""row d-flex justify-content-center"">
    <div class=""col-10 mt-5"">
        <table class=""table table-hover table-bg-light"">
            <thead>
                <tr>
                    <th scope=""col"">#</th>
                    <th scope=""col"">Name</th>
                </tr>
            </thead>
");
#nullable restore
#line 18 "C:\Projects\CinemaProject\CinemaProject\Views\Studio\StudioList.cshtml"
              
                foreach (var studio in Model)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tbody>\r\n                        <tr>\r\n                            <th scope=\"row\">");
#nullable restore
#line 24 "C:\Projects\CinemaProject\CinemaProject\Views\Studio\StudioList.cshtml"
                                       Write(studio.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>");
#nullable restore
#line 25 "C:\Projects\CinemaProject\CinemaProject\Views\Studio\StudioList.cshtml"
                           Write(studio.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                    </tbody>\r\n");
#nullable restore
#line 28 "C:\Projects\CinemaProject\CinemaProject\Views\Studio\StudioList.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Studio>> Html { get; private set; }
    }
}
#pragma warning restore 1591
