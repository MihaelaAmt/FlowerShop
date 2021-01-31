func @_FlowerApp.Migrations.ShippingAndPaymentMethods.Up$Microsoft.EntityFrameworkCore.Migrations.MigrationBuilder$(none) -> () loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :9 :8) {
^entry (%_migrationBuilder : none):
%0 = cbde.alloca none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :9 :35)
cbde.store %_migrationBuilder, %0 : memref<none> loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :9 :35)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :12 :12) // Not a variable of known type: migrationBuilder
%2 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :14 :22) // "CardNumber" (StringLiteralExpression)
%3 = constant unit loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :16 :23) // Orders (IdentifierName)
%4 = constant 50 : i32 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :18 :27)
%5 = constant 1 : i1 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :19 :26) // true
%6 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :12 :12) // migrationBuilder.AddColumn<string>(                  //first column is for card                  name: "CardNumber",                  //table name is  Orders                  table: Orders,                  //set length                  maxLength: 50,                  nullable: true) (InvocationExpression)
%7 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :21 :12) // Not a variable of known type: migrationBuilder
%8 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :23 :22) // "PayMethod" (StringLiteralExpression)
%9 = constant unit loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :24 :23) // Orders (IdentifierName)
%10 = constant 50 : i32 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :25 :27)
%11 = constant 0 : i1 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :26 :26) // false
%12 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :27 :30) // "" (StringLiteralExpression)
%13 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :21 :12) // migrationBuilder.AddColumn<string>(                  //column name is pay method                  name: "PayMethod",                  table: Orders,                  maxLength: 50,                  nullable: false,                  defaultValue: "") (InvocationExpression)
%14 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :29 :12) // Not a variable of known type: migrationBuilder
%15 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :31 :22) // "ShippingMethod" (StringLiteralExpression)
%16 = constant unit loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :32 :23) // Orders (IdentifierName)
%17 = constant 50 : i32 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :33 :27)
%18 = constant 0 : i1 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :34 :26) // false
%19 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :35 :30) // "" (StringLiteralExpression)
%20 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :29 :12) // migrationBuilder.AddColumn<string>(                  //column name is pay method                  name: "ShippingMethod",                  table: Orders,                  maxLength: 50,                  nullable: false,                  defaultValue: "") (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_FlowerApp.Migrations.ShippingAndPaymentMethods.Down$Microsoft.EntityFrameworkCore.Migrations.MigrationBuilder$(none) -> () loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :38 :8) {
^entry (%_migrationBuilder : none):
%0 = cbde.alloca none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :38 :37)
cbde.store %_migrationBuilder, %0 : memref<none> loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :38 :37)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :40 :12) // Not a variable of known type: migrationBuilder
%2 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :42 :22) // "CardNumber" (StringLiteralExpression)
%3 = constant unit loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :43 :23) // Orders (IdentifierName)
%4 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :40 :12) // migrationBuilder.DropColumn(                  //in drop menu, column name is card number                  name: "CardNumber",                  table: Orders) (InvocationExpression)
%5 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :45 :12) // Not a variable of known type: migrationBuilder
%6 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :47 :22) // "PayMethod" (StringLiteralExpression)
%7 = constant unit loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :48 :23) // Orders (IdentifierName)
%8 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :45 :12) // migrationBuilder.DropColumn(                  //in drop menu, column name is pay method                  name: "PayMethod",                  table: Orders) (InvocationExpression)
%9 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :50 :12) // Not a variable of known type: migrationBuilder
%10 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :52 :22) // "ShippingMethod" (StringLiteralExpression)
%11 = constant unit loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :53 :23) // Orders (IdentifierName)
%12 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :50 :12) // migrationBuilder.DropColumn(                  //in drop menu, column name is pay method                  name: "ShippingMethod",                  table: Orders) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
