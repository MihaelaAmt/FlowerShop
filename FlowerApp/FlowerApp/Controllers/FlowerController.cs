using FlowerApp.Models;
using FlowerApp.Repository;
using FlowerApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FlowerApp.Controllers
{
    public class FlowerController : Controller
    {
        private readonly IFlowerRepository _flowerRepository;
        private readonly ICategoryRepository _categoryRepository;

        public FlowerController(IFlowerRepository flowerRepository, ICategoryRepository categoryRepository)
        {
            _flowerRepository = flowerRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(string category)
        {
            IEnumerable<Flower> flowers;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                flowers = _flowerRepository.Flowers.OrderBy(p => p.FlowerId);
                currentCategory = "All flowers";
            }
            else
            {
                flowers = _flowerRepository.Flowers.Where(p => p.Category.CategoryName == category)
                   .OrderBy(p => p.FlowerId);
                currentCategory = _categoryRepository.Categories.FirstOrDefault(c => c.CategoryName == category).CategoryName;
            }

            return View(new FlowerListViewModel
            {
                Flowers = flowers,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult Details(int id)
        {
            var flower = _flowerRepository.GetFlowerById(id);

            return View(new FlowerDetailViewModel() {
                Flower = flower
            });
        }

    }
}