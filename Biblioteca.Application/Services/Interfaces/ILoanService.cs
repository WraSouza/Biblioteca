using Biblioteca.Application.InputModels;
using Biblioteca.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Application.Services.Interfaces
{
    public interface ILoanService
    {
        List<LoanViewModel> GetAll();
        LoanViewModel Get(int id);
        int Create(CreateLoanInputModel model);
        void Update(UpdateLoanInputModel model);        
        
    }
}
