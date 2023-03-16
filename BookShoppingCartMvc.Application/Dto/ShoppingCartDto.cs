namespace BookShoppingCartMvc.Application.Dto
{
    public class ShoppingCartDto
    {
        public Guid Id { get; set; }
        public string? UserId { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
