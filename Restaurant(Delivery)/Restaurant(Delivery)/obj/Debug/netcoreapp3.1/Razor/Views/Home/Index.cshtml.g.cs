#pragma checksum "C:\Users\Antonio\Desktop\Project_4223\Restaurant(Delivery)\Restaurant(Delivery)\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e1e6730572cb56397f81bf10aba4bc89fe4193a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Antonio\Desktop\Project_4223\Restaurant(Delivery)\Restaurant(Delivery)\Views\_ViewImports.cshtml"
using Restaurant_Delivery_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Antonio\Desktop\Project_4223\Restaurant(Delivery)\Restaurant(Delivery)\Views\_ViewImports.cshtml"
using Restaurant_Delivery_.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Antonio\Desktop\Project_4223\Restaurant(Delivery)\Restaurant(Delivery)\Views\_ViewImports.cshtml"
using Restaurant_Delivery_.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e1e6730572cb56397f81bf10aba4bc89fe4193a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be4f146fdd4291ccc53a9e54aa9bb218a4eecf86", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Antonio\Desktop\Project_4223\Restaurant(Delivery)\Restaurant(Delivery)\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("Carousel"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>Hot Deals the week </h2>\r\n<h4>Clients preferences - just for you!</h4>\r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 9 "C:\Users\Antonio\Desktop\Project_4223\Restaurant(Delivery)\Restaurant(Delivery)\Views\Home\Index.cshtml"
     foreach (var product in Model.HotDeals)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Antonio\Desktop\Project_4223\Restaurant(Delivery)\Restaurant(Delivery)\Views\Home\Index.cshtml"
   Write(await Html.PartialAsync("ProductsSummary", product));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Antonio\Desktop\Project_4223\Restaurant(Delivery)\Restaurant(Delivery)\Views\Home\Index.cshtml"
                                                            
   }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
