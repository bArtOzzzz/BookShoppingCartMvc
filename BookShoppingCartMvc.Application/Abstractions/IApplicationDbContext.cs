using BookShoppingCartMvc.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookShoppingCartMvc.Application.Abstractions
{
    public interface IApplicationDbContext
    {
        DbSet<BookEntity> Books { get; set; }
        DbSet<CartDetailEntity> CartDetailEntities { get; set; }
        DbSet<GenreEntity> GenreEntities { get; set; }
        DbSet<OrderDetailEntity> OrderDetailEntities { get; set; }
        DbSet<OrderEntity> OrderEntities { get; set; }
        DbSet<OrderStatusEntity> OrderStatusEntities { get; set; }
        DbSet<ShoppingCartEntity> ShoppingCartEntities { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
