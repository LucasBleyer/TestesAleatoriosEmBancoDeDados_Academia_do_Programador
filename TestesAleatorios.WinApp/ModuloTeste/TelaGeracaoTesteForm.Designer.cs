namespace TestesAleatorios.WinApp.ModuloTeste
{
    partial class TelaGeracaoTesteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNumero = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelDisciplina = new System.Windows.Forms.Label();
            this.labelMateria = new System.Windows.Forms.Label();
            this.labelQntQuestoes = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.cbDisciplina = new System.Windows.Forms.ComboBox();
            this.cbMateria = new System.Windows.Forms.ComboBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.checkBoxRecuperacao = new System.Windows.Forms.CheckBox();
            this.labelData = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.labelDeQuestoes = new System.Windows.Forms.Label();
            this.btnGerarQuestoes = new System.Windows.Forms.Button();
            this.listBoxQuestoes = new System.Windows.Forms.ListBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(38, 19);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(63, 20);
            this.labelNumero.TabIndex = 0;
            this.labelNumero.Text = "Número";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(54, 57);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(47, 20);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Título";
            // 
            // labelDisciplina
            // 
            this.labelDisciplina.AutoSize = true;
            this.labelDisciplina.Location = new System.Drawing.Point(27, 96);
            this.labelDisciplina.Name = "labelDisciplina";
            this.labelDisciplina.Size = new System.Drawing.Size(74, 20);
            this.labelDisciplina.TabIndex = 2;
            this.labelDisciplina.Text = "Disciplina";
            // 
            // labelMateria
            // 
            this.labelMateria.AutoSize = true;
            this.labelMateria.Location = new System.Drawing.Point(41, 162);
            this.labelMateria.Name = "labelMateria";
            this.labelMateria.Size = new System.Drawing.Size(60, 20);
            this.labelMateria.TabIndex = 3;
            this.labelMateria.Text = "Matéria";
            // 
            // labelQntQuestoes
            // 
            this.labelQntQuestoes.AutoSize = true;
            this.labelQntQuestoes.Location = new System.Drawing.Point(14, 235);
            this.labelQntQuestoes.Name = "labelQntQuestoes";
            this.labelQntQuestoes.Size = new System.Drawing.Size(87, 20);
            this.labelQntQuestoes.TabIndex = 4;
            this.labelQntQuestoes.Text = "Quantidade";
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(107, 16);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(159, 27);
            this.txtNumero.TabIndex = 5;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(107, 54);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(312, 27);
            this.txtTitulo.TabIndex = 6;
            // 
            // cbDisciplina
            // 
            this.cbDisciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDisciplina.FormattingEnabled = true;
            this.cbDisciplina.Location = new System.Drawing.Point(107, 93);
            this.cbDisciplina.Name = "cbDisciplina";
            this.cbDisciplina.Size = new System.Drawing.Size(312, 28);
            this.cbDisciplina.TabIndex = 7;
            this.cbDisciplina.SelectedIndexChanged += new System.EventHandler(this.cbDisciplina_SelectedIndexChanged);
            // 
            // cbMateria
            // 
            this.cbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMateria.FormattingEnabled = true;
            this.cbMateria.Location = new System.Drawing.Point(107, 159);
            this.cbMateria.Name = "cbMateria";
            this.cbMateria.Size = new System.Drawing.Size(312, 28);
            this.cbMateria.TabIndex = 8;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(107, 239);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(159, 27);
            this.txtQuantidade.TabIndex = 9;
            // 
            // checkBoxRecuperacao
            // 
            this.checkBoxRecuperacao.AutoSize = true;
            this.checkBoxRecuperacao.Location = new System.Drawing.Point(173, 127);
            this.checkBoxRecuperacao.Name = "checkBoxRecuperacao";
            this.checkBoxRecuperacao.Size = new System.Drawing.Size(179, 24);
            this.checkBoxRecuperacao.TabIndex = 10;
            this.checkBoxRecuperacao.Text = "Prova de Recuperação";
            this.checkBoxRecuperacao.UseVisualStyleBackColor = true;
            this.checkBoxRecuperacao.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBoxRecuperacao_MouseClick);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(54, 204);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(41, 20);
            this.labelData.TabIndex = 11;
            this.labelData.Text = "Data";
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(107, 199);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(312, 27);
            this.dtpData.TabIndex = 12;
            // 
            // labelDeQuestoes
            // 
            this.labelDeQuestoes.AutoSize = true;
            this.labelDeQuestoes.Location = new System.Drawing.Point(11, 250);
            this.labelDeQuestoes.Name = "labelDeQuestoes";
            this.labelDeQuestoes.Size = new System.Drawing.Size(91, 20);
            this.labelDeQuestoes.TabIndex = 13;
            this.labelDeQuestoes.Text = "de Questões";
            // 
            // btnGerarQuestoes
            // 
            this.btnGerarQuestoes.Location = new System.Drawing.Point(14, 287);
            this.btnGerarQuestoes.Name = "btnGerarQuestoes";
            this.btnGerarQuestoes.Size = new System.Drawing.Size(405, 51);
            this.btnGerarQuestoes.TabIndex = 14;
            this.btnGerarQuestoes.Text = "Gerar Questões Aleatórias";
            this.btnGerarQuestoes.UseVisualStyleBackColor = true;
            this.btnGerarQuestoes.Click += new System.EventHandler(this.btnGerarQuestoes_Click);
            // 
            // listBoxQuestoes
            // 
            this.listBoxQuestoes.Enabled = false;
            this.listBoxQuestoes.FormattingEnabled = true;
            this.listBoxQuestoes.ItemHeight = 20;
            this.listBoxQuestoes.Location = new System.Drawing.Point(14, 395);
            this.listBoxQuestoes.Name = "listBoxQuestoes";
            this.listBoxQuestoes.Size = new System.Drawing.Size(405, 244);
            this.listBoxQuestoes.TabIndex = 15;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(205, 672);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(104, 47);
            this.btnGravar.TabIndex = 16;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(315, 672);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 47);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaGeracaoTesteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 730);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.listBoxQuestoes);
            this.Controls.Add(this.btnGerarQuestoes);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.checkBoxRecuperacao);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.cbMateria);
            this.Controls.Add(this.cbDisciplina);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.labelQntQuestoes);
            this.Controls.Add(this.labelMateria);
            this.Controls.Add(this.labelDisciplina);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.labelDeQuestoes);
            this.Name = "TelaGeracaoTesteForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geração de Teste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelDisciplina;
        private System.Windows.Forms.Label labelMateria;
        private System.Windows.Forms.Label labelQntQuestoes;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.ComboBox cbDisciplina;
        private System.Windows.Forms.ComboBox cbMateria;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.CheckBox checkBoxRecuperacao;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label labelDeQuestoes;
        private System.Windows.Forms.Button btnGerarQuestoes;
        private System.Windows.Forms.ListBox listBoxQuestoes;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
    }
}