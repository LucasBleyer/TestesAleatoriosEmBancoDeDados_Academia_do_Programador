using FluentValidation.Results;
using TestesAleatorios.Dominio.Compartilhado;

namespace TestesAleatorios.Dominio.ModuloMateria
{
    public interface IRepositorioMateria : IRepositorio<Materia>
    {
        ValidationResult Inserir(Materia materia);

        ValidationResult Editar(Materia materia);
    }
}
