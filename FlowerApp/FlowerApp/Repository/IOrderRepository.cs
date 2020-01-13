using FlowerApp.Models;
using FlowerApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerApp.Repository
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);

        IEnumerable<OrderHistoryDetailsViewModel> GetOrdersAsViewModel(string userName = "");
    }
}
