using BookShoppingCartMvc.Application.Dto;

namespace BookShoppingCartMvc.Application.Abstractions.IServices
{
    public interface IBookService
    {
        Task<List<BookDto>> GetAllByGenreAsync(Guid categoryId, string filter = "");
    }
}
