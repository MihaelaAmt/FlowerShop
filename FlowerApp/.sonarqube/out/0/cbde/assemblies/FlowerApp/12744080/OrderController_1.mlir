func @_FlowerApp.Controllers.OrderController.Checkout$$() -> none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :18 :8) {
^entry :
br ^0

^0: // JumpBlock
// Entity from another assembly: View
%0 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :21 :19) // View() (InvocationExpression)
return %0 : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :21 :12)

^1: // ExitBlock
cbde.unreachable

}
func @_FlowerApp.Controllers.OrderController.Checkout$FlowerApp.Models.Order$(none) -> none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :24 :8) {
^entry (%_order : none):
%0 = cbde.alloca none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :26 :38)
cbde.store %_order, %0 : memref<none> loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :26 :38)
br ^0

^0: // BinaryBranchBlock
%1 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :28 :24) // Not a variable of known type: _shoppingCart
%2 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :28 :24) // _shoppingCart.GetShoppingCartItems() (InvocationExpression)
%4 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :29 :12) // Not a variable of known type: _shoppingCart
%5 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :29 :12) // _shoppingCart.ShoppingCartItems (SimpleMemberAccessExpression)
%6 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :29 :46) // Not a variable of known type: items
%7 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :31 :16) // Not a variable of known type: _shoppingCart
%8 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :31 :16) // _shoppingCart.ShoppingCartItems (SimpleMemberAccessExpression)
%9 = cbde.unknown : i32 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :31 :16) // _shoppingCart.ShoppingCartItems.Count (SimpleMemberAccessExpression)
%10 = constant 0 : i32 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :31 :57)
%11 = cmpi "eq", %9, %10 : i32 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :31 :16)
cond_br %11, ^1, ^2 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :31 :16)

^1: // SimpleBlock
%12 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :33 :16) // Identifier from another assembly: ModelState
%13 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :33 :41) // "" (StringLiteralExpression)
%14 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :33 :45) // "Your cart is empty, add some flowers first" (StringLiteralExpression)
%15 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :33 :16) // ModelState.AddModelError("", "Your cart is empty, add some flowers first") (InvocationExpression)
br ^2

^2: // BinaryBranchBlock
%16 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :36 :16) // Identifier from another assembly: ModelState
%17 = cbde.unknown : i1 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :36 :16) // ModelState.IsValid (SimpleMemberAccessExpression)
cond_br %17, ^3, ^4 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :36 :16)

^3: // JumpBlock
%18 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :38 :16) // Not a variable of known type: order
%19 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :38 :16) // order.Email (SimpleMemberAccessExpression)
%20 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :38 :30) // Identifier from another assembly: User
%21 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :38 :30) // User.Identity (SimpleMemberAccessExpression)
%22 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :38 :30) // User.Identity.Name (SimpleMemberAccessExpression)
%23 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :39 :16) // Not a variable of known type: _orderRepository
%24 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :39 :45) // Not a variable of known type: order
%25 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :39 :16) // _orderRepository.CreateOrder(order) (InvocationExpression)
%26 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :40 :16) // Not a variable of known type: _shoppingCart
%27 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :40 :16) // _shoppingCart.ClearCart() (InvocationExpression)
// Entity from another assembly: RedirectToAction
%28 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :41 :40) // "CheckoutComplete" (StringLiteralExpression)
%29 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :41 :23) // RedirectToAction("CheckoutComplete") (InvocationExpression)
return %29 : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :41 :16)

^4: // JumpBlock
// Entity from another assembly: View
%30 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :43 :24) // Not a variable of known type: order
%31 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :43 :19) // View(order) (InvocationExpression)
return %31 : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :43 :12)

^5: // ExitBlock
cbde.unreachable

}
func @_FlowerApp.Controllers.OrderController.CheckoutComplete$$() -> none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :46 :8) {
^entry :
br ^0

^0: // JumpBlock
%0 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :48 :12) // Identifier from another assembly: ViewBag
%1 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :48 :12) // ViewBag.CheckoutCompleteMessage (SimpleMemberAccessExpression)
%2 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :48 :46) // "Thanks for your order. You'll soon enjoy our beautiful flowers" (StringLiteralExpression)
// Entity from another assembly: View
%3 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :50 :19) // View() (InvocationExpression)
return %3 : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\OrderController.cs" :50 :12)

^1: // ExitBlock
cbde.unreachable

}
