using FlowerApp.Models;
using System.Collections.Generic;

namespace FlowerApp.ViewModels
{
    public class FlowerListViewModel
    {
        public IEnumerable<Flower> Flowers { get; set; }

        public string CurrentCategory { get; set; }
    }
}
