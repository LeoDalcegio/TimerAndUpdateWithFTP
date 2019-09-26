using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteFTP
{
    class DadosUsuario
    {
        public string _usuario { get; }
        public string _senha { get; }
        public string _enderecoServidor { get; }
        public string _arquivoDownload { get; }
        public string _BaixarPara { get; }

        public DadosUsuario(string usuario, string senha, string enderecoServidor, string arquivoDownload, string BaixarPara) {
            _usuario = usuario;
            _senha = senha;
            _enderecoServidor = enderecoServidor;
            _arquivoDownload = arquivoDownload;
            _BaixarPara = BaixarPara;
        }  
    }
}
