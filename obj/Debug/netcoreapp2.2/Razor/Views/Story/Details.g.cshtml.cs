#pragma checksum "Z:\Documents\Course\CSE686_IP\Lab\Lab9\StoryWebsite\Views\Story\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9113bda238ef958ef4f74750783e3cbbba595aae"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9113bda238ef958ef4f74750783e3cbbba595aae", @"/Views/Story/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Story_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StoryWebsite.Models.Story>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-green width-150px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "story", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditStory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-red width-150px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteStory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addcomment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("usrform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "Z:\Documents\Course\CSE686_IP\Lab\Lab9\StoryWebsite\Views\Story\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(80, 6, true);
            WriteLiteral("\r\n<img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 86, "\"", 108, 1);
#line 7 "Z:\Documents\Course\CSE686_IP\Lab\Lab9\StoryWebsite\Views\Story\Details.cshtml"
WriteAttributeValue("", 92, Href(Model.url), 92, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 109, "\"", 127, 1);
#line 7 "Z:\Documents\Course\CSE686_IP\Lab\Lab9\StoryWebsite\Views\Story\Details.cshtml"
WriteAttributeValue("", 115, Model.title, 115, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(128, 50, true);
            WriteLiteral(" class=\"img-disp\">\r\n<div class=\"story-btns\">\r\n    ");
            EndContext();
            BeginContext(178, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9113bda238ef958ef4f74750783e3cbbba595aae6782", async() => {
                BeginContext(298, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-storyID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 9 "Z:\Documents\Course\CSE686_IP\Lab\Lab9\StoryWebsite\Views\Story\Details.cshtml"
                                                                                                WriteLiteral(Model.storyID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["storyID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-storyID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["storyID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(306, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(312, 130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9113bda238ef958ef4f74750783e3cbbba595aae9480", async() => {
                BeginContext(432, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-storyID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 10 "Z:\Documents\Course\CSE686_IP\Lab\Lab9\StoryWebsite\Views\Story\Details.cshtml"
                                                                                                WriteLiteral(Model.storyID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["storyID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-storyID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["storyID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(442, 205, true);
            WriteLiteral("\r\n</div>\r\n<div class=\"detail-info\">\r\n    <div class=\"story-info\">\r\n        <div class=\"detail-title\">Story Info</div>\r\n        <hr />\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(648, 41, false);
#line 18 "Z:\Documents\Course\CSE686_IP\Lab\Lab9\StoryWebsite\Views\Story\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.title));

#line default
#line hidden
            EndContext();
            BeginContext(689, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(745, 37, false);
#line 21 "Z:\Documents\Course\CSE686_IP\Lab\Lab9\StoryWebsite\Views\Story\Details.cshtml"
           Write(Html.DisplayFor(model => model.title));

#line default
#line hidden
            EndContext();
            BeginContext(782, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(838, 42, false);
#line 24 "Z:\Documents\Course\CSE686_IP\Lab\Lab9\StoryWebsite\Views\Story\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.author));

#line default
#line hidden
            EndContext();
            BeginContext(880, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(936, 47, false);
#line 27 "Z:\Documents\Course\CSE686_IP\Lab\Lab9\StoryWebsite\Views\Story\Details.cshtml"
           Write(Html.DisplayFor(model => model.author.userName));

#line default
#line hidden
            EndContext();
            BeginContext(983, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1039, 43, false);
#line 30 "Z:\Documents\Course\CSE686_IP\Lab\Lab9\StoryWebsite\Views\Story\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.content));

#line default
#line hidden
            EndContext();
            BeginContext(1082, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1138, 39, false);
#line 33 "Z:\Documents\Course\CSE686_IP\Lab\Lab9\StoryWebsite\Views\Story\Details.cshtml"
           Write(Html.DisplayFor(model => model.content));

#line default
#line hidden
            EndContext();
            BeginContext(1177, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1233, 44, false);
#line 36 "Z:\Documents\Course\CSE686_IP\Lab\Lab9\StoryWebsite\Views\Story\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.category));

#line default
#line hidden
            EndContext();
            BeginContext(1277, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1333, 53, false);
#line 39 "Z:\Documents\Course\CSE686_IP\Lab\Lab9\StoryWebsite\Views\Story\Details.cshtml"
           Write(Html.DisplayFor(model => model.category.categoryName));

#line default
#line hidden
            EndContext();
            BeginContext(1386, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1442, 46, false);
#line 42 "Z:\Documents\Course\CSE686_IP\Lab\Lab9\StoryWebsite\Views\Story\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.createTime));

#line default
#line hidden
            EndContext();
            BeginContext(1488, 39, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n");
            EndContext();
            BeginContext(1592, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1609, 59, false);
#line 46 "Z:\Documents\Course\CSE686_IP\Lab\Lab9\StoryWebsite\Views\Story\Details.cshtml"
           Write(Html.ValueFor(model => model.createTime, "{0:dd MMM yyyy}"));

#line default
#line hidden
            EndContext();
            BeginContext(1668, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1724, 46, false);
#line 49 "Z:\Documents\Course\CSE686_IP\Lab\Lab9\StoryWebsite\Views\Story\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.updateTime));

#line default
#line hidden
            EndContext();
            BeginContext(1770, 39, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n");
            EndContext();
            BeginContext(1874, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1891, 59, false);
#line 53 "Z:\Documents\Course\CSE686_IP\Lab\Lab9\StoryWebsite\Views\Story\Details.cshtml"
           Write(Html.ValueFor(model => model.updateTime, "{0:dd MMM yyyy}"));

#line default
#line hidden
            EndContext();
            BeginContext(1950, 307, true);
            WriteLiteral(@"
            </dd>
        </dl>
    </div>

    <div class=""comments"">
        <div class=""comment-title"">Comments</div>
        <hr />

        <div class=""comment_editor"">
            <div class=""comments-row"">
                <div class=""avatar-column"">
                    <img alt=""Avatar""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2257, "\"", 2419, 1);
#line 65 "Z:\Documents\Course\CSE686_IP\Lab\Lab9\StoryWebsite\Views\Story\Details.cshtml"
WriteAttributeValue("", 2263, Href("https://secure.gravatar.com/avatar/6371f3ab23417a606e12cbef6fe97394?default=https%3A%2F%2Fassets.zendesk.com%2Fhc%2Fassets%2Fdefault_avatar.png&r=g"), 2263, 156, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2420, 93, true);
            WriteLiteral(">\r\n                </div>\r\n                <div class=\"comment-column\">\r\n                    ");
            EndContext();
            BeginContext(2513, 591, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9113bda238ef958ef4f74750783e3cbbba595aae18565", async() => {
                BeginContext(2593, 187, true);
                WriteLiteral("\r\n                        <textarea rows=\"4\" cols=\"50\" name=\"content\" form=\"usrform\" placeholder=\"Type comment here...\"></textarea>\r\n                        <input type=\"hidden\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2780, "\"", 2802, 1);
#line 70 "Z:\Documents\Course\CSE686_IP\Lab\Lab9\StoryWebsite\Views\Story\Details.cshtml"
WriteAttributeValue("", 2788, Model.storyID, 2788, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2803, 70, true);
                WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"author.userID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2873, "\"", 2901, 1);
#line 71 "Z:\Documents\Course\CSE686_IP\Lab\Lab9\StoryWebsite\Views\Story\Details.cshtml"
WriteAttributeValue("", 2881, Model.author.userID, 2881, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2902, 64, true);
                WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"storyID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2966, "\"", 2988, 1);
#line 72 "Z:\Documents\Course\CSE686_IP\Lab\Lab9\StoryWebsite\Views\Story\Details.cshtml"
WriteAttributeValue("", 2974, Model.storyID, 2974, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2989, 108, true);
                WriteLiteral(" />\r\n                        <input type=\"submit\" class=\"comment-btn\" value=\"Comment\">\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3104, 104, true);
            WriteLiteral("\r\n                    <br>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <hr />\r\n");
            EndContext();
#line 80 "Z:\Documents\Course\CSE686_IP\Lab\Lab9\StoryWebsite\Views\Story\Details.cshtml"
         foreach (var cm in Model.comments)
        {

#line default
#line hidden
            BeginContext(3264, 122, true);
            WriteLiteral("            <div class=\"comments-row\">\r\n                <div class=\"avatar-column\">\r\n                    <img alt=\"Avatar\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3386, "\"", 3418, 1);
#line 84 "Z:\Documents\Course\CSE686_IP\Lab\Lab9\StoryWebsite\Views\Story\Details.cshtml"
WriteAttributeValue("", 3392, Href(cm.author.avatarURL), 3392, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3419, 97, true);
            WriteLiteral(">\r\n                </div>\r\n                <div class=\"comment-column\">\r\n                    <p> ");
            EndContext();
            BeginContext(3517, 10, false);
#line 87 "Z:\Documents\Course\CSE686_IP\Lab\Lab9\StoryWebsite\Views\Story\Details.cshtml"
                   Write(cm.content);

#line default
#line hidden
            EndContext();
            BeginContext(3527, 109, true);
            WriteLiteral(" </p>\r\n                    <div class=\"comment-meta\">\r\n                        <span class=\"comment-author\"> ");
            EndContext();
            BeginContext(3637, 18, false);
#line 89 "Z:\Documents\Course\CSE686_IP\Lab\Lab9\StoryWebsite\Views\Story\Details.cshtml"
                                                 Write(cm.author.userName);

#line default
#line hidden
            EndContext();
            BeginContext(3655, 62, true);
            WriteLiteral(" </span>\r\n                        <span class=\"comment-date\"> ");
            EndContext();
            BeginContext(3718, 54, false);
#line 90 "Z:\Documents\Course\CSE686_IP\Lab\Lab9\StoryWebsite\Views\Story\Details.cshtml"
                                               Write(Html.ValueFor(model => cm.postTime, "{0:dd MMM yyyy}"));

#line default
#line hidden
            EndContext();
            BeginContext(3772, 102, true);
            WriteLiteral(" </span>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <hr />\r\n");
            EndContext();
#line 95 "Z:\Documents\Course\CSE686_IP\Lab\Lab9\StoryWebsite\Views\Story\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(3885, 24, true);
            WriteLiteral("    </div>\r\n\r\n</div>\r\n\r\n");
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
