using BookShoppingCartMvc.Domain.Entities;

namespace BookShoppingCartMvc.Application.Abstractions.IRepositories
{
    public interface IShoppingCartRepository
    {
        Task<ShoppingCartEntity?> GetByUserIdAsync(string userId);
        Task<ShoppingCartEntity> GetByUserIdAsync();
        Task<int> GetCartItemCountAsync(string userId = "");
        Task<int> CreateAsync(Guid bookId, int quantity);
        Task<int> DeleteAsync(Guid bookId);
    }
}
