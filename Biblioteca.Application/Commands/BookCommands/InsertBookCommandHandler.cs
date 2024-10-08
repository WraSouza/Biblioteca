﻿using Biblioteca.Core.Entities;
using Biblioteca.Core.Repositories;
using MediatR;

namespace Biblioteca.Application.Commands.BookCommands
{
    public class InsertBookCommandHandler : IRequestHandler<InsertBookCommand, int>
    {
        private readonly IBookRepository _bookRepository;
        public InsertBookCommandHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public async Task<int> Handle(InsertBookCommand request, CancellationToken cancellationToken)
        {
            bool getAllBooks = await _bookRepository.BookExistsAsync(request.Titulo);

            if (getAllBooks == false)
            {
                var book = new Book(request.Titulo, request.Autor, request.Isbn, request.AnoPublicacao);

                int id = _bookRepository.Create(book);

                return 1;

            }

            return 0;
        }
    }
}
