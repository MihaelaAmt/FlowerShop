func @_FlowerApp.Migrations.AddFavorite.Up$Microsoft.EntityFrameworkCore.Migrations.MigrationBuilder$(none) -> () loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191209173625_AddFavorite.cs" :8 :8) {
^entry (%_migrationBuilder : none):
%0 = cbde.alloca none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191209173625_AddFavorite.cs" :8 :35)
cbde.store %_migrationBuilder, %0 : memref<none> loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191209173625_AddFavorite.cs" :8 :35)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191209173625_AddFavorite.cs" :11 :12) // Not a variable of known type: migrationBuilder
%2 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191209173625_AddFavorite.cs" :13 :22) // "IsFavorite" (StringLiteralExpression)
%3 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191209173625_AddFavorite.cs" :15 :23) // "Flowers" (StringLiteralExpression)
%4 = constant 0 : i1 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191209173625_AddFavorite.cs" :16 :26) // false
%5 = constant 0 : i1 loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191209173625_AddFavorite.cs" :17 :30) // false
%6 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191209173625_AddFavorite.cs" :11 :12) // migrationBuilder.AddColumn<bool>(                  //name                   name: "IsFavorite",                  //table                   table: "Flowers",                  nullable: false,                  defaultValue: false) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_FlowerApp.Migrations.AddFavorite.Down$Microsoft.EntityFrameworkCore.Migrations.MigrationBuilder$(none) -> () loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191209173625_AddFavorite.cs" :20 :8) {
^entry (%_migrationBuilder : none):
%0 = cbde.alloca none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191209173625_AddFavorite.cs" :20 :37)
cbde.store %_migrationBuilder, %0 : memref<none> loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191209173625_AddFavorite.cs" :20 :37)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191209173625_AddFavorite.cs" :22 :12) // Not a variable of known type: migrationBuilder
%2 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191209173625_AddFavorite.cs" :24 :22) // "IsFavorite" (StringLiteralExpression)
%3 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191209173625_AddFavorite.cs" :26 :23) // "Flowers" (StringLiteralExpression)
%4 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Migrations\\20191209173625_AddFavorite.cs" :22 :12) // migrationBuilder.DropColumn(                  //name                  name: "IsFavorite",                  //table                  table: "Flowers") (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
