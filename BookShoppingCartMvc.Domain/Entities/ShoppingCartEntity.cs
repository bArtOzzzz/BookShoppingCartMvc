namespace BookShoppingCartMvc.Domain.Entities
{
    public class ShoppingCartEntity
    {
        public Guid Id { get; set; }
        public string? UserId { get; set; }
        public bool IsDeleted { get; set; } = false;
        public List<CartDetailEntity>? CartDetails { get; set; }
    }
}
