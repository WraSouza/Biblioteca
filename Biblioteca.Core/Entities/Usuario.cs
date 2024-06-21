using Biblioteca.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Core.Entities
{
    public class Usuario : BaseEntity
    {
        public Usuario(string? nome, string? email)
        {
            Nome = nome;
            Email = email;
            UserStatus = UserStatusEnum.Created;
            LivrosEmprestados = new();
        }

        public string? Nome { get; private set; }
        public string? Email { get; private set; }
        public UserStatusEnum UserStatus { get; private set; }
        public List<Book> LivrosEmprestados { get; private set; }

        public void Bloquear()
        {
            if(UserStatus == UserStatusEnum.Created)
            {
                UserStatus = UserStatusEnum.Blocked;
            }
        }
    }
}
