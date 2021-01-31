using FlowerApp.Models;
using FlowerApp.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace FlowerApp.Repository
{
    public class ModelFlowerRepository : IFlowerRepository
    {
        private readonly ICategoryRepository _categoryRepository = new ModelCategoryRepository();


        private List<Flower> FlowersList
        {
            get
            {
                return new List<Flower>
                {
                    new Flower {
                        FlowerId = 1,
                        Name="Lilies",
                        Price=15.95M,
                        ShortDescription="White lilies",
                        LongDescription="dfdfd",
                        Category = _categoryRepository.Categories.ToList()[0],
                        ImageUrl ="https://www.florarialarosa.ro/861-large_default/buchet-cu-crini.jpg", InStock=true,
                        ImageThumbnailUrl ="https://www.florarialarosa.ro/861-large_default/buchet-cu-crini.jpg"},

                    new Flower {
                        FlowerId = 2,
                        Name="Peonies",
                        Price=18.95M,
                        ShortDescription="Pink peonies",
                        LongDescription=" hghgjx",
                        Category = _categoryRepository.Categories.ToList()[1],
                        ImageUrl ="https://purpleflowers.ro/wp-content/uploads/2018/06/BUC52-Buchet-diafan-cu-25-bujori-roz.jpg",
                        InStock=true,
                        ImageThumbnailUrl ="https://purpleflowers.ro/wp-content/uploads/2018/06/BUC52-Buchet-diafan-cu-25-bujori-roz.jpg"},

                    new Flower {FlowerId = 3,
                        Name="Roses", Price=15.95M,
                        ShortDescription="Red roses",
                        LongDescription=" khhfgdsg",
                        Category = _categoryRepository.Categories.ToList()[0],
                        ImageUrl ="https://media-cdn.tripadvisor.com/media/photo-s/08/b1/e1/8a/floraria-narcis.jpg", InStock=true,
                        ImageThumbnailUrl ="https://media-cdn.tripadvisor.com/media/photo-s/08/b1/e1/8a/floraria-narcis.jpg"},

                    new Flower {FlowerId = 4,
                        Name="Tulips", Price=12.95M,
                        ShortDescription="Yellow tulips",
                        LongDescription="sfsdga",
                        Category = _categoryRepository.Categories.ToList()[2],
                        ImageUrl ="https://imodflowers.ro/wp-content/uploads/buchet-cu-100-lalele-galbene-1.jpg", InStock=true,
                        ImageThumbnailUrl ="https://imodflowers.ro/wp-content/uploads/buchet-cu-100-lalele-galbene-1.jpg"}
                };
            }
        }

        public IEnumerable<Flower> FlowerPresentation { get; }

        public IEnumerable<FlowerViewModel> FlowersAsViewModel => FlowersList.Select(x => new FlowerViewModel
        {
            Name = x.Name,
            FlowerId = x.FlowerId,
            Price = x.Price,
            ImageThumbnailUrl = x.ImageThumbnailUrl,
            ShortDescription = x.ShortDescription
        });

        public IEnumerable<string> FlowersNames => FlowersList.Select(x => x.Name);

        public IEnumerable<Flower> Flowers => FlowersList;

        public bool AddFlower(Flower flower)
        {
            FlowersList.Add(flower);
            return true;
        }

        public bool DeleteFlower(Flower flower)
        {
            FlowersList.Remove(flower);
            return true;
        }

        public Flower GetFlowerById(int flowerId)
        {
            return FlowersList.FirstOrDefault(x => x.FlowerId == flowerId);
        }

        public bool UpdateFlower(Flower flower)
        {
            var flowerToUpdate = GetFlowerById(flower.FlowerId);
            flowerToUpdate.Name = flower.Name;
            flowerToUpdate.Price = flower.Price;
            flowerToUpdate.IsFlowerPresentation = flower.IsFlowerPresentation;
            flowerToUpdate.InStock = flower.InStock;
            flowerToUpdate.ImageThumbnailUrl = flower.ImageThumbnailUrl;
            flowerToUpdate.LongDescription = flower.LongDescription;
            flowerToUpdate.ShortDescription = flower.ShortDescription;

            return true;
        }
    }
}
