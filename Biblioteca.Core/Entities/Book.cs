using Biblioteca.Core.Enums;

namespace Biblioteca.Core.Entities
{
    public class Book : BaseEntity
    {
        public Book(string? titulo, string? autor, string? iSBN, int anoPublicacao)
        {
            Titulo = titulo;
            Autor = autor;
            ISBN = iSBN;
            AnoPublicacao = anoPublicacao;
            StatusBook = BookStatusEnum.Available;
        }

        public string? Titulo { get; private set; }
        public string? Autor { get; private set; }
        public string? ISBN { get; private set; }
        public int AnoPublicacao { get; private set; }
        public BookStatusEnum StatusBook { get; private set; }
    }
}
