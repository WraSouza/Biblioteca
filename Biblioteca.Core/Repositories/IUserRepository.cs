using Biblioteca.Core.DTOs;
using Biblioteca.Core.Entities;

namespace Biblioteca.Core.Repositories
{
    public interface IUserRepository
    {
        Task<List<UserDTO>> GetAllUsersAsync();
        UserDTO GetById(int id);
        List<UserDTO> Get(string query);
        int Create(Usuario model);
    }
}
