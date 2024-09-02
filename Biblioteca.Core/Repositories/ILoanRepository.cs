using Biblioteca.Core.DTOs;

namespace Biblioteca.Core.Repositories
{
    public interface ILoanRepository
    {
        Task<List<LoanDTO>> GetAllAsync();
    }
}
