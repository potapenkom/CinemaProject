#pragma checksum "C:\Projects\CinemaProject\CinemaProject\Views\Actor\ActorList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d0d8bfce117591bd3cbffaf0c531b29b7b1939a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Actor_ActorList), @"mvc.1.0.view", @"/Views/Actor/ActorList.cshtml")]
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
#line 1 "C:\Projects\CinemaProject\CinemaProject\Views\Actor\ActorList.cshtml"
using CinemaProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d0d8bfce117591bd3cbffaf0c531b29b7b1939a", @"/Views/Actor/ActorList.cshtml")]
    public class Views_Actor_ActorList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Actor>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row d-flex justify-content-center"">
    <div class=""col-10 mt-5"">
        <table class=""table table-hover table-bg-light"">
            <thead>
                <tr>
                    <th scope=""col"">#</th>
                    <th scope=""col"">First Name</th>
                    <th scope=""col"">Last Name</th>
                    <th scope=""col"">Age</th>
                </tr>
            </thead>
");
#nullable restore
#line 15 "C:\Projects\CinemaProject\CinemaProject\Views\Actor\ActorList.cshtml"
              
                foreach (var actor in Model)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tbody>\r\n                        <tr>\r\n                            <th scope=\"row\">");
#nullable restore
#line 21 "C:\Projects\CinemaProject\CinemaProject\Views\Actor\ActorList.cshtml"
                                       Write(actor.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>");
#nullable restore
#line 22 "C:\Projects\CinemaProject\CinemaProject\Views\Actor\ActorList.cshtml"
                           Write(actor.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 23 "C:\Projects\CinemaProject\CinemaProject\Views\Actor\ActorList.cshtml"
                           Write(actor.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 24 "C:\Projects\CinemaProject\CinemaProject\Views\Actor\ActorList.cshtml"
                           Write(actor.Age.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                    </tbody>\r\n");
#nullable restore
#line 27 "C:\Projects\CinemaProject\CinemaProject\Views\Actor\ActorList.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Actor>> Html { get; private set; }
    }
}
#pragma warning restore 1591