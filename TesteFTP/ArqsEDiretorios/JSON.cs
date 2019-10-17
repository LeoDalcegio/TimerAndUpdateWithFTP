using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteFTP.ArqsEDiretorios
{
    class JSON
    {
        DadosUsuario _dados;

        public JSON(DadosUsuario dados) {
            _dados = dados;
        }

        public JSON() {
            
        }


        public void SalvaDadosTela() {
            // busca _dados e salva num JSON, colocar em outra classe para salvar, funcoesJSON e JSON
            // colocar em outra classe "Util" o diretorio do salvar json e dir bkp
        }

        public DadosUsuario BuscaDadosTela() {
            
            // busca no dir JSON e retorna DadosUsuario
            //loop no arqJSON
            return dadosBkp;
        }
    }
}
