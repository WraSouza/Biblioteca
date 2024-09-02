using Biblioteca.Core.Enums;
using MediatR;

namespace Biblioteca.Application.Commands.LoanCommand
{
    public class InsertLoanCommand : IRequest<int>
    {
        public int IdUsuario { get; private set; }
        public int IdBook { get; private set; }
        public BookStatusEnum Status { get; private set; }
        public DateTime DataEmprestimo { get; private set; }
        public DateTime? DataDevolucao { get; private set; }
    }
}
