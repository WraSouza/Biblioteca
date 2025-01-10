using Biblioteca.Core.DTOs;
using Biblioteca.Core.Repositories;
using MediatR;

namespace Biblioteca.Application.Queries.GetAllBooks
{
    public class GetAllBooksQueryHandler(IBookRepository bookRepository) : IRequestHandler<GetAllBooksQuery, List<BookDTO>>
    {        
        public async Task<List<BookDTO>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            return await bookRepository.GetAllAsync();
        }
    }
}
