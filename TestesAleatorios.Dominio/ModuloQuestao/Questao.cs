using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestesAleatorios.Dominio.Compartilhado;
using TestesAleatorios.Dominio.ModuloDisciplina;
using TestesAleatorios.Dominio.ModuloMateria;

namespace TestesAleatorios.Dominio.ModuloQuestao
{
    public class Questao : EntidadeBase<Questao>
    {
        public string Enunciado { get; set; }
        public char Resposta { get; set; }
        public Materia Materia { get; set; }

        public Disciplina Disciplina { get; set; }

        public List<string> Alternativas { get; set; }

        public override void Atualizar(Questao registro)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{Enunciado}";
        }
    }
}
