using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestesAleatorios.WinApp.Compartilhado;

namespace TestesAleatorios.WinApp.ModuloTeste
{
    public class ConfiguracaoToolboxTeste : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Controle de TestesAleatorios";

        public override string TooltipInserir => "Gerar um teste aleatório";

        public override string TooltipExcluir => "Excluir um teste existente";

        public override string TooltipEditar => "Você não pode editar um teste";

        public override string TooltipGerarPdf => "Gerar PDF de um teste";

        public override string TooltipDuplicar => "Duplicar um teste";

        public override bool GerarPdfHabilitado { get { return true; } }

        public override bool DuplicarHabilitado { get { return true; } }

        public override bool EditarHabilitado { get { return false; } }
       
    }
}
