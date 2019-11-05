using FlowerApp.Repository;
using FlowerApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;




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

        public ViewResult List()
        {
            FlowerListViewModel flowerListViewModel = new FlowerListViewModel();
            flowerListViewModel.Flowers = _flowerRepository.Flowers;

            flowerListViewModel.CurrentCategory = "";
            return View(flowerListViewModel);
        }

    }
}