#pragma checksum "C:\Users\User\Desktop\ddac assignemnt\MyEcommerce\MyEcommerce\Views\Payment\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36047b8980d304faad605796b97d047c29f61f89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payment_Checkout), @"mvc.1.0.view", @"/Views/Payment/Checkout.cshtml")]
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
#line 1 "C:\Users\User\Desktop\ddac assignemnt\MyEcommerce\MyEcommerce\Views\_ViewImports.cshtml"
using MyEcommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\ddac assignemnt\MyEcommerce\MyEcommerce\Views\_ViewImports.cshtml"
using MyEcommerce.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36047b8980d304faad605796b97d047c29f61f89", @"/Views/Payment/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d77deb1bd3e19626a798689422851bfe80c579f", @"/Views/_ViewImports.cshtml")]
    public class Views_Payment_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyEcommerce.Models.CartItems>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("OrderForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\Desktop\ddac assignemnt\MyEcommerce\MyEcommerce\Views\Payment\Checkout.cshtml"
  
    ViewData["Title"] = "Payment";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\ddac assignemnt\MyEcommerce\MyEcommerce\Views\Payment\Checkout.cshtml"
  
    decimal gt = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<style>\r\n    a {\r\n        text-decoration: none;\r\n    }\r\n</style>\r\n\r\n<div class=\"alert-info\">\r\n    ");
#nullable restore
#line 18 "C:\Users\User\Desktop\ddac assignemnt\MyEcommerce\MyEcommerce\Views\Payment\Checkout.cshtml"
Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>
<h1>Cart Items</h1>

<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Item Pic</th>
            <th scope=""col"">Name</th>
            <th scope=""col"">Price</th>
            <th scope=""col"">Qunatity</th>
            <th scope=""col"">Sub Total</th>
            <th scope=""col"">Action</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 34 "C:\Users\User\Desktop\ddac assignemnt\MyEcommerce\MyEcommerce\Views\Payment\Checkout.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr style=\"vertical-align:middle\">\r\n                <td>\r\n                    <img style=\"height:50px;width:150px;\"");
            BeginWriteAttribute("src", "\r\n                         src=\'", 793, "\'", 905, 1);
#nullable restore
#line 39 "C:\Users\User\Desktop\ddac assignemnt\MyEcommerce\MyEcommerce\Views\Payment\Checkout.cshtml"
WriteAttributeValue("", 825, Url.Action("ItemImageRetreiver", "Payment", new { productid = item.ProductId }), 825, 80, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Item Pic\" />\r\n                </td>\r\n                <td>");
#nullable restore
#line 41 "C:\Users\User\Desktop\ddac assignemnt\MyEcommerce\MyEcommerce\Views\Payment\Checkout.cshtml"
               Write(item.ForeignProductID.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>$");
#nullable restore
#line 42 "C:\Users\User\Desktop\ddac assignemnt\MyEcommerce\MyEcommerce\Views\Payment\Checkout.cshtml"
                Write(Convert.ToDecimal(item.ForeignProductID.ProductPrice).ToString("#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1157, "\"", 1240, 1);
#nullable restore
#line 44 "C:\Users\User\Desktop\ddac assignemnt\MyEcommerce\MyEcommerce\Views\Payment\Checkout.cshtml"
WriteAttributeValue("", 1164, Url.Action("DecreaseItemQuantity", "Payment", new { cartitemId = item.Id }), 1164, 76, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"badge bg-danger\">-</a>\r\n                    <b>");
#nullable restore
#line 45 "C:\Users\User\Desktop\ddac assignemnt\MyEcommerce\MyEcommerce\Views\Payment\Checkout.cshtml"
                  Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1338, "\"", 1420, 1);
#nullable restore
#line 46 "C:\Users\User\Desktop\ddac assignemnt\MyEcommerce\MyEcommerce\Views\Payment\Checkout.cshtml"
WriteAttributeValue("", 1345, Url.Action("IncreasItemQuantity", "Payment", new { cartitemId = item.Id }), 1345, 75, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"badge bg-success\">+</a>\r\n                </td>\r\n                <td>\r\n                    $");
#nullable restore
#line 49 "C:\Users\User\Desktop\ddac assignemnt\MyEcommerce\MyEcommerce\Views\Payment\Checkout.cshtml"
                Write(Convert.ToDecimal(item.Quantity * item.ForeignProductID.ProductPrice).ToString("#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 50 "C:\Users\User\Desktop\ddac assignemnt\MyEcommerce\MyEcommerce\Views\Payment\Checkout.cshtml"
                       gt = gt + Convert.ToDecimal(item.Quantity * item.ForeignProductID.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 1764, "\"", 1810, 2);
            WriteAttributeValue("", 1771, "/Payment/RemoveCartItem?itemid=", 1771, 31, true);
#nullable restore
#line 52 "C:\Users\User\Desktop\ddac assignemnt\MyEcommerce\MyEcommerce\Views\Payment\Checkout.cshtml"
WriteAttributeValue("", 1802, item.Id, 1802, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-outline-danger\">Remove</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 54 "C:\Users\User\Desktop\ddac assignemnt\MyEcommerce\MyEcommerce\Views\Payment\Checkout.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <th></th>\r\n            <th id=\"grandtotal\">Grand Total =  $");
#nullable restore
#line 60 "C:\Users\User\Desktop\ddac assignemnt\MyEcommerce\MyEcommerce\Views\Payment\Checkout.cshtml"
                                           Write(gt.ToString("#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
            <th></th>
        </tr>
    </tbody>
</table>
<button hidden id=""orderbtn"" style=""float:right;"" class=""btn btn-success"" onclick=""$('#OrderDetailsModal').modal('show')"">Place your Order Now!</button>
<a href=""/Home/ProductsList"">Continue Shopping</a>

<!-- Button trigger modal -->
<!--<button type=""button"" class=""btn btn-primary"" data-bs-toggle=""modal"" data-bs-target=""#exampleModal"">
    Launch demo modal
</button>-->
<!-- Modal -->
<div class=""modal fade"" id=""OrderDetailsModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Order Processing Details</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36047b8980d304faad605796b97d047c29f61f8910628", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label class=""control-label"">Email Address</label>
                        <input class=""form-control"" placeholder=""Email Address"" required id=""email"" />
                    </div>
                    <div class=""form-group"">
                        <label class=""control-label"">Phone Number</label>
                        <input class=""form-control"" placeholder=""Phone Number"" required id=""phonenumber"" />
                    </div>
                    <div class=""form-group"">
                        <label class=""control-label"">Address Detail</label>
                        <textarea class=""form-control"" rows=""5"" placeholder=""Address Details"" required id=""address""></textarea>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn btn-warning"" onclick=""PlaceOrder()"">Process Order</button>
            </div>
        </div>
    </div>
</div>


<script>
    $(document).ready(function () {
        if (");
#nullable restore
#line 107 "C:\Users\User\Desktop\ddac assignemnt\MyEcommerce\MyEcommerce\Views\Payment\Checkout.cshtml"
       Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("!= 0) {\r\n            $(\"#orderbtn\").removeAttr(\"hidden\");\r\n        }\r\n    });\r\n\r\n    function PlaceOrder() {\r\n\r\n        if (document.forms[\'OrderForm\'].reportValidity() == true) {\r\n            var productids = [];\r\n");
#nullable restore
#line 116 "C:\Users\User\Desktop\ddac assignemnt\MyEcommerce\MyEcommerce\Views\Payment\Checkout.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            WriteLiteral("productids.push(\"");
#nullable restore
#line 118 "C:\Users\User\Desktop\ddac assignemnt\MyEcommerce\MyEcommerce\Views\Payment\Checkout.cshtml"
                              Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n");
#nullable restore
#line 119 "C:\Users\User\Desktop\ddac assignemnt\MyEcommerce\MyEcommerce\Views\Payment\Checkout.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            var quantities = [];\r\n");
#nullable restore
#line 121 "C:\Users\User\Desktop\ddac assignemnt\MyEcommerce\MyEcommerce\Views\Payment\Checkout.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            WriteLiteral("quantities.push(\"");
#nullable restore
#line 123 "C:\Users\User\Desktop\ddac assignemnt\MyEcommerce\MyEcommerce\Views\Payment\Checkout.cshtml"
                              Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n");
#nullable restore
#line 124 "C:\Users\User\Desktop\ddac assignemnt\MyEcommerce\MyEcommerce\Views\Payment\Checkout.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            var productPrices = [];\r\n");
#nullable restore
#line 126 "C:\Users\User\Desktop\ddac assignemnt\MyEcommerce\MyEcommerce\Views\Payment\Checkout.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            WriteLiteral("productPrices.push(\"");
#nullable restore
#line 128 "C:\Users\User\Desktop\ddac assignemnt\MyEcommerce\MyEcommerce\Views\Payment\Checkout.cshtml"
                                 Write(item.ForeignProductID.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n");
#nullable restore
#line 129 "C:\Users\User\Desktop\ddac assignemnt\MyEcommerce\MyEcommerce\Views\Payment\Checkout.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            $.ajax({
                type: ""POST"",
                url: ""/Payment/CreateOrder"",
                data: {
                    ids: productids,
                    quantities: quantities,
                    prices: productPrices,
                    email: $(""#email"").val(),
                    phone: $(""#phonenumber"").val(),
                    address: $(""#address"").val(),
                },
                success: function (data) {
                    $('#OrderDetailsModal').modal('hide');
                    Swal.fire(
                        'Success',
                        data,
                        'success'
                    )
                },
                error: function () {
                    Swal.fire(
                        'Error',
                        'Something went wrong please try again later!',
                        'error'
                    )
                }
            });
        } else {
            Swal.fire(
      ");
            WriteLiteral("          \'Warning\',\r\n                \'Please fill all details!\',\r\n                \'warning\'\r\n            )\r\n        }\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyEcommerce.Models.CartItems>> Html { get; private set; }
    }
}
#pragma warning restore 1591
