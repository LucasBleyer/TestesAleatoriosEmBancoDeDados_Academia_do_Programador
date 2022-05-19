using TestesAleatorios.WinApp.Compartilhado;

namespace TestesAleatorios.WinApp.ModuloQuestao
{
    public class ConfiguracaoToolboxQuestao : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Controle de Questões";

        public override string TooltipInserir => "Inserir uma nova questão";

        public override string TooltipExcluir => "Excluir uma questão existente";

        public override bool EditarHabilitado { get { return false; } }

        public override string TooltipEditar => "Você não pode editar uma questão";

        public override string TooltipGerarPdf => "Você não pode gerar um PDF de uma questão";
    }
}
