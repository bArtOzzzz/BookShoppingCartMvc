using AutoMapper;
using BookShoppingCartMvc.Application.Abstractions.IRepositories;
using BookShoppingCartMvc.Application.Abstractions.IServices;
using BookShoppingCartMvc.Application.Dto;

namespace BookShoppingCartMvc.Application.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public BookService(IBookRepository bookRepository, 
                           IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<List<BookDto>> GetAllByGenreAsync(Guid categoryId, string filter = "")
        {
            var booksMap = await _bookRepository.GetAllByGenreAsync(categoryId, filter);

            return _mapper.Map<List<BookDto>>(booksMap);
        }
    }
}
