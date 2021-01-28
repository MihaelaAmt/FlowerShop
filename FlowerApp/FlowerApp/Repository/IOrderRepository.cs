using FlowerApp.Models;
using FlowerApp.ViewModels;
using System.Collections.Generic;

namespace FlowerApp.Repository
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);

        IEnumerable<OrderHistoryDetailsViewModel> GetOrdersAsViewModel(string userName = "");
    }
}
