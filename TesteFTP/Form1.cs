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

            // se usuario está reabrindo o app
            if (!string.IsNullOrEmpty(TxtUsuario.Text) && !string.IsNullOrEmpty(TxtSenha.Text) && !string.IsNullOrEmpty(txtEnderecoServidorFTP.Text)) {
                PreencheDadosUsuario();
                Tarefa tarefa = new Tarefa(HorarioAgendado, dados);
            }
    
        }

        // botao de salvar
        // Tarefa tarefa = new Tarefa(HorarioAgendado, dados);

        private void PreencheDadosUsuario() { 
            if (ValidaInformacaoServidorFTP()) {
                if (ValidaInformacaoDownload()) {
                    dados = new DadosUsuario(TxtUsuario.Text, TxtSenha.Text,
                    txtEnderecoServidorFTP.Text, TxtDirArqsServidor.Text, TxtDirArqLocal.Text);
                } else {
                    MessageBox.Show("Informações para download incorretas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            } else {
                MessageBox.Show("Informações do sevidor incorretas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }    

        private bool ValidaInformacaoServidorFTP() {        
            if (string.IsNullOrEmpty(TxtUsuario.Text) || string.IsNullOrEmpty(TxtSenha.Text) || string.IsNullOrEmpty(txtEnderecoServidorFTP.Text)){
                return false;
            } else {
                return true;
            }
        }

        private bool ValidaInformacaoDownload() {
            
            if ((TxtDirArqsServidor.Text == null) || string.IsNullOrEmpty(TxtDirArqLocal.Text)) {
                return false;
            } else {
                return true;
            }
        }

        private void BtnBaixarArquivo_Click(object sender, EventArgs e) {
            PreencheDadosUsuario();
            FuncoesFTP funcao = new FuncoesFTP(dados);
            funcao.DownloadArquivo();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}
