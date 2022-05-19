namespace TestesAleatorios.WinApp.ModuloQuestao
{
    partial class TelaCadastroQuestaoForm
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
            this.labelDisciplina = new System.Windows.Forms.Label();
            this.labelMateria = new System.Windows.Forms.Label();
            this.labelEnunciado = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtEnunciado = new System.Windows.Forms.TextBox();
            this.cbDisciplina = new System.Windows.Forms.ComboBox();
            this.cbMateria = new System.Windows.Forms.ComboBox();
            this.labelLinha = new System.Windows.Forms.Label();
            this.labelResposta = new System.Windows.Forms.Label();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.checkBoxRespostaCorreta = new System.Windows.Forms.CheckBox();
            this.btnAdicionarResposta = new System.Windows.Forms.Button();
            this.listBoxAlternativas = new System.Windows.Forms.ListBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(27, 18);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(63, 20);
            this.labelNumero.TabIndex = 0;
            this.labelNumero.Text = "Número";
            // 
            // labelDisciplina
            // 
            this.labelDisciplina.AutoSize = true;
            this.labelDisciplina.Location = new System.Drawing.Point(16, 57);
            this.labelDisciplina.Name = "labelDisciplina";
            this.labelDisciplina.Size = new System.Drawing.Size(74, 20);
            this.labelDisciplina.TabIndex = 1;
            this.labelDisciplina.Text = "Disciplina";
            // 
            // labelMateria
            // 
            this.labelMateria.AutoSize = true;
            this.labelMateria.Location = new System.Drawing.Point(30, 100);
            this.labelMateria.Name = "labelMateria";
            this.labelMateria.Size = new System.Drawing.Size(60, 20);
            this.labelMateria.TabIndex = 2;
            this.labelMateria.Text = "Matéria";
            // 
            // labelEnunciado
            // 
            this.labelEnunciado.AutoSize = true;
            this.labelEnunciado.Location = new System.Drawing.Point(12, 139);
            this.labelEnunciado.Name = "labelEnunciado";
            this.labelEnunciado.Size = new System.Drawing.Size(78, 20);
            this.labelEnunciado.TabIndex = 3;
            this.labelEnunciado.Text = "Enunciado";
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(96, 15);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(239, 27);
            this.txtNumero.TabIndex = 4;
            // 
            // txtEnunciado
            // 
            this.txtEnunciado.Location = new System.Drawing.Point(96, 136);
            this.txtEnunciado.Multiline = true;
            this.txtEnunciado.Name = "txtEnunciado";
            this.txtEnunciado.Size = new System.Drawing.Size(438, 103);
            this.txtEnunciado.TabIndex = 5;
            // 
            // cbDisciplina
            // 
            this.cbDisciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDisciplina.FormattingEnabled = true;
            this.cbDisciplina.Location = new System.Drawing.Point(96, 54);
            this.cbDisciplina.Name = "cbDisciplina";
            this.cbDisciplina.Size = new System.Drawing.Size(239, 28);
            this.cbDisciplina.TabIndex = 6;
            this.cbDisciplina.SelectedIndexChanged += new System.EventHandler(this.cbDisciplina_SelectedIndexChanged);
            // 
            // cbMateria
            // 
            this.cbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMateria.FormattingEnabled = true;
            this.cbMateria.Location = new System.Drawing.Point(96, 97);
            this.cbMateria.Name = "cbMateria";
            this.cbMateria.Size = new System.Drawing.Size(239, 28);
            this.cbMateria.TabIndex = 7;
            // 
            // labelLinha
            // 
            this.labelLinha.AutoSize = true;
            this.labelLinha.Location = new System.Drawing.Point(-45, 253);
            this.labelLinha.Name = "labelLinha";
            this.labelLinha.Size = new System.Drawing.Size(759, 20);
            this.labelLinha.TabIndex = 8;
            this.labelLinha.Text = "_________________________________________________________________________________" +
    "____________________________________________";
            // 
            // labelResposta
            // 
            this.labelResposta.AutoSize = true;
            this.labelResposta.Location = new System.Drawing.Point(21, 301);
            this.labelResposta.Name = "labelResposta";
            this.labelResposta.Size = new System.Drawing.Size(69, 20);
            this.labelResposta.TabIndex = 9;
            this.labelResposta.Text = "Resposta";
            // 
            // txtResposta
            // 
            this.txtResposta.Location = new System.Drawing.Point(96, 298);
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(239, 27);
            this.txtResposta.TabIndex = 10;
            // 
            // checkBoxRespostaCorreta
            // 
            this.checkBoxRespostaCorreta.AutoSize = true;
            this.checkBoxRespostaCorreta.Location = new System.Drawing.Point(96, 331);
            this.checkBoxRespostaCorreta.Name = "checkBoxRespostaCorreta";
            this.checkBoxRespostaCorreta.Size = new System.Drawing.Size(144, 24);
            this.checkBoxRespostaCorreta.TabIndex = 11;
            this.checkBoxRespostaCorreta.Text = "Resposta Correta";
            this.checkBoxRespostaCorreta.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarResposta
            // 
            this.btnAdicionarResposta.Location = new System.Drawing.Point(352, 298);
            this.btnAdicionarResposta.Name = "btnAdicionarResposta";
            this.btnAdicionarResposta.Size = new System.Drawing.Size(182, 27);
            this.btnAdicionarResposta.TabIndex = 12;
            this.btnAdicionarResposta.Text = "Adicionar Resposta";
            this.btnAdicionarResposta.UseVisualStyleBackColor = true;
            this.btnAdicionarResposta.Click += new System.EventHandler(this.btnAdicionarResposta_Click);
            // 
            // listBoxAlternativas
            // 
            this.listBoxAlternativas.FormattingEnabled = true;
            this.listBoxAlternativas.ItemHeight = 20;
            this.listBoxAlternativas.Location = new System.Drawing.Point(21, 394);
            this.listBoxAlternativas.Name = "listBoxAlternativas";
            this.listBoxAlternativas.Size = new System.Drawing.Size(513, 104);
            this.listBoxAlternativas.TabIndex = 13;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(310, 546);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(109, 46);
            this.btnGravar.TabIndex = 14;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(425, 546);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 46);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaCadastroQuestaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 601);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.listBoxAlternativas);
            this.Controls.Add(this.btnAdicionarResposta);
            this.Controls.Add(this.checkBoxRespostaCorreta);
            this.Controls.Add(this.txtResposta);
            this.Controls.Add(this.labelResposta);
            this.Controls.Add(this.labelLinha);
            this.Controls.Add(this.cbMateria);
            this.Controls.Add(this.cbDisciplina);
            this.Controls.Add(this.txtEnunciado);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.labelEnunciado);
            this.Controls.Add(this.labelMateria);
            this.Controls.Add(this.labelDisciplina);
            this.Controls.Add(this.labelNumero);
            this.Name = "TelaCadastroQuestaoForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Questões";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Label labelDisciplina;
        private System.Windows.Forms.Label labelMateria;
        private System.Windows.Forms.Label labelEnunciado;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtEnunciado;
        private System.Windows.Forms.ComboBox cbDisciplina;
        private System.Windows.Forms.ComboBox cbMateria;
        private System.Windows.Forms.Label labelLinha;
        private System.Windows.Forms.Label labelResposta;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.CheckBox checkBoxRespostaCorreta;
        private System.Windows.Forms.Button btnAdicionarResposta;
        private System.Windows.Forms.ListBox listBoxAlternativas;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
    }
}