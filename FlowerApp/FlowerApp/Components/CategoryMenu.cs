using FlowerApp.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FlowerApp.Components
{
    //create category menu
    public class CategoryMenu : ViewComponent
    {
        //using Category Interface
        private readonly ICategoryRepository _categoryRepository;

        //class for Category Menu
        public CategoryMenu(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        //categories order by name
        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.Categories.OrderBy(c => c.CategoryName);

            //view categories
            return View(categories);
        }
    }
}

