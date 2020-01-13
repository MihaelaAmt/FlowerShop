using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerApp.ViewModels
{
    public class OrderHistoryViewModel
    {
        public IEnumerable<OrderHistoryDetailsViewModel> Orders { get; set; }
    }
}
