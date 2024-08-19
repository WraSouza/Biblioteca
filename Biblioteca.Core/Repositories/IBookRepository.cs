using Biblioteca.Core.DTOs;
using Biblioteca.Core.Entities;

namespace Biblioteca.Core.Repositories
{
    public interface IBookRepository
    {
        Task<List<BookDTO>> GetAll();
        BookDTO GetById(int id);
        List<BookDTO> Get(string query);      
        int Create(Book model);
    }
}
