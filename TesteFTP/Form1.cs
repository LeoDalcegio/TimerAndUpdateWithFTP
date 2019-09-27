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
