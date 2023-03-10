namespace BookShoppingCartMvc.Domain.Entities
{
    public class CartDetailEntity
    {
        public Guid Id { get; set; }
        public Guid ShoppingCartId { get; set; }
        public Guid BookId { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public BookEntity? Book { get; set; }
        public ShoppingCartEntity? ShoppingCart { get; set; }
    }
}
