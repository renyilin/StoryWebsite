#pragma checksum "Z:\Documents\Course\CSE686_IP\MyFinalProject\StoryWebsite_With_Auth\StoryWebsite\StoryWebsite\Views\Story\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ec7bfd8fe75b3f186047a0d0c7ccf2624facc43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Story_Show), @"mvc.1.0.view", @"/Views/Story/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Story/Show.cshtml", typeof(AspNetCore.Views_Story_Show))]
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
#line 1 "Z:\Documents\Course\CSE686_IP\MyFinalProject\StoryWebsite_With_Auth\StoryWebsite\StoryWebsite\Views\Story\Show.cshtml"
using StoryWebsite;

#line default
#line hidden
#line 2 "Z:\Documents\Course\CSE686_IP\MyFinalProject\StoryWebsite_With_Auth\StoryWebsite\StoryWebsite\Views\Story\Show.cshtml"
using StoryWebsite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ec7bfd8fe75b3f186047a0d0c7ccf2624facc43", @"/Views/Story/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"216d4ed7c04549acee3ca5a910874feed3bf3759", @"/Views/_ViewImports.cshtml")]
    public class Views_Story_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StoryWebsite.Models.Story>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "story", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("menubutton"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/show.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("show-body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(138, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "Z:\Documents\Course\CSE686_IP\MyFinalProject\StoryWebsite_With_Auth\StoryWebsite\StoryWebsite\Views\Story\Show.cshtml"
  
    Layout = null;
    ViewData["Title"] = "Show";
    //ViewData["Title"] = Href(slide.url).ToString();

#line default
#line hidden
            BeginContext(255, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(284, 470, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ec7bfd8fe75b3f186047a0d0c7ccf2624facc435809", async() => {
                BeginContext(290, 72, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
                EndContext();
                BeginContext(363, 13, false);
#line 17 "Z:\Documents\Course\CSE686_IP\MyFinalProject\StoryWebsite_With_Auth\StoryWebsite\StoryWebsite\Views\Story\Show.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(376, 36, true);
                WriteLiteral("</title>\r\n    <link rel=\"stylesheet\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 412, "\"", 448, 1);
#line 18 "Z:\Documents\Course\CSE686_IP\MyFinalProject\StoryWebsite_With_Auth\StoryWebsite\StoryWebsite\Views\Story\Show.cshtml"
WriteAttributeValue("", 419, Href("~/CSS/StyleSheet.css"), 419, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(449, 298, true);
                WriteLiteral(@" />
    <link href=""https://fonts.googleapis.com/css?family=Margarine|Roboto"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.8.1/css/all.css"" integrity=""sha384-50oBUHEmvpQ+1lW4y57PTFmhCaXp0ML5d60M1M7uH2+nqUivzIebhndOJK28anvf"" crossorigin=""anonymous"">
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(754, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(756, 1031, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ec7bfd8fe75b3f186047a0d0c7ccf2624facc438265", async() => {
                BeginContext(780, 37, true);
                WriteLiteral("\r\n    <div class=\"menubar\">\r\n        ");
                EndContext();
                BeginContext(817, 135, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ec7bfd8fe75b3f186047a0d0c7ccf2624facc438687", async() => {
                    BeginContext(913, 35, true);
                    WriteLiteral("<i class=\"fas fa-chevron-left\"></i>");
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
#line 24 "Z:\Documents\Course\CSE686_IP\MyFinalProject\StoryWebsite_With_Auth\StoryWebsite\StoryWebsite\Views\Story\Show.cshtml"
                                                         WriteLiteral(Model.storyID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(952, 35, true);
                WriteLiteral("\r\n        <p class=\"flex-grow-1\">1/");
                EndContext();
                BeginContext(988, 20, false);
#line 25 "Z:\Documents\Course\CSE686_IP\MyFinalProject\StoryWebsite_With_Auth\StoryWebsite\StoryWebsite\Views\Story\Show.cshtml"
                            Write(Model.slides.Count());

#line default
#line hidden
                EndContext();
                BeginContext(1008, 127, true);
                WriteLiteral("</p>\r\n        <button id=\"play\" class=\"menubutton\"><i class=\"fas fa-play\"></i></button>\r\n    </div>\r\n    <div class=\"slider\">\r\n");
                EndContext();
#line 29 "Z:\Documents\Course\CSE686_IP\MyFinalProject\StoryWebsite_With_Auth\StoryWebsite\StoryWebsite\Views\Story\Show.cshtml"
         foreach (var slide in Model.slides)
        {
            var url = slide.url;
            url = url.Replace('\\','/');

#line default
#line hidden
                BeginContext(1268, 30, true);
                WriteLiteral("            <div class=\"slide\"");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 1298, "\"", 1358, 7);
                WriteAttributeValue("", 1306, "background:", 1306, 11, true);
                WriteAttributeValue(" ", 1317, "url(", 1318, 5, true);
#line 33 "Z:\Documents\Course\CSE686_IP\MyFinalProject\StoryWebsite_With_Auth\StoryWebsite\StoryWebsite\Views\Story\Show.cshtml"
WriteAttributeValue("", 1322, url, 1322, 4, false);

#line default
#line hidden
                WriteAttributeValue("", 1326, ")", 1326, 1, true);
                WriteAttributeValue(" ", 1327, "no-repeat", 1328, 10, true);
                WriteAttributeValue(" ", 1337, "center", 1338, 7, true);
                WriteAttributeValue(" ", 1344, "center/cover;", 1345, 14, true);
                EndWriteAttribute();
                BeginContext(1359, 66, true);
                WriteLiteral(">\r\n                <div class=\"content\">\r\n                    <h1>");
                EndContext();
                BeginContext(1426, 11, false);
#line 35 "Z:\Documents\Course\CSE686_IP\MyFinalProject\StoryWebsite_With_Auth\StoryWebsite\StoryWebsite\Views\Story\Show.cshtml"
                   Write(slide.title);

#line default
#line hidden
                EndContext();
                BeginContext(1437, 30, true);
                WriteLiteral("</h1>\r\n                    <p>");
                EndContext();
                BeginContext(1468, 17, false);
#line 36 "Z:\Documents\Course\CSE686_IP\MyFinalProject\StoryWebsite_With_Auth\StoryWebsite\StoryWebsite\Views\Story\Show.cshtml"
                  Write(slide.description);

#line default
#line hidden
                EndContext();
                BeginContext(1485, 50, true);
                WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n");
                EndContext();
#line 39 "Z:\Documents\Course\CSE686_IP\MyFinalProject\StoryWebsite_With_Auth\StoryWebsite\StoryWebsite\Views\Story\Show.cshtml"
        }

#line default
#line hidden
                BeginContext(1546, 196, true);
                WriteLiteral("    </div>\r\n    <div class=\"buttons\">\r\n        <button id=\"prev\"><i class=\"fas fa-arrow-left\"></i></button>\r\n        <button id=\"next\"><i class=\"fas fa-arrow-right\"></i></button>\r\n    </div>\r\n    ");
                EndContext();
                BeginContext(1742, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ec7bfd8fe75b3f186047a0d0c7ccf2624facc4314909", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1778, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1787, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
