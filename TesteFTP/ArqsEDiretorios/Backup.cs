using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteFTP
{
    class Backup
    {
        DadosUsuario _dados;
        List<string> _arqsParaBkp;
        string pastaBackup;

        public Backup(DadosUsuario dados, List<string> arqsParaBkp) {
            _dados = dados;
            _arqsParaBkp = arqsParaBkp;
            pastaBackup = _dados.BaixarPara + "\\Backup"; // utilizar parâmetro
            VerificaSePastaExiste();
        }

        void VerificaSePastaExiste() {

            if (!Directory.Exists(pastaBackup)) {

                Directory.CreateDirectory(pastaBackup);

                RealizaBackup();

            } else {
                RealizaBackup();
            }
        }


        // foi feito desta forma pois assim, evita com que além de não precisar ler o arquivo
        // e copiar para outra pasta, depois excluir ele antes de fazer o download.
        void RealizaBackup() {
            string arqAnterior;
            foreach (string arq in _arqsParaBkp) {
                arqAnterior = _dados.BaixarPara + '\\' + Path.GetFileName(arq);
                if (File.Exists(arqAnterior)){
                    File.Move(arqAnterior, pastaBackup);
                }
            }
        }
    }
}
