using BookShoppingCartMvc.Application.Abstractions;
using BookShoppingCartMvc.Application.Abstractions.IRepositories;
using BookShoppingCartMvc.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookShoppingCartMvc.Infrastructure.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly IApplicationDbContext _context;

        public BookRepository(IApplicationDbContext context)
        {
            _context = context;   
        }

        public async Task<List<BookEntity>> GetAllByGenreAsync(Guid genreId, string filter = "")
        {
            filter = filter!.ToLower();
            var books = await (from book in _context.Books
                         join genre in _context.GenreEntities
                         on book.GenreId equals genre.Id
                         where string.IsNullOrWhiteSpace(filter) || (book != null && book.Name!.ToLower().StartsWith(filter))
                         select new BookEntity
                         {
                             Id = book.Id,
                             CoverUrl = book.CoverUrl,
                             AuthorName = book.AuthorName,
                             Name = book.Name,
                             GenreId = book.GenreId,
                             Price = book.Price,
                            GenreName = genre.Name
                         }).ToListAsync();

            if(!genreId.Equals(Guid.Empty))
                books = books.Where(a => a.GenreId.Equals(genreId)).ToList();

            return books;
        }
    }
}
