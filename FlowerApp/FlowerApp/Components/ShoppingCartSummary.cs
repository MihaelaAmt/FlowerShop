using FlowerApp.Models;
using FlowerApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FlowerApp.Components
{
    // class for shopping cart summary
    public class ShoppingCartSummary : ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;

        //constructor for Shopping cart class
        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        //view items from shopping cart
        public IViewComponentResult Invoke()
        {
            var items = _shoppingCart.GetShoppingCartItems;
            //var items = new List<ShoppingCartItem>() { new ShoppingCartItem(), new ShoppingCartItem() };
            _shoppingCart.ShoppingCartItems = items;

            //all itmes from shopping cart 
            //and total
            var shoppingViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal
            };
            // return view
            return View(shoppingViewModel);
        }
    }
}
