using Biblioteca.Core.Entities;
using Biblioteca.Core.Repositories;
using MediatR;

namespace Biblioteca.Application.Commands.LoanCommand
{
    public class InsertLoanCommandHandler(ILoanRepository loanRepository) : IRequestHandler<InsertLoanCommand, int>
    {        
        public async Task<int> Handle(InsertLoanCommand request, CancellationToken cancellationToken)
        {
            var loan = new Emprestimo(request.IdUsuario, request.IdBook, request.DataDevolucao);

            int id = await loanRepository.CreateAsync(loan);

            return id;
        }
    }
}
