using System;
using System.IO;
using System.Windows.Forms;

namespace TesteFTP
{
    class Funcoes:FTP
    {
        DadosUsuario dados;

        public Funcoes(DadosUsuario dados) {
            
        }

        public void DownloadArquivo() {
            if (ValidaInformacaoServidorFTP()) {
                if (ValidaInformacaoDownload()) {
                    try {
                        BaixarArquivoFTP(dados._arquivoDownload, dados._BaixarPara, dados._usuario, 
                            dados._senha);
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
                if (!string.IsNullOrEmpty(dados._arquivoUpload)) {
                    string urlArquivoEnviar = dados._enderecoServidor + Path.GetFullPath(dados._arquivoUpload);
                    try {
                        EnviarArquivoFTP(dados._arquivoUpload, urlArquivoEnviar, dados._usuario, dados._senha);
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
            if (string.IsNullOrEmpty(dados._usuario) || string.IsNullOrEmpty(dados._senha) || string.IsNullOrEmpty(dados._enderecoServidor) {
                return false;
            } else {
                return true;
            }
        }

        private bool ValidaInformacaoDownload() {
            if (string.IsNullOrEmpty(dados._arquivoDownload) || string.IsNullOrEmpty(dados._BaixarPara)) {
                return false;
            } else {
                return true;
            }
        }
    }
}
