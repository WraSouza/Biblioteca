using Biblioteca.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Application.ViewModels
{
    public class LoanViewModel
    {
        public LoanViewModel(int idUsuario, int idBook, BookStatusEnum status, DateTime dataEmprestimo)
        {
            IdUsuario = idUsuario;
            IdBook = idBook;
            Status = status;
            DataEmprestimo = dataEmprestimo;
        }

        public int IdUsuario { get; private set; }
        public int IdBook { get; private set; }
        public BookStatusEnum Status { get; private set; }
        public DateTime DataEmprestimo { get; private set; }
    }
}
