using Biblioteca.Application.InputModels;

namespace Biblioteca.Application.Services.Interfaces
{
    public interface IUsuarioService
    {
        int Create(CreateUserInputModel model);
        void Delete(int id);
    }
}
