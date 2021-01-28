func @_FlowerApp.Controllers.ShoppingCartController.Index$$() -> none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\ShoppingCartController.cs" :19 :8) {
^entry :
br ^0

^0: // JumpBlock
%0 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\ShoppingCartController.cs" :21 :24) // Not a variable of known type: _shoppingCart
%1 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\ShoppingCartController.cs" :21 :24) // _shoppingCart.GetShoppingCartItems() (InvocationExpression)
%3 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\ShoppingCartController.cs" :22 :12) // Not a variable of known type: _shoppingCart
%4 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\ShoppingCartController.cs" :22 :12) // _shoppingCart.ShoppingCartItems (SimpleMemberAccessExpression)
%5 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\ShoppingCartController.cs" :22 :46) // Not a variable of known type: items
%6 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\ShoppingCartController.cs" :24 :40) // new ShoppingCartViewModel              {                  ShoppingCart = _shoppingCart,                  ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()              } (ObjectCreationExpression)
%7 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\ShoppingCartController.cs" :26 :31) // Not a variable of known type: _shoppingCart
%8 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\ShoppingCartController.cs" :27 :36) // Not a variable of known type: _shoppingCart
%9 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\ShoppingCartController.cs" :27 :36) // _shoppingCart.GetShoppingCartTotal() (InvocationExpression)
// Entity from another assembly: View
%11 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\ShoppingCartController.cs" :30 :24) // Not a variable of known type: shoppingCartViewModel
%12 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\ShoppingCartController.cs" :30 :19) // View(shoppingCartViewModel) (InvocationExpression)
return %12 : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\ShoppingCartController.cs" :30 :12)

^1: // ExitBlock
cbde.unreachable

}
// Skipping function AddToShoppingCart(i32), it contains poisonous unsupported syntaxes

// Skipping function UpdateShoppingCart(i32, i1), it contains poisonous unsupported syntaxes

// Skipping function RemoveFromShoppingCart(i32), it contains poisonous unsupported syntaxes

