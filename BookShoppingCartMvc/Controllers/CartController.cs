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
        public async Task<IActionResult> CreateAsync(Guid bookId, int quantity = 1, int redirect = 0)
        {
            var cartCount = await _shoppingCartService.CreateAsync(bookId, quantity);

            if (redirect.Equals(0))
                return Ok(cartCount);

            return RedirectToAction("GetByUserIdAsync");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveAsync(Guid bookId)
        {
            var cartCount = await _shoppingCartService.DeleteAsync(bookId);

            return RedirectToAction("GetByUserIdAsync");
        }

        [HttpGet]
        public async Task<IActionResult> GetByUserIdAsync()
        {
            var cart = await _shoppingCartService.GetByUserIdAsync();

            return View(cart);
        }

        [HttpGet]
        public async Task<IActionResult> GetCartItemCountAsync()
        {
            int cartItem = await _shoppingCartService.GetCartItemCountAsync();

            return Ok(cartItem);
        }
    }
}
