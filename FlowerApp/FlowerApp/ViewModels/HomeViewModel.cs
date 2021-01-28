using FlowerApp.Models;
using System.Collections.Generic;

namespace FlowerApp.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Flower> FlowerPresentation { get; set; }

        public IEnumerable<string> FlowersName { get; set; }
    }
}
