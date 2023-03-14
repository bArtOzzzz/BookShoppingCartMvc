using BookShoppingCartMvc.Domain.Entities;

namespace BookShoppingCartMvc.Application.Abstractions.IRepositories
{
    public interface IBookRepository
    {
        Task<List<BookEntity>> GetAllByGenreAsync(Guid categoryId, string filter = "");
    }
}
