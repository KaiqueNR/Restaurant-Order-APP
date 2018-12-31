#pragma checksum "C:\Users\kenan\Desktop\Projetos\GFTTest\GFTTest\Views\Orders\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "375c62ebe94a45597175c4b7910b769e39eace09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Home), @"mvc.1.0.view", @"/Views/Orders/Home.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/Home.cshtml", typeof(AspNetCore.Views_Orders_Home))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"375c62ebe94a45597175c4b7910b769e39eace09", @"/Views/Orders/Home.cshtml")]
    public class Views_Orders_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dictionary<int, List<GFTTest.Models.Dish>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/Scripts/Pages/orders.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\kenan\Desktop\Projetos\GFTTest\GFTTest\Views\Orders\Home.cshtml"
  
    ViewBag.Title = "Home";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(114, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("JavaScript", async() => {
                BeginContext(137, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(143, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dba1713bf2f240f986c8b4a326718c20", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(200, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(205, 1317, true);
            WriteLiteral(@"
    <div class=""container"">
        <div class=""row"">
            <div class=""col col-sm-12"">
                <h4>Orders</h4>
            </div>
        </div>
        <div class=""row"">
            <div class=""col col-sm-3"">
                <label class=""label"">Input</label>
                <div class=""form-group"">
                    <input id=""txt-input"" name=""InputBox"" type=""text"" class=""form-control"" />
                </div>
            </div>
            <div class=""col col-sm-3"">
                <label class=""label"">Output</label>
                <div class=""form-group"">
                    <input id=""txt-output"" name=""OutputBox"" type=""text"" class=""form-control"" />
                </div>
            </div>
            <div class=""col col-sm-12"">
                <button id=""btn-send-order"" type=""button"" class=""btn btn-primary"">Send Order</button>
            </div>
        </div>

        <div class=""row mt-2"">
            <div class=""col col-sm-12"">
                <table cl");
            WriteLiteral(@"ass=""table table-bordered"">
                    <thead>
                        <tr>
                            <th>Input</th>
                            <th>Output</th>
                        </tr>
                    </thead>
                    <tbody id=""tbody-orders-history"">
");
            EndContext();
#line 46 "C:\Users\kenan\Desktop\Projetos\GFTTest\GFTTest\Views\Orders\Home.cshtml"
                         if (Model.Count > 0)
                        {
                            foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(1684, 120, true);
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(1805, 114, false);
#line 52 "C:\Users\kenan\Desktop\Projetos\GFTTest\GFTTest\Views\Orders\Home.cshtml"
                                   Write(string.Concat(item.Value.FirstOrDefault().Period, ", ", string.Join(",", item.Value.Select(s => (int)s.DishType))));

#line default
#line hidden
            EndContext();
            BeginContext(1919, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2047, 719, false);
#line 55 "C:\Users\kenan\Desktop\Projetos\GFTTest\GFTTest\Views\Orders\Home.cshtml"
                                   Write(string.Concat(item.Value.FirstOrDefault().Period, ", ", string.Join(",", item.Value
                                                                                                                .GroupBy(g => g.DishType)
                                                                                                                .Select(s => string.Format("{0}{1}", 
                                                                                                                            s.FirstOrDefault().Name
                                                                                                                            , s.Count() > 1 ? string.Concat("(", s.Count(), ")") : string.Empty)))));

#line default
#line hidden
            EndContext();
            BeginContext(2766, 84, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 62 "C:\Users\kenan\Desktop\Projetos\GFTTest\GFTTest\Views\Orders\Home.cshtml"

                            }
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(2967, 172, true);
            WriteLiteral("                            <tr class=\"no-orders\">\r\n                                <td colspan=\"3\">No orders have been performed.</td>\r\n                            </tr>\r\n");
            EndContext();
#line 70 "C:\Users\kenan\Desktop\Projetos\GFTTest\GFTTest\Views\Orders\Home.cshtml"
                        }

#line default
#line hidden
            BeginContext(3166, 316, true);
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
        </div>

        <div class=""row mt-2"">
            <div class=""col col-sm-12"">
                <div id=""alert"" class=""alert alert-primary"" role=""alert"" style=""display:none;""></div>
            </div>
        </div>
    </div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dictionary<int, List<GFTTest.Models.Dish>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
