using System;
using System.Collections.Generic;
using System.IO;
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
        public string LocalDownload { get; }
        public string BaixarPara { get; }

        public DadosUsuario(string usuario, string senha, string enderecoServidor, string localDownload, string baixarPara) {
            Usuario = usuario;
            Senha = senha;
            EnderecoServidor = enderecoServidor;
            LocalDownload = localDownload;
            BaixarPara = baixarPara;
        }  
    }
}
