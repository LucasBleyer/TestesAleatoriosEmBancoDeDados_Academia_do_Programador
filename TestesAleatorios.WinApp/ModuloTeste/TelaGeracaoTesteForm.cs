using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TestesAleatorios.Dominio.ModuloDisciplina;
using TestesAleatorios.Dominio.ModuloMateria;
using TestesAleatorios.Dominio.ModuloQuestao;
using TestesAleatorios.Dominio.ModuloTeste;
using TestesAleatorios.WinApp.Compartilhado;

namespace TestesAleatorios.WinApp.ModuloTeste
{
    public partial class TelaGeracaoTesteForm : Form
    {
        private Teste teste;
        IRepositorioQuestao repositorioQuestao;
        List<Questao> questoesTeste = new List<Questao>();
        ValidadorRegex validador = new ValidadorRegex();
        private List<Materia> materias;

        public TelaGeracaoTesteForm(IRepositorioQuestao repositorioQuestao, List<Questao> questoes, List<Disciplina> disciplinas, List<Materia> materias)
        {
            this.repositorioQuestao = repositorioQuestao;
            InitializeComponent();
            CarregarDisciplinas(disciplinas);
            this.materias = materias;
        }

        public Func<Teste, ValidationResult> GravarRegistro { get; set; }

        public Teste Teste
        {
            get { return teste; }
            set
            {
                teste = value;

                txtNumero.Text = teste.Numero.ToString();
                txtTitulo.Text = teste.Titulo;
                cbDisciplina.SelectedItem = teste.Disciplina;
                cbMateria.SelectedItem = teste.Materia;
                dtpData.Value = teste.Data;
                txtQuantidade.Text = teste.NumeroQuestoes.ToString();
            }
        }

        private void TelaCadastroTestesForm_Load(object sender, EventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }

        private void TelaCadastroTestesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }

        private void CarregarDisciplinas(List<Disciplina> disciplinas)
        {
            cbDisciplina.Items.Clear();

            foreach (var item in disciplinas)
            {
                cbDisciplina.Items.Add(item);
            }
        }

        private void CarregarMaterias(List<Materia> materias, string disciplinaSelecionada)
        {
            cbMateria.Items.Clear();

            foreach (var item in materias)
            {
                if (item.Disciplina.Nome == disciplinaSelecionada)
                    cbMateria.Items.Add(item);
            }
        }

        private void btnGerarQuestoes_Click(object sender, EventArgs e)
        {
            btnGerarQuestoes.Enabled = false;

            int countNumeroQuestao = 1;
            var random = new Random();

            if (checkBoxRecuperacao.Checked)
            {
                var todasQuestoes = repositorioQuestao.SelecionarTodos()
                            .Where(x => x.Disciplina.Nome == cbDisciplina.Text);

                var todasQuestoesEmbaralhadas = todasQuestoes.OrderBy(item => random.Next()).ToList();

                if (int.Parse(txtQuantidade.Text) > todasQuestoes.Count())
                {
                    MessageBox.Show("Verifique a matéria e a disciplina selecionadas e se há um número de questões suficiente" +
                        " para gerar um teste com a quantidadee digitada",
                    "Cadastro de Questão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnGerarQuestoes.Enabled = true;
                    return;
                }

                for (int i = 0; i < int.Parse(txtQuantidade.Text); i++)
                {
                    questoesTeste.Add(todasQuestoesEmbaralhadas.ElementAt(i));
                }

                listBoxQuestoes.Items.Clear();

                foreach (var item in questoesTeste)
                {
                    listBoxQuestoes.Items.Add(countNumeroQuestao + "- " + item.ToString());
                    countNumeroQuestao++;
                }
            }
            else
            {
                var disciplinaQuestoes = repositorioQuestao.SelecionarTodos()
                                .Where(x => x.Disciplina.Nome == cbDisciplina.Text)
                                .Where(x => x.Materia.Nome == cbMateria.Text)
                                .ToList();

                var disciplinaQuestoesEmbaralhadas = disciplinaQuestoes.OrderBy(item => random.Next()).ToList();

                if (int.Parse(txtQuantidade.Text) > disciplinaQuestoes.Count())
                {
                    MessageBox.Show("Verifique a matéria e a disciplina selecionadas e se há um número de questões suficiente" +
                        " para gerar um teste com a quantidade digitada",
                    "Cadastro de Questão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnGerarQuestoes.Enabled = true;
                    return;
                }

                for (int i = 0; i < int.Parse(txtQuantidade.Text); i++)
                {
                    questoesTeste.Add(disciplinaQuestoesEmbaralhadas.ElementAt(i));
                }

                listBoxQuestoes.Items.Clear();

                foreach (var item in questoesTeste)
                {
                    listBoxQuestoes.Items.Add(countNumeroQuestao + "- " + item.ToString());
                    countNumeroQuestao++;
                }
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (validador.ApenasNumero(txtNumero.Text))
            {
                teste.Numero = int.Parse(txtNumero.Text);
                teste.Titulo = txtTitulo.Text;
                teste.NumeroQuestoes = int.Parse(txtQuantidade.Text);
                teste.Disciplina = (Disciplina)cbDisciplina.SelectedItem;
                teste.Data = dtpData.Value.Date;
                teste.Questoes = questoesTeste;
                try
                {
                    teste.Materia = (Materia)cbMateria.SelectedItem;
                } catch 
                {
                    Materia novaMateria = new Materia();
                    novaMateria.Nome = "Todas";
                    teste.Materia = novaMateria;

                }

                var resultadoValidacao = GravarRegistro(teste);

                if (resultadoValidacao.IsValid == false)
                {
                    string erro = resultadoValidacao.Errors[0].ErrorMessage;

                    TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                    MessageBox.Show("Verifique os campos preenchidos e tente novamente",
                    "Geração de TestesAleatorios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                    DialogResult = DialogResult.None;
                }
            }
            else
            {
                MessageBox.Show("Digite apenas números no campo 'Quantidade de Questões'",
                "Cadastro de Questão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void checkBoxRecuperacao_MouseClick(object sender, MouseEventArgs e)
        {
            cbMateria.Items.Add("Todas");
            int index = cbMateria.Items.Count;
            cbMateria.SelectedIndex = index - 1;
            cbMateria.Enabled = false;
            checkBoxRecuperacao.Enabled = false;
        }

        private void cbDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarMaterias(materias, cbDisciplina.Text);
        }
    }
}
