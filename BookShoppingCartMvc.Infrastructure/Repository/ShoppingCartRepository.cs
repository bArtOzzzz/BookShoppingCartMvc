using BookShoppingCartMvc.Application.Abstractions.IRepositories;
using BookShoppingCartMvc.Application.Abstractions;
using BookShoppingCartMvc.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace BookShoppingCartMvc.Infrastructure.Repository
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly IApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ShoppingCartRepository(IApplicationDbContext context,
                                      UserManager<IdentityUser> userManager,
                                      IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
        }

        public async Task<ShoppingCartEntity?> GetByUserIdAsync(string userId)
        {
            return await _context.ShoppingCartEntities.Where(e => e.UserId!.Equals(userId)).FirstOrDefaultAsync();
        }

        public async Task<int> GetCartItemCountAsync(string userId = "")
        {
            if(!string.IsNullOrEmpty(userId)) 
            {
                userId = GetUserId();
            }

            var data = await (from cart in _context.ShoppingCartEntities
                              join cartDetail in _context.CartDetailEntities
                              on cart.Id equals cartDetail.ShoppingCartId
                              select new { cartDetail.Id })
                              .ToListAsync();

            return data.Count;
        }

        public async Task<ShoppingCartEntity> GetByUserIdAsync()
        {
            var userId = GetUserId();

            if (userId.Equals(null))
                throw new Exception("Invalid user id");

            var shoppingCart = await _context.ShoppingCartEntities.Include(e => e.CartDetails)!
                                                                  .ThenInclude(e => e.Book)
                                                                  .ThenInclude(e => e.Genre)
                                                                  .Where(e => e.UserId!.Equals(userId))
                                                                  .FirstOrDefaultAsync();

            return shoppingCart!;
        }

        public async Task<int> CreateAsync(Guid bookId, int quantity)
        {
            string userId = GetUserId();
            using var transaction = _context.Database.BeginTransaction();

            try
            {
                var cart = await GetByUserIdAsync(userId);

                if (string.IsNullOrEmpty(userId))
                    throw new Exception("User is not logged-in");

                if (cart is null)
                {
                    cart = new ShoppingCartEntity()
                    {
                        UserId = userId,
                    };

                    await _context.ShoppingCartEntities.AddAsync(cart);
                }

                await _context.SaveChangesAsync(CancellationToken.None);

                var cartItem = await _context.CartDetailEntities.FirstOrDefaultAsync(e => e.ShoppingCartId.Equals(cart.Id) && e.BookId.Equals(bookId));

                if(cartItem is not null)
                {
                    cartItem.Quantity += quantity;
                }
                else
                {
                    cartItem = new CartDetailEntity
                    {
                        BookId = bookId,
                        ShoppingCartId = cart.Id,
                        Quantity = quantity
                    };

                    await _context.CartDetailEntities.AddAsync(cartItem);
                }

                await _context.SaveChangesAsync(CancellationToken.None);
                transaction.Commit();
            }
            catch (Exception)
            {
            }

            return await GetCartItemCountAsync(userId);
        }

        public async Task<int> DeleteAsync(Guid bookId)
        {
            //using var transaction = _context.Database.BeginTransaction();
            string userId = GetUserId();

            try
            {
                if (string.IsNullOrEmpty(userId))
                    throw new Exception("User is not logged-in");

                var cart = await GetByUserIdAsync(userId);

                if (cart is null)
                {
                    throw new Exception("Invalid cart");
                }

                await _context.SaveChangesAsync(CancellationToken.None);

                var cartItem = await _context.CartDetailEntities.FirstOrDefaultAsync(e => e.ShoppingCartId.Equals(cart.Id) && e.BookId.Equals(bookId));

                if (cartItem is null)
                    throw new Exception("Not items in cart");
                else if (cartItem.Quantity.Equals(1))
                {
                    _context.CartDetailEntities.Remove(cartItem);
                }
                else
                {
                    cartItem.Quantity = cartItem.Quantity - 1;
                }

                await _context.SaveChangesAsync(CancellationToken.None);
                //transaction.Commit();
            }
            catch (Exception)
            {
            }

            return await GetCartItemCountAsync(userId);
        }

        private string GetUserId()
        {
            var principal = _httpContextAccessor.HttpContext.User;
            string userId = _userManager.GetUserId(principal)!;
            return userId;
        }
    }
}
