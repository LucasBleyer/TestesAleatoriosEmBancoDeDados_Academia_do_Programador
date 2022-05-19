using FluentValidation;
using TestesAleatorios.Dominio.ModuloQuestao;

namespace TestesAleatorios.Dominio.ModuloTeste
{
    public class ValidadorTeste : AbstractValidator<Teste>
    {
        public ValidadorTeste()
        {
            RuleFor(x => x.Titulo)
               .NotNull()
               .NotEmpty()
               .MinimumLength(3);

            RuleFor(x => x.Disciplina)
                .NotNull()
                .NotEmpty();

            RuleFor(x => x.Materia)
                .NotNull()
                .NotEmpty();

            RuleFor(x => (int)x.NumeroQuestoes)
                .NotNull()
                .NotEmpty()
                .GreaterThan(4);
        }
    }
}
