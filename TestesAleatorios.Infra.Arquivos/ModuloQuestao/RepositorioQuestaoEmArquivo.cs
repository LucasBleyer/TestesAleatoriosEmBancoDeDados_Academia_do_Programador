using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestesAleatorios.Dominio.Compartilhado;
using TestesAleatorios.Dominio.ModuloQuestao;
using TestesAleatorios.Infra.Arquivos.Compartilhado.Serializadores;

namespace TestesAleatorios.Infra.Arquivos.ModuloQuestao
{
    public class RepositorioQuestaoEmArquivo : RepositorioEmArquivoBase<Questao>, IRepositorioQuestao
    {
        public RepositorioQuestaoEmArquivo(DataContext dataContext) : base(dataContext)
        {
            if (dataContext.Questoes.Count > 0)
                contador = dataContext.Questoes.Max(x => x.Numero);
        }

        public override List<Questao> ObterRegistros()
        {
            return dataContext.Questoes;
        }

        public override AbstractValidator<Questao> ObterValidador()
        {
            return new ValidadorQuestao();
        }

        public List<Questao> SelecionarQuestoesPorDisciplina(string nomeDisciplina)
        {
            return ObterRegistros()
                .Where(x => x.Disciplina.Nome == nomeDisciplina)
                .ToList();
        }

        public List<Questao> SelecionarQuestoesPorMateria(string nomeMateria)
        {
            return ObterRegistros()
                .Where(x => x.Materia.Nome == nomeMateria)
                .ToList();
        }
    }
}
