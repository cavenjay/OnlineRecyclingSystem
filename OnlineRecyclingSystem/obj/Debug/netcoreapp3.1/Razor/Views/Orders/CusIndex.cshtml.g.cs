#pragma checksum "C:\Users\caven\Desktop\Degree Year 3\SEM 2\FYP sem 2\OnlineRecyclingSystem\OnlineRecyclingSystem\Views\Orders\CusIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7d3026fdc5e462624a0fa88fecafb181c88646f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_CusIndex), @"mvc.1.0.view", @"/Views/Orders/CusIndex.cshtml")]
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
#line 1 "C:\Users\caven\Desktop\Degree Year 3\SEM 2\FYP sem 2\OnlineRecyclingSystem\OnlineRecyclingSystem\Views\_ViewImports.cshtml"
using OnlineRecyclingSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\caven\Desktop\Degree Year 3\SEM 2\FYP sem 2\OnlineRecyclingSystem\OnlineRecyclingSystem\Views\_ViewImports.cshtml"
using OnlineRecyclingSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\caven\Desktop\Degree Year 3\SEM 2\FYP sem 2\OnlineRecyclingSystem\OnlineRecyclingSystem\Views\Orders\CusIndex.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\caven\Desktop\Degree Year 3\SEM 2\FYP sem 2\OnlineRecyclingSystem\OnlineRecyclingSystem\Views\Orders\CusIndex.cshtml"
using OnlineRecyclingSystem.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7d3026fdc5e462624a0fa88fecafb181c88646f", @"/Views/Orders/CusIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2c3ff2ddd3cfe80d8ed93c4652bcbf64f577c1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_CusIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineRecyclingSystem.Models.Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CusEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CusDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\caven\Desktop\Degree Year 3\SEM 2\FYP sem 2\OnlineRecyclingSystem\OnlineRecyclingSystem\Views\Orders\CusIndex.cshtml"
  
    ViewData["Title"] = "CusIndex";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Your Orders</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7d3026fdc5e462624a0fa88fecafb181c88646f5006", async() => {
                WriteLiteral("\r\n    \r\n    Sort Your Order By ");
#nullable restore
#line 14 "C:\Users\caven\Desktop\Degree Year 3\SEM 2\FYP sem 2\OnlineRecyclingSystem\OnlineRecyclingSystem\Views\Orders\CusIndex.cshtml"
                  Write(Html.DropDownList("OrderStatus", "All"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br /> <br />\r\n    <input type=\"submit\" name=\"search\" value=\"Sort!\" />\r\n    <br /> <br />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\caven\Desktop\Degree Year 3\SEM 2\FYP sem 2\OnlineRecyclingSystem\OnlineRecyclingSystem\Views\Orders\CusIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\caven\Desktop\Degree Year 3\SEM 2\FYP sem 2\OnlineRecyclingSystem\OnlineRecyclingSystem\Views\Orders\CusIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\caven\Desktop\Degree Year 3\SEM 2\FYP sem 2\OnlineRecyclingSystem\OnlineRecyclingSystem\Views\Orders\CusIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.CusName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\caven\Desktop\Degree Year 3\SEM 2\FYP sem 2\OnlineRecyclingSystem\OnlineRecyclingSystem\Views\Orders\CusIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.CusContact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\caven\Desktop\Degree Year 3\SEM 2\FYP sem 2\OnlineRecyclingSystem\OnlineRecyclingSystem\Views\Orders\CusIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.DriverName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\caven\Desktop\Degree Year 3\SEM 2\FYP sem 2\OnlineRecyclingSystem\OnlineRecyclingSystem\Views\Orders\CusIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.DriverContact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "C:\Users\caven\Desktop\Degree Year 3\SEM 2\FYP sem 2\OnlineRecyclingSystem\OnlineRecyclingSystem\Views\Orders\CusIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 53 "C:\Users\caven\Desktop\Degree Year 3\SEM 2\FYP sem 2\OnlineRecyclingSystem\OnlineRecyclingSystem\Views\Orders\CusIndex.cshtml"
         foreach (var item in Model)
        {
        
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\caven\Desktop\Degree Year 3\SEM 2\FYP sem 2\OnlineRecyclingSystem\OnlineRecyclingSystem\Views\Orders\CusIndex.cshtml"
             if (UserManager.GetUserName(User) == item.CusName)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 60 "C:\Users\caven\Desktop\Degree Year 3\SEM 2\FYP sem 2\OnlineRecyclingSystem\OnlineRecyclingSystem\Views\Orders\CusIndex.cshtml"
               Write(Html.DisplayFor(modelItem => item.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 63 "C:\Users\caven\Desktop\Degree Year 3\SEM 2\FYP sem 2\OnlineRecyclingSystem\OnlineRecyclingSystem\Views\Orders\CusIndex.cshtml"
               Write(Html.DisplayFor(modelItem => item.OrderTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 66 "C:\Users\caven\Desktop\Degree Year 3\SEM 2\FYP sem 2\OnlineRecyclingSystem\OnlineRecyclingSystem\Views\Orders\CusIndex.cshtml"
               Write(Html.DisplayFor(modelItem => item.CusName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 69 "C:\Users\caven\Desktop\Degree Year 3\SEM 2\FYP sem 2\OnlineRecyclingSystem\OnlineRecyclingSystem\Views\Orders\CusIndex.cshtml"
               Write(Html.DisplayFor(modelItem => item.CusContact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 73 "C:\Users\caven\Desktop\Degree Year 3\SEM 2\FYP sem 2\OnlineRecyclingSystem\OnlineRecyclingSystem\Views\Orders\CusIndex.cshtml"
               Write(Html.DisplayFor(modelItem => item.DriverName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 76 "C:\Users\caven\Desktop\Degree Year 3\SEM 2\FYP sem 2\OnlineRecyclingSystem\OnlineRecyclingSystem\Views\Orders\CusIndex.cshtml"
               Write(Html.DisplayFor(modelItem => item.DriverContact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 79 "C:\Users\caven\Desktop\Degree Year 3\SEM 2\FYP sem 2\OnlineRecyclingSystem\OnlineRecyclingSystem\Views\Orders\CusIndex.cshtml"
               Write(Html.DisplayFor(modelItem => item.OrderStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n");
#nullable restore
#line 83 "C:\Users\caven\Desktop\Degree Year 3\SEM 2\FYP sem 2\OnlineRecyclingSystem\OnlineRecyclingSystem\Views\Orders\CusIndex.cshtml"
                     if (item.OrderStatus == "Ongoing")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7d3026fdc5e462624a0fa88fecafb181c88646f13058", async() => {
                WriteLiteral("Edit Order");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "C:\Users\caven\Desktop\Degree Year 3\SEM 2\FYP sem 2\OnlineRecyclingSystem\OnlineRecyclingSystem\Views\Orders\CusIndex.cshtml"
                                              WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <br>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7d3026fdc5e462624a0fa88fecafb181c88646f15313", async() => {
                WriteLiteral("Cancel Order");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 87 "C:\Users\caven\Desktop\Degree Year 3\SEM 2\FYP sem 2\OnlineRecyclingSystem\OnlineRecyclingSystem\Views\Orders\CusIndex.cshtml"
                                                WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 88 "C:\Users\caven\Desktop\Degree Year 3\SEM 2\FYP sem 2\OnlineRecyclingSystem\OnlineRecyclingSystem\Views\Orders\CusIndex.cshtml"
                    }
                    else
                    {

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 95 "C:\Users\caven\Desktop\Degree Year 3\SEM 2\FYP sem 2\OnlineRecyclingSystem\OnlineRecyclingSystem\Views\Orders\CusIndex.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\Users\caven\Desktop\Degree Year 3\SEM 2\FYP sem 2\OnlineRecyclingSystem\OnlineRecyclingSystem\Views\Orders\CusIndex.cshtml"
             
            
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<OnlineRecyclingSystemUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnlineRecyclingSystem.Models.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591