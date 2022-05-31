using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestesAleatorios.Dominio.Compartilhado;
using TestesAleatorios.Dominio.ModuloDisciplina;

namespace TestesAleatorios.Dominio.ModuloMateria
{
    public class Materia : EntidadeBase<Materia>
    {
        public string Nome { get; set; }
        public int Serie { get; set; }

        public Disciplina Disciplina { get; set; }

        public override void Atualizar(Materia registro)
        {
        }

        public override string ToString()
        {
            return $"{Nome}";
        }
    }
}
