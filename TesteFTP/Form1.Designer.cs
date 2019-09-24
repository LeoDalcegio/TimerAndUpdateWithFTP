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
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnEnviarArquivo = new System.Windows.Forms.Button();
            this.txtArquivoUpload = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBaixarArquivo = new System.Windows.Forms.Button();
            this.txtBaixarPara = new System.Windows.Forms.TextBox();
            this.txtArquivoDownload = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.horarioAgendado = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEnderecoServidorFTP);
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 100);
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
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(267, 20);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 2;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(73, 20);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 1;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnProcurar);
            this.groupBox2.Controls.Add(this.btnEnviarArquivo);
            this.groupBox2.Controls.Add(this.txtArquivoUpload);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(9, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 106);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Upload";
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(339, 41);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(28, 22);
            this.btnProcurar.TabIndex = 5;
            this.btnProcurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // btnEnviarArquivo
            // 
            this.btnEnviarArquivo.Location = new System.Drawing.Point(14, 68);
            this.btnEnviarArquivo.Name = "btnEnviarArquivo";
            this.btnEnviarArquivo.Size = new System.Drawing.Size(353, 28);
            this.btnEnviarArquivo.TabIndex = 6;
            this.btnEnviarArquivo.Text = "Enviar arquivo";
            this.btnEnviarArquivo.UseVisualStyleBackColor = true;
            this.btnEnviarArquivo.Click += new System.EventHandler(this.btnEnviarArquivo_Click);
            // 
            // txtArquivoUpload
            // 
            this.txtArquivoUpload.Location = new System.Drawing.Point(14, 42);
            this.txtArquivoUpload.Name = "txtArquivoUpload";
            this.txtArquivoUpload.Size = new System.Drawing.Size(319, 20);
            this.txtArquivoUpload.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Arquivo a Enviar: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBaixarArquivo);
            this.groupBox3.Controls.Add(this.txtBaixarPara);
            this.groupBox3.Controls.Add(this.txtArquivoDownload);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(9, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(379, 119);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Download";
            // 
            // btnBaixarArquivo
            // 
            this.btnBaixarArquivo.Location = new System.Drawing.Point(14, 80);
            this.btnBaixarArquivo.Name = "btnBaixarArquivo";
            this.btnBaixarArquivo.Size = new System.Drawing.Size(353, 28);
            this.btnBaixarArquivo.TabIndex = 9;
            this.btnBaixarArquivo.Text = "Baixar arquivo";
            this.btnBaixarArquivo.UseVisualStyleBackColor = true;
            this.btnBaixarArquivo.Click += new System.EventHandler(this.btnBaixarArquivo_Click);
            // 
            // txtBaixarPara
            // 
            this.txtBaixarPara.Location = new System.Drawing.Point(73, 54);
            this.txtBaixarPara.Name = "txtBaixarPara";
            this.txtBaixarPara.Size = new System.Drawing.Size(294, 20);
            this.txtBaixarPara.TabIndex = 8;
            // 
            // txtArquivoDownload
            // 
            this.txtArquivoDownload.Location = new System.Drawing.Point(73, 20);
            this.txtArquivoDownload.Name = "txtArquivoDownload";
            this.txtArquivoDownload.Size = new System.Drawing.Size(294, 20);
            this.txtArquivoDownload.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Baixar para:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Arquivo:";
            // 
            // horarioAgendado
            // 
            this.horarioAgendado.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horarioAgendado.Location = new System.Drawing.Point(276, 356);
            this.horarioAgendado.Name = "horarioAgendado";
            this.horarioAgendado.ShowUpDown = true;
            this.horarioAgendado.Size = new System.Drawing.Size(100, 20);
            this.horarioAgendado.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Horário para verificar arquivos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 386);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.horarioAgendado);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnderecoServidorFTP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnEnviarArquivo;
        private System.Windows.Forms.TextBox txtArquivoUpload;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBaixarArquivo;
        private System.Windows.Forms.TextBox txtBaixarPara;
        private System.Windows.Forms.TextBox txtArquivoDownload;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker horarioAgendado;
        private System.Windows.Forms.Label label4;
    }
}

