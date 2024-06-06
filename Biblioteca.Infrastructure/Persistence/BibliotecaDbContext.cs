using Biblioteca.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Infrastructure.Persistence
{
    public class BibliotecaDbContext
    {
        public List<Book>? Books { get; set; }
        public List<Emprestimo>? Loans { get; set; }
    }
}
