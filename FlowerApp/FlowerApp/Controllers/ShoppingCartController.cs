﻿using FlowerApp.Models;
using FlowerApp.Repository;
using FlowerApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FlowerApp.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IFlowerRepository _flowerRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IFlowerRepository flowerRepository, ShoppingCart shoppingCart)
        {
            _flowerRepository = flowerRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int flowerId)
        {
            var selectedFlower = _flowerRepository.Flowers.FirstOrDefault(p => p.FlowerId == flowerId);

            if (selectedFlower != null)
            {
                _shoppingCart.AddToCart(selectedFlower, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult UpdateShoppingCart(int flowerId, bool isAdding)
        {
            var selectedFlower = _flowerRepository.Flowers.FirstOrDefault(p => p.FlowerId == flowerId);

            if (selectedFlower != null)
            {
                if (isAdding)
                {
                    _shoppingCart.AddToCart(selectedFlower, 1);
                }
                else
                {
                    _shoppingCart.AddToCart(selectedFlower, -1);
                }
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int flowerId)
        {
            var selectedFlower = _flowerRepository.Flowers.FirstOrDefault(p => p.FlowerId == flowerId);

            if (selectedFlower != null)
            {
                _shoppingCart.RemoveFromCart(selectedFlower);
            }
            return RedirectToAction("Index");
        }
    }
}
