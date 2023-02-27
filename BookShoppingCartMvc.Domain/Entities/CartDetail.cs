namespace BookShoppingCartMvc.Domain.Entities
{
    public class CartDetail
    {
        public Guid Id { get; set; }
        public Guid ShoppingCartId { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
    }
}
