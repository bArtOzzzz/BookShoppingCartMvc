namespace BookShoppingCartMvc.Domain.Entities
{
    public class OrderStatusEntity
    {
        public Guid Id { get; set; }
        public Guid StatusId { get; set; }
        public string? StatusName { get; set; }
    }
}
