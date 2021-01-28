using System.Collections.Generic;

namespace FlowerApp.ViewModels
{
    public class OrderHistoryViewModel
    {
        public IEnumerable<OrderHistoryDetailsViewModel> Orders { get; set; }
    }
}
