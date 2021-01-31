using FlowerApp.Auth;
using FlowerApp.Repository;
using FlowerApp.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FlowerApp.Controllers
{
    //create order history controller
    //base class is controller
    public class OrderHistoryController : Controller
    {
        //using Order Repository interface
        private readonly IOrderRepository _orderRepository;
        //using SignInManager from ApplicationUser
        private readonly SignInManager<ApplicationUser> _signInManager;

        //controler
        public OrderHistoryController(IOrderRepository orderRepository, SignInManager<ApplicationUser> signInManager)
        {
            _orderRepository = orderRepository;
            _signInManager = signInManager;
        }

        //class for view result
        public ViewResult Index()
        {
            //enumeration for orders history
            IEnumerable<OrderHistoryDetailsViewModel> orders = null;
            //logged in as a user
            // and logged in as a administrator
            if (_signInManager.IsSignedIn(User) && User.IsInRole("Administrators"))
            {
                orders = _orderRepository.GetOrdersAsViewModel();
            }
            else
            {
                orders = _orderRepository.GetOrdersAsViewModel(User.Identity.Name);
            }

            return View(new OrderHistoryViewModel
            {
                Orders = orders
            });
        }
    }

}
