using System.Collections.Generic;

namespace FlowerApp.Auth
{
    //access for add, update, delete
    public class FlowerShopClaimTypes
    {
        //create list
        public static List<string> ClaimsList { get; set; } = new List<string> { "Delete Flower", "Add Flower", "Age for ordering" };
    }
}
