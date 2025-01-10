using Biblioteca.Core.Entities;
using Biblioteca.Core.Repositories;
using MediatR;

namespace Biblioteca.Application.Commands.BookCommands
{
    public class InsertBookCommandHandler(IBookRepository bookRepository) : IRequestHandler<InsertBookCommand, int>
    {        
        public async Task<int> Handle(InsertBookCommand request, CancellationToken cancellationToken)
        {
            bool getAllBooks = await bookRepository.BookExistsAsync(request.Titulo);

            if (getAllBooks == false)
            {
                var book = new Book(request.Titulo, request.Autor, request.Isbn, request.AnoPublicacao);

                int id = bookRepository.Create(book);

                return id;

            }

            return 0;
        }
    }
}
