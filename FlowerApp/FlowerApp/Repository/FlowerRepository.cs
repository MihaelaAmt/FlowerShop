using FlowerApp.Models;
using FlowerApp.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FlowerApp.Repository
{
    public class FlowerRepository : IFlowerRepository
    {
        private readonly AppDbContext _appDbContext;

        public FlowerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Flower> Flowers
        {
            get
            {
                return _appDbContext.Flowers.Include(c => c.Category);
            }
        }

        public IEnumerable<string> FlowersNames
        {
            get
            {
                return _appDbContext.Flowers.Select(x => x.Name).ToList();
            }
        }

        public IEnumerable<Flower> FlowerPresentation
        {
            get
            {
                return _appDbContext.Flowers.Include(c => c.Category).Where(p => p.IsFlowerPresentation);
            }
        }

        public Flower GetFlowerById(int flowerId)
        {
            return _appDbContext.Flowers.FirstOrDefault(f => f.FlowerId == flowerId);
        }

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

        public bool AddFlower(Flower flower)
        {
            var result = _appDbContext.Add(flower);

            _appDbContext.SaveChanges();

            return result.State == EntityState.Added || result.State == EntityState.Unchanged ? true : false;
        }

        public bool DeleteFlower(Flower flower)
        {
            var result = _appDbContext.Remove(flower);

            _appDbContext.SaveChanges();

            return result.State == EntityState.Deleted || result.State == EntityState.Unchanged ? true : false;
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

        public bool UpdateFlower(Flower flower)
        {
            _appDbContext.Update(flower);

            _appDbContext.SaveChanges();

            return true;
        }
    }
}


