using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestesAleatorios.Dominio.Compartilhado;

namespace TestesAleatorios.Dominio.ModuloQuestao
{
    public interface IRepositorioQuestao : IRepositorio<Questao>
    {
        ValidationResult Inserir(Questao questao);

        List<Questao> SelecionarQuestoesPorMateria(string nomeMateria);

        List<Questao> SelecionarQuestoesPorDisciplina(string nomeDisciplina);
    }
}
    