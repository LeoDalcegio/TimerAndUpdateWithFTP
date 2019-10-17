using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteFTP.Util
{
    class Diretorios
    {
        DadosUsuario _dados;

        public Diretorios(DadosUsuario dados)
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

        public void CriaDiretorio(string diretorio)
        {
            if (!Directory.Exists(diretorio))
            {
                Directory.CreateDirectory(diretorio);
            }
            else
            {
            }
        }
    }
}
