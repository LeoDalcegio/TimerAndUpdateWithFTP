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

        public Diretorios() {

        }

        public Diretorios(DadosUsuario dados)
        {
            _dados = dados;
        }

        public string DiretorioBackup() 
        {
            if (_dados == null) return " ";  
            return _dados.BaixarPara + "\\Backup";

        }

        public string DiretorioDadosTelaXML()
        {
            return Path.GetTempPath() + "\\BackupDadosTela\\";
        }

        public void CriaDiretorio(string diretorio)
        {
            if (!Directory.Exists(diretorio))
            {
                Directory.CreateDirectory(diretorio);
            }
        }

        public async void EscreveArquivo(string diretorio)
        {
            UnicodeEncoding uniencoding = new UnicodeEncoding();

            byte[] result = uniencoding.GetBytes(diretorio);

            using (FileStream SourceStream = File.Open(diretorio, FileMode.OpenOrCreate)) {
                SourceStream.Seek(0, SeekOrigin.End);
                await SourceStream.WriteAsync(result, 0, result.Length);
            }
        }
    }
}
