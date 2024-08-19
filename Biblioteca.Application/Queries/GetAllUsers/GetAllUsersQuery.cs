using Biblioteca.Core.DTOs;
using MediatR;

namespace Biblioteca.Application.Queries.GetAllUsers
{
    public class GetAllUsersQuery : IRequest<List<UserDTO>>
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public int UserStatus { get; set; }
    }
}
