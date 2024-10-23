namespace arquivos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCaminho = new TextBox();
            txtNomeArquivos = new TextBox();
            txtQuantidade = new TextBox();
            btnFolder = new Button();
            btnCriar = new Button();
            label4 = new Label();
            txtNomePasta = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Caminho";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome dos arquivos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(224, 97);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 2;
            label3.Text = "Quantidade";
            // 
            // txtCaminho
            // 
            txtCaminho.Location = new Point(12, 27);
            txtCaminho.Name = "txtCaminho";
            txtCaminho.Size = new Size(246, 23);
            txtCaminho.TabIndex = 3;
            // 
            // txtNomeArquivos
            // 
            txtNomeArquivos.Location = new Point(12, 115);
            txtNomeArquivos.Name = "txtNomeArquivos";
            txtNomeArquivos.Size = new Size(206, 23);
            txtNomeArquivos.TabIndex = 4;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(224, 115);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(69, 23);
            txtQuantidade.TabIndex = 5;
            // 
            // btnFolder
            // 
            btnFolder.Location = new Point(264, 26);
            btnFolder.Name = "btnFolder";
            btnFolder.Size = new Size(29, 23);
            btnFolder.TabIndex = 6;
            btnFolder.Text = "...";
            btnFolder.UseVisualStyleBackColor = true;
            btnFolder.Click += btnFolder_Click;
            // 
            // btnCriar
            // 
            btnCriar.Location = new Point(12, 144);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(281, 23);
            btnCriar.TabIndex = 7;
            btnCriar.Text = "Criar";
            btnCriar.UseVisualStyleBackColor = true;
            btnCriar.Click += btnCriar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 53);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 8;
            label4.Text = "Nome da pasta";
            // 
            // txtNomePasta
            // 
            txtNomePasta.Location = new Point(12, 71);
            txtNomePasta.Name = "txtNomePasta";
            txtNomePasta.Size = new Size(281, 23);
            txtNomePasta.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 180);
            Controls.Add(txtNomePasta);
            Controls.Add(label4);
            Controls.Add(btnCriar);
            Controls.Add(btnFolder);
            Controls.Add(txtQuantidade);
            Controls.Add(txtNomeArquivos);
            Controls.Add(txtCaminho);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Criador de arquivos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCaminho;
        private TextBox txtNomeArquivos;
        private TextBox txtQuantidade;
        private Button btnFolder;
        private Button btnCriar;
        private Label label4;
        private TextBox txtNomePasta;
    }
}
