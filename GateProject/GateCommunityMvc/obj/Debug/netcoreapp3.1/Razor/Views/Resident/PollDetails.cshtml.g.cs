#pragma checksum "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Resident\PollDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f570db917fc25f7e3fa4ee20a441cea50b92ab3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Resident_PollDetails), @"mvc.1.0.view", @"/Views/Resident/PollDetails.cshtml")]
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
#line 1 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\_ViewImports.cshtml"
using GateCommunityMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\_ViewImports.cshtml"
using GateCommunityMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f570db917fc25f7e3fa4ee20a441cea50b92ab3", @"/Views/Resident/PollDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0a3033c42509be48c68e3f6b5da0c54e9fcd533", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Resident_PollDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Poll>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SubmitPoll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Resident", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Polls</h1>\r\n\r\n");
#nullable restore
#line 25 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Resident\PollDetails.cshtml"
 foreach (var poll in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f570db917fc25f7e3fa4ee20a441cea50b92ab34516", async() => {
                WriteLiteral("\r\n    <div class=\"poll-card\">\r\n        <h3>");
#nullable restore
#line 29 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Resident\PollDetails.cshtml"
       Write(poll.Question);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n        <div class=\"options\">\r\n");
#nullable restore
#line 31 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Resident\PollDetails.cshtml"
             foreach (var option in poll.Options)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"option\">\r\n                    <input type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 964, "\"", 979, 1);
#nullable restore
#line 34 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Resident\PollDetails.cshtml"
WriteAttributeValue("", 969, option.Id, 969, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"selectedOption\"");
                BeginWriteAttribute("value", " value=\"", 1002, "\"", 1020, 1);
#nullable restore
#line 34 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Resident\PollDetails.cshtml"
WriteAttributeValue("", 1010, option.Id, 1010, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <label");
                BeginWriteAttribute("for", " for=\"", 1052, "\"", 1068, 1);
#nullable restore
#line 35 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Resident\PollDetails.cshtml"
WriteAttributeValue("", 1058, option.Id, 1058, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 35 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Resident\PollDetails.cshtml"
                                       Write(option.OptionText);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                </div>\r\n");
#nullable restore
#line 37 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Resident\PollDetails.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n        <div class=\"submit-container\">\r\n           \r\n            <input type=\"hidden\" name=\"pollId\"");
                BeginWriteAttribute("value", " value=\"", 1252, "\"", 1268, 1);
#nullable restore
#line 41 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Resident\PollDetails.cshtml"
WriteAttributeValue("", 1260, poll.Id, 1260, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            <button type=\"submit\" class=\"submit-button\">Submit</button>\r\n           \r\n        </div>\r\n    </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 47 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Resident\PollDetails.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Poll>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
