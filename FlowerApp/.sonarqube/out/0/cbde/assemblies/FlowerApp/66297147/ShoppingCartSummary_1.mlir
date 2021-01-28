func @_FlowerApp.Components.ShoppingCartSummary.Invoke$$() -> none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\ShoppingCartSummary.cs" :19 :8) {
^entry :
br ^0

^0: // JumpBlock
%0 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\ShoppingCartSummary.cs" :21 :24) // Not a variable of known type: _shoppingCart
%1 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\ShoppingCartSummary.cs" :21 :24) // _shoppingCart.GetShoppingCartItems() (InvocationExpression)
%3 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\ShoppingCartSummary.cs" :23 :12) // Not a variable of known type: _shoppingCart
%4 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\ShoppingCartSummary.cs" :23 :12) // _shoppingCart.ShoppingCartItems (SimpleMemberAccessExpression)
%5 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\ShoppingCartSummary.cs" :23 :46) // Not a variable of known type: items
%6 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\ShoppingCartSummary.cs" :25 :36) // new ShoppingCartViewModel              {                  ShoppingCart = _shoppingCart,                  ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()              } (ObjectCreationExpression)
%7 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\ShoppingCartSummary.cs" :27 :31) // Not a variable of known type: _shoppingCart
%8 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\ShoppingCartSummary.cs" :28 :36) // Not a variable of known type: _shoppingCart
%9 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\ShoppingCartSummary.cs" :28 :36) // _shoppingCart.GetShoppingCartTotal() (InvocationExpression)
// Entity from another assembly: View
%11 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\ShoppingCartSummary.cs" :30 :24) // Not a variable of known type: shoppingViewModel
%12 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\ShoppingCartSummary.cs" :30 :19) // View(shoppingViewModel) (InvocationExpression)
return %12 : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\ShoppingCartSummary.cs" :30 :12)

^1: // ExitBlock
cbde.unreachable

}
