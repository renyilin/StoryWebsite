#pragma checksum "Z:\Documents\Course\CSE686_IP\MyFinalProject\StoryWebsite_With_Auth\StoryWebsite\StoryWebsite\Views\Story\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b002ae864667c9dc94a23757ef2e73b326d85f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Story_Index), @"mvc.1.0.view", @"/Views/Story/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Story/Index.cshtml", typeof(AspNetCore.Views_Story_Index))]
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
#line 1 "Z:\Documents\Course\CSE686_IP\MyFinalProject\StoryWebsite_With_Auth\StoryWebsite\StoryWebsite\Views\_ViewImports.cshtml"
using StoryWebsite;

#line default
#line hidden
#line 2 "Z:\Documents\Course\CSE686_IP\MyFinalProject\StoryWebsite_With_Auth\StoryWebsite\StoryWebsite\Views\_ViewImports.cshtml"
using StoryWebsite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b002ae864667c9dc94a23757ef2e73b326d85f7", @"/Views/Story/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"216d4ed7c04549acee3ca5a910874feed3bf3759", @"/Views/_ViewImports.cshtml")]
    public class Views_Story_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StoryWebsite.ViewModels.StoryIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "story", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "Z:\Documents\Course\CSE686_IP\MyFinalProject\StoryWebsite_With_Auth\StoryWebsite\StoryWebsite\Views\Story\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(96, 85, true);
            WriteLiteral("\r\n\r\n\r\n\r\n<div class= \"gallery-container\">\r\n    <div class=\"gallery-ctg\">Newest</div>\r\n");
            EndContext();
#line 12 "Z:\Documents\Course\CSE686_IP\MyFinalProject\StoryWebsite_With_Auth\StoryWebsite\StoryWebsite\Views\Story\Index.cshtml"
     foreach (var story in Model.StoryCollection)
    {

#line default
#line hidden
            BeginContext(239, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(247, 416, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b002ae864667c9dc94a23757ef2e73b326d85f74667", async() => {
                BeginContext(324, 57, true);
                WriteLiteral("\r\n            <div class=\"gallery\">\r\n                <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 381, "\"", 403, 1);
#line 16 "Z:\Documents\Course\CSE686_IP\MyFinalProject\StoryWebsite_With_Auth\StoryWebsite\StoryWebsite\Views\Story\Index.cshtml"
WriteAttributeValue("", 387, Href(story.url), 387, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 404, "\"", 422, 1);
#line 16 "Z:\Documents\Course\CSE686_IP\MyFinalProject\StoryWebsite_With_Auth\StoryWebsite\StoryWebsite\Views\Story\Index.cshtml"
WriteAttributeValue("", 410, story.title, 410, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(423, 96, true);
                WriteLiteral(">\r\n                <div class=\"figure-caption\">\r\n                    <div class=\"gallery-title\">");
                EndContext();
                BeginContext(520, 11, false);
#line 18 "Z:\Documents\Course\CSE686_IP\MyFinalProject\StoryWebsite_With_Auth\StoryWebsite\StoryWebsite\Views\Story\Index.cshtml"
                                          Write(story.title);

#line default
#line hidden
                EndContext();
                BeginContext(531, 54, true);
                WriteLiteral("</div>\r\n                    <div class=\"gallery-desc\">");
                EndContext();
                BeginContext(586, 13, false);
#line 19 "Z:\Documents\Course\CSE686_IP\MyFinalProject\StoryWebsite_With_Auth\StoryWebsite\StoryWebsite\Views\Story\Index.cshtml"
                                         Write(story.content);

#line default
#line hidden
                EndContext();
                BeginContext(599, 60, true);
                WriteLiteral("</div>\r\n                </div>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 14 "Z:\Documents\Course\CSE686_IP\MyFinalProject\StoryWebsite_With_Auth\StoryWebsite\StoryWebsite\Views\Story\Index.cshtml"
                                                         WriteLiteral(story.storyID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(663, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 23 "Z:\Documents\Course\CSE686_IP\MyFinalProject\StoryWebsite_With_Auth\StoryWebsite\StoryWebsite\Views\Story\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(672, 12, true);
            WriteLiteral("</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StoryWebsite.ViewModels.StoryIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
