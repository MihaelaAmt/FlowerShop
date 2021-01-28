func @_FlowerApp.TagHelpers.EmailTagHelper.Process$Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext.Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput$(none, none) -> () loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\TagHelpers\\EmailTagHelper.cs" :10 :8) {
^entry (%_context : none, %_output : none):
%0 = cbde.alloca none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\TagHelpers\\EmailTagHelper.cs" :10 :37)
cbde.store %_context, %0 : memref<none> loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\TagHelpers\\EmailTagHelper.cs" :10 :37)
%1 = cbde.alloca none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\TagHelpers\\EmailTagHelper.cs" :10 :63)
cbde.store %_output, %1 : memref<none> loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\TagHelpers\\EmailTagHelper.cs" :10 :63)
br ^0

^0: // SimpleBlock
%2 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\TagHelpers\\EmailTagHelper.cs" :12 :12) // Not a variable of known type: output
%3 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\TagHelpers\\EmailTagHelper.cs" :12 :12) // output.TagName (SimpleMemberAccessExpression)
%4 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\TagHelpers\\EmailTagHelper.cs" :12 :29) // "a" (StringLiteralExpression)
%5 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\TagHelpers\\EmailTagHelper.cs" :13 :12) // Not a variable of known type: output
%6 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\TagHelpers\\EmailTagHelper.cs" :13 :12) // output.Attributes (SimpleMemberAccessExpression)
%7 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\TagHelpers\\EmailTagHelper.cs" :13 :43) // "href" (StringLiteralExpression)
%8 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\TagHelpers\\EmailTagHelper.cs" :13 :51) // "mailto:" (StringLiteralExpression)
%9 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\TagHelpers\\EmailTagHelper.cs" :13 :63) // Not a variable of known type: Address
%10 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\TagHelpers\\EmailTagHelper.cs" :13 :51) // Binary expression on unsupported types "mailto:" + Address
%11 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\TagHelpers\\EmailTagHelper.cs" :13 :12) // output.Attributes.SetAttribute("href", "mailto:" + Address) (InvocationExpression)
%12 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\TagHelpers\\EmailTagHelper.cs" :14 :12) // Not a variable of known type: output
%13 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\TagHelpers\\EmailTagHelper.cs" :14 :12) // output.Content (SimpleMemberAccessExpression)
%14 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\TagHelpers\\EmailTagHelper.cs" :14 :38) // Not a variable of known type: Content
%15 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\TagHelpers\\EmailTagHelper.cs" :14 :12) // output.Content.SetContent(Content) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
