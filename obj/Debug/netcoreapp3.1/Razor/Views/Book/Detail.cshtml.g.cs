#pragma checksum "C:\Users\hp\Desktop\village_de_emploi\programmation_.net_framework\Projet.ASP.NET.Core.MVC\Views\Book\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94c86172cb67a4d1fe9d9f72ec36e88f2b273c9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Detail), @"mvc.1.0.view", @"/Views/Book/Detail.cshtml")]
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
#line 1 "C:\Users\hp\Desktop\village_de_emploi\programmation_.net_framework\Projet.ASP.NET.Core.MVC\Views\_ViewImports.cshtml"
using Projet.ASP.NET.Core.MVC.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\Desktop\village_de_emploi\programmation_.net_framework\Projet.ASP.NET.Core.MVC\Views\_ViewImports.cshtml"
using Projet.ASP.NET.Core.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94c86172cb67a4d1fe9d9f72ec36e88f2b273c9d", @"/Views/Book/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed7209827dac19547f4d9a604ff87fc41def828e", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"col-sm-4 col-lg-4 col-md-4\">\r\n    <div class=\"thumbnail\">\r\n        <h2>\r\n            <a>");
#nullable restore
#line 6 "C:\Users\hp\Desktop\village_de_emploi\programmation_.net_framework\Projet.ASP.NET.Core.MVC\Views\Book\Detail.cshtml"
          Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </h2>\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 159, "\"", 182, 1);
#nullable restore
#line 8 "C:\Users\hp\Desktop\village_de_emploi\programmation_.net_framework\Projet.ASP.NET.Core.MVC\Views\Book\Detail.cshtml"
WriteAttributeValue("", 165, Model.ImageurUrl, 165, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 183, "\"", 189, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"250\" height=\"500\">\r\n        <div class=\"caption-full\">\r\n            <p>");
#nullable restore
#line 10 "C:\Users\hp\Desktop\village_de_emploi\programmation_.net_framework\Projet.ASP.NET.Core.MVC\Views\Book\Detail.cshtml"
          Write(Model.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>");
#nullable restore
#line 11 "C:\Users\hp\Desktop\village_de_emploi\programmation_.net_framework\Projet.ASP.NET.Core.MVC\Views\Book\Detail.cshtml"
          Write(Model.LongDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <h3 class=\"pull-right\">");
#nullable restore
#line 12 "C:\Users\hp\Desktop\village_de_emploi\programmation_.net_framework\Projet.ASP.NET.Core.MVC\Views\Book\Detail.cshtml"
                              Write(Model.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
