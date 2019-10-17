using System;
using System.Security;
using System.Windows.Forms;
using TesteFTP.ArqsEDiretorios;

namespace TesteFTP
{
    public partial class Form1 : Form
    {
        DadosUsuario dados;        

        public Form1() {
            InitializeComponent();

            // se usuario está reabrindo o app
            if (PreencheDadosUsuario(false) == false) {
                
                Tarefa tarefa = new Tarefa(HorarioAgendado, dados);
            }
    
        }

        // botao de salvar
        // Tarefa tarefa = new Tarefa(HorarioAgendado, dados);

        private bool PreencheDadosUsuario(bool exibeMsg = true) { 
            if (ValidaInformacaoServidorFTP()) {
                if (ValidaInformacaoDownload()) {
                    dados = new DadosUsuario(TxtUsuario.Text, TxtSenha.Text,
                    txtEnderecoServidorFTP.Text, TxtDirArqsServidor.Text, TxtDirArqLocal.Text);

                    return false;

                } else {
                    if (exibeMsg) {
                        MessageBox.Show("Informações para download incorretas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    return true;
                }
                
            } else {
                if (exibeMsg) {
                    MessageBox.Show("Informações do sevidor incorretas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                return true;
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

            if (PreencheDadosUsuario() == false) {
                Tarefa tarefa = new Tarefa(dados);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            if(dados == null) {
                dados = new DadosUsuario(TxtUsuario.Text, TxtSenha.Text,
                    txtEnderecoServidorFTP.Text, TxtDirArqsServidor.Text, TxtDirArqLocal.Text);
            }

            JSON json = new JSON(dados);
            
        }
    }
}
