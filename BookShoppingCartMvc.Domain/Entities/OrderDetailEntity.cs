namespace BookShoppingCartMvc.Domain.Entities
{
    public class OrderDetailEntity
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid BookId { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public OrderEntity? Order { get; set; }
        public BookEntity? Book { get; set; }
    }
}
