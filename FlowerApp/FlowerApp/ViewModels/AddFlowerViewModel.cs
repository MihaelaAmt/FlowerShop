﻿namespace FlowerApp.ViewModels
{
    public class AddFlowerViewModel
    {
        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public string ImageThumbnailUrl { get; set; }

        public bool IsFlowerPresentation { get; set; }

        public bool InStock { get; set; }

        public int CategoryId { get; set; }
    }
}
