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
using TestesAleatorios.WinApp.Compartilhado;

namespace TestesAleatorios.WinApp.ModuloMateria
{
    public partial class TelaCadastroMateriaForm : Form
    {
        private Materia materia;
        ValidadorRegex validador = new ValidadorRegex();

        public TelaCadastroMateriaForm(List<Disciplina> disciplinas)
        {
            InitializeComponent();
            CarregarDisciplinas(disciplinas);
            CarregarSeries();
        }

        public Func<Materia, ValidationResult> GravarRegistro { get; set; }

        public Materia Materia
        {
            get { return materia; }
            set
            {
                materia = value;

                txtNumero.Text = materia.Numero.ToString();
                txtNome.Text = materia.Nome;
                cbDisciplina.SelectedItem = materia.Disciplina;
                cbSerie.SelectedItem = materia.Serie;
            }
        }

        private void TelaCadastroMateriasForm_Load(object sender, EventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }

        private void TelaCadastroMateriasForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void CarregarSeries()
        {
            cbSerie.Items.Clear();
            cbSerie.Items.Add("1ª Série");
            cbSerie.Items.Add("2ª Série");
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (validador.ApenasLetra(txtNome.Text))
            {
                materia.Numero = int.Parse(txtNumero.Text);
                materia.Nome = txtNome.Text;
                materia.Serie = cbSerie.Text;
                materia.Disciplina = (Disciplina)cbDisciplina.SelectedItem;

                var resultadoValidacao = GravarRegistro(materia);

                if (resultadoValidacao.IsValid == false)
                {
                    string erro = resultadoValidacao.Errors[0].ErrorMessage;

                    TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                    DialogResult = DialogResult.None;

                    MessageBox.Show("Verifique os campos preenchidos e tente novamente",
                    "Cadastro de Matérias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Digite apenas letras no campo 'Nome'",
                "Cadastro de Matérias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

    }
}
