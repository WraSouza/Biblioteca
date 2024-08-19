using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Core.DTOs
{
    public class InsertBookDTO
    {
        public InsertBookDTO(string? titulo, string? autor, string? isbn, int anoPublicacao)
        {
            Titulo = titulo;
            Autor = autor;
            Isbn = isbn;
            AnoPublicacao = anoPublicacao;
        }

        public string? Titulo { get; set; }
        public string? Autor { get; set; }
        public string? Isbn { get; set; }
        public int AnoPublicacao { get; set; }
    }
}
