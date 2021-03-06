#pragma checksum "C:\Projects\CinemaProject\CinemaProject\Views\Director\DirectorList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a5db6a8d9725e66755ebd27046615766bfeddc5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Director_DirectorList), @"mvc.1.0.view", @"/Views/Director/DirectorList.cshtml")]
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
#line 1 "C:\Projects\CinemaProject\CinemaProject\Views\Director\DirectorList.cshtml"
using CinemaProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a5db6a8d9725e66755ebd27046615766bfeddc5", @"/Views/Director/DirectorList.cshtml")]
    public class Views_Director_DirectorList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Director>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Projects\CinemaProject\CinemaProject\Views\Director\DirectorList.cshtml"
  
    ViewBag.Title = "All Directors";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h2>");
#nullable restore
#line 8 "C:\Projects\CinemaProject\CinemaProject\Views\Director\DirectorList.cshtml"
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
                    <th scope=""col"">First Name</th>
                    <th scope=""col"">Last Name</th>
                    <th scope=""col"">Birth Date</th>
                    <th scope=""col"">Movie</th>
                </tr>
            </thead>
");
#nullable restore
#line 21 "C:\Projects\CinemaProject\CinemaProject\Views\Director\DirectorList.cshtml"
              
                foreach (var director in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tbody>\r\n                        <tr>\r\n                            <th scope=\"row\">");
#nullable restore
#line 26 "C:\Projects\CinemaProject\CinemaProject\Views\Director\DirectorList.cshtml"
                                       Write(director.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>");
#nullable restore
#line 27 "C:\Projects\CinemaProject\CinemaProject\Views\Director\DirectorList.cshtml"
                           Write(director.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 28 "C:\Projects\CinemaProject\CinemaProject\Views\Director\DirectorList.cshtml"
                           Write(director.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 29 "C:\Projects\CinemaProject\CinemaProject\Views\Director\DirectorList.cshtml"
                           Write(director.BirthDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 30 "C:\Projects\CinemaProject\CinemaProject\Views\Director\DirectorList.cshtml"
                           Write(director.Movie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                    </tbody>\r\n");
#nullable restore
#line 33 "C:\Projects\CinemaProject\CinemaProject\Views\Director\DirectorList.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Director>> Html { get; private set; }
    }
}
#pragma warning restore 1591
