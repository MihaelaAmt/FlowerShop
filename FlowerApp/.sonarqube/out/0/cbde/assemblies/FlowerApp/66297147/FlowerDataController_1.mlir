// Skipping function LoadMoreFlowers(), it contains poisonous unsupported syntaxes

func @_FlowerApp.Controllers.FlowerDataController.MapDbFlowerToFlowerViewModel$FlowerApp.Models.Flower$(none) -> none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\FlowerDataController.cs" :40 :8) {
^entry (%_dbFlower : none):
%0 = cbde.alloca none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\FlowerDataController.cs" :40 :61)
cbde.store %_dbFlower, %0 : memref<none> loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\FlowerDataController.cs" :40 :61)
br ^0

^0: // JumpBlock
%1 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\FlowerDataController.cs" :42 :19) // new FlowerViewModel()              {                  FlowerId = dbFlower.FlowerId,                  Name = dbFlower.Name,                  Price = dbFlower.Price,                  ShortDescription = dbFlower.ShortDescription,                  ImageThumbnailUrl = dbFlower.ImageThumbnailUrl              } (ObjectCreationExpression)
%2 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\FlowerDataController.cs" :44 :27) // Not a variable of known type: dbFlower
%3 = cbde.unknown : i32 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\FlowerDataController.cs" :44 :27) // dbFlower.FlowerId (SimpleMemberAccessExpression)
%4 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\FlowerDataController.cs" :45 :23) // Not a variable of known type: dbFlower
%5 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\FlowerDataController.cs" :45 :23) // dbFlower.Name (SimpleMemberAccessExpression)
%6 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\FlowerDataController.cs" :46 :24) // Not a variable of known type: dbFlower
%7 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\FlowerDataController.cs" :46 :24) // dbFlower.Price (SimpleMemberAccessExpression)
%8 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\FlowerDataController.cs" :47 :35) // Not a variable of known type: dbFlower
%9 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\FlowerDataController.cs" :47 :35) // dbFlower.ShortDescription (SimpleMemberAccessExpression)
%10 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\FlowerDataController.cs" :48 :36) // Not a variable of known type: dbFlower
%11 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\FlowerDataController.cs" :48 :36) // dbFlower.ImageThumbnailUrl (SimpleMemberAccessExpression)
return %1 : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\FlowerDataController.cs" :42 :12)

^1: // ExitBlock
cbde.unreachable

}
