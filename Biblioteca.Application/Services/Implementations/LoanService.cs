using Biblioteca.Application.InputModels;
using Biblioteca.Application.Services.Interfaces;
using Biblioteca.Application.ViewModels;
using Biblioteca.Core.Entities;
using Biblioteca.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Application.Services.Implementations
{
    public class LoanService : ILoanService
    {
        private readonly BibliotecaDbContext _dbContext;
        public LoanService(BibliotecaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Create(CreateLoanInputModel model)
        {
            var loan = new Emprestimo(model.IdUsuario, model.IdBook);

            _dbContext?.Loans?.Add(loan);

            return loan.Id;
        }        

        public LoanViewModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<LoanViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(UpdateLoanInputModel model)
        {
            throw new NotImplementedException();
        }
    }
}
