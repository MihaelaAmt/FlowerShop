func @_FlowerApp.Migrations.ShippingAndPaymentMethods.Up$Microsoft.EntityFrameworkCore.Migrations.MigrationBuilder$(none) -> () loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :6 :8) {
^entry (%_migrationBuilder : none):
%0 = cbde.alloca none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :6 :35)
cbde.store %_migrationBuilder, %0 : memref<none> loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :6 :35)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :8 :12) // Not a variable of known type: migrationBuilder
%2 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :9 :22) // "CardNumber" (StringLiteralExpression)
%3 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :10 :23) // "Orders" (StringLiteralExpression)
%4 = constant 50 : i32 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :11 :27)
%5 = constant 1 : i1 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :12 :26) // true
%6 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :8 :12) // migrationBuilder.AddColumn<string>(                  name: "CardNumber",                  table: "Orders",                  maxLength: 50,                  nullable: true) (InvocationExpression)
%7 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :14 :12) // Not a variable of known type: migrationBuilder
%8 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :15 :22) // "PayMethod" (StringLiteralExpression)
%9 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :16 :23) // "Orders" (StringLiteralExpression)
%10 = constant 50 : i32 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :17 :27)
%11 = constant 0 : i1 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :18 :26) // false
%12 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :19 :30) // "" (StringLiteralExpression)
%13 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :14 :12) // migrationBuilder.AddColumn<string>(                  name: "PayMethod",                  table: "Orders",                  maxLength: 50,                  nullable: false,                  defaultValue: "") (InvocationExpression)
%14 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :21 :12) // Not a variable of known type: migrationBuilder
%15 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :22 :22) // "ShippingMethod" (StringLiteralExpression)
%16 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :23 :23) // "Orders" (StringLiteralExpression)
%17 = constant 50 : i32 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :24 :27)
%18 = constant 0 : i1 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :25 :26) // false
%19 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :26 :30) // "" (StringLiteralExpression)
%20 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :21 :12) // migrationBuilder.AddColumn<string>(                  name: "ShippingMethod",                  table: "Orders",                  maxLength: 50,                  nullable: false,                  defaultValue: "") (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_FlowerApp.Migrations.ShippingAndPaymentMethods.Down$Microsoft.EntityFrameworkCore.Migrations.MigrationBuilder$(none) -> () loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :29 :8) {
^entry (%_migrationBuilder : none):
%0 = cbde.alloca none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :29 :37)
cbde.store %_migrationBuilder, %0 : memref<none> loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :29 :37)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :31 :12) // Not a variable of known type: migrationBuilder
%2 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :32 :22) // "CardNumber" (StringLiteralExpression)
%3 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :33 :23) // "Orders" (StringLiteralExpression)
%4 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :31 :12) // migrationBuilder.DropColumn(                  name: "CardNumber",                  table: "Orders") (InvocationExpression)
%5 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :35 :12) // Not a variable of known type: migrationBuilder
%6 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :36 :22) // "PayMethod" (StringLiteralExpression)
%7 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :37 :23) // "Orders" (StringLiteralExpression)
%8 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :35 :12) // migrationBuilder.DropColumn(                  name: "PayMethod",                  table: "Orders") (InvocationExpression)
%9 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :39 :12) // Not a variable of known type: migrationBuilder
%10 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :40 :22) // "ShippingMethod" (StringLiteralExpression)
%11 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :41 :23) // "Orders" (StringLiteralExpression)
%12 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182401_ShippingAndPaymentMethods.cs" :39 :12) // migrationBuilder.DropColumn(                  name: "ShippingMethod",                  table: "Orders") (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
