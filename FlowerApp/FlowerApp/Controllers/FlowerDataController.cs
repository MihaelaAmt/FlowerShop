using FlowerApp.Models;
using FlowerApp.Repository;
using FlowerApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FlowerApp.Controllers
{
    //create flower data controller
    //base class controler
    [Route("api/[controller]")]
    public class FlowerDataController : Controller
    {
        private readonly IFlowerRepository _flowerRepository;

        //constructor
        public FlowerDataController(IFlowerRepository flowerRepository)
        {
            _flowerRepository = flowerRepository;
        }

        //requeste data from a specified resource
        [HttpGet]
        public IEnumerable<FlowerViewModel> LoadMoreFlowers()
        {
            //enumeration for flowers
            IEnumerable<Flower> dbFlowers = null;
            //order by id
            //take 10 items
            dbFlowers = _flowerRepository.Flowers.OrderBy(p => p.FlowerId).Take(10);
            //create a list
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
                //return
                // flower id
                FlowerId = dbFlower.FlowerId,
                //flower name
                Name = dbFlower.Name,
                //price
                Price = dbFlower.Price,
                //short description
                ShortDescription = dbFlower.ShortDescription,
                //thumbnail
                ImageThumbnailUrl = dbFlower.ImageThumbnailUrl
            };
        }
    }
}

