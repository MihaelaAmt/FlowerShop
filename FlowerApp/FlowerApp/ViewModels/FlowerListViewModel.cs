using FlowerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerApp.ViewModels
{
    public class FlowerListViewModel
    {
        public IEnumerable<Flower> Flowers { get; set; }

        public string CurrentCategory { get; set; }
    }
}
