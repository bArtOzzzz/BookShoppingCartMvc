namespace BookShoppingCartMvc.Domain.Entities
{
    public class GenreEntity
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public List<BookEntity>? Books { get; set; }
    }
}
