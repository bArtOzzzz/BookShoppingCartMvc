using BookShoppingCartMvc.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace BookShoppingCartMvc.Infrastructure
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            Database.EnsureCreated();
        }

        public DbSet<BookEntity> Books { get; set; } = default!;
        public DbSet<CartDetailEntity> CartDetailEntities { get; set; } = default!;
        public DbSet<GenreEntity> GenreEntities { get; set; } = default!;
        public DbSet<OrderDetailEntity> OrderDetailEntities { get; set; } = default!;
        public DbSet<OrderEntity> OrderEntities { get; set; } = default!;
        public DbSet<OrderStatusEntity> OrderStatusEntities { get; set; } = default!;
        public DbSet<ShoppingCartEntity> ShoppingCartEntities { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            #region Local variables
            Guid[] GuidGenresArr = { Guid.NewGuid(),
                                     Guid.NewGuid(),
                                     Guid.NewGuid(),
                                     Guid.NewGuid(),
                                     Guid.NewGuid() };
            #endregion

            #region Relationships configuration
            builder.Entity<OrderStatusEntity>(
                entity =>
                {
                    entity.Property(e => e.Id)
                          .IsRequired();
                });

            builder.Entity<ShoppingCartEntity>(
               entity =>
               {
                   entity.Property(e => e.Id)
                         .IsRequired();
               });

            builder.Entity<GenreEntity>(
                entity =>
                {
                    entity.Property(e => e.Id)
                          .IsRequired();
                });

            builder.Entity<BookEntity>(
                entity =>
                {
                    entity.Property(e => e.Id)
                          .IsRequired();

                    entity.HasOne(e => e.Genre)
                          .WithMany(g => g.Books)
                          .HasForeignKey(e => e.GenreId);
                });

            builder.Entity<OrderEntity>(
                entity =>
                {
                    entity.Property(e => e.Id)
                          .IsRequired();

                    entity.HasOne(e => e.OrderStatus)
                          .WithMany(g => g.Orders)
                          .HasForeignKey(e => e.OrderStatusId);
                });

            builder.Entity<OrderDetailEntity>(
                entity =>
                {
                    entity.Property(e => e.Id)
                          .IsRequired();

                    entity.HasOne(e => e.Order)
                          .WithMany(g => g.OrderDetails)
                          .HasForeignKey(e => e.OrderId);

                    entity.HasOne(e => e.Book)
                          .WithMany(g => g.OrderDetails)
                          .HasForeignKey(e => e.BookId);
                });

            builder.Entity<CartDetailEntity>(
                entity =>
                {
                    entity.Property(e => e.Id)
                          .IsRequired();

                    entity.HasOne(e => e.Book)
                          .WithMany(g => g.CartDetails)
                          .HasForeignKey(e => e.BookId);

                    entity.HasOne(e => e.ShoppingCart)
                          .WithMany(g => g.CartDetails)
                          .HasForeignKey(e => e.ShoppingCartId);
                });

            base.OnModelCreating(builder);
            #endregion

            #region Seeddata
            builder.Entity<GenreEntity>().HasData(
                new GenreEntity
                {
                    Id = GuidGenresArr[0],
                    Name = "Adventure",
                },

                new GenreEntity
                {
                    Id = GuidGenresArr[1],
                    Name = "Roman"
                },

                new GenreEntity
                {
                    Id = GuidGenresArr[2],
                    Name = "Horror"
                },

                new GenreEntity
                {
                    Id = GuidGenresArr[3],
                    Name = "IT Education"
                },

                new GenreEntity
                {
                    Id = GuidGenresArr[4],
                    Name = "Western"
                });

            builder.Entity<BookEntity>().HasData(
                new BookEntity
                {
                    Id = Guid.NewGuid(),
                    GenreId = GuidGenresArr[0],
                    Name = "Комикс Sonic. Том 1 Нежелательные последствия",
                    AuthorName = "Ian Flynn",
                    CoverUrl = "https://images.deal.by/172909677_w640_h640_komiks-sonic-sonik.jpg",
                    Price = 7.8
                },

                new BookEntity
                {
                    Id = Guid.NewGuid(),
                    GenreId = GuidGenresArr[0],
                    Name = "Комикс Sonic. Том 2. Судьба доктора Эггмана",
                    AuthorName = "Ian Flynn",
                    CoverUrl = "https://cv2.litres.ru/pub/c/cover_415/54096725.webp",
                    Price = 7.8
                },

                new BookEntity
                {
                    Id = Guid.NewGuid(),
                    GenreId = GuidGenresArr[0],
                    Name = "Комикс Sonic. Том 3 Битва за Остров Ангела",
                    AuthorName = "Ian Flynn",
                    CoverUrl = "https://cv1.litres.ru/pub/c/cover_415/51657416.webp",
                    Price = 7.8
                },

                new BookEntity
                {
                    Id = Guid.NewGuid(),
                    GenreId = GuidGenresArr[0],
                    Name = "Комикс Sonic. Том 4 Заражение",
                    AuthorName = "Ian Flynn",
                    CoverUrl = "https://cv4.litres.ru/pub/c/cover_415/54096646.webp",
                    Price = 7.8
                },

                new BookEntity
                {
                    Id = Guid.NewGuid(),
                    GenreId = GuidGenresArr[0],
                    Name = "Комикс Sonic. Том 5 Кризис в городе",
                    AuthorName = "Ian Flynn",
                    CoverUrl = "https://cv9.litres.ru/pub/c/cover_415/66477990.webp",
                    Price = 7.8
                },

                new BookEntity
                {
                    Id = Guid.NewGuid(),
                    GenreId = GuidGenresArr[0],
                    Name = "Комикс Sonic. Том 6 Последняя минута",
                    AuthorName = "Ian Flynn",
                    CoverUrl = "https://cv9.litres.ru/pub/c/cover_415/65106791.webp",
                    Price = 7.8
                },

                new BookEntity
                {
                    Id = Guid.NewGuid(),
                    GenreId = GuidGenresArr[0],
                    Name = "Комикс Sonic. Том 7 Все или Ничего",
                    AuthorName = "Ian Flynn",
                    CoverUrl = "https://cv1.litres.ru/pub/c/cover_415/67066215.webp",
                    Price = 7.8
                },

                new BookEntity
                {
                    Id = Guid.NewGuid(),
                    GenreId = GuidGenresArr[3],
                    Name = "Высокопроизводительный код на платформе .NET",
                    AuthorName = "Ben Watson",
                    CoverUrl = "https://cv3.litres.ru/pub/c/cover_415/64086931.webp",
                    Price = 7.9
                },

                new BookEntity
                {
                    Id = Guid.NewGuid(),
                    GenreId = GuidGenresArr[3],
                    Name = "CLR via C#",
                    AuthorName = "Jeffrey Richter",
                    CoverUrl = "https://cv3.litres.ru/pub/c/cover_415/11643433.webp",
                    Price = 9.2
                });
            #endregion
        }
    }
}