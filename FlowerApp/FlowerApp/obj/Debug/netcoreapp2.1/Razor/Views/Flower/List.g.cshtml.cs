#pragma checksum "C:\Users\Mihaela\source\repos\FlowerShopApp\FlowerApp\FlowerApp\Views\Flower\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42e1570ee3e87df9a2cf7bf2172c66140436e198"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flower_List), @"mvc.1.0.view", @"/Views/Flower/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Flower/List.cshtml", typeof(AspNetCore.Views_Flower_List))]
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
#line 1 "C:\Users\Mihaela\source\repos\FlowerShopApp\FlowerApp\FlowerApp\Views\_ViewImports.cshtml"
using FlowerApp.Models;

#line default
#line hidden
#line 2 "C:\Users\Mihaela\source\repos\FlowerShopApp\FlowerApp\FlowerApp\Views\_ViewImports.cshtml"
using FlowerApp.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\Mihaela\source\repos\FlowerShopApp\FlowerApp\FlowerApp\Views\_ViewImports.cshtml"
using FlowerApp.TagHelpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42e1570ee3e87df9a2cf7bf2172c66140436e198", @"/Views/Flower/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82ffc988e157097c6e39f8ac58b132e561528904", @"/Views/_ViewImports.cshtml")]
    public class Views_Flower_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FlowerListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "ascending", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "descending", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success my-2 my-sm-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Flower", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline mt-2 mt-md-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(30, 750, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2291ea45c4a84c4ba6e9d9c16c49fa6a", async() => {
                BeginContext(69, 305, true);
                WriteLiteral(@"
    <input class=""form-control mr-sm-2"" type=""text"" placeholder=""Low price"" aria-label=""Search"" name=""lowPrice"">
    <input class=""form-control mr-sm-2"" type=""text"" placeholder=""High price"" aria-label=""Search"" name=""highPrice"">
    <input style=""display: none"" class=""form-control mr-sm-2"" type=""text""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 374, "\"", 406, 1);
#line 6 "C:\Users\Mihaela\source\repos\FlowerShopApp\FlowerApp\FlowerApp\Views\Flower\List.cshtml"
WriteAttributeValue("", 382, ViewBag.CurrentCategory, 382, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(407, 119, true);
                WriteLiteral(" placeholder=\"category\" aria-label=\"Search\" name=\"category\">\r\n    <select aria-label=\"Search\" name=\"sorting\">\r\n        ");
                EndContext();
                BeginContext(526, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9153c92d56c43aab35f1b599428b73f", async() => {
                    BeginContext(552, 9, true);
                    WriteLiteral("Ascending");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(570, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(580, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "684f189f518a4160a5745fee3e513f17", async() => {
                    BeginContext(607, 10, true);
                    WriteLiteral("Descending");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(626, 21, true);
                WriteLiteral("\r\n    </select>\r\n    ");
                EndContext();
                BeginContext(647, 124, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71b08a467a164cb2abbc367dc001f0a8", async() => {
                    BeginContext(756, 6, true);
                    WriteLiteral("Filter");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(771, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(780, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(785, 23, false);
#line 14 "C:\Users\Mihaela\source\repos\FlowerShopApp\FlowerApp\FlowerApp\Views\Flower\List.cshtml"
Write(ViewBag.CurrentCategory);

#line default
#line hidden
            EndContext();
            BeginContext(808, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 15 "C:\Users\Mihaela\source\repos\FlowerShopApp\FlowerApp\FlowerApp\Views\Flower\List.cshtml"
 foreach (var flower in Model.Flowers)
{
    

#line default
#line hidden
            BeginContext(858, 45, false);
#line 17 "C:\Users\Mihaela\source\repos\FlowerShopApp\FlowerApp\FlowerApp\Views\Flower\List.cshtml"
Write(Html.Partial("FlowerOverviewSummary", flower));

#line default
#line hidden
            EndContext();
#line 17 "C:\Users\Mihaela\source\repos\FlowerShopApp\FlowerApp\FlowerApp\Views\Flower\List.cshtml"
                                                  
}

#line default
#line hidden
            BeginContext(908, 34, true);
            WriteLiteral("\r\n<div id=\"flowerDiv\">\r\n\r\n</div>\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(959, 2188, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            LoadMoreFlowers();
        });
        $(window).scroll(function () {
            if ($(window).scrollTop() == $(document).height() - $(window).height()) {
                LoadMoreFlowers();
            }
        });
        function LoadMoreFlowers() {
            $.ajax({
                type: 'GET',
                url: '/api/FlowerData',
                dataType: 'json',
                success: function (jsonData) {
                    if (jsonData == null) {
                        alert('no data returned');
                        return;
                    }
                    $.each(jsonData, function (index, flower) {
                        var FlowerSummarString = '<div class=""col-sm-4 col-lg-4 col-md-4""> ' +
                            '  <div class=""thumbnail"">' +
                            '     <img src=""' + flower.imageThumbnailUrl + '"" alt="""">' +
                            '      <div class=""caption");
                WriteLiteral(@""">' +
                            '         <h3 class=""pull-right"">' + flower.price + '</h3>' +
                            '         <h3>' +
                            '             <a href=/Flower/Details/' + flower.flowerId + '>' + flower.name + '</a>' +
                            '         </h3>' +
                            '         <p>' + flower.shortDescription + '</p>' +
                            '    </div>' +
                            '    <div class=""addToCart"">' +
                            '        <p class=""button"">' +
                            '             <a class=""btn btn-primary"" href=/ShoppingCart/AddToShoppingCart?flowerId=' + flower.flowerId + '>Add to cart</a>' +
                            '         </p>' +
                            '     </div>' +
                            '  </div>' +
                            '</div>';
                        $('#flowerDiv').append(FlowerSummarString);
                    });
                },
                error");
                WriteLiteral(": function (ex) {\r\n                    alert(ex);\r\n                }\r\n            });\r\n            return false;\r\n        }\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(3150, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FlowerListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
