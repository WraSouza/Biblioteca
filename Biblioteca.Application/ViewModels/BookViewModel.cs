using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Application.ViewModels
{
    public class BookViewModel
    {
        public BookViewModel(string? titulo, string? autor)
        {
            Titulo = titulo;
            Autor = autor;
        }

        public string? Titulo {  get; set; }
        public string? Autor { get; set; }
    }
}
