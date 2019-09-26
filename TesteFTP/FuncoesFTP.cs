using System;
using System.IO;
using System.Windows.Forms;

namespace TesteFTP
{
    class FuncoesFTP:FTP
    {
        private DadosUsuario _dados;

        public FuncoesFTP(DadosUsuario dados) {
            _dados = dados;
        }

        public void DownloadArquivo() {
            if (ValidaInformacaoServidorFTP()) {
                if (ValidaInformacaoDownload()) {
                    try {
                        BaixarArquivoFTP(_dados.ArquivoDownload, _dados.BaixarPara, _dados.Usuario, 
                            _dados.Senha);
                    }
                    catch (Exception ex) {
                        MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else {
                    MessageBox.Show("Informações para download incompletas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                MessageBox.Show("Informações do sevidor incompletas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidaInformacaoServidorFTP() {
            if (string.IsNullOrEmpty(_dados.Usuario) || string.IsNullOrEmpty(_dados.Senha) || string.IsNullOrEmpty(_dados.EnderecoServidor)){
                return false;
            } else {
                return true;
            }
        }

        private bool ValidaInformacaoDownload() {
            if (string.IsNullOrEmpty(_dados.ArquivoDownload) || string.IsNullOrEmpty(_dados.BaixarPara)) {
                return false;
            } else {
                return true;
            }
        }
    }
}
