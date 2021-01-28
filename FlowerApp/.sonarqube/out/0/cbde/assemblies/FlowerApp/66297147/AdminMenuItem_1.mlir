func @_FlowerApp.Components.AdminMenu.Invoke$$() -> none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :10 :8) {
^entry :
br ^0

^0: // JumpBlock
%0 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :12 :28) // new List<AdminMenuItem> { new AdminMenuItem()                  {                      DisplayValue = "User management",                      ActionValue = "UserManagement"                    },                     new AdminMenuItem()                  {                      DisplayValue = "Role management",                      ActionValue = "RoleManagement"                  },                      new AdminMenuItem()                  {                      DisplayValue = "Flower management",                      ActionValue = "FlowerManagement"                  },              } (ObjectCreationExpression)
%1 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :12 :54) // new AdminMenuItem()                  {                      DisplayValue = "User management",                      ActionValue = "UserManagement"                    } (ObjectCreationExpression)
%2 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :14 :35) // "User management" (StringLiteralExpression)
%3 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :15 :34) // "UserManagement" (StringLiteralExpression)
%4 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :19 :17) // new AdminMenuItem()                  {                      DisplayValue = "Role management",                      ActionValue = "RoleManagement"                  } (ObjectCreationExpression)
%5 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :21 :35) // "Role management" (StringLiteralExpression)
%6 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :22 :34) // "RoleManagement" (StringLiteralExpression)
%7 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :25 :18) // new AdminMenuItem()                  {                      DisplayValue = "Flower management",                      ActionValue = "FlowerManagement"                  } (ObjectCreationExpression)
%8 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :27 :35) // "Flower management" (StringLiteralExpression)
%9 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :28 :34) // "FlowerManagement" (StringLiteralExpression)
// Entity from another assembly: View
%11 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :32 :24) // Not a variable of known type: menuItems
%12 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :32 :19) // View(menuItems) (InvocationExpression)
return %12 : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :32 :12)

^1: // ExitBlock
cbde.unreachable

}
