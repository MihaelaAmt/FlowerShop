// Skipping function GetOrdersAsViewModel(none), it contains poisonous unsupported syntaxes

// Skipping function CreateOrder(none), it contains poisonous unsupported syntaxes

func @_FlowerApp.Repository.OrderRepository.MapDbOrderToOrderViewModel$FlowerApp.Models.Order$(none) -> none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\OrderRepository.cs" :64 :8) {
^entry (%_dbOrder : none):
%0 = cbde.alloca none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\OrderRepository.cs" :64 :72)
cbde.store %_dbOrder, %0 : memref<none> loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\OrderRepository.cs" :64 :72)
br ^0

^0: // JumpBlock
%1 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\OrderRepository.cs" :66 :19) // new OrderHistoryDetailsViewModel()              {                  OrderId = dbOrder.OrderId,                  Address = dbOrder.AddressLine1 + " " + dbOrder.AddressLine2,                  City = dbOrder.City,                  FirstName = dbOrder.FirstName,                  LastName = dbOrder.LastName,                  PayMethod = dbOrder.PayMethod,                  PhoneNumber = dbOrder.PhoneNumber,                  ShippingMethod = dbOrder.ShippingMethod              } (ObjectCreationExpression)
%2 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\OrderRepository.cs" :68 :26) // Not a variable of known type: dbOrder
%3 = cbde.unknown : i32 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\OrderRepository.cs" :68 :26) // dbOrder.OrderId (SimpleMemberAccessExpression)
%4 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\OrderRepository.cs" :69 :26) // Not a variable of known type: dbOrder
%5 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\OrderRepository.cs" :69 :26) // dbOrder.AddressLine1 (SimpleMemberAccessExpression)
%6 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\OrderRepository.cs" :69 :49) // " " (StringLiteralExpression)
%7 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\OrderRepository.cs" :69 :26) // Binary expression on unsupported types dbOrder.AddressLine1 + " "
%8 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\OrderRepository.cs" :69 :55) // Not a variable of known type: dbOrder
%9 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\OrderRepository.cs" :69 :55) // dbOrder.AddressLine2 (SimpleMemberAccessExpression)
%10 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\OrderRepository.cs" :69 :26) // Binary expression on unsupported types dbOrder.AddressLine1 + " " + dbOrder.AddressLine2
%11 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\OrderRepository.cs" :70 :23) // Not a variable of known type: dbOrder
%12 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\OrderRepository.cs" :70 :23) // dbOrder.City (SimpleMemberAccessExpression)
%13 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\OrderRepository.cs" :71 :28) // Not a variable of known type: dbOrder
%14 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\OrderRepository.cs" :71 :28) // dbOrder.FirstName (SimpleMemberAccessExpression)
%15 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\OrderRepository.cs" :72 :27) // Not a variable of known type: dbOrder
%16 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\OrderRepository.cs" :72 :27) // dbOrder.LastName (SimpleMemberAccessExpression)
%17 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\OrderRepository.cs" :73 :28) // Not a variable of known type: dbOrder
%18 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\OrderRepository.cs" :73 :28) // dbOrder.PayMethod (SimpleMemberAccessExpression)
%19 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\OrderRepository.cs" :74 :30) // Not a variable of known type: dbOrder
%20 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\OrderRepository.cs" :74 :30) // dbOrder.PhoneNumber (SimpleMemberAccessExpression)
%21 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\OrderRepository.cs" :75 :33) // Not a variable of known type: dbOrder
%22 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\OrderRepository.cs" :75 :33) // dbOrder.ShippingMethod (SimpleMemberAccessExpression)
return %1 : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Repository\\OrderRepository.cs" :66 :12)

^1: // ExitBlock
cbde.unreachable

}
