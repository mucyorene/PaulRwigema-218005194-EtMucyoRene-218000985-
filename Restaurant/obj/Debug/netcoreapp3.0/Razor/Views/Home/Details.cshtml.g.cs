#pragma checksum "C:\Users\MUCYO\RiderProjects\Restaurant\Restaurant\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8012e1e2a60ac2a10fd871698447a25ab5929e55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8012e1e2a60ac2a10fd871698447a25ab5929e55", @"/Views/Home/Details.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Restaurant.Models.Restaurant>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\MUCYO\RiderProjects\Restaurant\Restaurant\Views\Home\Details.cshtml"
  
     Layout = "~/Pages/Shared/_Layout.cshtml";
 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row""><img style=""width: 100em;height: 30em;"" src=""https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQz2_q9zpZO3y1rZhXNlnUPoR8Q1vkZP1BCiOBgSiuWBCJz_gTj""/></div>
<div class=""row"">
    <div class=""col-md-2""></div><div class=""col-md-8"">
        <div class=""text-center""><h3 class=""text-success"">Restaurant</h3></div>
        <table class=""table table-borderless"">
            <tr><td>Restaurant Name :</td><td>");
#nullable restore
#line 12 "C:\Users\MUCYO\RiderProjects\Restaurant\Restaurant\Views\Home\Details.cshtml"
                                         Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n            <tr><td>Restaurant Cuisine type: </td><td>");
#nullable restore
#line 13 "C:\Users\MUCYO\RiderProjects\Restaurant\Restaurant\Views\Home\Details.cshtml"
                                                 Write(Model.Cuisine);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n            <tr><td colspan=\"2\"><h6 class=\"text-success\">");
#nullable restore
#line 14 "C:\Users\MUCYO\RiderProjects\Restaurant\Restaurant\Views\Home\Details.cshtml"
                                                    Write(Html.ActionLink("All Restaurant", "Index","Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6></td></tr>\r\n        </table>\r\n    </div>\r\n    \r\n     </div><div class=\"col-md-2\"></div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Restaurant.Models.Restaurant> Html { get; private set; }
    }
}
#pragma warning restore 1591
