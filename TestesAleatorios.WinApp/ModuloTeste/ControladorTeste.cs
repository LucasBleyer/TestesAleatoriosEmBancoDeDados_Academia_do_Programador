using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using TestesAleatorios.Dominio.ModuloDisciplina;
using TestesAleatorios.Dominio.ModuloMateria;
using TestesAleatorios.Dominio.ModuloQuestao;
using TestesAleatorios.Dominio.ModuloTeste;
using TestesAleatorios.WinApp.Compartilhado;

namespace TestesAleatorios.WinApp.ModuloTeste
{
    public class ControladorTeste : ControladorBase
    {
        private readonly IRepositorioTeste repositorioTeste;
        private readonly IRepositorioQuestao repositorioQuestao;
        private readonly IRepositorioMateria repositorioMateria;
        private readonly IRepositorioDisciplina repositorioDisciplina;

        private TabelaTesteControl tabelaTestes;
        public ControladorTeste(IRepositorioTeste repositorioTeste, IRepositorioQuestao repositorioQuestao, IRepositorioMateria repositorioMateria, IRepositorioDisciplina repositorioDisciplina)
        {
            this.repositorioTeste = repositorioTeste;
            this.repositorioQuestao = repositorioQuestao;
            this.repositorioMateria = repositorioMateria;
            this.repositorioDisciplina = repositorioDisciplina;
        }

        public void Duplicar()
        {
            Teste testeSelecionado = ObtemTesteSelecionado();

            if (testeSelecionado == null)
            {
                MessageBox.Show("Selecione um teste primeiro",
                "Duplicação de TestesAleatorios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Teste testeDuplicado = new Teste();
            CopiaTeste(testeSelecionado, testeDuplicado);

            var disciplinas = repositorioDisciplina.SelecionarTodos();
            var materias = repositorioMateria.SelecionarTodos();
            var questoes = repositorioQuestao.SelecionarTodos();

            TelaGeracaoTesteForm tela = new TelaGeracaoTesteForm(repositorioQuestao, questoes, disciplinas, materias);
            tela.Teste = testeDuplicado;

            tela.GravarRegistro = repositorioTeste.Inserir;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarTestes();
            }

        }

        private static void CopiaTeste(Teste testeSelecionado, Teste testeDuplicado)
        {
            testeDuplicado.Titulo = testeSelecionado.Titulo;
            testeDuplicado.Disciplina = testeSelecionado.Disciplina;
            testeDuplicado.Materia = testeSelecionado.Materia;
            testeDuplicado.Data = testeSelecionado.Data;
            testeDuplicado.NumeroQuestoes = testeSelecionado.NumeroQuestoes;
        }

        public void GerarPdf()
        {
            Teste testeSelecionado = ObtemTesteSelecionado();

            string nomeArquivo = @"C:\Users\luisy\Documents\dados.pdf";

            FileStream arquivoPdf = new FileStream(nomeArquivo, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            PdfWriter escritorPdf = PdfWriter.GetInstance(doc, arquivoPdf);

            doc.Open();
            string dados = "";

            Paragraph paragrafoTitulo = new Paragraph(dados);

            paragrafoTitulo.Alignment = Element.ALIGN_CENTER;
            paragrafoTitulo.Add(testeSelecionado.Titulo+"\n");
            paragrafoTitulo.Add("Disciplina: "+testeSelecionado.Disciplina+"\n");
            paragrafoTitulo.Add("Matéria: "+testeSelecionado.Materia+"\n");
            paragrafoTitulo.Add("Data: "+testeSelecionado.Data.Date+"\n\n\n");
            
            Paragraph paragrafoQuestoes = new Paragraph(dados);
            paragrafoQuestoes.Alignment = Element.ALIGN_LEFT;

            var questoes = testeSelecionado.Questoes;

            foreach (var questao in questoes)
            {
                CriarCelula(questao.Enunciado);
                paragrafoQuestoes.Add(questao.Enunciado.ToString()+"\n");
            }

            doc.Open();
            doc.Add(paragrafoTitulo);
            doc.Add(paragrafoQuestoes);
            doc.Close();

            MessageBox.Show("PDF gerado com sucesso",
            "Gerãção de PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private static PdfPCell CriarCelula(string texto)
        {
            var celula = new PdfPCell(new Phrase("Código"));

            return celula;
        }

        public override void Inserir()
        {
            var disciplinas = repositorioDisciplina.SelecionarTodos();
            var materias = repositorioMateria.SelecionarTodos();
            var questoes = repositorioQuestao.SelecionarTodos();

            TelaGeracaoTesteForm tela = new TelaGeracaoTesteForm(repositorioQuestao, questoes, disciplinas, materias);
            tela.Teste = new Teste();

            tela.GravarRegistro = repositorioTeste.Inserir;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarTestes();
            }
        }
        public override void Excluir()
        {
            Teste testeSelecionado = ObtemTesteSelecionado();

            if (testeSelecionado == null)
            {
                MessageBox.Show("Selecione um teste primeiro",
                "Exclusão de TestesAleatorios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir o teste?",
                "Exclusão de TestesAleatorios", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioTeste.Excluir(testeSelecionado);
                CarregarTestes();
            }
        }

        public override UserControl ObtemListagem()
        {
            if (tabelaTestes == null)
                tabelaTestes = new TabelaTesteControl();

            CarregarTestes();

            return tabelaTestes;
        }

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxTeste();
        }


        private Teste ObtemTesteSelecionado()
        { 
            var numero = tabelaTestes.ObtemNumeroTesteSelecionado();

            return repositorioTeste.SelecionarPorNumero(numero);
        }

        private void CarregarTestes()
        {
            List<Teste> testes = repositorioTeste.SelecionarTodos();

            tabelaTestes.AtualizarRegistros(testes);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {testes.Count} teste(s)");
        }

    }
}
