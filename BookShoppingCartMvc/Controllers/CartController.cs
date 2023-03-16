using BookShoppingCartMvc.Application.Abstractions.IServices;
using Microsoft.AspNetCore.Mvc;

namespace BookShoppingCartMvc.Controllers
{
    public class CartController : Controller
    {
        private readonly IShoppingCartService _shoppingCartService;

        public CartController(IShoppingCartService shoppingCartService)
        {
            _shoppingCartService = shoppingCartService;
        }

        [HttpPost]
        public async Task<ActionResult> CreateAsync(Guid bookId, int quantity = 1, int redirect = 0)
        {
            var cartCount = await _shoppingCartService.CreateAsync(bookId, quantity);

            if (redirect.Equals(0))
                return Ok(cartCount);

            return RedirectToAction("GetByUserIdAsync");
        }

        public async Task<ActionResult> RemoveAsync(Guid bookId)
        {
            var cartCount = await _shoppingCartService.DeleteAsync(bookId);

            return RedirectToAction("GetByUserIdAsync");
        }

        public async Task<ActionResult> GetByUserIdAsync()
        {
            var cart = await _shoppingCartService.GetByUserIdAsync();

            return View(cart);
        }

        public async Task<ActionResult> GetCartItemCountAsync()
        {
            int cartItem = await _shoppingCartService.GetCartItemCountAsync();

            return Ok(cartItem);
        }
    }
}
