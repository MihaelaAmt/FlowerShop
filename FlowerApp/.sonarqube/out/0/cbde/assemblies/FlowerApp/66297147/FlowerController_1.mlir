// Skipping function List(none, none, none, none, none), it contains poisonous unsupported syntaxes

// Skipping function Favorite(), it contains poisonous unsupported syntaxes

// Skipping function AddToFavorite(i32), it contains poisonous unsupported syntaxes

// Skipping function RemoveFromFavorite(i32), it contains poisonous unsupported syntaxes

// Skipping function PriceFilter(none, none, none), it contains poisonous unsupported syntaxes

// Skipping function Search(none, none, none, none), it contains poisonous unsupported syntaxes

// Skipping function AutocompleteSearch(), it contains poisonous unsupported syntaxes

func @_FlowerApp.Controllers.FlowerController.FlowersNames$$() -> none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\FlowerController.cs" :181 :8) {
^entry :
br ^0

^0: // JumpBlock
%0 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\FlowerController.cs" :184 :19) // Not a variable of known type: _flowerRepository
%1 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\FlowerController.cs" :184 :19) // _flowerRepository.FlowersNames (SimpleMemberAccessExpression)
return %1 : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\FlowerController.cs" :184 :12)

^1: // ExitBlock
cbde.unreachable

}
func @_FlowerApp.Controllers.FlowerController.Details$int$(i32) -> none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\FlowerController.cs" :187 :8) {
^entry (%_id : i32):
%0 = cbde.alloca i32 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\FlowerController.cs" :187 :37)
cbde.store %_id, %0 : memref<i32> loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\FlowerController.cs" :187 :37)
br ^0

^0: // BinaryBranchBlock
%1 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\FlowerController.cs" :189 :25) // Not a variable of known type: _flowerRepository
%2 = cbde.load %0 : memref<i32> loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\FlowerController.cs" :189 :57)
%3 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\FlowerController.cs" :189 :25) // _flowerRepository.GetFlowerById(id) (InvocationExpression)
%5 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\FlowerController.cs" :191 :16) // Not a variable of known type: flower
%6 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\FlowerController.cs" :191 :26) // null (NullLiteralExpression)
%7 = cbde.unknown : i1  loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\FlowerController.cs" :191 :16) // comparison of unknown type: flower == null
cond_br %7, ^1, ^2 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\FlowerController.cs" :191 :16)

^1: // JumpBlock
// Entity from another assembly: NotFound
%8 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\FlowerController.cs" :192 :23) // NotFound() (InvocationExpression)
return %8 : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\FlowerController.cs" :192 :16)

^2: // JumpBlock
// Entity from another assembly: View
%9 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\FlowerController.cs" :194 :24) // new FlowerDetailViewModel              {                  Flower = flower              } (ObjectCreationExpression)
%10 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\FlowerController.cs" :196 :25) // Not a variable of known type: flower
%11 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\FlowerController.cs" :194 :19) // View(new FlowerDetailViewModel              {                  Flower = flower              }) (InvocationExpression)
return %11 : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Controllers\\FlowerController.cs" :194 :12)

^3: // ExitBlock
cbde.unreachable

}
