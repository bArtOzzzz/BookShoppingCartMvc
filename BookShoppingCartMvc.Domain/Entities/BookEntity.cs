namespace BookShoppingCartMvc.Domain.Entities
{
    public class BookEntity
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? AuthorName { get; set; }
        public double Price { get; set; }
        public string? CoverUrl { get; set; }
        public Guid GenreId { get; set; }
        public GenreEntity? Genre { get; set; }
        public List<OrderDetailEntity>? OrderDetails { get; set; }
        public List<CartDetailEntity>? CartDetails { get; set; }
    }
}
