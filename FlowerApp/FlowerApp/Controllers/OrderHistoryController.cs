using FlowerApp.Auth;
using FlowerApp.Repository;
using FlowerApp.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FlowerApp.Controllers
{
    public class OrderHistoryController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public OrderHistoryController(IOrderRepository orderRepository, SignInManager<ApplicationUser> signInManager)
        {
            _orderRepository = orderRepository;
            _signInManager = signInManager;
        }

        public ViewResult Index()
        {
            IEnumerable<OrderHistoryDetailsViewModel> orders = null;
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
