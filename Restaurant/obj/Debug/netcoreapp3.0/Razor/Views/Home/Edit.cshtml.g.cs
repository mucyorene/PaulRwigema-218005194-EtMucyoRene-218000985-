#pragma checksum "C:\Users\MUCYO\RiderProjects\Restaurant\Restaurant\Views\Home\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59e08cca3ce6eccc67152e73b611bc7a7970e590"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Edit), @"mvc.1.0.view", @"/Views/Home/Edit.cshtml")]
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
#line 1 "C:\Users\MUCYO\RiderProjects\Restaurant\Restaurant\Views\Home\Edit.cshtml"
using Restaurant.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MUCYO\RiderProjects\Restaurant\Restaurant\Views\Home\Edit.cshtml"
using Restaurant.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59e08cca3ce6eccc67152e73b611bc7a7970e590", @"/Views/Home/Edit.cshtml")]
    public class Views_Home_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Restaurant>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/header.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\MUCYO\RiderProjects\Restaurant\Restaurant\Views\Home\Edit.cshtml"
  
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n\r\n");
            WriteLiteral("        \r\n<div class=\"row\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "59e08cca3ce6eccc67152e73b611bc7a7970e5903914", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</div>
<div class=""row"">
    <div class=""col-md-2""></div><div class=""col-md-8"">
        <div class=""text-center""><h3 style=""color: #2270C0;"">Edit Restaurant</h3></div>
        <form method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Name"" class=""control-label""></label>
                <input asp-for=""Name"" name=""Name""");
            BeginWriteAttribute("value", " value=\"", 688, "\"", 707, 1);
#nullable restore
#line 20 "C:\Users\MUCYO\RiderProjects\Restaurant\Restaurant\Views\Home\Edit.cshtml"
WriteAttributeValue("", 696, Model.Name, 696, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"  class=""form-control""/>
                <span asp-validation-for=""Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Cuisine"" class=""control-label""></label>
                <select asp-for=""Cuisine"" name=""Cuisine"" class=""form-control"">

");
#nullable restore
#line 27 "C:\Users\MUCYO\RiderProjects\Restaurant\Restaurant\Views\Home\Edit.cshtml"
                     foreach (CuisineType c in (CuisineType[]) Enum.GetValues(typeof(CuisineType)))
                    {
                        if (@c==@Model.Cuisine)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 1259, "\"", 1286, 1);
#nullable restore
#line 31 "C:\Users\MUCYO\RiderProjects\Restaurant\Restaurant\Views\Home\Edit.cshtml"
WriteAttributeValue("", 1267, Convert.ToInt32(c), 1267, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" selected>");
#nullable restore
#line 31 "C:\Users\MUCYO\RiderProjects\Restaurant\Restaurant\Views\Home\Edit.cshtml"
                                                                    Write(c);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 32 "C:\Users\MUCYO\RiderProjects\Restaurant\Restaurant\Views\Home\Edit.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 1429, "\"", 1456, 1);
#nullable restore
#line 35 "C:\Users\MUCYO\RiderProjects\Restaurant\Restaurant\Views\Home\Edit.cshtml"
WriteAttributeValue("", 1437, Convert.ToInt32(c), 1437, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 35 "C:\Users\MUCYO\RiderProjects\Restaurant\Restaurant\Views\Home\Edit.cshtml"
                                                           Write(c);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 36 "C:\Users\MUCYO\RiderProjects\Restaurant\Restaurant\Views\Home\Edit.cshtml"
                        }
                        

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </select>\r\n                <span asp-validation-for=\"Cuisine\" class=\"text-danger\"></span>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\"");
            BeginWriteAttribute("asp-for", " asp-for=\"", 1752, "\"", 1762, 0);
            EndWriteAttribute();
            WriteLiteral("  value=\"Save Changes\" class=\"btn btn-primary\"/>\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div><div class=\"col-md-2\"></div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Restaurant> Html { get; private set; }
    }
}
#pragma warning restore 1591
