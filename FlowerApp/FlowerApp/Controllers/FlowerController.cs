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
    //for Flower
    //create a controller
    //base class controller
    public class FlowerController : Controller
    {
        private readonly IFlowerRepository _flowerRepository;
        private readonly ICategoryRepository _categoryRepository;

        //constructor
        public FlowerController(IFlowerRepository flowerRepository, ICategoryRepository categoryRepository)
        {
            _flowerRepository = flowerRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(string category,
            //set low Price
            decimal lowPrice = 0,
            //set high price
            decimal highPrice = 0,
            string sorting = "",
            FlowerStock availability = 0)
        {
            //enumeration for flower
            IEnumerable<Flower> flowers;
            string currentCategory = string.Empty;
            GetByCategory(category, lowPrice, highPrice, out flowers, out currentCategory);

            //sorting
            flowers = SortFlowers(sorting, flowers);

            switch (availability)
            {
                //sorting if the flowers are in stock
                case FlowerStock.InStock:
                    flowers = flowers.Where(x => x.InStock);
                    break;
                //the flowers are not in stock
                case FlowerStock.NotInStock:
                    flowers = flowers.Where(x => !x.InStock);
                    break;
                // all
                case FlowerStock.All:
                    break;
            }

            return View(new FlowerListViewModel
            {
                Flowers = flowers,
                CurrentCategory = currentCategory
            });
        }

        private void GetByCategory(string category, decimal lowPrice, decimal highPrice, out IEnumerable<Flower> flowers, out string currentCategory)
        {
            if (string.IsNullOrEmpty(category))
            {
                //order by Id
                flowers = _flowerRepository.Flowers.OrderBy(p => p.FlowerId);
                //set price filter for low price, high price and flowers
                flowers = PriceFilter(lowPrice, highPrice, flowers);

                //set current categroy 
                currentCategory = "All flowers";
            }
            else
            {
                //order category by id
                flowers = _flowerRepository.Flowers.Where(p => p.Category.CategoryName == category)
                   .OrderBy(p => p.FlowerId);

                flowers = PriceFilter(lowPrice, highPrice, flowers);

                currentCategory = _categoryRepository.Categories.FirstOrDefault(c => c.CategoryName == category).CategoryName;
            }
        }

        private static IEnumerable<Flower> SortFlowers(string sorting, IEnumerable<Flower> flowers)
        {
            if (!string.IsNullOrEmpty(sorting))
            {
                //ascending sort
                if (sorting.Equals("ascending", StringComparison.OrdinalIgnoreCase))
                {
                    flowers = flowers.OrderBy(p => p.Price);
                }
                //descending sort
                else if (sorting.Equals("descending", StringComparison.OrdinalIgnoreCase))
                {
                    flowers = flowers.OrderByDescending(p => p.Price);
                }
            }

            return flowers;
        }

        //favorite flowers
        public ViewResult Favorite()
        {
            IEnumerable<Flower> flowers = _flowerRepository.Flowers
                .Where(x => x.IsFavorite)
                .OrderBy(p => p.FlowerId)
                .ToList();

            return View(new FlowerListViewModel
            {
                Flowers = flowers,
                CurrentCategory = null
            });
        }

        //add flowers to favorite 
        //by id
        public ActionResult AddToFavorite(int flowerId)
        {
            var flower = _flowerRepository.Flowers.Where(x => x.FlowerId == flowerId).FirstOrDefault();

            if (flower != null)
            {
                flower.IsFavorite = true;
                _flowerRepository.UpdateFlower(flower);
            }

            return RedirectToAction("Favorite", "Flower");
        }

        //remove favorite flower
        public ActionResult RemoveFromFavorite(int flowerId)
        {
            var flower = _flowerRepository.Flowers.Where(x => x.FlowerId == flowerId).FirstOrDefault();

            if (flower != null)
            {
                flower.IsFavorite = false;
                _flowerRepository.UpdateFlower(flower);
            }

            return RedirectToAction("List", "Flower");
        }

        //create price filter
        private static IEnumerable<Flower> PriceFilter(decimal lowPrice, decimal highPrice, IEnumerable<Flower> flowers)
        {
            //low price is not 0
            if (lowPrice != 0)
            {
                //high price is not 0
                if (highPrice != 0)
                {
                    //show flowers
                    //which have a price higher than price
                    //and lower than price
                    return flowers.Where(x => x.Price >= lowPrice && x.Price <= highPrice).OrderBy(p => p.FlowerId);
                }
                else
                {
                    return flowers.Where(x => x.Price >= lowPrice).OrderBy(p => p.FlowerId);
                }
            }
            else if (highPrice != 0)
            {
                return flowers.Where(x => x.Price <= highPrice).OrderBy(p => p.FlowerId);
            }
            else
            {
                return flowers;
            }
        }

        //create stock filter
        public enum FlowerStock
        {
            //set all 0
            All = 0,
            //in stock 1
            InStock = 1,
            //not in stock 2
            NotInStock = 2
        }

        //request data from a specified resource
        [HttpGet]
        public ViewResult Search(string flowerName, decimal lowPrice = 0, decimal highPrice = 0, string sorting = "")
        {
            //enumeration for flowers
            IEnumerable<Flower> flowers;
            //set current category
            string currentCategory = string.Empty;
            //flower name
            ViewBag.FlowerName = flowerName;

            //search by name
            //by long description
            //by short description
            flowers = _flowerRepository.Flowers.Where(p => p.Name.Contains(flowerName) ||
                p.LongDescription.Contains(flowerName) ||
                p.ShortDescription.Contains(flowerName)).OrderBy(p => p.FlowerId);
            //price filter
            flowers = PriceFilter(lowPrice, highPrice, flowers);

            if (!string.IsNullOrEmpty(sorting))
            {
                //ascending sort
                if (sorting.Equals("ascending", StringComparison.OrdinalIgnoreCase))
                {
                    //order by price 
                    flowers = flowers.OrderBy(p => p.Price);
                }

                //descending sort
                else if (sorting.Equals("descending", StringComparison.OrdinalIgnoreCase))
                {
                    //order by price
                    flowers = flowers.OrderByDescending(p => p.Price);
                }
            }

            //view flowers
            //current category
            return View(new FlowerListViewModel
            {
                Flowers = flowers,
                CurrentCategory = currentCategory
            });
        }

        //request data from a specified resource
        [HttpGet]
        //autocomplete search
        public async Task<ActionResult> AutocompleteSearch()
        {
            try
            {
                //completing to piece of word
                string term = HttpContext.Request.Query["term"].ToString();
                var names = _flowerRepository.Flowers.Where(p => p.Name.Contains(term)).Select(p => p.Name).ToList();

                return Ok(names);
            }
            catch
            {
                return BadRequest();
            }
        }
        //request data from a specified resource
        [HttpGet]
        public IEnumerable<string> FlowersNames()
        {
            return _flowerRepository.FlowersNames;
        }

        public IActionResult Details(int id)
        {
            //by id
            var flower = _flowerRepository.GetFlowerById(id);

            if (flower == null)
            {
                return NotFound();
            }

            return View(new FlowerDetailViewModel
            {
                Flower = flower
            });
        }
    }
}