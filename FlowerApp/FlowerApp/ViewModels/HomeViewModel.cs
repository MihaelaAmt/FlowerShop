using FlowerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerApp.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Flower> FlowerPresentation { get; set; }

        public IEnumerable<string> FlowersName { get; set; }
    }
}
