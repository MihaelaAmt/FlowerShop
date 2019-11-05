using FlowerApp.Repository;
using FlowerApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFlowerRepository _flowerRepository;

        public HomeController(IFlowerRepository flowerRepository)
        {
            _flowerRepository = flowerRepository;
        }

        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                FlowerPresentation = _flowerRepository.FlowerPresentation
            };

            return View(homeViewModel);
        }
    }
}
