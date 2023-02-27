namespace BookShoppingCartMvc.Domain.Entities
{
    public class Book
    {
        public Guid Id { get; set; }
        public Guid GenreId { get; set; }
        public string? Name { get; set; }
        public string? CoverURL { get; set; }
        public Genre? Genre { get; set; }
    }
}
