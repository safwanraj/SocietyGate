#pragma checksum "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Society\Vehiclelist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55611b6ca74111f4ad45337585bc550dcb61a5fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Society_Vehiclelist), @"mvc.1.0.view", @"/Views/Society/Vehiclelist.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55611b6ca74111f4ad45337585bc550dcb61a5fd", @"/Views/Society/Vehiclelist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0a3033c42509be48c68e3f6b5da0c54e9fcd533", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Society_Vehiclelist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GateCommunityMvc.Models.Vehicle>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Society\Vehiclelist.cshtml"
  
    ViewData["Title"] = "Vehiclelist";
    Layout = "~/Views/Society/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Vehiclelist</h1>


<table id=""vehiclelist"" class=""table table-striped table-bordered"">

    <thead>
        <tr>
            <th>
                Resident name
            </th>
            <th>
                wing name
            </th>
            <th>
                flatno
            </th>
            <th>
                Vehicle number
            </th>
            <th>
                vehicle type
            </th>
            <th>
                Manufacturer
            </th>
            <th>
                Contact
            </th>

        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 40 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Society\Vehiclelist.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Society\Vehiclelist.cshtml"
               Write(item.Tblresident.firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 45 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Society\Vehiclelist.cshtml"
               Write(item.Tblresident.lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Society\Vehiclelist.cshtml"
               Write(item.Wingmodel.WingName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Society\Vehiclelist.cshtml"
               Write(item.Flatmodel.flatno);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Society\Vehiclelist.cshtml"
               Write(item.vehicleno);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Society\Vehiclelist.cshtml"
               Write(item.vehicletype);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 62 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Society\Vehiclelist.cshtml"
               Write(item.manufacturer);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 65 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Society\Vehiclelist.cshtml"
               Write(item.Tblresident.phoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n\r\n            </tr>\r\n");
#nullable restore
#line 70 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Society\Vehiclelist.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            DefineSection("veh", async() => {
                WriteLiteral(@"

    <script src=""https://code.jquery.com/jquery-3.7.0.min.js""></script>

    <link href=""https://cdn.datatables.net/1.13.4/css/jquery.dataTables.min.css"" rel=""stylesheet"" />
    <script src=""https://cdn.datatables.net/1.13.4/js/jquery.dataTables.min.js"" defer></script>
    <script>
        $(document).ready(function () {
            $('#vehiclelist').DataTable();
        });
    </script>

");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GateCommunityMvc.Models.Vehicle>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
