using AutoMapper;
using BookShoppingCartMvc.Application.Abstractions.IRepositories;
using BookShoppingCartMvc.Application.Abstractions.IServices;
using BookShoppingCartMvc.Application.Dto;

namespace BookShoppingCartMvc.Application.Services
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly IShoppingCartRepository _shoppingCartRepository;
        private readonly IMapper _mapper;

        public ShoppingCartService(IShoppingCartRepository shoppingCartRepository, IMapper mapper)
        {
            _mapper = mapper;
            _shoppingCartRepository = shoppingCartRepository;
        }

        public async Task<ShoppingCartDto> GetByUserIdAsync()
        {
            var carts = await _shoppingCartRepository.GetByUserIdAsync();

            return _mapper.Map<ShoppingCartDto>(carts);
        }

        public async Task<int> GetCartItemCountAsync(string userId = "")
        {
            return await _shoppingCartRepository.GetCartItemCountAsync(userId);
        }

        public async Task<ShoppingCartDto?> GetByUserIdAsync(string userId)
        {
            var cart = await _shoppingCartRepository.GetByUserIdAsync(userId);

            return _mapper.Map<ShoppingCartDto>(cart);
        }

        public async Task<int> CreateAsync(Guid bookId, int quantity)
        {
            return await _shoppingCartRepository.CreateAsync(bookId, quantity);
        }

        public async Task<int> DeleteAsync(Guid bookId)
        {
            return await _shoppingCartRepository.DeleteAsync(bookId);
        }
    }
}
