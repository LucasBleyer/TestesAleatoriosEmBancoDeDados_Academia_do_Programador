using System;
using System.Windows.Forms;
using TestesAleatorios.Dominio.ModuloDisciplina;
using FluentValidation.Results;
using TestesAleatorios.WinApp.Compartilhado;

namespace TestesAleatorios.WinApp.ModuloDisciplina
{
    public partial class TelaCadastroDisciplinaForm : Form
    {
        private Disciplina disciplina;
        ValidadorRegex validador = new ValidadorRegex();

        public TelaCadastroDisciplinaForm()
        {
            InitializeComponent();
            txtNumero.Text = "";
        }

        public Func<Disciplina, ValidationResult> GravarRegistro { get; set; }

        public Disciplina Disciplina
        {
            get { return disciplina; }
            set
            {
                disciplina = value;

                txtNumero.Text = disciplina.Numero.ToString();

                txtNome.Text = disciplina.Nome;
            }
        }

        private void TelaCadastroDisciplinasForm_Load(object sender, EventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }

        private void TelaCadastroDisciplinasForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if(validador.ApenasLetra(txtNome.Text))
            { 
                disciplina.Numero = int.Parse(txtNumero.Text);
                disciplina.Nome = txtNome.Text;

                var resultadoValidacao = GravarRegistro(disciplina);

                if (resultadoValidacao.IsValid == false)
                {
                    string erro = resultadoValidacao.Errors[0].ErrorMessage;

                    TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                    DialogResult = DialogResult.None;

                    MessageBox.Show("Verifique os campos preenchidos e tente novamente",
                    "Cadastro de Disciplinas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Digite apenas letras no campo 'Nome'",
                "Cadastro de Disciplinas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
    }
}
