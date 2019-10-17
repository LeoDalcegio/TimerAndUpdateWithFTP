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


        public FuncoesJSON(DadosUsuario dados)
        {
            _dados = dados;
            RetornaDiretorios diretorios = new RetornaDiretorios(dados);
            DiretorioDadosTela = diretorios.DiretorioDadosTelaJSON();
        }

        public FuncoesJSON()
        {

        }


        public void SalvaDadosTela()
        {
            // busca _dados e salva num JSON, colocar em outra classe para salvar, funcoesJSON e JSON
            // colocar em outra classe "Util" o diretorio do salvar json e dir bkp
        }

        public DadosUsuario BuscaDadosTela()
        {

            if (!Directory.Exists(DiretorioDadosTela))
            {

                Directory.CreateDirectory(DiretorioDadosTela);
                //JSON busca dados
            }
            else
            {
                //JSON busca dados
            }
            // busca no dir JSON e retorna DadosUsuario
            //loop no arqJSON
 
        }
    }
}
