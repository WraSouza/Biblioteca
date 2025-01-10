using Biblioteca.Core.Enums;
using MediatR;

namespace Biblioteca.Application.Commands.LoanCommand
{
    public class InsertLoanCommand : IRequest<int>
    {
        public int IdUsuario { get; set; }
        public int IdBook { get; set; }
        public BookStatusEnum Status { get; set; }
        public DateTime DataEmprestimo { get; private set; }
        public DateTime? DataDevolucao { get; set; }
    }
}
