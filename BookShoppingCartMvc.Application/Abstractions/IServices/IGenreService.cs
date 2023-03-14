using BookShoppingCartMvc.Application.Dto;

namespace BookShoppingCartMvc.Application.Abstractions.IServices
{
    public interface IGenreService
    {
        Task<List<GenreDto>> GetAllAsync();
    }
}
