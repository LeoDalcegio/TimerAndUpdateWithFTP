using System;
using System.IO;
using System.Windows.Forms;

namespace TesteFTP
{
    class FuncoesFTP : FTP
    {
        private DadosUsuario _dados;

        public FuncoesFTP(DadosUsuario dados) 
        {
            _dados = dados;
        }

        public void DownloadArquivo()
        {
            try {
                BaixarArquivoFTP(_dados.DirArqServidor, _dados.BaixarPara, _dados.Usuario,
                    _dados.Senha);
            }
            catch (Exception ex) {
                MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
