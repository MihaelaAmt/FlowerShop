func @_FlowerApp.Components.AdminMenu.Invoke$$() -> none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :7 :8) {
^entry :
br ^0

^0: // JumpBlock
%0 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :9 :28) // new List<AdminMenuItem> { new AdminMenuItem()                  {                      DisplayValue = "User management",                      ActionValue = "UserManagement"                    },                     new AdminMenuItem()                  {                      DisplayValue = "Role management",                      ActionValue = "RoleManagement"                  },                      new AdminMenuItem()                  {                      DisplayValue = "Flower management",                      ActionValue = "FlowerManagement"                  },              } (ObjectCreationExpression)
%1 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :9 :54) // new AdminMenuItem()                  {                      DisplayValue = "User management",                      ActionValue = "UserManagement"                    } (ObjectCreationExpression)
%2 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :11 :35) // "User management" (StringLiteralExpression)
%3 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :12 :34) // "UserManagement" (StringLiteralExpression)
%4 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :16 :17) // new AdminMenuItem()                  {                      DisplayValue = "Role management",                      ActionValue = "RoleManagement"                  } (ObjectCreationExpression)
%5 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :18 :35) // "Role management" (StringLiteralExpression)
%6 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :19 :34) // "RoleManagement" (StringLiteralExpression)
%7 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :22 :18) // new AdminMenuItem()                  {                      DisplayValue = "Flower management",                      ActionValue = "FlowerManagement"                  } (ObjectCreationExpression)
%8 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :24 :35) // "Flower management" (StringLiteralExpression)
%9 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :25 :34) // "FlowerManagement" (StringLiteralExpression)
// Entity from another assembly: View
%11 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :29 :24) // Not a variable of known type: menuItems
%12 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :29 :19) // View(menuItems) (InvocationExpression)
return %12 : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :29 :12)

^1: // ExitBlock
cbde.unreachable

}
