using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestesAleatorios.WinApp.Compartilhado;

namespace TestesAleatorios.WinApp.ModuloDisciplina
{
    public class ConfiguracaoToolboxDisciplina : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Controle de Disciplinas";

        public override string TooltipInserir => "Inserir uma nova disciplina";

        public override string TooltipEditar => "Editar uma disciplina existente";

        public override string TooltipExcluir => "Excluir uma disciplina existente";

        public override string TooltipGerarPdf => "Você não pode gerar um PDF de uma disciplina";
    }
}
