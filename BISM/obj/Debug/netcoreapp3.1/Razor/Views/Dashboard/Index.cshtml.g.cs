#pragma checksum "D:\Balimoon\BISM\ASP.NETCore-BISManufaktur\BISM\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ce09e67e2d2246f5c89af0e80433ca7009fc57a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
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
#line 1 "D:\Balimoon\BISM\ASP.NETCore-BISManufaktur\BISM\Views\_ViewImports.cshtml"
using BISM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Balimoon\BISM\ASP.NETCore-BISManufaktur\BISM\Views\_ViewImports.cshtml"
using BISM.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ce09e67e2d2246f5c89af0e80433ca7009fc57a", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4911dfac42da4b592dc2b6b237b8e52a25ff3e03", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Balimoon\BISM\ASP.NETCore-BISManufaktur\BISM\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Login";
    Layout = "~/Views/Shared/custom/_Layouts.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section id=""content"">
    <div class=""container"">
        <div class=""c-header"">
            <h1>Main Dashboard</h1>
        </div>
        <div class=""row"">
            <div class=""col-md-6"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h2>Sales</h2>
                    </div>
                    <div class=""card-body card-padding"">
                        <p>
                            Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris blandit massa in diam tempor, eu viverra orci molestie. Morbi condimentum sapien sed finibus rhoncus. Vivamus venenatis lectus quis risus finibus pharetra. Curabitur imperdiet blandit faucibus. Integer consequat erat ut blandit mattis. Vestibulum imperdiet convallis nisl, finibus vehicula turpis facilisis ut. In ut molestie lacus. Nam ornare urna ac justo condimentum, a ornare justo elementum. Aenean sem turpis, rhoncus quis vulputate sed, dapibus quis ex. Etiam vitae vestibulum nisl, sit");
            WriteLiteral(@" amet hendrerit lorem. Vivamus est nunc, convallis vel mattis ac, luctus at est.
                        </p>
                    </div>
                </div>
            </div>
            <div class=""col-md-6"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h2>Stock</h2>
                    </div>
                    <div class=""card-body card-padding"">
                        <table id=""tabel-stock"" class=""table table-vmiddle"" style=""table-layout:auto;"">
                            <thead>
                                <tr>
                                    <th colspan=""3"" id=""tbl_stock_Bulan""></th>
                                    <th colspan=""3"">Stock</th>
                                </tr>
                                <tr>
                                    <th> Finish Goods</th>
                                    <th>5000</th>
                                    <th>700</th>
                                 ");
            WriteLiteral(@"   <th>250</th>
                                    <th colspan=""2"">Material</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>Omrach</td>
                                    <td>0</td>
                                    <td id=""omrach700""></td>
                                    <td id=""omrach250""></td>
                                    <td>Alkohol</td>
                                    <td id=""matAlkohol"">0</td>
                                </tr>
                                <tr>
                                    <td>Vodka 9</td>
                                    <td>0</td>
                                    <td id=""9vd700""></td>
                                    <td id=""9vd250"">0</td>
                                    <td>Gula</td>
                                    <td id=""gula"">0</td>
                                </tr>
            WriteLiteral(@"
                                <tr>
                                    <td>Silver</td>
                                    <td>0</td>
                                    <td id=""silver700""></td>
                                    <td id=""silver250""></td>
                                    <td colspan=""2"">Bottle</td>
                                </tr>
                                <tr>
                                    <td>Blanco</td>
                                    <td id=""blanco5""></td>
                                    <td id=""blanco700""></td>
                                    <td id=""blanco250""></td>
                                    <td>700 Omrach</td>
                                    <td id=""botolOmrach7""></td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
<script>
    var dates = new Date();
    const monthNames = [""Jan"", ""Feb"", ""Mar"", ""Apr"", ""May"", ""Jun"", ""Jul"", ""Aug"", ""Sept"", ""Oct"", ""Nov"", ""Dec""];
    var month = monthNames[dates.getMonth()];
    var year = dates.getFullYear();
    $(""#tbl_stock_Bulan"").html(month + "" - "" + year);

</script>
<script>
    (function update() {
        $.ajax({
            type: ""GET"",
            url: ""/api/StockFGItemLedgerEntry"",
            success: function (res) {
                //var res = JSON.parse(data);
                if (res.result == ""OK"") {
                    $.each(res.data, function (i, item) {
                        if (res.data[i].itemno == ""700203"") {
                            $(""#omrach700"").html(res.data[i].total);
                        }
                        else if (res.data[i].itemno === ""700225"") {
                            $(""#omrach250"").html(res.data[i].total);
                        }
                    })


                }
            }
        }).then");
                WriteLiteral("(function () {\r\n            setTimeout(update, 30000);\r\n        });\r\n    })();\r\n    \r\n</script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591