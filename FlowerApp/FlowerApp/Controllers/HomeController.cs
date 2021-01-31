using FlowerApp.Repository;
using FlowerApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FlowerApp.Controllers
{
    //create home controller
    //base class is controller
    public class HomeController : Controller
    {
        //using IflowerRepository
        private readonly IFlowerRepository _flowerRepository;

        //constructor 
        public HomeController(IFlowerRepository flowerRepository)
        {
            _flowerRepository = flowerRepository;
        }

        //will be presented
        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                //flowers from flower presentation
                FlowerPresentation = _flowerRepository.FlowerPresentation,
                //and flowers name
                FlowersName = _flowerRepository.FlowersNames
            };

            return View(homeViewModel);
        }
    }
}
