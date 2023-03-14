namespace BookShoppingCartMvc.Application.Dto
{
    public class BookDto
    {
        public Guid Id { get; set; }
        public Guid GenreId { get; set; }
        public string? Name { get; set; }
        public string? AuthorName { get; set; }
        public double Price { get; set; }
        public string? CoverUrl { get; set; }
        public string? GenreName { get; set; }
    }
}
