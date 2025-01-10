using Biblioteca.Core.DTOs;
using Biblioteca.Core.Entities;
using Biblioteca.Core.Enums;
using Biblioteca.Core.Repositories;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Biblioteca.Infrastructure.Repositories
{
    public class LoanRepository : ILoanRepository
    {
        private readonly string? _connectionString;
        public LoanRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("BibliotecaCs");
        }

        public async Task<int> CreateAsync(Emprestimo model)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();                 

                var script = "INSERT INTO Loans (IdUsuario, IdBook,Status, DataEmprestimo, DataDevolucao) VALUES (@IdUsuario, @IdBook, @Status, @DataEmprestimo, @DataDevolucao)";

                await connection.ExecuteAsync(script, model);
            }

            return model.Id;
        }

        public Task<List<LoanDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
