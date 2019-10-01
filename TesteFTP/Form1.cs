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

        private void PreencheDadosUsuario() { //valida form
            // ValidaDadosUsuario()
            dados = new DadosUsuario(TxtUsuario.Text, TxtSenha.Text, 
                txtEnderecoServidorFTP.Text, TxtLocalDownload.Text, TxtBaixarPara.Text);
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
