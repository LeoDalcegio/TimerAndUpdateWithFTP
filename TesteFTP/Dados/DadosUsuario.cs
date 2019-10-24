
namespace TesteFTP
{
    class DadosUsuario
    {
        public string Usuario { get; set; }
        public string Senha { get; }
        public string EnderecoServidor { get; set; }
        public string DirArqServidor { get; set; }
        public string BaixarPara { get; set; }

        public DadosUsuario(string usuario, string senha, string enderecoServidor, string dirArqServ, string baixarPara) {
            Usuario = usuario;
            Senha = senha;
            EnderecoServidor = enderecoServidor;
            DirArqServidor = dirArqServ;
            BaixarPara = baixarPara;
        }  
    }
}
