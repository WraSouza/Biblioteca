using Biblioteca.Application.InputModels;
using Biblioteca.Application.Services.Interfaces;
using Biblioteca.Application.ViewModels;
using Biblioteca.Core.Entities;
using Biblioteca.Infrastructure.Persistence;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Biblioteca.Application.Services.Implementations
{
    public class BookService : IBookService
    {
        private readonly BibliotecaDbContext _bibliotecaDbContext;
        private readonly string? _connectionString;

        public BookService(BibliotecaDbContext bibliotecaDbContext, IConfiguration configuration)
        {
            _bibliotecaDbContext = bibliotecaDbContext;

            _connectionString = configuration.GetConnectionString("BibliotecaCs");
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
            using(var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();

                var script = "SELECT Titulo, Autor FROM Books";

                return sqlConnection.Query<BookViewModel>(script).ToList();
            }

           
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
