using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteFTP
{
    class DadosUsuario
    {
        public string Usuario { get; }
        public string Senha { get; }
        public string EnderecoServidor { get; }
        public string ArquivoDownload { get; }
        public string BaixarPara { get; }

        public DadosUsuario(string usuario, string senha, string enderecoServidor, string arquivoDownload, string baixarPara) {
            Usuario = usuario;
            Senha = senha;
            EnderecoServidor = enderecoServidor;
            ArquivoDownload = arquivoDownload;
            BaixarPara = baixarPara;
        }  
    }
}
