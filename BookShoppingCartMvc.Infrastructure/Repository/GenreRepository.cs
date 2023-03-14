using BookShoppingCartMvc.Application.Abstractions;
using BookShoppingCartMvc.Application.Abstractions.IRepositories;
using BookShoppingCartMvc.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookShoppingCartMvc.Infrastructure.Repository
{
    public class GenreRepository : IGenreRepository
    {
        private readonly IApplicationDbContext _context;

        public GenreRepository(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<GenreEntity>> GetAllAsync()
        {
            return await _context.GenreEntities.ToListAsync();
        }
    }
}
