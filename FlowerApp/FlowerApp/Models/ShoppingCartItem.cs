namespace FlowerApp.Models
{
    public class ShoppingCartItem
    {
        //shopping cart item id
        public int ShoppingCartItemId { get; set; }

        //flower
        public Flower Flower { get; set; }

        //amount
        public int Amount { get; set; }

        //shopping cart id
        public string ShoppingCartId { get; set; }
    }
}
