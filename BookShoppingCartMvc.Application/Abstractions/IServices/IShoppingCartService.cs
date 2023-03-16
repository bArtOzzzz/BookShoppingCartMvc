using BookShoppingCartMvc.Application.Dto;

namespace BookShoppingCartMvc.Application.Abstractions.IServices
{
    public interface IShoppingCartService
    {
        Task<ShoppingCartDto?> GetByUserIdAsync(string userId);
        Task<ShoppingCartDto> GetByUserIdAsync();
        Task<int> GetCartItemCountAsync(string userId = "");
        Task<int> CreateAsync(Guid bookId, int quantity);
        Task<int> DeleteAsync(Guid bookId);
    }
}
