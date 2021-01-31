namespace FlowerApp.Models
{
    public class OrderDetail
    {
        //order detail id
        public int OrderDetailId { get; set; }

        //order id
        public int OrderId { get; set; }

        //flower id
        public int FlowerId { get; set; }

        //amount
        public int Amount { get; set; }

        //price
        public decimal Price { get; set; }

        //flower
        public virtual Flower Flower { get; set; }

        //order
        public virtual Order Order { get; set; }
    }
}
