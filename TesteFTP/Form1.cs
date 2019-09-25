using System;
using System.Security;
using System.Windows.Forms;

namespace TesteFTP
{
    public partial class Form1 : Form
    {
        DadosUsuario dados;
        Tarefa tarefa;

        public Form1() {
            InitializeComponent();
            if (!string.IsNullOrEmpty(TxtUsuario.Text) && !string.IsNullOrEmpty(TxtSenha.Text) && !string.IsNullOrEmpty(txtEnderecoServidorFTP.Text)) {
                PreencheDadosUsuario();
                tarefa = new Tarefa(HorarioAgendado, dados);
            } else {
                tarefa = new Tarefa(HorarioAgendado);
            }

            // cada vez q altero algo eu vou lá e tarefa._dados.alterado, 
            // p qndo chegar no timer se tiver esses dados eu usar eles
        }

        private void PreencheDadosUsuario() {
            dados = new DadosUsuario(TxtUsuario.Text, TxtSenha.Text, 
                txtEnderecoServidorFTP.Text, TxtArquivoUpload.Text, TxtArquivoUpload.Text, 
                TxtBaixarPara.Text);
        }

        private void BtnEnviarArquivo_Click(object sender, EventArgs e) {
            PreencheDadosUsuario();
            FuncoesFTP funcao = new FuncoesFTP(dados);
            funcao.UploadArquivo();
        }

        private void BtnBaixarArquivo_Click(object sender, EventArgs e) {
            PreencheDadosUsuario();
            FuncoesFTP funcao = new FuncoesFTP(dados);
            funcao.DownloadArquivo();
        }

        private void BtnProcurar_Click(object sender, EventArgs e) {
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
                    TxtArquivoUpload.Text = ofd1.FileName;
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
    }
}
