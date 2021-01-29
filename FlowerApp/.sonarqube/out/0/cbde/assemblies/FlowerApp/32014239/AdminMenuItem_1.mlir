func @_FlowerApp.Components.AdminMenu.Invoke$$() -> none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :8 :8) {
^entry :
br ^0

^0: // JumpBlock
%0 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :11 :28) // new List<AdminMenuItem> { new AdminMenuItem                  {                      //Display and action value for user                      DisplayValue = "User management",                      ActionValue = "UserManagement"                    },                    //Display and action value for role                   new AdminMenuItem                  {                      DisplayValue = "Role management",                      ActionValue = "RoleManagement"                  },                     //Display and action value for flower                    new AdminMenuItem                  {                      DisplayValue = "Flower management",                      ActionValue = "FlowerManagement"                  },              } (ObjectCreationExpression)
%1 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :11 :54) // new AdminMenuItem                  {                      //Display and action value for user                      DisplayValue = "User management",                      ActionValue = "UserManagement"                    } (ObjectCreationExpression)
%2 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :14 :35) // "User management" (StringLiteralExpression)
%3 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :15 :34) // "UserManagement" (StringLiteralExpression)
%4 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :20 :17) // new AdminMenuItem                  {                      DisplayValue = "Role management",                      ActionValue = "RoleManagement"                  } (ObjectCreationExpression)
%5 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :22 :35) // "Role management" (StringLiteralExpression)
%6 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :23 :34) // "RoleManagement" (StringLiteralExpression)
%7 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :27 :18) // new AdminMenuItem                  {                      DisplayValue = "Flower management",                      ActionValue = "FlowerManagement"                  } (ObjectCreationExpression)
%8 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :29 :35) // "Flower management" (StringLiteralExpression)
%9 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :30 :34) // "FlowerManagement" (StringLiteralExpression)
// Entity from another assembly: View
%11 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :35 :24) // Not a variable of known type: menuItems
%12 = cbde.unknown : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :35 :19) // View(menuItems) (InvocationExpression)
return %12 : none loc("E:\\Projects\\FlowerShop\\FlowerApp\\FlowerApp\\Components\\AdminMenuItem.cs" :35 :12)

^1: // ExitBlock
cbde.unreachable

}
