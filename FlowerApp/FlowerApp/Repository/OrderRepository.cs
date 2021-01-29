using FlowerApp.Models;
using FlowerApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FlowerApp.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }

        public IEnumerable<OrderHistoryDetailsViewModel> GetOrdersAsViewModel(string userName = "")
        {
            List<Order> orders = null;
            if (string.IsNullOrEmpty(userName))
            {
                orders = _appDbContext.Orders.ToList();
            }
            else
            {
                orders = _appDbContext.Orders.Where(x => x.Email == userName).ToList();
            }

            var orderHistoryDetailsList = new List<OrderHistoryDetailsViewModel>();
            foreach (var order in orders)
            {
                orderHistoryDetailsList.Add(MapDbOrderToOrderViewModel(order));
            }

            return orderHistoryDetailsList;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            _appDbContext.Orders.Add(order);

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Amount = shoppingCartItem.Amount,
                    FlowerId = shoppingCartItem.Flower.FlowerId,
                    OrderId = order.OrderId,
                    Price = shoppingCartItem.Flower.Price
                };

                _appDbContext.OrderDetails.Add(orderDetail);
            }

            _appDbContext.SaveChanges();
        }

        private OrderHistoryDetailsViewModel MapDbOrderToOrderViewModel(Order dbOrder)
        {
            return new OrderHistoryDetailsViewModel
            {
                OrderId = dbOrder.OrderId,
                Address = dbOrder.AddressLine1 + " " + dbOrder.AddressLine2,
                City = dbOrder.City,
                FirstName = dbOrder.FirstName,
                LastName = dbOrder.LastName,
                PayMethod = dbOrder.PayMethod,
                PhoneNumber = dbOrder.PhoneNumber,
                ShippingMethod = dbOrder.ShippingMethod
            };
        }
    }
}
