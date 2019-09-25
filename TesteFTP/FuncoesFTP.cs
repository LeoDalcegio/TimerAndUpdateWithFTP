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
                if (ValidaInformacaoDownload()) { //provavel q n vai precisar
                    try {
                        BaixarArquivoFTP(_dados._arquivoDownload, _dados._BaixarPara, _dados._usuario, 
                            _dados._senha);
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

        public void UploadArquivo() {
            if (ValidaInformacaoServidorFTP()) {
                if (!string.IsNullOrEmpty(_dados._arquivoUpload)) {
                    string urlArquivoEnviar = _dados._enderecoServidor + Path.GetFullPath(_dados._arquivoUpload);
                    try {
                        EnviarArquivoFTP(_dados._arquivoUpload, urlArquivoEnviar, _dados._usuario, _dados._senha);
                    }
                    catch (Exception ex) {
                        MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            } else {
                MessageBox.Show("Informações do servidor incompletas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidaInformacaoServidorFTP() {
            if (string.IsNullOrEmpty(_dados._usuario) || string.IsNullOrEmpty(_dados._senha) || string.IsNullOrEmpty(_dados._enderecoServidor)){
                return false;
            } else {
                return true;
            }
        }

        private bool ValidaInformacaoDownload() {
            if (string.IsNullOrEmpty(_dados._arquivoDownload) || string.IsNullOrEmpty(_dados._BaixarPara)) {
                return false;
            } else {
                return true;
            }
        }
    }
}
