namespace BookShoppingCartMvc.Domain.Entities
{
    public class ShoppingCart
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
