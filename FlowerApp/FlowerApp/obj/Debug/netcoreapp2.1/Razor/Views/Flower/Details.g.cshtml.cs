#pragma checksum "C:\Users\Mihaela\source\repos\FlowerShopApp\FlowerApp\FlowerApp\Views\Flower\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13ac9373f038cb23bacf4a3cc490d6a122025ca6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flower_Details), @"mvc.1.0.view", @"/Views/Flower/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Flower/Details.cshtml", typeof(AspNetCore.Views_Flower_Details))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
#line 2 "C:\Users\Mihaela\source\repos\FlowerShopApp\FlowerApp\FlowerApp\Views\Flower\Details.cshtml"
using System.Threading.Tasks;

#line default
#line hidden
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
#line 1 "C:\Users\Mihaela\source\repos\FlowerShopApp\FlowerApp\FlowerApp\Views\Flower\Details.cshtml"
using System.Net;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13ac9373f038cb23bacf4a3cc490d6a122025ca6", @"/Views/Flower/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82ffc988e157097c6e39f8ac58b132e561528904", @"/Views/_ViewImports.cshtml")]
    public class Views_Flower_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FlowerDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(80, 35, true);
            WriteLiteral("\r\n<div class=\"thumbnail\">\r\n    <img");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 115, "\"", 139, 1);
#line 6 "C:\Users\Mihaela\source\repos\FlowerShopApp\FlowerApp\FlowerApp\Views\Flower\Details.cshtml"
WriteAttributeValue("", 121, Model.Flower.Name, 121, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 140, "\"", 168, 1);
#line 6 "C:\Users\Mihaela\source\repos\FlowerShopApp\FlowerApp\FlowerApp\Views\Flower\Details.cshtml"
WriteAttributeValue("", 146, Model.Flower.ImageUrl, 146, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(169, 66, true);
            WriteLiteral(">\r\n    <div class=\"caption-full\">\r\n        <h3 class=\"pull-right\">");
            EndContext();
            BeginContext(236, 18, false);
#line 8 "C:\Users\Mihaela\source\repos\FlowerShopApp\FlowerApp\FlowerApp\Views\Flower\Details.cshtml"
                          Write(Model.Flower.Price);

#line default
#line hidden
            EndContext();
            BeginContext(254, 45, true);
            WriteLiteral("</h3>\r\n        <h3>\r\n            <a href=\"#\">");
            EndContext();
            BeginContext(300, 17, false);
#line 10 "C:\Users\Mihaela\source\repos\FlowerShopApp\FlowerApp\FlowerApp\Views\Flower\Details.cshtml"
                   Write(Model.Flower.Name);

#line default
#line hidden
            EndContext();
            BeginContext(317, 33, true);
            WriteLiteral("</a>\r\n        </h3>\r\n        <h4>");
            EndContext();
            BeginContext(351, 29, false);
#line 12 "C:\Users\Mihaela\source\repos\FlowerShopApp\FlowerApp\FlowerApp\Views\Flower\Details.cshtml"
       Write(Model.Flower.ShortDescription);

#line default
#line hidden
            EndContext();
            BeginContext(380, 18, true);
            WriteLiteral("</h4>\r\n        <p>");
            EndContext();
            BeginContext(399, 28, false);
#line 13 "C:\Users\Mihaela\source\repos\FlowerShopApp\FlowerApp\FlowerApp\Views\Flower\Details.cshtml"
      Write(Model.Flower.LongDescription);

#line default
#line hidden
            EndContext();
            BeginContext(427, 46, true);
            WriteLiteral("</p>\r\n        <p class=\"button\">\r\n            ");
            EndContext();
            BeginContext(473, 160, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e8072d9f4234dd98caf366035d6a82e", async() => {
                BeginContext(618, 11, true);
                WriteLiteral("Add to cart");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pieId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 16 "C:\Users\Mihaela\source\repos\FlowerShopApp\FlowerApp\FlowerApp\Views\Flower\Details.cshtml"
                    WriteLiteral(Model.Flower.FlowerId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pieId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pieId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pieId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(633, 36, true);
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FlowerDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591