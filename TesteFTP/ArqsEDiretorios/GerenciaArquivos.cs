using System;
using System.Collections.Generic;
using System.IO;

namespace TesteFTP
{
    class GerenciaArquivos
    {
        private readonly DadosUsuario _dados;

        private string[] LocaisArquivos;

        public List<string> ArqsBaixar = new List<string>();

        public GerenciaArquivos(DadosUsuario dados)
        {
            _dados = dados;

            ArqsBaixar = BuscaArquivosDownload(); //lista que será retornada aq, será usada no foreach
        }

        private List<string> BuscaArquivosDownload()
        {

            List<string> ArqABaixar = new List<string>();

            LocaisArquivos = Directory.GetFiles(_dados.DirArqServidor);

            foreach (string arq in LocaisArquivos)
            {
                if (ComparaArquivos(arq))
                {
                    ArqABaixar.Add(arq);
                }
            }
            return ArqABaixar;
        }

        private bool ComparaArquivos(string arqAtual)
        {

            string arqLocal = _dados.BaixarPara + Path.GetFileName(arqAtual);

            if (File.Exists(arqLocal))
            {
                if (VerificaAlteracao(arqAtual, arqLocal))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        private bool VerificaAlteracao(string caminhoArqServ, string caminhoArqLocal)
        {
            FileInfo arqServ = new FileInfo(caminhoArqServ);
            FileInfo arqLocal = new FileInfo(caminhoArqLocal);

            if (arqServ.LastWriteTime != arqLocal.LastWriteTime)
            {
                return true;
            }

            return false;
        }
    }
}
