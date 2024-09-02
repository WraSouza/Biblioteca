namespace Biblioteca.Core.DTOs
{
    public class BookDTO
    {
        public BookDTO(string? titulo, string? autor, string statusBook)
        {
            Titulo = titulo;
            Autor = autor;
            StatusBook = statusBook;
        }

        public string? Titulo { get; set; }
        public string? Autor { get; set; }
        public string StatusBook { get; set; }
    }
}
