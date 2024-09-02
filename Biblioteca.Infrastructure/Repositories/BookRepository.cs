using Biblioteca.Core.DTOs;
using Biblioteca.Core.Entities;
using Biblioteca.Core.Repositories;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Biblioteca.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly string? _connectionString;
        public BookRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("BibliotecaCs");
        }

        public async Task<bool> BookExistsAsync(string query)
        {
            BookDTO bookDTO = null;

            bool bookExists = false;

            using (var sqlConnection = new SqlConnection(_connectionString))
            {

                sqlConnection.Open();

                var parameters = new { Titulo = query };

                var script = "SELECT Titulo, Autor, StatusBook FROM Books WHERE Titulo = @Titulo";

                var book = await sqlConnection.QueryAsync<BookDTO>(script, parameters);

                int qtdyBooks = book.ToList().Where(x => x.Titulo == query).Count();

                if (qtdyBooks > 0)
                {
                    bookExists = true;

                    return bookExists;
                }


                return bookExists;
            }
        }

        public int Create(Book model)
        {            
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var script = "INSERT INTO Books (Titulo, Autor, Isbn, AnoPublicacao, StatusBook) VALUES (@Titulo, @Autor, @Isbn, @AnoPublicacao, @StatusBook)";

                connection.Execute(script, model);
            }

            return model.Id;
        }

        public async Task<BookDTO> Get(string query)
        {
            BookDTO bookDTO = null;

            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                
                    sqlConnection.Open();

                    var parameters = new { Titulo = query };

                    var script = "SELECT Titulo, Autor, StatusBook FROM Books WHERE Titulo = @Titulo";

                    var book = await sqlConnection.QueryFirstOrDefaultAsync<BookDTO>(script, parameters);                    

                    return book;
                

               // return bookDTO;
            }
        }

        public async Task<List<BookDTO>> GetAll()
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();

                var script = "SELECT Titulo, Autor, StatusBook FROM Books";

                var books = await sqlConnection.QueryAsync<BookDTO>(script);

                return books.ToList();
            }
        }

        public BookDTO GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
