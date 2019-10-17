using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteFTP.Util
{
    class RetornaDiretorios
    {
        DadosUsuario _dados;

        public RetornaDiretorios(DadosUsuario dados)
        {
            _dados = dados;
        }

        public string DiretorioBackup()
        {
            return _dados.BaixarPara + "\\Backup";
        }

        public string DiretorioDadosTelaJSON()
        {
            return _dados.BaixarPara + "\\Backup\\DadosTela";
        }
    }
}
