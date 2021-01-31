using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FlowerApp.Models
{
    //class for shopping cart 
    public class ShoppingCart
    {
        private readonly AppDbContext _appDbContext;
        //constructor
        private ShoppingCart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        //shopping cart id
        public string ShoppingCartId { get; set; }

        //list for shopping cart item
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        //get cart
        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = services.GetService<AppDbContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }

        //add to cart
        //the method has two parameters 
        public void AddToCart(Flower flower, int amount)
        {
            //set var shopping cart item with shopping cart id
            var shoppingCartItem =
                    _appDbContext.ShoppingCartItems.SingleOrDefault(
                        s => s.Flower.FlowerId == flower.FlowerId && s.ShoppingCartId == ShoppingCartId);
            //if it is null
            if (shoppingCartItem == null)
            {
                //in shopping cart item view
                //shopping cart id
                //flower
                //amount
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Flower = flower,
                    Amount = 1
                };

                _appDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            //else it is different from null
            else
            {
                //if (shoppingCartItem.Amount > 0 && shoppingCartItem.Amount < 9)
                //{
                //    shoppingCartItem.Amount += amount;
                //}
                //else
                //    shoppingCartItem.Amount = amount;
                if (shoppingCartItem.Amount < 1)
                {
                    shoppingCartItem.Amount = amount + 1;
                }
                else if (shoppingCartItem.Amount > 8)
                {
                    shoppingCartItem.Amount = amount;
                }
                else
                {
                    shoppingCartItem.Amount += amount;
                }
            }
            //save changes
            _appDbContext.SaveChanges();
        }

        //remove to cart
        public int RemoveFromCart(Flower flower)
        {
            var shoppingCartItem =
                    _appDbContext.ShoppingCartItems.SingleOrDefault(
                        s => s.Flower.FlowerId == flower.FlowerId && s.ShoppingCartId == ShoppingCartId);
            //set local amount
            var localAmount = 0;

            //if is different from null
            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    //decrement
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _appDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }
            //save changes
            _appDbContext.SaveChanges();

            return localAmount;
        }

        //list of shopping cart item
        public List<ShoppingCartItem> GetShoppingCartItems => ShoppingCartItems ??
                   (ShoppingCartItems = _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                           .Include(s => s.Flower)
                           .ToList());

        //clear cart
        public void ClearCart()
        {
            //set var cart items with id cart
            var cartItems = _appDbContext
                .ShoppingCartItems
                .Where(cart => cart.ShoppingCartId == ShoppingCartId);

            _appDbContext.ShoppingCartItems.RemoveRange(cartItems);

            _appDbContext.SaveChanges();
        }


        //shopping cart total
        public decimal GetShoppingCartTotal => _appDbContext.ShoppingCartItems
            .Where(c => c.ShoppingCartId == ShoppingCartId)
            .Select(c => c.Flower.Price * c.Amount)
            .Sum();
    }
}
