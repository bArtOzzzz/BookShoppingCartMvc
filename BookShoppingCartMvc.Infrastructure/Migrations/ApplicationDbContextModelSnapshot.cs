﻿// <auto-generated />
using System;
using BookShoppingCartMvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookShoppingCartMvc.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookShoppingCartMvc.Domain.Entities.BookEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AuthorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoverUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("GenreId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = new Guid("63b0ddcd-27b6-4778-b9ba-8e4c068674c4"),
                            AuthorName = "Ian Flynn",
                            CoverUrl = "https://images.deal.by/172909677_w640_h640_komiks-sonic-sonik.jpg",
                            GenreId = new Guid("1d9997a6-a281-4614-bc30-520f853d3bad"),
                            Name = "Комикс Sonic. Том 1 Нежелательные последствия",
                            Price = 7.7999999999999998
                        },
                        new
                        {
                            Id = new Guid("4999068c-46c9-405b-b515-aa943120dd60"),
                            AuthorName = "Ian Flynn",
                            CoverUrl = "https://cv2.litres.ru/pub/c/cover_415/54096725.webp",
                            GenreId = new Guid("1d9997a6-a281-4614-bc30-520f853d3bad"),
                            Name = "Комикс Sonic. Том 2. Судьба доктора Эггмана",
                            Price = 7.7999999999999998
                        },
                        new
                        {
                            Id = new Guid("26a36f81-3eff-45bb-b32e-87daa74ff68a"),
                            AuthorName = "Ian Flynn",
                            CoverUrl = "https://cv1.litres.ru/pub/c/cover_415/51657416.webp",
                            GenreId = new Guid("1d9997a6-a281-4614-bc30-520f853d3bad"),
                            Name = "Комикс Sonic. Том 3 Битва за Остров Ангела",
                            Price = 7.7999999999999998
                        },
                        new
                        {
                            Id = new Guid("f572372a-0670-4053-b3db-bd04458a8779"),
                            AuthorName = "Ian Flynn",
                            CoverUrl = "https://cv4.litres.ru/pub/c/cover_415/54096646.webp",
                            GenreId = new Guid("1d9997a6-a281-4614-bc30-520f853d3bad"),
                            Name = "Комикс Sonic. Том 4 Заражение",
                            Price = 7.7999999999999998
                        },
                        new
                        {
                            Id = new Guid("117bd63c-cccb-45c1-9e39-9a30c8448eef"),
                            AuthorName = "Ian Flynn",
                            CoverUrl = "https://cv9.litres.ru/pub/c/cover_415/66477990.webp",
                            GenreId = new Guid("1d9997a6-a281-4614-bc30-520f853d3bad"),
                            Name = "Комикс Sonic. Том 5 Кризис в городе",
                            Price = 7.7999999999999998
                        },
                        new
                        {
                            Id = new Guid("8c5e3e7d-210a-4707-91d1-64d09498b239"),
                            AuthorName = "Ian Flynn",
                            CoverUrl = "https://cv9.litres.ru/pub/c/cover_415/65106791.webp",
                            GenreId = new Guid("1d9997a6-a281-4614-bc30-520f853d3bad"),
                            Name = "Комикс Sonic. Том 6 Последняя минута",
                            Price = 7.7999999999999998
                        },
                        new
                        {
                            Id = new Guid("286e9324-8f3f-4e0b-a7c9-c4099956f67d"),
                            AuthorName = "Ian Flynn",
                            CoverUrl = "https://cv1.litres.ru/pub/c/cover_415/67066215.webp",
                            GenreId = new Guid("1d9997a6-a281-4614-bc30-520f853d3bad"),
                            Name = "Комикс Sonic. Том 7 Все или Ничего",
                            Price = 7.7999999999999998
                        },
                        new
                        {
                            Id = new Guid("2292a1f7-6ef6-4cd2-9178-0f61a11c6956"),
                            AuthorName = "Ben Watson",
                            CoverUrl = "https://cv3.litres.ru/pub/c/cover_415/64086931.webp",
                            GenreId = new Guid("fb3f8241-4336-49ea-9bd4-aaaaad64b406"),
                            Name = "Высокопроизводительный код на платформе .NET",
                            Price = 7.9000000000000004
                        },
                        new
                        {
                            Id = new Guid("ce873c06-d87c-40e7-b880-cd57a4f62188"),
                            AuthorName = "Jeffrey Richter",
                            CoverUrl = "https://cv3.litres.ru/pub/c/cover_415/11643433.webp",
                            GenreId = new Guid("fb3f8241-4336-49ea-9bd4-aaaaad64b406"),
                            Name = "CLR via C#",
                            Price = 9.1999999999999993
                        });
                });

            modelBuilder.Entity("BookShoppingCartMvc.Domain.Entities.CartDetailEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid>("ShoppingCartId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("ShoppingCartId");

                    b.ToTable("CartDetailEntities");
                });

            modelBuilder.Entity("BookShoppingCartMvc.Domain.Entities.GenreEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GenreEntities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1d9997a6-a281-4614-bc30-520f853d3bad"),
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = new Guid("cf13ea50-d7d1-46af-ac54-096f8d830d11"),
                            Name = "Roman"
                        },
                        new
                        {
                            Id = new Guid("55e9c97b-205b-4c4f-a56e-ff52c552f625"),
                            Name = "Horror"
                        },
                        new
                        {
                            Id = new Guid("fb3f8241-4336-49ea-9bd4-aaaaad64b406"),
                            Name = "IT Education"
                        },
                        new
                        {
                            Id = new Guid("11e2af74-de57-41a0-92b8-c39af4de86a2"),
                            Name = "Western"
                        });
                });

            modelBuilder.Entity("BookShoppingCartMvc.Domain.Entities.OrderDetailEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetailEntities");
                });

            modelBuilder.Entity("BookShoppingCartMvc.Domain.Entities.OrderEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("OrderStatusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OrderStatusId");

                    b.ToTable("OrderEntities");
                });

            modelBuilder.Entity("BookShoppingCartMvc.Domain.Entities.OrderStatusEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("StatusName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OrderStatusEntities");
                });

            modelBuilder.Entity("BookShoppingCartMvc.Domain.Entities.ShoppingCartEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ShoppingCartEntities");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BookShoppingCartMvc.Domain.Entities.BookEntity", b =>
                {
                    b.HasOne("BookShoppingCartMvc.Domain.Entities.GenreEntity", "Genre")
                        .WithMany("Books")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("BookShoppingCartMvc.Domain.Entities.CartDetailEntity", b =>
                {
                    b.HasOne("BookShoppingCartMvc.Domain.Entities.BookEntity", "Book")
                        .WithMany("CartDetails")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookShoppingCartMvc.Domain.Entities.ShoppingCartEntity", "ShoppingCart")
                        .WithMany("CartDetails")
                        .HasForeignKey("ShoppingCartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("ShoppingCart");
                });

            modelBuilder.Entity("BookShoppingCartMvc.Domain.Entities.OrderDetailEntity", b =>
                {
                    b.HasOne("BookShoppingCartMvc.Domain.Entities.BookEntity", "Book")
                        .WithMany("OrderDetails")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookShoppingCartMvc.Domain.Entities.OrderEntity", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("BookShoppingCartMvc.Domain.Entities.OrderEntity", b =>
                {
                    b.HasOne("BookShoppingCartMvc.Domain.Entities.OrderStatusEntity", "OrderStatus")
                        .WithMany("Orders")
                        .HasForeignKey("OrderStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderStatus");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookShoppingCartMvc.Domain.Entities.BookEntity", b =>
                {
                    b.Navigation("CartDetails");

                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("BookShoppingCartMvc.Domain.Entities.GenreEntity", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BookShoppingCartMvc.Domain.Entities.OrderEntity", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("BookShoppingCartMvc.Domain.Entities.OrderStatusEntity", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("BookShoppingCartMvc.Domain.Entities.ShoppingCartEntity", b =>
                {
                    b.Navigation("CartDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
