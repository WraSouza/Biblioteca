using Biblioteca.Application.Commands.UserCommands;
using Biblioteca.Core.Entities;
using Biblioteca.Core.Repositories;
using MediatR;

namespace Biblioteca.Application.Commands.UserCommands
{
    public class InsertUserCommandHandler : IRequestHandler<InsertUserCommand, int>
    {
        private readonly IUserRepository _userRepository;
        public InsertUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<int> Handle(InsertUserCommand request, CancellationToken cancellationToken)
        {
            var user = new Usuario(request.Nome, request.Email);

            int id = _userRepository.Create(user);

            return id;
        }
    }
}

