namespace BookShoppingCartMvc.Domain.Entities
{
    public class OrderStatusEntity
    {
        public Guid Id { get; set; }
        public string? StatusName { get; set; }
        public List<OrderEntity>? Orders { get; set; }
    }
}
