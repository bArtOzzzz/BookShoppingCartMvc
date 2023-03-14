using AutoMapper;
using BookShoppingCartMvc.Application.Dto;
using BookShoppingCartMvc.Domain.Entities;

namespace BookShoppingCartMvc.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<BookEntity, BookDto>();
            CreateMap<BookDto, BookEntity>();
        }
    }
}
