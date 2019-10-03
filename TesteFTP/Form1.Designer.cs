namespace TesteFTP
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEnderecoServidorFTP = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.TxtDirArqsServidor = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnBaixarArquivo = new System.Windows.Forms.Button();
            this.TxtDirArqLocal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.HorarioAgendado = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEnderecoServidorFTP);
            this.groupBox1.Controls.Add(this.TxtSenha);
            this.groupBox1.Controls.Add(this.TxtDirArqsServidor);
            this.groupBox1.Controls.Add(this.TxtUsuario);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servidor FTP";
            // 
            // txtEnderecoServidorFTP
            // 
            this.txtEnderecoServidorFTP.Location = new System.Drawing.Point(73, 54);
            this.txtEnderecoServidorFTP.Name = "txtEnderecoServidorFTP";
            this.txtEnderecoServidorFTP.Size = new System.Drawing.Size(294, 20);
            this.txtEnderecoServidorFTP.TabIndex = 3;
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(267, 20);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(100, 20);
            this.TxtSenha.TabIndex = 2;
            // 
            // TxtDirArqsServidor
            // 
            this.TxtDirArqsServidor.Location = new System.Drawing.Point(73, 90);
            this.TxtDirArqsServidor.Name = "TxtDirArqsServidor";
            this.TxtDirArqsServidor.Size = new System.Drawing.Size(294, 20);
            this.TxtDirArqsServidor.TabIndex = 7;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(73, 20);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(100, 20);
            this.TxtUsuario.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Local:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Endereço:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnBaixarArquivo);
            this.groupBox3.Controls.Add(this.TxtDirArqLocal);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(9, 141);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(379, 97);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Download";
            // 
            // BtnBaixarArquivo
            // 
            this.BtnBaixarArquivo.Location = new System.Drawing.Point(14, 46);
            this.BtnBaixarArquivo.Name = "BtnBaixarArquivo";
            this.BtnBaixarArquivo.Size = new System.Drawing.Size(353, 28);
            this.BtnBaixarArquivo.TabIndex = 9;
            this.BtnBaixarArquivo.Text = "Baixar arquivos";
            this.BtnBaixarArquivo.UseVisualStyleBackColor = true;
            this.BtnBaixarArquivo.Click += new System.EventHandler(this.BtnBaixarArquivo_Click);
            // 
            // TxtDirArqLocal
            // 
            this.TxtDirArqLocal.Location = new System.Drawing.Point(73, 20);
            this.TxtDirArqLocal.Name = "TxtDirArqLocal";
            this.TxtDirArqLocal.Size = new System.Drawing.Size(294, 20);
            this.TxtDirArqLocal.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Baixar para:";
            // 
            // HorarioAgendado
            // 
            this.HorarioAgendado.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HorarioAgendado.Location = new System.Drawing.Point(196, 41);
            this.HorarioAgendado.Name = "HorarioAgendado";
            this.HorarioAgendado.ShowUpDown = true;
            this.HorarioAgendado.Size = new System.Drawing.Size(100, 20);
            this.HorarioAgendado.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Horário para verificar arquivos";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.HorarioAgendado);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(10, 253);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(378, 89);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Download e verificação automática";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 470);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnderecoServidorFTP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnBaixarArquivo;
        private System.Windows.Forms.TextBox TxtDirArqLocal;
        private System.Windows.Forms.TextBox TxtDirArqsServidor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker HorarioAgendado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

