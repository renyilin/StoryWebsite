#pragma checksum "Z:\Documents\Course\CSE686_IP\MyFinalProject\StoryWebsite\Views\Lab\Labs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "123f2152c4fb2aa7500e52b7017b73861b7172eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lab_Labs), @"mvc.1.0.view", @"/Views/Lab/Labs.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Lab/Labs.cshtml", typeof(AspNetCore.Views_Lab_Labs))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"123f2152c4fb2aa7500e52b7017b73861b7172eb", @"/Views/Lab/Labs.cshtml")]
    public class Views_Lab_Labs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MvcSkeleton.Models.Lab>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(37, 59, true);
            WriteLiteral("<!-- statement below required to use Razor TagHelpers -->\r\n");
            EndContext();
            BeginContext(150, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "Z:\Documents\Course\CSE686_IP\MyFinalProject\StoryWebsite\Views\Lab\Labs.cshtml"
  
    ViewBag.Title = "Labs";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(235, 65, true);
            WriteLiteral("\r\n<h2>Labs</h2>\r\n\r\n<hr/>\r\n<div class=\"indent\">\r\n    <p>\r\n        ");
            EndContext();
            BeginContext(300, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54c3fd06ab1b4ca7a154b74dfc7d7cb7", async() => {
                BeginContext(323, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(337, 56, true);
            WriteLiteral("\r\n    </p>\r\n    <table class=\"table\">\r\n        <tbody>\r\n");
            EndContext();
#line 19 "Z:\Documents\Course\CSE686_IP\MyFinalProject\StoryWebsite\Views\Lab\Labs.cshtml"
             foreach (var lab in Model)
            {

#line default
#line hidden
            BeginContext(449, 76, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                       Lab #");
            EndContext();
            BeginContext(526, 10, false);
#line 23 "Z:\Documents\Course\CSE686_IP\MyFinalProject\StoryWebsite\Views\Lab\Labs.cshtml"
                       Write(lab.number);

#line default
#line hidden
            EndContext();
            BeginContext(536, 2, true);
            WriteLiteral(". ");
            EndContext();
            BeginContext(539, 9, false);
#line 23 "Z:\Documents\Course\CSE686_IP\MyFinalProject\StoryWebsite\Views\Lab\Labs.cshtml"
                                    Write(lab.topic);

#line default
#line hidden
            EndContext();
            BeginContext(548, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(628, 53, false);
#line 26 "Z:\Documents\Course\CSE686_IP\MyFinalProject\StoryWebsite\Views\Lab\Labs.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { id = lab.id  }));

#line default
#line hidden
            EndContext();
            BeginContext(681, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(710, 58, false);
#line 27 "Z:\Documents\Course\CSE686_IP\MyFinalProject\StoryWebsite\Views\Lab\Labs.cshtml"
                   Write(Html.ActionLink("Details", "Details", new { id = lab.id }));

#line default
#line hidden
            EndContext();
            BeginContext(768, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(797, 56, false);
#line 28 "Z:\Documents\Course\CSE686_IP\MyFinalProject\StoryWebsite\Views\Lab\Labs.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { id = lab.id }));

#line default
#line hidden
            EndContext();
            BeginContext(853, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 31 "Z:\Documents\Course\CSE686_IP\MyFinalProject\StoryWebsite\Views\Lab\Labs.cshtml"
            }

#line default
#line hidden
            BeginContext(920, 40, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MvcSkeleton.Models.Lab>> Html { get; private set; }
    }
}
#pragma warning restore 1591
