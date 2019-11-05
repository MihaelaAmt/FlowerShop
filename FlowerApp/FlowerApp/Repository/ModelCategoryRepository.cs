using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlowerApp.Models;

namespace FlowerApp.Repository
{
    public class ModelCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category{CategoryId=1, CategoryName="Single flower", Description="All single flowers"},
                    new Category{CategoryId=2, CategoryName="Bouquet of flowers", Description="More flowers"},
                    new Category{CategoryId=3, CategoryName="Seasonal flowers", Description="Get in the mood for a seasonal flowers"}
                };
            }
        }
    }
}
