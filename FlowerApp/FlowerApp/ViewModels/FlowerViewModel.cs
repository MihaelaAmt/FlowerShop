using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerApp.ViewModels
{
    public class FlowerViewModel
    {
        public int FlowerId { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public decimal Price { get; set; }

        public string ImageThumbnailUrl { get; set; }
    }
}
