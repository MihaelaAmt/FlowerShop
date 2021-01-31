using FlowerApp.Models;
using FlowerApp.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FlowerApp.Controllers
{
    //create order controller
    //base class is controller
    public class OrderController : Controller
    {
        //using Order Repository interface
        private readonly IOrderRepository _orderRepository;
        //using Shopping Cart
        private readonly ShoppingCart _shoppingCart;

        //constructor
        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
        }

        [Authorize]
        public IActionResult Checkout()
        {
            return View();
        }

        //send data to server
        [HttpPost]
        [Authorize]
        //checkout
        public IActionResult Checkout(Order order)
        {
            var items = _shoppingCart.GetShoppingCartItems;
            _shoppingCart.ShoppingCartItems = items;

            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                //show error message
                ModelState.AddModelError("", "Your cart is empty, add some flowers first");
            }

            if (ModelState.IsValid)
            {
                order.Email = User.Identity.Name;
                _orderRepository.CreateOrder(order);
                _shoppingCart.ClearCart();
                //redirect to checkout complete
                return RedirectToAction("CheckoutComplete");
            }
            return View(order);
        }

        //checkout complete
        public IActionResult CheckoutComplete()
        {
            //when an order is complete
            //show message
            ViewBag.CheckoutCompleteMessage = "Thanks for your order. You'll soon enjoy our beautiful flowers";

            return View();
        }
    }
}
