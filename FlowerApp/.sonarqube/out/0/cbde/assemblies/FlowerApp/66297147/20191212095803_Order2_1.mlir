func @_FlowerApp.Migrations.Order2.Up$Microsoft.EntityFrameworkCore.Migrations.MigrationBuilder$(none) -> () loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191212095803_Order2.cs" :6 :8) {
^entry (%_migrationBuilder : none):
%0 = cbde.alloca none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191212095803_Order2.cs" :6 :35)
cbde.store %_migrationBuilder, %0 : memref<none> loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191212095803_Order2.cs" :6 :35)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191212095803_Order2.cs" :8 :12) // Not a variable of known type: migrationBuilder
%2 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191212095803_Order2.cs" :9 :22) // "SecurityCode" (StringLiteralExpression)
%3 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191212095803_Order2.cs" :10 :23) // "Orders" (StringLiteralExpression)
%4 = constant 50 : i32 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191212095803_Order2.cs" :11 :27)
%5 = constant 1 : i1 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191212095803_Order2.cs" :12 :26) // true
%6 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191212095803_Order2.cs" :8 :12) // migrationBuilder.AddColumn<string>(                  name: "SecurityCode",                  table: "Orders",                  maxLength: 50,                  nullable: true) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_FlowerApp.Migrations.Order2.Down$Microsoft.EntityFrameworkCore.Migrations.MigrationBuilder$(none) -> () loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191212095803_Order2.cs" :15 :8) {
^entry (%_migrationBuilder : none):
%0 = cbde.alloca none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191212095803_Order2.cs" :15 :37)
cbde.store %_migrationBuilder, %0 : memref<none> loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191212095803_Order2.cs" :15 :37)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191212095803_Order2.cs" :17 :12) // Not a variable of known type: migrationBuilder
%2 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191212095803_Order2.cs" :18 :22) // "SecurityCode" (StringLiteralExpression)
%3 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191212095803_Order2.cs" :19 :23) // "Orders" (StringLiteralExpression)
%4 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191212095803_Order2.cs" :17 :12) // migrationBuilder.DropColumn(                  name: "SecurityCode",                  table: "Orders") (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
