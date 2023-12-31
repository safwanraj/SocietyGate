#pragma checksum "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Admin\Display.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "994e775e8a4075eb7a3e244d992bcf3f946f538e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Display), @"mvc.1.0.view", @"/Views/Admin/Display.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"994e775e8a4075eb7a3e244d992bcf3f946f538e", @"/Views/Admin/Display.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0a3033c42509be48c68e3f6b5da0c54e9fcd533", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Display : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container"">
    <br />
    <div style=""width:90%; margin:0 auto;"">
        <table id=""example"" class=""table table-striped table-bordered dt-responsive nowrap"" width=""100%"" cellspacing=""0"">
            <thead>
                <tr>

                    <th>Society ID</th>
                    <th>Society Name</th>
                    <th>Description</th>
                    <th>President Nmae</th>
                    <th>gender</th>
                    <th>User Id</th>
                    <th>created admin Id</th>
                    <th>created date</th>
                    <th>updated date</th>
                    <th>status</th>
                    <th>Address</th>
                    <th>Country</th>
                    <th>state</th>
                    <th>City</th>
                    <th>Postal code</th>
                    <th>Phoneno</th>
                    <th>Edit</th>
                    <th>Delete</th>
                </tr>
            </thead>
        </tabl");
            WriteLiteral("e>\r\n    </div>\r\n</div>\r\n");
            DefineSection("display", async() => {
                WriteLiteral(@"
<!-- plugins -->
    <script src=""https://code.jquery.com/jquery-3.7.0.min.js""></script>
    <link href=""https://cdn.datatables.net/1.13.4/css/jquery.dataTables.min.css"" rel=""stylesheet"" />
    <script src=""https://cdn.datatables.net/1.13.4/js/jquery.dataTables.min.js""></script>

<script>

    $(document).ready(function () {
        $(""#example"").dataTable({
            ""processing"": true, // for show progress bar
            ""serverSide"": true, // for process server side
            ""filter"": true, // this is for disable filter (search box)
            ""orderMulti"": false, // for disable multiple column at once
            ""ajax"": {
                ""url"": ""/Admin/LoadData"",
                ""type"": ""POST"",
                ""datatype"": ""json""
            },
            ""columnDefs"": [{
                ""targets"": [0],
                ""visible"": false,
                ""searchable"": false
            }],
            ""columns"": [
                { ""data"": ""Society_Id"", ""name"": ""Society ID""");
                WriteLiteral(@", ""autoWidth"": true },
                { ""data"": ""Society_Name"", ""name"": ""Society Name"", ""autoWidth"": true },
                { ""data"": ""Description"", ""name"": ""Description"", ""autoWidth"": true },
                { ""data"": ""President_Name"", ""name"": ""President Name"", ""autoWidth"": true },
                { ""data"": ""Gender"", ""name"": ""gender"", ""autoWidth"": true },
                { ""data"": ""ApplicationUserId"", ""name"": ""User Id"", ""autoWidth"": true },
                { ""data"": ""AdminID"", ""name"": ""created admin Id"", ""autoWidth"": true },
                { ""data"": ""CreatedDate"", ""name"": ""created date"", ""autoWidth"": true },
                { ""data"": ""UpdatedDate"", ""name"": ""updated date"", ""autoWidth"": true },
                { ""data"": ""status"", ""name"": ""status"", ""autoWidth"": true },

                { ""data"": ""Address"", ""name"": ""Address"", ""autoWidth"": true },
                { ""data"": ""Country"", ""name"": ""Country"", ""autoWidth"": true },
                { ""data"": ""State"", ""name"": ""state"", ""autoWidth"": true },
 ");
                WriteLiteral(@"               { ""data"": ""City"", ""name"": ""City"", ""autoWidth"": true },
                { ""data"": ""Postal_Code"", ""name"": ""Postal code"", ""autoWidth"": true },
                { ""data"": ""Contact"", ""name"": ""Phoneno"", ""autoWidth"": true },
                {
                    ""render"": function (data, type, full, meta) { return '<a class=""btn btn-info"" href=""/Admin/EditSociety/' + full.Society_Id + '"">Edit</a>'; }
                },
                {
                    data: null,
                    render: function (data, type, row) {
                        return ""<a href='#' class='btn btn-danger' onclick=DeleteData('"" + row.Society_Id + ""'); >Delete</a>"";
                    }
                },
            ]

        });
    });


                    //function DeleteData(CustomerID) {
                    //    if (confirm(""Are you sure you want to delete ...?"")) {
                    //        Delete(CustomerID);
                    //    } else {
                    //        return f");
                WriteLiteral("alse;\r\n                    //    }\r\n                    //}\r\n\r\n\r\n                    //function Delete(CustomerID) {\r\n                    //    var url = \'");
#nullable restore
#line 98 "C:\Users\safwan\mscict2\project\GateProject\GateCommunityMvc\Views\Admin\Display.cshtml"
                                Write(Url);

#line default
#line hidden
#nullable disable
                WriteLiteral(@". //Content(""~/"")' + ""Admin/Delete"";

                    //    $.post(url, { ID: CustomerID }, function (data) {
                    //        if (data) {
                    //            oTable = $('#example').DataTable();
                    //            oTable.draw();
                    //        } else {
                    //            alert(""Something Went Wrong!"");
                    //        }
                    //    });
                    //}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
