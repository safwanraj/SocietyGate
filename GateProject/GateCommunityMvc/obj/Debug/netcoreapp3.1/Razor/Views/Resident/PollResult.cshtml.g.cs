#pragma checksum "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Resident\PollResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db086704e5bbf792d1a7eefbe88ff12e95bb6c50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Resident_PollResult), @"mvc.1.0.view", @"/Views/Resident/PollResult.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db086704e5bbf792d1a7eefbe88ff12e95bb6c50", @"/Views/Resident/PollResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0a3033c42509be48c68e3f6b5da0c54e9fcd533", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Resident_PollResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Poll>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"poll-result\">\r\n    <h2 class=\"poll-question\">");
#nullable restore
#line 21 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Resident\PollResult.cshtml"
                         Write(Model.Question);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
#nullable restore
#line 23 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Resident\PollResult.cshtml"
     foreach (var option in Model.Options)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"poll-option\">\r\n            <div class=\"option-text\">");
#nullable restore
#line 26 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Resident\PollResult.cshtml"
                                Write(option.OptionText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"vote-progress-bar\">\r\n                <div class=\"vote-progress\"");
            BeginWriteAttribute("style", " style=\"", 763, "\"", 840, 3);
            WriteAttributeValue("", 771, "width:", 771, 6, true);
#nullable restore
#line 28 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Resident\PollResult.cshtml"
WriteAttributeValue(" ", 777, CalculatePercentage(option.VotesCount, ViewBag.TotalVotes), 778, 61, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 839, "%", 839, 1, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            </div>\r\n            <div class=\"vote-count\">");
#nullable restore
#line 30 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Resident\PollResult.cshtml"
                               Write(option.VotesCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"vote-percentage\">");
#nullable restore
#line 31 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Resident\PollResult.cshtml"
                                    Write(CalculatePercentage(option.VotesCount, ViewBag.TotalVotes));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</div>\r\n        </div>\r\n");
#nullable restore
#line 33 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Resident\PollResult.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Resident\PollResult.cshtml"
            
    private double CalculatePercentage(int votesCount, int totalVotes)
    {
        return totalVotes > 0 ? (votesCount / (double)totalVotes) * 100 : 0;
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Poll> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591