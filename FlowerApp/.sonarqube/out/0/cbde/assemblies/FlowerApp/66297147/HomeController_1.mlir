func @_FlowerApp.Controllers.HomeController.Index$$() -> none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\HomeController.cs" :19 :8) {
^entry :
br ^0

^0: // JumpBlock
%0 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\HomeController.cs" :21 :32) // new HomeViewModel              {                  FlowerPresentation = _flowerRepository.FlowerPresentation,                  FlowersName = _flowerRepository.FlowersNames              } (ObjectCreationExpression)
%1 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\HomeController.cs" :23 :37) // Not a variable of known type: _flowerRepository
%2 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\HomeController.cs" :23 :37) // _flowerRepository.FlowerPresentation (SimpleMemberAccessExpression)
%3 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\HomeController.cs" :24 :30) // Not a variable of known type: _flowerRepository
%4 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\HomeController.cs" :24 :30) // _flowerRepository.FlowersNames (SimpleMemberAccessExpression)
// Entity from another assembly: View
%6 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\HomeController.cs" :27 :24) // Not a variable of known type: homeViewModel
%7 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\HomeController.cs" :27 :19) // View(homeViewModel) (InvocationExpression)
return %7 : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\HomeController.cs" :27 :12)

^1: // ExitBlock
cbde.unreachable

}
