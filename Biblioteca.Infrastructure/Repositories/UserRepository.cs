using Biblioteca.Core.DTOs;
using Biblioteca.Core.Entities;
using Biblioteca.Core.Repositories;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Biblioteca.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly string? _connectionString;
        public UserRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("BibliotecaCs"); ;
        }

        public int Create(Usuario model)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                
                var script = "INSERT INTO Usuarios (Nome, Email, UserStatus) VALUES (@Nome, @Email, @UserStatus)";

                connection.Execute(script, model);              
               
            }

            return model.Id;
        }

        public List<UserDTO> Get(string query)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserDTO>> GetAllUsersAsync()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var script = "SELECT Nome, Email, UserStatus FROM Usuarios";

                var users = await connection.QueryAsync<UserDTO>(script);

                return users.ToList();
            }
           
        }

        public UserDTO GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
