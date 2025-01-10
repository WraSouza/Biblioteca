using Biblioteca.Core.DTOs;
using Biblioteca.Core.Entities;

namespace Biblioteca.Core.Repositories
{
    public interface ILoanRepository
    {
        Task<List<LoanDTO>> GetAllAsync();
        Task<int> CreateAsync(Emprestimo model);
    }
}
