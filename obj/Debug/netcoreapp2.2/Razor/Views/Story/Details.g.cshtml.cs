#pragma checksum "/Users/ryl/Documents/Course/CSE686_IP/Lab/Lab9/StoryWebsite/Views/Story/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d2196b3d164b535ed8bcbd8fb2296f32740bf05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Story_Details), @"mvc.1.0.view", @"/Views/Story/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Story/Details.cshtml", typeof(AspNetCore.Views_Story_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d2196b3d164b535ed8bcbd8fb2296f32740bf05", @"/Views/Story/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Story_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StoryWebsite.Models.Story>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/ryl/Documents/Course/CSE686_IP/Lab/Lab9/StoryWebsite/Views/Story/Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(80, 6, true);
            WriteLiteral("\r\n<img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 86, "\"", 108, 1);
#line 7 "/Users/ryl/Documents/Course/CSE686_IP/Lab/Lab9/StoryWebsite/Views/Story/Details.cshtml"
WriteAttributeValue("", 92, Href(Model.url), 92, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 109, "\"", 127, 1);
#line 7 "/Users/ryl/Documents/Course/CSE686_IP/Lab/Lab9/StoryWebsite/Views/Story/Details.cshtml"
WriteAttributeValue("", 115, Model.title, 115, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(128, 215, true);
            WriteLiteral(" class=\"img-disp\">\r\n<div class=\"detail-info\">\r\n    <div class=\"story-info\">\r\n        <div class=\"detail-title\">Story Info</div>\r\n        <hr />\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(344, 41, false);
#line 14 "/Users/ryl/Documents/Course/CSE686_IP/Lab/Lab9/StoryWebsite/Views/Story/Details.cshtml"
           Write(Html.DisplayNameFor(model => model.title));

#line default
#line hidden
            EndContext();
            BeginContext(385, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(441, 37, false);
#line 17 "/Users/ryl/Documents/Course/CSE686_IP/Lab/Lab9/StoryWebsite/Views/Story/Details.cshtml"
           Write(Html.DisplayFor(model => model.title));

#line default
#line hidden
            EndContext();
            BeginContext(478, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(534, 42, false);
#line 20 "/Users/ryl/Documents/Course/CSE686_IP/Lab/Lab9/StoryWebsite/Views/Story/Details.cshtml"
           Write(Html.DisplayNameFor(model => model.author));

#line default
#line hidden
            EndContext();
            BeginContext(576, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(632, 47, false);
#line 23 "/Users/ryl/Documents/Course/CSE686_IP/Lab/Lab9/StoryWebsite/Views/Story/Details.cshtml"
           Write(Html.DisplayFor(model => model.author.userName));

#line default
#line hidden
            EndContext();
            BeginContext(679, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(735, 43, false);
#line 26 "/Users/ryl/Documents/Course/CSE686_IP/Lab/Lab9/StoryWebsite/Views/Story/Details.cshtml"
           Write(Html.DisplayNameFor(model => model.content));

#line default
#line hidden
            EndContext();
            BeginContext(778, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(834, 39, false);
#line 29 "/Users/ryl/Documents/Course/CSE686_IP/Lab/Lab9/StoryWebsite/Views/Story/Details.cshtml"
           Write(Html.DisplayFor(model => model.content));

#line default
#line hidden
            EndContext();
            BeginContext(873, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(929, 44, false);
#line 32 "/Users/ryl/Documents/Course/CSE686_IP/Lab/Lab9/StoryWebsite/Views/Story/Details.cshtml"
           Write(Html.DisplayNameFor(model => model.category));

#line default
#line hidden
            EndContext();
            BeginContext(973, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1029, 53, false);
#line 35 "/Users/ryl/Documents/Course/CSE686_IP/Lab/Lab9/StoryWebsite/Views/Story/Details.cshtml"
           Write(Html.DisplayFor(model => model.category.categoryName));

#line default
#line hidden
            EndContext();
            BeginContext(1082, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1138, 46, false);
#line 38 "/Users/ryl/Documents/Course/CSE686_IP/Lab/Lab9/StoryWebsite/Views/Story/Details.cshtml"
           Write(Html.DisplayNameFor(model => model.createTime));

#line default
#line hidden
            EndContext();
            BeginContext(1184, 39, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n");
            EndContext();
            BeginContext(1288, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1305, 59, false);
#line 42 "/Users/ryl/Documents/Course/CSE686_IP/Lab/Lab9/StoryWebsite/Views/Story/Details.cshtml"
           Write(Html.ValueFor(model => model.createTime, "{0:dd MMM yyyy}"));

#line default
#line hidden
            EndContext();
            BeginContext(1364, 145, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n    <div class=\"comments\">\r\n        <div class=\"comment-title\">Comments</div>\r\n        <hr />\r\n\r\n");
            EndContext();
#line 50 "/Users/ryl/Documents/Course/CSE686_IP/Lab/Lab9/StoryWebsite/Views/Story/Details.cshtml"
         foreach (var cm in Model.comments)
        {

#line default
#line hidden
            BeginContext(1565, 122, true);
            WriteLiteral("            <div class=\"comments-row\">\r\n                <div class=\"avatar-column\">\r\n                    <img alt=\"Avatar\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1687, "\"", 1719, 1);
#line 54 "/Users/ryl/Documents/Course/CSE686_IP/Lab/Lab9/StoryWebsite/Views/Story/Details.cshtml"
WriteAttributeValue("", 1693, Href(cm.author.avatarURL), 1693, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1720, 97, true);
            WriteLiteral(">\r\n                </div>\r\n                <div class=\"comment-column\">\r\n                    <p> ");
            EndContext();
            BeginContext(1818, 10, false);
#line 57 "/Users/ryl/Documents/Course/CSE686_IP/Lab/Lab9/StoryWebsite/Views/Story/Details.cshtml"
                   Write(cm.content);

#line default
#line hidden
            EndContext();
            BeginContext(1828, 109, true);
            WriteLiteral(" </p>\r\n                    <div class=\"comment-meta\">\r\n                        <span class=\"comment-author\"> ");
            EndContext();
            BeginContext(1938, 18, false);
#line 59 "/Users/ryl/Documents/Course/CSE686_IP/Lab/Lab9/StoryWebsite/Views/Story/Details.cshtml"
                                                 Write(cm.author.userName);

#line default
#line hidden
            EndContext();
            BeginContext(1956, 62, true);
            WriteLiteral(" </span>\r\n                        <span class=\"comment-date\"> ");
            EndContext();
            BeginContext(2019, 54, false);
#line 60 "/Users/ryl/Documents/Course/CSE686_IP/Lab/Lab9/StoryWebsite/Views/Story/Details.cshtml"
                                               Write(Html.ValueFor(model => cm.postTime, "{0:dd MMM yyyy}"));

#line default
#line hidden
            EndContext();
            BeginContext(2073, 102, true);
            WriteLiteral(" </span>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <hr />\r\n");
            EndContext();
#line 65 "/Users/ryl/Documents/Course/CSE686_IP/Lab/Lab9/StoryWebsite/Views/Story/Details.cshtml"
        }

#line default
#line hidden
            BeginContext(2186, 22, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StoryWebsite.Models.Story> Html { get; private set; }
    }
}
#pragma warning restore 1591
