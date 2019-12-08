using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerApp.Auth
{
    public class FlowerShopClaimTypes
    {
        public static List<string> ClaimsList { get; set; } = new List<string> { "Delete Flower", "Add Flower", "Age for ordering" };
    }
}
