using MediatR;

namespace Biblioteca.Application.Commands.BookCommands
{
    public class InsertBookCommand : IRequest<int>
    {
        public string? Titulo { get; set; }
        public string? Autor { get; set; }
        public string? Isbn { get; set; }
        public int AnoPublicacao { get; set; }
    }
}
