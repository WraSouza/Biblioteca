using Biblioteca.Application.InputModels;
using Biblioteca.Application.Services.Interfaces;
using Biblioteca.Application.ViewModels;
using Biblioteca.Core.Entities;
using Biblioteca.Infrastructure.Persistence;

namespace Biblioteca.Application.Services.Implementations
{
    public class BookService : IBookService
    {
        private readonly BibliotecaDbContext _bibliotecaDbContext;

        public BookService(BibliotecaDbContext bibliotecaDbContext)
        {
            _bibliotecaDbContext = bibliotecaDbContext;
        }

        public int Create(InsertBookInputModel model)
        {
            var book = new Book(model.Titulo, model.Autor, model.Isbn, model.AnoPublicacao);

            _bibliotecaDbContext?.Books?.Add(book);

            return book.Id;
        }

        public List<BookViewModel> Get(string query)
        {
           var books = _bibliotecaDbContext.Books;

            var booksViewModel = books?
                .Select(book => new BookViewModel(book.Titulo, book.Autor)).ToList();

            return booksViewModel;
        }

        public List<BookViewModel> GetAll()
        {
            var books = _bibliotecaDbContext.Books;

            var booksViewModel = books?
                .Select(b =>  new BookViewModel(b.Titulo, b.Autor)).ToList();

            return booksViewModel;
        }

        public BookViewModel GetById(int id)
        {
            var book = _bibliotecaDbContext?.Books?.SingleOrDefault(book => book.Id == id);

            var bookViewModel = new BookViewModel(
                book?.Titulo,
                book?.Autor);

            return bookViewModel;
        }
    }
}
