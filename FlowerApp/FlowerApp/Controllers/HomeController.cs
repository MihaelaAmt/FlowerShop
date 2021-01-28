using FlowerApp.Repository;
using FlowerApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

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
                FlowerPresentation = _flowerRepository.FlowerPresentation,
                FlowersName = _flowerRepository.FlowersNames
            };

            return View(homeViewModel);
        }
    }
}
