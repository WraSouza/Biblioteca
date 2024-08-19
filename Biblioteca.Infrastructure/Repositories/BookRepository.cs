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

        public List<BookDTO> Get(string query)
        {
            throw new NotImplementedException();
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
