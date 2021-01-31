using FlowerApp.Models;
using FlowerApp.ViewModels;
using System.Collections.Generic;

namespace FlowerApp.Repository
{
    // create interface for order
    public interface IOrderRepository
    {
        //create order
        void CreateOrder(Order order);

        //iteration 
        IEnumerable<OrderHistoryDetailsViewModel> GetOrdersAsViewModel(string userName = "");
    }
}
