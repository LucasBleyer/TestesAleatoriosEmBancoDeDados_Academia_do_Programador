using FluentValidation.Results;
using TestesAleatorios.Dominio.Compartilhado;

namespace TestesAleatorios.Dominio.ModuloDisciplina
{
    public interface IRepositorioDisciplina : IRepositorio<Disciplina>
    {
        ValidationResult Inserir(Disciplina disciplina);

        ValidationResult Editar(Disciplina disciplina);
    }
}
