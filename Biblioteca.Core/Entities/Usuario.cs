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
        }

        public string? Nome { get; private set; }
        public string? Email { get; private set; }
    }
}
