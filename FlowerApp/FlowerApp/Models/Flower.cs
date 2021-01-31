namespace FlowerApp.Models
{
    public class Flower
    {
        //id
        public int FlowerId { get; set; }

        //name
        public string Name { get; set; }

        //short description
        public string ShortDescription { get; set; }

        //long description
        public string LongDescription { get; set; }

        //price
        public decimal Price { get; set; }

        //image 
        public string ImageUrl { get; set; }

        //thumbnail
        public string ImageThumbnailUrl { get; set; }

        //stock
        public bool InStock { get; set; }

        //category id
        public int CategoryId { get; set; }

        //category
        public virtual Category Category { get; set; }

        //flower presentation
        public bool IsFlowerPresentation { get; set; }

        // favorite
        public bool IsFavorite { get; set; }
    }
}
