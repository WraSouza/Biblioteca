using Biblioteca.Core.DTOs;
using Biblioteca.Core.Entities;

namespace Biblioteca.Core.Repositories
{
    public interface IBookRepository
    {
        Task<List<BookDTO>> GetAll();
        BookDTO GetById(int id);
        Task<BookDTO> Get(string query);      
        int Create(Book model);
        Task<bool> BookExistsAsync(string  query);
    }
}
