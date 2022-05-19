using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestesAleatorios.WinApp.Compartilhado;

namespace TestesAleatorios.WinApp.ModuloMateria
{
    public class ConfiguracaoToolboxMateria : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Controle de Matérias";

        public override string TooltipInserir => "Inserir uma nova matéria";

        public override string TooltipEditar => "Editar uma matéria existente";

        public override string TooltipExcluir => "Excluir uma matéria existente";

        public override string TooltipGerarPdf => "Você não pode gerar um PDF de uma matéria";
    }
}
