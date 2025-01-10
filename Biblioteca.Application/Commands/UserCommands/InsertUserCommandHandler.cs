using Biblioteca.Core.Entities;
using Biblioteca.Core.Repositories;
using MediatR;

namespace Biblioteca.Application.Commands.UserCommands
{
    public class InsertUserCommandHandler(IUserRepository userRepository) : IRequestHandler<InsertUserCommand, int>
    {
        public async Task<int> Handle(InsertUserCommand request, CancellationToken cancellationToken)
        {
            var user = new Usuario(request.Nome, request.Email);

            int id = await userRepository.CreateAsync(user);

            return id;
        }
    }
}

