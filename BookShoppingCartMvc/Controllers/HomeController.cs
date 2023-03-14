using BookShoppingCartMvc.Application.Abstractions.IServices;
using BookShoppingCartMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BookShoppingCartMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookService _bookService;
        private readonly IGenreService _genreService;

        public HomeController(IBookService bookService, IGenreService genreService)
        {
            _bookService = bookService;
            _genreService = genreService;
        }

        public async Task<ActionResult> Index(Guid genreId, string filter = "")
        {
            var books = await _bookService.GetAllByGenreAsync(genreId, filter);
            var genres = await _genreService.GetAllAsync();

            BookDisplayModel model = new()
            {
                Books = books,
                Genres = genres,
                Filter = filter,
                GenreId = genreId
            };

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}