using MediatR;

namespace Biblioteca.Application.Commands.UserCommands
{
    public class InsertUserCommand : IRequest<int>
    {
        public string? Nome { get; set; }
        public string? Email { get; set; }
    }
}
