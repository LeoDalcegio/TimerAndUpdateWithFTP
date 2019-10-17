using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteFTP.Util;

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

        public FuncoesJSON()
        {

        }


        public void SalvaDadosTela()
        {
            
        }

        public DadosUsuario BuscaDadosTelaSalvo()
        {
            diretorios.CriaDiretorio(DiretorioDadosTela);


            // busca no dir JSON e retorna DadosUsuario
            //loop no arqJSON

        }
    }
}
