
namespace TesteFTP
{
    class DadosUsuario
    {
        public string Usuario { get; }
        public string Senha { get; }
        public string EnderecoServidor { get; }
        public string DirArqServidor { get; }
        public string BaixarPara { get; }

        public DadosUsuario(string usuario, string senha, string enderecoServidor, string dirArqServ, string baixarPara) {
            Usuario = usuario;
            Senha = senha;
            EnderecoServidor = enderecoServidor;
            DirArqServidor = dirArqServ;
            BaixarPara = baixarPara;
        }  
    }
}
