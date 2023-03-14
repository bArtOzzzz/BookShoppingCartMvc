using BookShoppingCartMvc.Domain.Entities;

namespace BookShoppingCartMvc.Application.Abstractions.IRepositories
{
    public interface IGenreRepository
    {
        Task<List<GenreEntity>> GetAllAsync();
    }
}
