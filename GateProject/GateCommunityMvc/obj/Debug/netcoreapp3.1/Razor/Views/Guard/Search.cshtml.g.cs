#pragma checksum "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Guard\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "025e5b29f5f2d5101a90feccf47fcf55e7632793"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Guard_Search), @"mvc.1.0.view", @"/Views/Guard/Search.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"025e5b29f5f2d5101a90feccf47fcf55e7632793", @"/Views/Guard/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0a3033c42509be48c68e3f6b5da0c54e9fcd533", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Guard_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GateCommunityMvc.Models.Searchview>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Profile Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Guard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Handlestaff", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Guard\Search.cshtml"
 if (Model.Families.Any() || Model.Staffs.Any())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Guard\Search.cshtml"
     if (Model.Families.Any())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table id=""familylist"" class=""table table-striped table-bordered"">
            <thead>
                <tr>
                    <th>
                        Family member name
                    </th>
                    <th>
                        Resident Name
                    </th>
                    <th>
                        Relationship
                    </th>
                    <th>
                        Profile
                    </th>
                    <th>
                        Gender
                    </th>
                    <th>
                        Action
                    </th>
                </tr>
            </thead>
            <tbody>
                <!-- Display Table1 results -->
");
#nullable restore
#line 31 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Guard\Search.cshtml"
                 foreach (var result in Model.Families)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 34 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Guard\Search.cshtml"
                       Write(result.FamilyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 36 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Guard\Search.cshtml"
                       Write(result.Tblresident.firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 37 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Guard\Search.cshtml"
                       Write(result.Tblresident.lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 40 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Guard\Search.cshtml"
                       Write(result.relationship);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "025e5b29f5f2d5101a90feccf47fcf55e76327938274", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1417, "~/", 1417, 2, true);
#nullable restore
#line 43 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Guard\Search.cshtml"
AddHtmlAttributeValue("", 1419, result.filepath, 1419, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 46 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Guard\Search.cshtml"
                       Write(result.gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "025e5b29f5f2d5101a90feccf47fcf55e763279310442", async() => {
                WriteLiteral("\r\n                                <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 1810, "\"", 1834, 1);
#nullable restore
#line 50 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Guard\Search.cshtml"
WriteAttributeValue("", 1818, result.FamilyId, 1818, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <button type=\"submit\" name=\"action\" value=\"Family\">Entry</button>\r\n\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 57 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Guard\Search.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n</table>\r\n");
#nullable restore
#line 60 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Guard\Search.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Guard\Search.cshtml"
     if (Model.Staffs.Any())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table id=""searchlist"" class=""table table-striped table-bordered"">
            <thead>
                <tr>
                    <th>
                        Staff name
                    </th>
                    <th>
                        Resident Name
                    </th>
                    <th>
                        Work as
                    </th>
                    <th>
                        Profile
                    </th>
                    <th>
                        Gender
                    </th>
                    <th>
                        Action
                    </th>
                </tr>
            </thead>
            <tbody>
                <!-- Display Table1 results -->
");
#nullable restore
#line 90 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Guard\Search.cshtml"
                 foreach (var result in Model.Staffs)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 93 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Guard\Search.cshtml"
                       Write(result.staffName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 95 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Guard\Search.cshtml"
                       Write(result.Tblresident.firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 96 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Guard\Search.cshtml"
                       Write(result.Tblresident.lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 99 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Guard\Search.cshtml"
                       Write(result.workas);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "025e5b29f5f2d5101a90feccf47fcf55e763279316003", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3393, "~/", 3393, 2, true);
#nullable restore
#line 102 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Guard\Search.cshtml"
AddHtmlAttributeValue("", 3395, result.filepath, 3395, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 105 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Guard\Search.cshtml"
                       Write(result.gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "025e5b29f5f2d5101a90feccf47fcf55e763279318174", async() => {
                WriteLiteral("\r\n                                <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 3786, "\"", 3809, 1);
#nullable restore
#line 109 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Guard\Search.cshtml"
WriteAttributeValue("", 3794, result.staffId, 3794, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <button type=\"submit\" name=\"action\" value=\"Staff\">Entry</button>\r\n\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 116 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Guard\Search.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 119 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Guard\Search.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 119 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Guard\Search.cshtml"
     
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GateCommunityMvc.Models.Searchview> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591