using Biblioteca.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Application.InputModels
{
    public class CreateLoanInputModel
    {
        public int IdUsuario { get; private set; }
        public int IdBook { get; private set; }
        public BookStatusEnum Status { get; private set; }
        public DateTime DataEmprestimo { get; private set; }
        public DateTime? DataDevolucao { get; private set; }
    }
}
