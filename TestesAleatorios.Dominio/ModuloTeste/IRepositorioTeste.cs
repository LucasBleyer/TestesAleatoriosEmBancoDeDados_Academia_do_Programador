using FluentValidation.Results;
using TestesAleatorios.Dominio.Compartilhado;
using TestesAleatorios.Dominio.ModuloDisciplina;

namespace TestesAleatorios.Dominio.ModuloTeste
{
    public interface IRepositorioTeste : IRepositorio<Teste>
    {
        ValidationResult Inserir(Teste teste);
    }
}
