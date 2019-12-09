using FlowerApp.Models;
using FlowerApp.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FlowerApp.Controllers
{
    public class FavoriteFlowerController : Controller
    {
        private readonly IFlowerRepository _flowerRepository;

        public FavoriteFlowerController(IFlowerRepository flowerRepository, ShoppingCart shoppingCart)
        {
            _flowerRepository = flowerRepository;
        }


    }
}
