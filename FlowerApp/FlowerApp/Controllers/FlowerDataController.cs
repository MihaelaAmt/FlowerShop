using FlowerApp.Models;
using FlowerApp.Repository;
using FlowerApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FlowerApp.Controllers
{
    [Route("api/[controller]")]
    public class FlowerDataController : Controller
    {
        private readonly IFlowerRepository _flowerRepository;

        public FlowerDataController(IFlowerRepository flowerRepository)
        {
            _flowerRepository = flowerRepository;
        }


        [HttpGet]
        public IEnumerable<FlowerViewModel> LoadMoreFlowers()
        {
            IEnumerable<Flower> dbFlowers = null;

            dbFlowers = _flowerRepository.Flowers.OrderBy(p => p.FlowerId).Take(10);

            List<FlowerViewModel> flowers = new List<FlowerViewModel>();

            foreach (var dbFlower in dbFlowers)
            {
                flowers.Add(MapDbFlowerToFlowerViewModel(dbFlower));
            }
            return flowers;
        }

        private FlowerViewModel MapDbFlowerToFlowerViewModel(Flower dbFlower)
        {
            return new FlowerViewModel
            {
                FlowerId = dbFlower.FlowerId,
                Name = dbFlower.Name,
                Price = dbFlower.Price,
                ShortDescription = dbFlower.ShortDescription,
                ImageThumbnailUrl = dbFlower.ImageThumbnailUrl
            };
        }
    }
}

