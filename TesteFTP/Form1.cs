using System;
using System.Security;
using System.IO;
using System.Windows.Forms;

namespace TesteFTP
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
            //thread? onStart(), sleep 1h e volta, ou timer
            // Windows Service com TopShelf 
        }

        FTP ftp = new FTP();

        private void btnEnviarArquivo_Click(object sender, EventArgs e) {
            if (validaInformacaoServidorFTP()) {
                if (!string.IsNullOrEmpty(txtArquivoUpload.Text)) {
                    string urlArquivoEnviar = txtEnderecoServidorFTP.Text + Path.GetFullPath(txtArquivoUpload.Text);
                    try {
                        ftp.EnviarArquivoFTP(txtArquivoUpload.Text, urlArquivoEnviar, txtUsuario.Text, txtSenha.Text);
                    }
                    catch (Exception ex) {
                        MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            } else {
                MessageBox.Show("Informações do servidor incompletas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e) {
            OpenFileDialog ofd1 = new OpenFileDialog();

            ofd1.Multiselect = false;
            ofd1.Title = "Selecionar Arquivos";
            ofd1.InitialDirectory = @"C:\Dados\";

            ofd1.Filter = "All files (*.*)|*.*";
            ofd1.CheckFileExists = true;
            ofd1.CheckPathExists = true;
            ofd1.RestoreDirectory = true;

            DialogResult dr = ofd1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK) {
                try {
                    txtArquivoUpload.Text = ofd1.FileName;
                }
                catch (SecurityException ex) {
                    MessageBox.Show("Erro de segurança.\n\n" +
                                                "Mensagem : " + ex.Message + "\n\n");
                }
                catch (Exception ex) {
                    MessageBox.Show("Você pode não ter permissão para ler o arquivo , ou " +
                                               " ele pode estar corrompido.\n\nErro reportado : " + ex.Message);
                }
            }
        }

        private void btnBaixarArquivo_Click(object sender, EventArgs e) {
            if (validaInformacaoServidorFTP()) {
                if (validaInformacaoDownload()) {
                    try {
                        ftp.BaixarArquivoFTP(txtArquivoDownload.Text, txtBaixarPara.Text, txtUsuario.Text, txtSenha.Text);
                    }catch(Exception ex) {
                        MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else {
                    MessageBox.Show("Informações para download incompletas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                MessageBox.Show("Informações do sevidor incompletas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validaInformacaoServidorFTP() {
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtSenha.Text) || string.IsNullOrEmpty(txtEnderecoServidorFTP.Text)) {
                return false;
            } else {
                return true;
            }
        }

        private bool validaInformacaoDownload() {
            if (string.IsNullOrEmpty(txtArquivoDownload.Text) || string.IsNullOrEmpty(txtBaixarPara.Text)) {
                return false;
            } else {
                return true;
            }
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {
            
        }
    }
}
