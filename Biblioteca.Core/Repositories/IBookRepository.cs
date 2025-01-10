using Biblioteca.Core.DTOs;
using Biblioteca.Core.Entities;

namespace Biblioteca.Core.Repositories
{
    public interface IBookRepository
    {
        Task<List<BookDTO>> GetAllAsync();
        BookDTO GetById(int id);
        Task<BookDTO> GetAsync(string query);      
        int Create(Book model);
        Task<bool> BookExistsAsync(string  query);
    }
}
