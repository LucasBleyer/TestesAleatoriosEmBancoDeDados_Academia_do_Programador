using TestesAleatorios.Dominio.Compartilhado;

namespace TestesAleatorios.Dominio.ModuloDisciplina
{
    public class Disciplina : EntidadeBase<Disciplina>
    {
        //public Disciplina()
        //{
        //}

        //public Disciplina(string nome)
        //{
        //    Nome = nome;
        //}

        public string Nome { get; set; }

        public override void Atualizar(Disciplina registro)
        {
        }

        public override string ToString()
        {
            return $"{Nome}";
        }

    }
}
