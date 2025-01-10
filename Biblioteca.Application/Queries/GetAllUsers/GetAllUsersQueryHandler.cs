using Biblioteca.Core.DTOs;
using Biblioteca.Core.Repositories;
using MediatR;

namespace Biblioteca.Application.Queries.GetAllUsers
{
    public class GetAllUsersQueryHandler(IUserRepository userRepository) : IRequestHandler<GetAllUsersQuery, List<UserDTO>>
    {
        public async Task<List<UserDTO>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            return await userRepository.GetAllUsersAsync();
        }
    }
}
