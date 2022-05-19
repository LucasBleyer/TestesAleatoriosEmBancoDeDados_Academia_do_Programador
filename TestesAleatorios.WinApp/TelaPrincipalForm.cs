using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TestesAleatorios.Infra.Arquivos.Compartilhado.Serializadores;
using TestesAleatorios.Infra.Arquivos.ModuloDisciplina;
using TestesAleatorios.Infra.Arquivos.ModuloMateria;
using TestesAleatorios.Infra.Arquivos.ModuloQuestao;
using TestesAleatorios.Infra.Arquivos.ModuloTeste;
using TestesAleatorios.Infra.BancoDeDados.ModuloDisciplina;
using TestesAleatorios.WinApp.Compartilhado;
using TestesAleatorios.WinApp.ModuloDisciplina;
using TestesAleatorios.WinApp.ModuloMateria;
using TestesAleatorios.WinApp.ModuloQuestao;
using TestesAleatorios.WinApp.ModuloTeste;

namespace TestesAleatorios.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;
        private Dictionary<string, ControladorBase> controladores;
        private DataContext contextoDados;

        public TelaPrincipalForm(DataContext contextoDados)
        {
            InitializeComponent();

            Instancia = this;

            labelRodape.Text = string.Empty;
            labelTipoCadastro.Text = string.Empty;

            this.contextoDados = contextoDados;

            InicializarControladores();
        }

        public static TelaPrincipalForm Instancia
        {
            get;
            private set;
        }

        public void AtualizarRodape(string mensagem)
        {
            labelRodape.Text = mensagem;
        }

        private void testesMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }

        private void questoesMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }

        private void materiasMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }

        private void disciplinasMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void btnGerarPdf_Click(object sender, EventArgs e)
        {
            ((ControladorTeste)controlador).GerarPdf();
        }

        private void btnDuplicar_Click(object sender, EventArgs e)
        {
            ((ControladorTeste)controlador).Duplicar();
        }

        private void ConfigurarBotoes(ConfiguracaoToolboxBase configuracao)
        {
            btnInserir.Enabled = configuracao.InserirHabilitado;
            btnEditar.Enabled = configuracao.EditarHabilitado;
            btnExcluir.Enabled = configuracao.ExcluirHabilitado;
            btnGerarPdf.Enabled = configuracao.GerarPdfHabilitado;
            btnDuplicar.Enabled = configuracao.DuplicarHabilitado;
        }

        private void ConfigurarTooltips(ConfiguracaoToolboxBase configuracao)
        {
            btnInserir.ToolTipText = configuracao.TooltipInserir;
            btnEditar.ToolTipText = configuracao.TooltipEditar;
            btnExcluir.ToolTipText = configuracao.TooltipExcluir;
            btnGerarPdf.ToolTipText = configuracao.TooltipGerarPdf;
            btnDuplicar.ToolTipText = configuracao.TooltipDuplicar;
        }

        private void ConfigurarTelaPrincipal(ToolStripMenuItem opcaoSelecionada)
        {
            var tipo = opcaoSelecionada.Text;

            controlador = controladores[tipo];            

            ConfigurarToolbox();

            ConfigurarListagem();
        }

        private void ConfigurarToolbox()
        {
            ConfiguracaoToolboxBase configuracao = controlador.ObtemConfiguracaoToolbox();

            if (configuracao != null)
            {
                toolbox.Enabled = true;

                labelTipoCadastro.Text = configuracao.TipoCadastro;

                ConfigurarTooltips(configuracao);

                ConfigurarBotoes(configuracao);
            }
        }

        private void ConfigurarListagem()
        {
            AtualizarRodape("");

            var listagemControl = controlador.ObtemListagem();

            panelRegistros.Controls.Clear();

            listagemControl.Dock = DockStyle.Fill;

            panelRegistros.Controls.Add(listagemControl);
        }

        private void InicializarControladores()
        {
            var repositorioTeste = new RepositorioTesteEmArquivo(contextoDados);
            var repositorioQuestao = new RepositorioQuestaoEmArquivo(contextoDados);
            var repositorioMateria = new RepositorioMateriaEmArquivo(contextoDados);
            var repositorioDisciplina = new RepositorioDisciplinaEmBancoDeDados();

            controladores = new Dictionary<string, ControladorBase>();

            controladores.Add("TestesAleatorios", new ControladorTeste(repositorioTeste, repositorioQuestao, repositorioMateria, repositorioDisciplina));
            controladores.Add("Questões", new ControladorQuestao(repositorioQuestao, repositorioMateria, repositorioDisciplina));
            controladores.Add("Disciplinas", new ControladorDisciplina(repositorioDisciplina));
            controladores.Add("Matérias", new ControladorMateria(repositorioMateria, repositorioDisciplina));
        }
    }
}
