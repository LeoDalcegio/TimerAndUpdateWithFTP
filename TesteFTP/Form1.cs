using System;
using System.Security;
using System.Windows.Forms;

namespace TesteFTP
{
    public partial class Form1 : Form
    {
        DadosUsuario dados;

        public Form1() {
            InitializeComponent();
            Tarefa tarefa = new Tarefa(horarioAgendado); // vai controlar o timer e os download auto
            
        }
        // da de fazer tb pra qndo alterar algo da tela essa alteração vai para o set da var
        // correspondente da DadosUsuario e dai passo a instancia dela como parametro, 
        // faz mais sentido para futura manutenção
        private void PreencheDadosUsuario() {
            dados = new DadosUsuario(txtUsuario.Text, txtSenha.Text, 
                txtEnderecoServidorFTP.Text, txtArquivoUpload.Text, txtArquivoUpload.Text, 
                txtBaixarPara.Text);
        }

        private void btnEnviarArquivo_Click(object sender, EventArgs e) {
            PreencheDadosUsuario();
            Funcoes funcao = new Funcoes(dados);
            funcao.UploadArquivo();
        }

        private void btnBaixarArquivo_Click(object sender, EventArgs e) {
            PreencheDadosUsuario();
            Funcoes funcao = new Funcoes(dados);
            funcao.DownloadArquivo();
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
    }
}
