// Skipping function GetFlowerById(i32), it contains poisonous unsupported syntaxes

// Skipping function AddFlower(none), it contains poisonous unsupported syntaxes

// Skipping function DeleteFlower(none), it contains poisonous unsupported syntaxes

func @_FlowerApp.Repository.FlowerRepository.MapDbFlowerToFlowerViewModel$FlowerApp.Models.Flower$(none) -> none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\FlowerRepository.cs" :81 :8) {
^entry (%_dbFlower : none):
%0 = cbde.alloca none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\FlowerRepository.cs" :81 :61)
cbde.store %_dbFlower, %0 : memref<none> loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\FlowerRepository.cs" :81 :61)
br ^0

^0: // JumpBlock
%1 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\FlowerRepository.cs" :83 :19) // new FlowerViewModel()              {                  FlowerId = dbFlower.FlowerId,                  Name = dbFlower.Name,                  Price = dbFlower.Price,                  ShortDescription = dbFlower.ShortDescription,                  ImageThumbnailUrl = dbFlower.ImageThumbnailUrl              } (ObjectCreationExpression)
%2 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\FlowerRepository.cs" :85 :27) // Not a variable of known type: dbFlower
%3 = cbde.unknown : i32 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\FlowerRepository.cs" :85 :27) // dbFlower.FlowerId (SimpleMemberAccessExpression)
%4 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\FlowerRepository.cs" :86 :23) // Not a variable of known type: dbFlower
%5 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\FlowerRepository.cs" :86 :23) // dbFlower.Name (SimpleMemberAccessExpression)
%6 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\FlowerRepository.cs" :87 :24) // Not a variable of known type: dbFlower
%7 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\FlowerRepository.cs" :87 :24) // dbFlower.Price (SimpleMemberAccessExpression)
%8 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\FlowerRepository.cs" :88 :35) // Not a variable of known type: dbFlower
%9 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\FlowerRepository.cs" :88 :35) // dbFlower.ShortDescription (SimpleMemberAccessExpression)
%10 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\FlowerRepository.cs" :89 :36) // Not a variable of known type: dbFlower
%11 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\FlowerRepository.cs" :89 :36) // dbFlower.ImageThumbnailUrl (SimpleMemberAccessExpression)
return %1 : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\FlowerRepository.cs" :83 :12)

^1: // ExitBlock
cbde.unreachable

}
func @_FlowerApp.Repository.FlowerRepository.UpdateFlower$FlowerApp.Models.Flower$(none) -> i1 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\FlowerRepository.cs" :93 :8) {
^entry (%_flower : none):
%0 = cbde.alloca none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\FlowerRepository.cs" :93 :33)
cbde.store %_flower, %0 : memref<none> loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\FlowerRepository.cs" :93 :33)
br ^0

^0: // JumpBlock
%1 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\FlowerRepository.cs" :95 :12) // Not a variable of known type: _appDbContext
%2 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\FlowerRepository.cs" :95 :33) // Not a variable of known type: flower
%3 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\FlowerRepository.cs" :95 :12) // _appDbContext.Update(flower) (InvocationExpression)
%4 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\FlowerRepository.cs" :97 :12) // Not a variable of known type: _appDbContext
%5 = cbde.unknown : i32 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\FlowerRepository.cs" :97 :12) // _appDbContext.SaveChanges() (InvocationExpression)
%6 = constant 1 : i1 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\FlowerRepository.cs" :99 :19) // true
return %6 : i1 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\FlowerRepository.cs" :99 :12)

^1: // ExitBlock
cbde.unreachable

}
