namespace Domain.Entity.Registrations
{
    public class OrderItem : EntityBase
    {
        public long OrderId { get; set; }
        public Order Order { get; set; }

        public long ProductId { get; set; }
        public Product Product { get; set; }

        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public decimal Discount { get; set; }

    }
}
