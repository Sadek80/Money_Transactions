#pragma checksum "D:\Study\.NET Projects\Money Transaction\Money_Transaction\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d285c49da8f35c3b06267be6b7916cd9fcd3c43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Money_Transaction.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace Money_Transaction.Pages
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
#line 1 "D:\Study\.NET Projects\Money Transaction\Money_Transaction\Pages\_ViewImports.cshtml"
using Money_Transaction;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Study\.NET Projects\Money Transaction\Money_Transaction\Pages\Index.cshtml"
using Money_Transaction.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d285c49da8f35c3b06267be6b7916cd9fcd3c43", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffe9b8da323ee3e6cfa6ec22c55097c6c4a61e0e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/transfer.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Transactions"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("icons"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("show-color"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Study\.NET Projects\Money Transaction\Money_Transaction\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral("<main class=\"home-main\">\r\n    <section>\r\n        <h2>Home</h2>\r\n        <section class=\"insights\">\r\n            <div>\r\n                <div class=\"insights-icons Transactions\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8d285c49da8f35c3b06267be6b7916cd9fcd3c435353", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
            WriteLiteral("\r\n                </div>\r\n                <div class=\"insights-details\">\r\n                    <h3 class=\"text-muted\">Total Transactions</h3>\r\n                    <h2>");
#nullable restore
#line 17 "D:\Study\.NET Projects\Money Transaction\Money_Transaction\Pages\Index.cshtml"
                   Write(Model.NumOfTransactions);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                </div>
            </div>
            <div>
                <div class=""insights-icons Customers"">
                    <span class=""material-icons-sharp md-24"">
                        person_outline
                    </span>
                </div>
                <div class=""insights-details"">
                    <h3 class=""text-muted"">Total Customers</h3>
                    <h2>");
#nullable restore
#line 28 "D:\Study\.NET Projects\Money Transaction\Money_Transaction\Pages\Index.cshtml"
                   Write(Model.NumOfCustomers);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                </div>
            </div>
        </section>
        <section class=""customers-list"">
            <h2>Customers</h2>
            <div class=""list-section"">
                <div class=""table-wrap"">
                    <table>
                        <thead>
                            <tr>
                                <th>Customer</th>
                                <th>Email</th>
                                <th>Balance</th>
                                <th></th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 46 "D:\Study\.NET Projects\Money Transaction\Money_Transaction\Pages\Index.cshtml"
                             foreach (var Customer in Model.Customers)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        <div class=\"customer-name\">\r\n                                            <img");
            BeginWriteAttribute("src", " src=", 1911, "", 1934, 1);
#nullable restore
#line 51 "D:\Study\.NET Projects\Money Transaction\Money_Transaction\Pages\Index.cshtml"
WriteAttributeValue("", 1916, Customer.ImageUrl, 1916, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"9\" class=\"profile-img\"> ");
#nullable restore
#line 51 "D:\Study\.NET Projects\Money Transaction\Money_Transaction\Pages\Index.cshtml"
                                                                                                Write(Customer.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 51 "D:\Study\.NET Projects\Money Transaction\Money_Transaction\Pages\Index.cshtml"
                                                                                                                    Write(Customer.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </div>\r\n                                    </td>\r\n                                    <td>");
#nullable restore
#line 54 "D:\Study\.NET Projects\Money Transaction\Money_Transaction\Pages\Index.cshtml"
                                   Write(Customer.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>$");
#nullable restore
#line 55 "D:\Study\.NET Projects\Money Transaction\Money_Transaction\Pages\Index.cshtml"
                                    Write(Customer.Balance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d285c49da8f35c3b06267be6b7916cd9fcd3c4310538", async() => {
                WriteLiteral("Show");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-customerId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "D:\Study\.NET Projects\Money Transaction\Money_Transaction\Pages\Index.cshtml"
                                                                                              WriteLiteral(Customer.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["customerId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-customerId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["customerId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 58 "D:\Study\.NET Projects\Money Transaction\Money_Transaction\Pages\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
            </div>
        </section>
    </section>

    <aside class=""aside"">
        <h2>Recent Transactions</h2>
        <section class=""recent-transactions"">
");
#nullable restore
#line 69 "D:\Study\.NET Projects\Money Transaction\Money_Transaction\Pages\Index.cshtml"
             foreach (var transaction in Model.Transactions)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""transaction"">
                    <div class=""left"">
                        <img src=""./Images/transfer.png"" alt=""transfer"" class=""icons"">
                        <div class=""transaction-details"">
                            <h3>");
#nullable restore
#line 75 "D:\Study\.NET Projects\Money Transaction\Money_Transaction\Pages\Index.cshtml"
                           Write(transaction.Sender.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" To ");
#nullable restore
#line 75 "D:\Study\.NET Projects\Money Transaction\Money_Transaction\Pages\Index.cshtml"
                                                           Write(transaction.Reciever.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n                            <small class=\"text-muted\"> ");
#nullable restore
#line 76 "D:\Study\.NET Projects\Money Transaction\Money_Transaction\Pages\Index.cshtml"
                                                  Write(transaction.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("  &bull; ");
#nullable restore
#line 76 "D:\Study\.NET Projects\Money Transaction\Money_Transaction\Pages\Index.cshtml"
                                                                            Write(transaction.Date.GetDateFormatted());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </small>\r\n                        </div>\r\n                    </div>\r\n                    <b>$");
#nullable restore
#line 79 "D:\Study\.NET Projects\Money Transaction\Money_Transaction\Pages\Index.cshtml"
                   Write(transaction.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                </div>\r\n");
#nullable restore
#line 81 "D:\Study\.NET Projects\Money Transaction\Money_Transaction\Pages\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </section>\r\n    </aside>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591