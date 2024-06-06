namespace Biblioteca.Application.InputModels
{
    public class InsertBookInputModel
    {
        public string? Titulo { get; set; }
        public string? Autor { get; set; }
        public string? Isbn { get; set; }
        public int AnoPublicacao { get; set; }
    }
}
