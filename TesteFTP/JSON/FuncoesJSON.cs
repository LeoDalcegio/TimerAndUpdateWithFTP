using System;
using System.Collections.Generic;
using System.IO;
using TesteFTP.Util;
using System.Web.Script.Serialization;
using System.Text;

namespace TesteFTP.JSON
{
    class FuncoesJSON 
    {
        readonly DadosUsuario _dados;
        readonly string DiretorioDadosTela;
        readonly Diretorios diretorios;

        public FuncoesJSON(DadosUsuario dados)
        {
            _dados = dados;
            diretorios = new Diretorios(dados);
            DiretorioDadosTela = diretorios.DiretorioDadosTelaJSON();
        }

        public void SalvaDadosTela()
        {
            var json = new JavaScriptSerializer().Serialize(_dados);
            
            diretorios.CriaDiretorio(DiretorioDadosTela);

            diretorios.EscreveArquivo(DiretorioDadosTela);

        }

        public DadosUsuario BuscaDadosTelaSalvo()
        {
            string texto = System.IO.File.ReadAllText(DiretorioDadosTela);

            var json = new JavaScriptSerializer().Deserialize(texto);
            
            JObject obj = JObject.Parse(json);
            _dados.BaixarPara = (string) obj["BaixarPara"];
            _dados.DirArqServidor = (string) obj["DirArqServidor"];
            _dados.EnderecoServidor = (string) obj["EnderecoServidor"];
            _dados.Senha = (string) obj["Senha"];
            _dados.Usuario = (string) obj["Usuario"];

            return _dados;
        }     
    }
}
