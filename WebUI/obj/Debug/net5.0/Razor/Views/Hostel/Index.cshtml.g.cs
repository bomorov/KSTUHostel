#pragma checksum "D:\git\own\Hostel\WebUI\Views\Hostel\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6e050ed467b03e3b942e361680e80d192ca2da6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hostel_Index), @"mvc.1.0.view", @"/Views/Hostel/Index.cshtml")]
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
#line 1 "D:\git\own\Hostel\WebUI\Views\_ViewImports.cshtml"
using WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\git\own\Hostel\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6e050ed467b03e3b942e361680e80d192ca2da6", @"/Views/Hostel/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bad66299b7d007bb162176ca662d9e029671c76", @"/Views/_ViewImports.cshtml")]
    public class Views_Hostel_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebUI.Models.DTOs.HostelDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\git\own\Hostel\WebUI\Views\Hostel\Index.cshtml"
   ViewData["Title"] = "Index"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Список Общежитий</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 12 "D:\git\own\Hostel\WebUI\Views\Hostel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "D:\git\own\Hostel\WebUI\Views\Hostel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Flooring));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\git\own\Hostel\WebUI\Views\Hostel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Capacity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "D:\git\own\Hostel\WebUI\Views\Hostel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LivingRoomCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "D:\git\own\Hostel\WebUI\Views\Hostel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ServiceRoomCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "D:\git\own\Hostel\WebUI\Views\Hostel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OfficeRoomCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Карта здания\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 36 "D:\git\own\Hostel\WebUI\Views\Hostel\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 40 "D:\git\own\Hostel\WebUI\Views\Hostel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 43 "D:\git\own\Hostel\WebUI\Views\Hostel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Flooring));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n\r\n                <th>\r\n                    ");
#nullable restore
#line 47 "D:\git\own\Hostel\WebUI\Views\Hostel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Capacity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 50 "D:\git\own\Hostel\WebUI\Views\Hostel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.LivingRoomCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 53 "D:\git\own\Hostel\WebUI\Views\Hostel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ServiceRoomCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 56 "D:\git\own\Hostel\WebUI\Views\Hostel\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.OfficeRoomCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n");
#nullable restore
#line 59 "D:\git\own\Hostel\WebUI\Views\Hostel\Index.cshtml"
                     foreach (NewsFilesNC item1 in @ViewBag.NewsFilesNC)
                    {
                       

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"carousel-item active\">\r\n                            <img width=\"100%\"");
            BeginWriteAttribute("src", " src=\"", 1900, "\"", 1917, 1);
#nullable restore
#line 63 "D:\git\own\Hostel\WebUI\Views\Hostel\Index.cshtml"
WriteAttributeValue("", 1906, item1.Path, 1906, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1918, "\"", 1924, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            </div>\r\n");
#nullable restore
#line 65 "D:\git\own\Hostel\WebUI\Views\Hostel\Index.cshtml"
                      
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </th>\r\n            </tr>\r\n");
#nullable restore
#line 69 "D:\git\own\Hostel\WebUI\Views\Hostel\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebUI.Models.DTOs.HostelDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
