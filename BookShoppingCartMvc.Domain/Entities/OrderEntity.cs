namespace BookShoppingCartMvc.Domain.Entities
{
    public class OrderEntity
    {
        public Guid Id { get; set; }
        public string? UserId { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;
        public Guid OrderStatusId { get; set; }
        public bool IsDeleted { get; set; } = false;
        public OrderStatusEntity? OrderStatus { get; set; }
        public List<OrderDetailEntity>? OrderDetails { get; set; }
    }
}
