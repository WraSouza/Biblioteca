using Biblioteca.Application.InputModels;
using Biblioteca.Application.ViewModels;

namespace Biblioteca.Application.Services.Interfaces
{
    public interface IBookService
    {
        List<BookViewModel> GetAll();
        List<BookViewModel> Get(string query);
        BookViewModel GetById(int id);
        int Create(InsertBookInputModel model);
    }
}
