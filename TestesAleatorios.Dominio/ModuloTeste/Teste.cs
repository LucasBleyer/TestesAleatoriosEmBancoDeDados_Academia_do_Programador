using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestesAleatorios.Dominio.Compartilhado;
using TestesAleatorios.Dominio.ModuloDisciplina;
using TestesAleatorios.Dominio.ModuloMateria;
using TestesAleatorios.Dominio.ModuloQuestao;

namespace TestesAleatorios.Dominio.ModuloTeste
{
    public class Teste : EntidadeBase<Teste>
    {
        private Teste testeSelecionado;

        public Teste()
        {
            Data = DateTime.Now;
        }

        public int NumeroQuestoes { get; set; }
        public string Titulo { get; set; }
        public Disciplina Disciplina { get; set; }
        public Materia Materia { get; set; }
        public DateTime Data { get; set; }
        public List<Questao> Questoes { get; set; }

        public override void Atualizar(Teste registro)
        {
            throw new NotImplementedException();
        }
    }
}
