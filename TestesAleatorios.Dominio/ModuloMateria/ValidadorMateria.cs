using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesAleatorios.Dominio.ModuloMateria
{
    public class ValidadorMateria : AbstractValidator<Materia>
    {
        public ValidadorMateria()
        {
            RuleFor(x => x.Nome)
               .NotNull()
               .NotEmpty()
               .MinimumLength(3);

            RuleFor(x => x.Disciplina)
                .NotNull()
                .NotEmpty();

            RuleFor(x => x.Serie)
                .NotNull()
                .NotEmpty();
        }
    }
}
