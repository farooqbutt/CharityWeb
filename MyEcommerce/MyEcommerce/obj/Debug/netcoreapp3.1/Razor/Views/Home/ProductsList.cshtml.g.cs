#pragma checksum "C:\Users\Muhammad Farooq\Box\UpWork Pending Tasks\Yossef\MyEcommerce\MyEcommerce\MyEcommerce\Views\Home\ProductsList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "412b246b7b6dca04cfe77c3606cd2171d65c8716"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ProductsList), @"mvc.1.0.view", @"/Views/Home/ProductsList.cshtml")]
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
#line 1 "C:\Users\Muhammad Farooq\Box\UpWork Pending Tasks\Yossef\MyEcommerce\MyEcommerce\MyEcommerce\Views\_ViewImports.cshtml"
using MyEcommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Muhammad Farooq\Box\UpWork Pending Tasks\Yossef\MyEcommerce\MyEcommerce\MyEcommerce\Views\_ViewImports.cshtml"
using MyEcommerce.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"412b246b7b6dca04cfe77c3606cd2171d65c8716", @"/Views/Home/ProductsList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d77deb1bd3e19626a798689422851bfe80c579f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ProductsList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyEcommerce.InterfaceClasses.ProductListInterfaceClass>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Muhammad Farooq\Box\UpWork Pending Tasks\Yossef\MyEcommerce\MyEcommerce\MyEcommerce\Views\Home\ProductsList.cshtml"
  
    ViewData["Title"] = "Products List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Muhammad Farooq\Box\UpWork Pending Tasks\Yossef\MyEcommerce\MyEcommerce\MyEcommerce\Views\Home\ProductsList.cshtml"
 if (User.IsInRole("Manager"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p style=\"float:right;\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "412b246b7b6dca04cfe77c3606cd2171d65c87164535", async() => {
                WriteLiteral("Add New Product");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </p>\r\n");
#nullable restore
#line 12 "C:\Users\Muhammad Farooq\Box\UpWork Pending Tasks\Yossef\MyEcommerce\MyEcommerce\MyEcommerce\Views\Home\ProductsList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Charity Products List</h1>\r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 17 "C:\Users\Muhammad Farooq\Box\UpWork Pending Tasks\Yossef\MyEcommerce\MyEcommerce\MyEcommerce\Views\Home\ProductsList.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\" style=\"width: 20rem;margin-left:7px;margin-top:7px;\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 483, "\"", 512, 1);
#nullable restore
#line 20 "C:\Users\Muhammad Farooq\Box\UpWork Pending Tasks\Yossef\MyEcommerce\MyEcommerce\MyEcommerce\Views\Home\ProductsList.cshtml"
WriteAttributeValue("", 489, item.ProductFirstImage, 489, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%;height:100%\" class=\"card-img-top\" alt=\"Image\">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 22 "C:\Users\Muhammad Farooq\Box\UpWork Pending Tasks\Yossef\MyEcommerce\MyEcommerce\MyEcommerce\Views\Home\ProductsList.cshtml"
                                  Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"card-text\">\r\n");
#nullable restore
#line 24 "C:\Users\Muhammad Farooq\Box\UpWork Pending Tasks\Yossef\MyEcommerce\MyEcommerce\MyEcommerce\Views\Home\ProductsList.cshtml"
                     if (item.ProductDescription.Length > 75)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span");
            BeginWriteAttribute("title", " title=\"", 834, "\"", 884, 3);
            WriteAttributeValue("", 842, "Full", 842, 4, true);
            WriteAttributeValue(" ", 846, "Description:", 847, 13, true);
#nullable restore
#line 26 "C:\Users\Muhammad Farooq\Box\UpWork Pending Tasks\Yossef\MyEcommerce\MyEcommerce\MyEcommerce\Views\Home\ProductsList.cshtml"
WriteAttributeValue(" ", 859, item.ProductDescription, 860, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 26 "C:\Users\Muhammad Farooq\Box\UpWork Pending Tasks\Yossef\MyEcommerce\MyEcommerce\MyEcommerce\Views\Home\ProductsList.cshtml"
                                                                            Write(item.ProductDescription.Substring(0, 75).ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("...</span>\r\n");
#nullable restore
#line 27 "C:\Users\Muhammad Farooq\Box\UpWork Pending Tasks\Yossef\MyEcommerce\MyEcommerce\MyEcommerce\Views\Home\ProductsList.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>");
#nullable restore
#line 30 "C:\Users\Muhammad Farooq\Box\UpWork Pending Tasks\Yossef\MyEcommerce\MyEcommerce\MyEcommerce\Views\Home\ProductsList.cshtml"
                         Write(item.ProductDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 31 "C:\Users\Muhammad Farooq\Box\UpWork Pending Tasks\Yossef\MyEcommerce\MyEcommerce\MyEcommerce\Views\Home\ProductsList.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </p>\r\n                <span class=\"badge badge-dark\">Price : $");
#nullable restore
#line 33 "C:\Users\Muhammad Farooq\Box\UpWork Pending Tasks\Yossef\MyEcommerce\MyEcommerce\MyEcommerce\Views\Home\ProductsList.cshtml"
                                                   Write(Convert.ToDecimal(@item.ProductPrice).ToString("#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1272, "\"", 1322, 2);
            WriteAttributeValue("", 1279, "/Home/ProductDescription?ProductId=", 1279, 35, true);
#nullable restore
#line 34 "C:\Users\Muhammad Farooq\Box\UpWork Pending Tasks\Yossef\MyEcommerce\MyEcommerce\MyEcommerce\Views\Home\ProductsList.cshtml"
WriteAttributeValue("", 1314, item.Id, 1314, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm\" style=\"float:right\">See Details</a>\r\n\r\n                <button");
            BeginWriteAttribute("onclick", " onclick=\"", 1417, "\"", 1450, 3);
            WriteAttributeValue("", 1427, "AddItemtoCart(", 1427, 14, true);
#nullable restore
#line 36 "C:\Users\Muhammad Farooq\Box\UpWork Pending Tasks\Yossef\MyEcommerce\MyEcommerce\MyEcommerce\Views\Home\ProductsList.cshtml"
WriteAttributeValue("", 1441, item.Id, 1441, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1449, ")", 1449, 1, true);
            EndWriteAttribute();
            WriteLiteral("\r\n                        class=\"btn btn-outline-success btn-sm btn-block\"\r\n                        style=\"margin-top:5px;\">\r\n                    Add to Cart\r\n                </button>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 43 "C:\Users\Muhammad Farooq\Box\UpWork Pending Tasks\Yossef\MyEcommerce\MyEcommerce\MyEcommerce\Views\Home\ProductsList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>


<script>
    function AddItemtoCart(productid) {
        $.ajax({
            type: ""GET"",
            url: ""/Payment/AddItemtoCart"",
            data: {
                Productid: productid
            },
            success: function (data) {
                alert(data);
                window.location.reload();
            },
            error: function () {
                alert(""Something went wrong! Please try again later."");
            }
        });
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyEcommerce.InterfaceClasses.ProductListInterfaceClass>> Html { get; private set; }
    }
}
#pragma warning restore 1591
