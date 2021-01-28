func @_FlowerApp.Controllers.AccountController.Login$string$(none) -> none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\AccountController.cs" :26 :8) {
^entry (%_returnUrl : none):
%0 = cbde.alloca none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\AccountController.cs" :27 :35)
cbde.store %_returnUrl, %0 : memref<none> loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\AccountController.cs" :27 :35)
br ^0

^0: // JumpBlock
// Entity from another assembly: View
%1 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\AccountController.cs" :29 :24) // new LoginViewModel              {                  ReturnUrl = returnUrl              } (ObjectCreationExpression)
%2 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\AccountController.cs" :31 :28) // Not a variable of known type: returnUrl
%3 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\AccountController.cs" :29 :19) // View(new LoginViewModel              {                  ReturnUrl = returnUrl              }) (InvocationExpression)
return %3 : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\AccountController.cs" :29 :12)

^1: // ExitBlock
cbde.unreachable

}
// Skipping function Login(none), it contains poisonous unsupported syntaxes

func @_FlowerApp.Controllers.AccountController.Register$$() -> none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\AccountController.cs" :60 :8) {
^entry :
br ^0

^0: // JumpBlock
// Entity from another assembly: View
%0 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\AccountController.cs" :63 :19) // View() (InvocationExpression)
return %0 : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\AccountController.cs" :63 :12)

^1: // ExitBlock
cbde.unreachable

}
// Skipping function Register(none), it contains poisonous unsupported syntaxes

// Skipping function Logout(), it contains poisonous unsupported syntaxes

