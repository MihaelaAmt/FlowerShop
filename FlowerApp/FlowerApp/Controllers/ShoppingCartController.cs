using FlowerApp.Models;
using FlowerApp.Repository;
using FlowerApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FlowerApp.Controllers
{
    //create controller for Shopping Cart
    //base class is controller
    public class ShoppingCartController : Controller
    {
        //using Flower Repository interface
        private readonly IFlowerRepository _flowerRepository;
        //using Shopping Cart from models
        private readonly ShoppingCart _shoppingCart;

        //constructor
        public ShoppingCartController(IFlowerRepository flowerRepository, ShoppingCart shoppingCart)
        {
            _flowerRepository = flowerRepository;
            _shoppingCart = shoppingCart;
        }


        //create a view result
        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems;
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                //shopping cart
                //and shopping cart total
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal
            };

            return View(shoppingCartViewModel);
        }


        //add flower in shooping cart
        public RedirectToActionResult AddToShoppingCart(int flowerId)
        {
            var selectedFlower = _flowerRepository.Flowers.FirstOrDefault(p => p.FlowerId == flowerId);

            //the flower selected is not null
            if (selectedFlower != null)
            {
                _shoppingCart.AddToCart(selectedFlower, 1);
            }
            //redirect to index
            return RedirectToAction("Index");
        }


        //update shopping cart
        public RedirectToActionResult UpdateShoppingCart(int flowerId, bool isAdding)
        {
            var selectedFlower = _flowerRepository.Flowers.FirstOrDefault(p => p.FlowerId == flowerId);

            //the flower selected is not null
            if (selectedFlower != null)
            {
                if (isAdding)
                {
                    _shoppingCart.AddToCart(selectedFlower, 1);
                }
                else
                {
                    _shoppingCart.AddToCart(selectedFlower, -1);
                }
            }
            //redirect to index
            return RedirectToAction("Index");
        }

        //remove from Shopping Cart
        public RedirectToActionResult RemoveFromShoppingCart(int flowerId)
        {
            var selectedFlower = _flowerRepository.Flowers.FirstOrDefault(p => p.FlowerId == flowerId);

            if (selectedFlower != null)
            {
                _shoppingCart.RemoveFromCart(selectedFlower);
            }
            //redirect to index
            return RedirectToAction("Index");
        }
    }
}
