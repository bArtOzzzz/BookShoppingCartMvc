using BookShoppingCartMvc.Application.Dto;

namespace BookShoppingCartMvc.Models
{
    public class BookDisplayModel
    {
        public List<GenreDto>? Genres { get; set; }
        public List<BookDto>? Books { get; set; }
        public string Filter { get; set; } = "";
        public Guid GenreId { get; set; }
    }
}
