namespace Biblioteca.Core.DTOs
{
    public class UserDTO
    {
        public UserDTO(string? nome, string? email, int userStatus)
        {
            Nome = nome;
            Email = email;
            UserStatus = userStatus;
        }

        public string? Nome { get; set; }
        public string? Email { get; set; }
        public int UserStatus { get; set; }
    }
}
