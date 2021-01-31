using FlowerApp.Models;
using FlowerApp.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FlowerApp.Controllers
{
    //for favorite flower
    //create a controller
    //base class is controller
    public class FavoriteFlowerController : Controller
    {
        //using IFlowerRepository
        private readonly IFlowerRepository _flowerRepository;

        public FavoriteFlowerController(IFlowerRepository flowerRepository, ShoppingCart shoppingCart)
        {
            _flowerRepository = flowerRepository;
        }


    }
}
