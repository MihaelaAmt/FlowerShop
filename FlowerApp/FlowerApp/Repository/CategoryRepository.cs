using FlowerApp.Models;
using System.Collections.Generic;

namespace FlowerApp.Repository
{
    //class for category repository
    //using Category Repository interface
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        //constructor
        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        //enumeration for categories
        public IEnumerable<Category> Categories => _appDbContext.Categories;
    }
}
