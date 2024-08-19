using Biblioteca.Core.DTOs;
using MediatR;

namespace Biblioteca.Application.Queries.GetAllBooks
{
    public class GetAllBooksQuery : IRequest<List<BookDTO>>
    {
        public string? Titulo { get; private set; }
        public string? Autor { get; private set; }
    }
}
