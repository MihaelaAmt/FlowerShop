using FlowerApp.Models;
using FlowerApp.Repository;
using FlowerApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public ViewResult List(string category, decimal lowPrice = 0, decimal highPrice = 0, string sorting = "")
        {
            IEnumerable<Flower> flowers;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                flowers = _flowerRepository.Flowers.OrderBy(p => p.FlowerId);
                flowers = PriceFilter(lowPrice, highPrice, flowers);

                currentCategory = "All flowers";
            }
            else
            {
                flowers = _flowerRepository.Flowers.Where(p => p.Category.CategoryName == category)
                   .OrderBy(p => p.FlowerId);
                flowers = PriceFilter(lowPrice, highPrice, flowers);
                currentCategory = _categoryRepository.Categories.FirstOrDefault(c => c.CategoryName == category).CategoryName;
            }

            if (!string.IsNullOrEmpty(sorting))
            {
                if (sorting.Equals("ascending", StringComparison.OrdinalIgnoreCase))
                    flowers = flowers.OrderBy(p => p.Price);
                else if (sorting.Equals("descending", StringComparison.OrdinalIgnoreCase))
                    flowers = flowers.OrderByDescending(p => p.Price);
            }

            return View(new FlowerListViewModel
            {
                Flowers = flowers,
                CurrentCategory = currentCategory
            });
        }

        private static IEnumerable<Flower> PriceFilter(decimal lowPrice, decimal highPrice, IEnumerable<Flower> flowers)
        {
            if (lowPrice != 0)
            {
                if (highPrice != 0)
                    return flowers.Where(x => x.Price >= lowPrice && x.Price <= highPrice).OrderBy(p => p.FlowerId);
                else
                    return flowers.Where(x => x.Price >= lowPrice).OrderBy(p => p.FlowerId);
            }
            else if (highPrice != 0)
                return flowers.Where(x => x.Price <= highPrice).OrderBy(p => p.FlowerId);
            else
                return flowers;
        }

        [HttpGet]
        public ViewResult Search(string flowerName, decimal lowPrice = 0, decimal highPrice = 0, string sorting = "")
        {
            IEnumerable<Flower> flowers;
            string currentCategory = string.Empty;
            ViewBag.FlowerName = flowerName;


            flowers = _flowerRepository.Flowers.Where(p => p.Name.Contains(flowerName) ||
                p.LongDescription.Contains(flowerName) ||
                p.ShortDescription.Contains(flowerName)).OrderBy(p => p.FlowerId);
                

            flowers = PriceFilter(lowPrice, highPrice, flowers);

            if (!string.IsNullOrEmpty(sorting))
            {
                if (sorting.Equals("ascending", StringComparison.OrdinalIgnoreCase))
                    flowers = flowers.OrderBy(p => p.Price);
                else if (sorting.Equals("descending", StringComparison.OrdinalIgnoreCase))
                    flowers = flowers.OrderByDescending(p => p.Price);
            }
            

            return View(new FlowerListViewModel
            {
                Flowers = flowers,
                CurrentCategory = currentCategory
            });
        }

        [HttpGet]
        public async Task<ActionResult> AutocompleteSearch()
        {
            try
            {
                string term = HttpContext.Request.Query["term"].ToString();
                var names = _flowerRepository.Flowers.Where(p => p.Name.Contains(term)).Select(p => p.Name).ToList();

                return Ok(names);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public IEnumerable<string> FlowersNames()
        {
            return _flowerRepository.FlowersNames;
        }

        public IActionResult Details(int id)
        {
            var flower = _flowerRepository.GetFlowerById(id);

            if (flower == null)
                return NotFound();

            return View(flower);
        }
    }
}