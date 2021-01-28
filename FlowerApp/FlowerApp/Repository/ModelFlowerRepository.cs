using FlowerApp.Models;
using FlowerApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FlowerApp.Repository
{
    public class ModelFlowerRepository : IFlowerRepository
    {
        private readonly ICategoryRepository _categoryRepository = new ModelCategoryRepository();


        public IEnumerable<Flower> Flowers
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

        public IEnumerable<FlowerViewModel> FlowersAsViewModel => throw new NotImplementedException();

        public IEnumerable<string> FlowersNames => throw new NotImplementedException();

        public bool AddFlower(Flower flower)
        {
            throw new NotImplementedException();
        }

        public bool DeleteFlower(Flower flower)
        {
            throw new NotImplementedException();
        }

        public Flower GetFlowerById(int flowerId)
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateFlower(Flower flower)
        {
            throw new NotImplementedException();
        }
    }
}
