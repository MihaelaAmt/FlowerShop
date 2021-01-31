using FlowerApp.Models;
using FlowerApp.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FlowerApp.Repository
{
    //class for Flower Repository
    //using Flower Repository Interface
    public class FlowerRepository : IFlowerRepository
    {
        private readonly AppDbContext _appDbContext;

        //constructor
        public FlowerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        //enumeration for flower
        public IEnumerable<Flower> Flowers
        {
            get
            {
                return _appDbContext.Flowers.Include(c => c.Category);
            }
        }

        //iteration for Flowers Name
        public IEnumerable<string> FlowersNames
        {
            //create a list with flower name
            get
            {
                return _appDbContext.Flowers.Select(x => x.Name);
            }
        }

        //iteration for Flower Presentation
        public IEnumerable<Flower> FlowerPresentation
        {
            get
            {
                return _appDbContext.Flowers.Include(c => c.Category).Where(p => p.IsFlowerPresentation);
            }
        }

        //get flower by id
        public Flower GetFlowerById(int flowerId)
        {
            return _appDbContext.Flowers.FirstOrDefault(f => f.FlowerId == flowerId);
        }

        //iteration 
        public IEnumerable<FlowerViewModel> FlowersAsViewModel
        {
            get
            {
                List<FlowerViewModel> flowers = new List<FlowerViewModel>();

                foreach (var dbFlower in Flowers)
                {
                    flowers.Add(MapDbFlowerToFlowerViewModel(dbFlower));
                }

                return flowers;
            }
        }

        //add flower
        public bool AddFlower(Flower flower)
        {
            var result = _appDbContext.Add(flower);

            _appDbContext.SaveChanges();
            //result for added
            return result.State == EntityState.Added || result.State == EntityState.Unchanged ? true : false;
        }

        //delete flower
        public bool DeleteFlower(Flower flower)
        {
            var result = _appDbContext.Remove(flower);

            _appDbContext.SaveChanges();
            //result for deleted
            return result.State == EntityState.Deleted || result.State == EntityState.Unchanged ? true : false;
        }

        //main page for flowers
        private FlowerViewModel MapDbFlowerToFlowerViewModel(Flower dbFlower)
        {
            return new FlowerViewModel
            {
                //flower id
                FlowerId = dbFlower.FlowerId,
                //flower name
                Name = dbFlower.Name,
                //the price of the flower
                Price = dbFlower.Price,
                //short description
                ShortDescription = dbFlower.ShortDescription,
                //image thumbnail
                ImageThumbnailUrl = dbFlower.ImageThumbnailUrl
            };
        }

        //update flower
        public bool UpdateFlower(Flower flower)
        {
            //update
            _appDbContext.Update(flower);
            //save changes
            _appDbContext.SaveChanges();

            return true;
        }
    }
}


