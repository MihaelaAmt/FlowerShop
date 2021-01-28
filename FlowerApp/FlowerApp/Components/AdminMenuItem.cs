using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FlowerApp.Components
{
    public class AdminMenu : ViewComponent
    {
        //create admin menu
        public IViewComponentResult Invoke()
        {
            //list of items for admin
            var menuItems = new List<AdminMenuItem> { new AdminMenuItem()
                {
                    //Display and action value for user
                    DisplayValue = "User management",
                    ActionValue = "UserManagement"

                },

                //Display and action value for role
                 new AdminMenuItem()
                {
                    DisplayValue = "Role management",
                    ActionValue = "RoleManagement"
                },

                 //Display and action value for flower
                  new AdminMenuItem()
                {
                    DisplayValue = "Flower management",
                    ActionValue = "FlowerManagement"
                },
            };

            //return view for this item
            return View(menuItems);
        }
    }

    //class for Admin Menu
    public class AdminMenuItem
    {
        //Display Value 
        public string DisplayValue { get; set; }

        //Action value
        public string ActionValue { get; set; }
    }
}

