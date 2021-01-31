using System.Collections.Generic;

namespace FlowerApp.Models
{
    //the central component of the pattern 
    //it directly manages the data, logic and rules of application
    //models for category
    public class Category
    {
        //category id
        public int CategoryId
        {
            get;
            set;
        }
        //category name
        public string CategoryName
        {
            get;
            set;
        }
        //description
        public string Description
        {
            get;
            set;
        }
        //list of flowers
        public List<Flower> Flowers
        {
            get;
            set;
        }
    }
}
