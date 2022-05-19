using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestesAleatorios.Dominio.ModuloDisciplina;
using TestesAleatorios.Dominio.ModuloMateria;
using TestesAleatorios.Dominio.ModuloQuestao;

namespace TestesAleatorios.WinApp.ModuloQuestao
{
    public partial class TelaCadastroQuestaoForm : Form
    {
        private Questao questao;
        private List<Materia> materias;
        char[] alternativas = new char[] { 'A', 'B', 'C', 'D', 'E' };
        List<string> alternativasQuestao = new List<string>();
        char respostaCorreta;
        int countAlternativa = 0;

        public TelaCadastroQuestaoForm(List<Disciplina> disciplinas, List<Materia> materias)
        {
            InitializeComponent();
            CarregarDisciplinas(disciplinas);
            this.materias = materias;
        }

        public Func<Questao, ValidationResult> GravarRegistro { get; set; }

        public Questao Questao
        {
            get { return questao; }
            set
            {
                questao = value;

                txtNumero.Text = questao.Numero.ToString();
                cbDisciplina.SelectedItem = questao.Disciplina;
                cbMateria.SelectedItem = questao.Materia;
                txtEnunciado.Text = questao.Enunciado;
            }
        }

        private void TelaCadastroQuestoesForm_Load(object sender, EventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }

        private void TelaCadastroQuestoesForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (countAlternativa == 5) // verifica se a questão tem somente 5 alternativas, nem mais nem menos
            {
                bool contemCorreta = false;
                foreach(var item in alternativasQuestao) // percorre as alternativas e verifica se uma está marcada como correta
                {
                    if (item.Contains("CORRETA"))
                    {
                        contemCorreta = true;
                    }
                }

                if (contemCorreta)
                {
                    questao.Numero = int.Parse(txtNumero.Text);
                    questao.Enunciado = txtEnunciado.Text;
                    questao.Materia = (Materia)cbMateria.SelectedItem;
                    questao.Disciplina = (Disciplina)cbDisciplina.SelectedItem;
                    questao.Resposta = respostaCorreta;
                    questao.Alternativas = alternativasQuestao;

                    var resultadoValidacao = GravarRegistro(questao);

                    if (resultadoValidacao.IsValid == false)
                    {
                        string erro = resultadoValidacao.Errors[0].ErrorMessage;

                        TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                        MessageBox.Show("Verifique os campos preenchidos e tente novamente",
                        "Cadastro de Questão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;

                        DialogResult = DialogResult.None;
                    }
                }
                else
                {
                    MessageBox.Show("Você deve adicionar uma alternativa correta",
                    "Cadastro de Questão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

            }
            else
            {
                MessageBox.Show("Você deve adicionar 5 alternativas à questão",
                "Cadastro de Questão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btnAdicionarResposta_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResposta.Text) && countAlternativa <= 4)
            {
                if (checkBoxRespostaCorreta.Checked)
                {
                    listBoxAlternativas.Items.Add(alternativas[countAlternativa] + ") " + txtResposta.Text + " [CORRETA] ");
                    respostaCorreta = alternativas[countAlternativa];
                    checkBoxRespostaCorreta.Checked = false;
                    checkBoxRespostaCorreta.Enabled = false;
                    alternativasQuestao.Add(alternativas[countAlternativa] + ") " + txtResposta.Text + " [CORRETA] ");
                    txtResposta.Clear();

                }
                else
                {
                    listBoxAlternativas.Items.Add(alternativas[countAlternativa] + ") " + txtResposta.Text);
                    alternativasQuestao.Add(alternativas[countAlternativa] + ") " + txtResposta.Text);
                }

                countAlternativa++;
                txtResposta.Clear();
            }
            else
            {
                MessageBox.Show("Você deve adicionar 5 alternativas e nenhuma delas pode ser vazia",
                "Cadastro de Alternativas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void cbDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarMaterias(materias, cbDisciplina.Text);
        }

    }
}
