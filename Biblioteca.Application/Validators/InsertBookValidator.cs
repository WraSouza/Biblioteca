using Biblioteca.Application.Commands.BookCommands;
using FluentValidation;

namespace Biblioteca.Application.Validators
{
    public class InsertBookValidator : AbstractValidator<InsertBookCommand>
    {
        public InsertBookValidator()
        {
            RuleFor(p => p.Titulo)
                .MaximumLength(200)
                .WithMessage("Título Deve Conter no Máximo 200 Caracteres");

            RuleFor(p => p.Titulo)
                .NotNull()
                .WithMessage("O Nome do Autor Deve Ser Preenchido");

            RuleFor(p => p.AnoPublicacao)
                .NotNull()
                .WithMessage("O Ano de Publicação Não Pode Ser Vazio");

            RuleFor(p => p.AnoPublicacao)
                 .NotNull()
                .WithMessage("Título Deve Conter no Máximo 200 Caracteres");
        }
    }
}
