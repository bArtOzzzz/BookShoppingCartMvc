using BookShoppingCartMvc.Application.Abstractions.IRepositories;
using BookShoppingCartMvc.Application.Abstractions.IServices;
using BookShoppingCartMvc.Application.Dto;
using AutoMapper;

namespace BookShoppingCartMvc.Application.Services
{
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository _genreRepository;
        private readonly IMapper _mapper;

        public GenreService(IGenreRepository genreRepository, IMapper mapper)
        {
            _genreRepository = genreRepository;
            _mapper = mapper;
        }

        public async Task<List<GenreDto>> GetAllAsync()
        {
            var genres = await _genreRepository.GetAllAsync();

            return _mapper.Map<List<GenreDto>>(genres);
        }
    }
}
