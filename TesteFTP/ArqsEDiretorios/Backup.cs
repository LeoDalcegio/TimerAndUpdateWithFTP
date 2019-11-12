using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteFTP.Util;

namespace TesteFTP
{
    class Backup 
    {
        readonly DadosUsuario _dados;
        readonly List<string> _arqsParaBkp;
        readonly string _pastaBackup;

        public Backup(DadosUsuario dados, List<string> arqsParaBkp) 
        {
            
            _dados = dados;
            _arqsParaBkp = arqsParaBkp;
            Diretorios diretorios = new Diretorios(dados);
            _pastaBackup = diretorios.DiretorioBackup();
            VerificaSePastaExiste();
        }

        void VerificaSePastaExiste() 
        {

            if (!Directory.Exists(_pastaBackup)) {

                Directory.CreateDirectory(_pastaBackup);
            }
        }


        // foi feito desta forma pois assim, evita com que além de não precisar ler o arquivo
        // e copiar para outra pasta, depois excluir ele antes de fazer o download.
        public void RealizaBackup() 
        {
            string arqAnterior;
            foreach (string arq in _arqsParaBkp) {
                arqAnterior = _dados.BaixarPara + '\\' + Path.GetFileName(arq);
                if (File.Exists(arqAnterior)){
                    File.Move(arqAnterior, _pastaBackup);
                }
            }
        }
    }
}
