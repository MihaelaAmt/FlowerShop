func @_FlowerApp.Migrations.ShippingAndPaymentMethods1.Up$Microsoft.EntityFrameworkCore.Migrations.MigrationBuilder$(none) -> () loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :9 :8) {
^entry (%_migrationBuilder : none):
%0 = cbde.alloca none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :9 :35)
cbde.store %_migrationBuilder, %0 : memref<none> loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :9 :35)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :12 :12) // Not a variable of known type: migrationBuilder
%2 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :14 :22) // "ZipCode" (StringLiteralExpression)
%3 = constant unit loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :16 :23) // Orders (IdentifierName)
%4 = constant 10 : i32 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :17 :27)
%5 = constant 1 : i1 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :18 :26) // true
%6 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :19 :28) // typeof(string) (TypeOfExpression)
%7 = constant 10 : i32 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :20 :30)
%8 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :12 :12) // migrationBuilder.AlterColumn<string>(                  //column name                  name: "ZipCode",                  //table name                  table: Orders,                  maxLength: 10,                  nullable: true,                  oldClrType: typeof(string),                  oldMaxLength: 10) (InvocationExpression)
%9 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :22 :12) // Not a variable of known type: migrationBuilder
%10 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :24 :22) // "Country" (StringLiteralExpression)
%11 = constant unit loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :26 :23) // Orders (IdentifierName)
%12 = constant 50 : i32 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :27 :27)
%13 = constant 1 : i1 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :28 :26) // true
%14 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :29 :28) // typeof(string) (TypeOfExpression)
%15 = constant 50 : i32 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :30 :30)
%16 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :22 :12) // migrationBuilder.AlterColumn<string>(                  //column name                  name: "Country",                  //table name                  table: Orders,                  maxLength: 50,                  nullable: true,                  oldClrType: typeof(string),                  oldMaxLength: 50) (InvocationExpression)
%17 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :32 :12) // Not a variable of known type: migrationBuilder
%18 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :34 :22) // "AddressLine1" (StringLiteralExpression)
%19 = constant unit loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :36 :23) // Orders (IdentifierName)
%20 = constant 100 : i32 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :37 :27)
%21 = constant 1 : i1 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :38 :26) // true
%22 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :39 :28) // typeof(string) (TypeOfExpression)
%23 = constant 100 : i32 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :40 :30)
%24 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :32 :12) // migrationBuilder.AlterColumn<string>(                  //column name                  name: "AddressLine1",                  //table name                  table: Orders,                  maxLength: 100,                  nullable: true,                  oldClrType: typeof(string),                  oldMaxLength: 100) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_FlowerApp.Migrations.ShippingAndPaymentMethods1.Down$Microsoft.EntityFrameworkCore.Migrations.MigrationBuilder$(none) -> () loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :43 :8) {
^entry (%_migrationBuilder : none):
%0 = cbde.alloca none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :43 :37)
cbde.store %_migrationBuilder, %0 : memref<none> loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :43 :37)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :46 :12) // Not a variable of known type: migrationBuilder
%2 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :48 :22) // "ZipCode" (StringLiteralExpression)
%3 = constant unit loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :50 :23) // Orders (IdentifierName)
%4 = constant 10 : i32 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :51 :27)
%5 = constant 0 : i1 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :52 :26) // false
%6 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :53 :28) // typeof(string) (TypeOfExpression)
%7 = constant 10 : i32 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :54 :30)
%8 = constant 1 : i1 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :55 :29) // true
%9 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :46 :12) // migrationBuilder.AlterColumn<string>(                  //column name                  name: "ZipCode",                  //table name                  table: Orders,                  maxLength: 10,                  nullable: false,                  oldClrType: typeof(string),                  oldMaxLength: 10,                  oldNullable: true) (InvocationExpression)
%10 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :57 :12) // Not a variable of known type: migrationBuilder
%11 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :59 :22) // "Country" (StringLiteralExpression)
%12 = constant unit loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :61 :23) // Orders (IdentifierName)
%13 = constant 50 : i32 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :62 :27)
%14 = constant 0 : i1 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :63 :26) // false
%15 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :64 :28) // typeof(string) (TypeOfExpression)
%16 = constant 50 : i32 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :65 :30)
%17 = constant 1 : i1 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :66 :29) // true
%18 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :57 :12) // migrationBuilder.AlterColumn<string>(                  //column name                  name: "Country",                  //table name                  table: Orders,                  maxLength: 50,                  nullable: false,                  oldClrType: typeof(string),                  oldMaxLength: 50,                  oldNullable: true) (InvocationExpression)
%19 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :68 :12) // Not a variable of known type: migrationBuilder
%20 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :70 :22) // "AddressLine1" (StringLiteralExpression)
%21 = constant unit loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :72 :23) // Orders (IdentifierName)
%22 = constant 100 : i32 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :73 :27)
%23 = constant 0 : i1 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :74 :26) // false
%24 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :75 :28) // typeof(string) (TypeOfExpression)
%25 = constant 100 : i32 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :76 :30)
%26 = constant 1 : i1 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :77 :29) // true
%27 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191211182629_ShippingAndPaymentMethods1.cs" :68 :12) // migrationBuilder.AlterColumn<string>(                  //column name                  name: "AddressLine1",                  //table name                  table: Orders,                  maxLength: 100,                  nullable: false,                  oldClrType: typeof(string),                  oldMaxLength: 100,                  oldNullable: true) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
