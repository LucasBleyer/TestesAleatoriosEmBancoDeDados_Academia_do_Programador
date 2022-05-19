using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesAleatorios.Infra.Arquivos.Compartilhado.Serializadores
{
    public interface ISerializador
    {
        DataContext CarregarDadosDoArquivo();
        void GravarDadosEmArquivo(DataContext dados);
    }
}
