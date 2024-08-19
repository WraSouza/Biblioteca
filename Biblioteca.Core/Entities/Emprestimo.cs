using Biblioteca.Core.Enums;

namespace Biblioteca.Core.Entities
{
    public class Emprestimo : BaseEntity
    {
        public Emprestimo(int idUsuario, int idBook)
        {
            IdUsuario = idUsuario;
            IdBook = idBook;

            Status = BookStatusEnum.Available;
            DataEmprestimo = DateTime.Now;
            DataDevolucao = DateTime.Now.AddDays(30);
        }

        public int IdUsuario { get; private set; }
        public int IdBook { get; private set; }
        public BookStatusEnum Status { get; private set; }
        public DateTime DataEmprestimo { get; private set; }
        public DateTime? DataDevolucao { get; private set; }

        public void SetAvailable()
        {
            if (Status == BookStatusEnum.Busy)
            {
                Status = BookStatusEnum.Available;
            }
        }
    }
}
