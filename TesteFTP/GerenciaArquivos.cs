using System;
using System.Collections.Generic;
using System.IO;

namespace TesteFTP
{
    class GerenciaArquivos
    {
        private DadosUsuario _dados;
        
        private string[] Arquivos;
        
        public GerenciaArquivos(DadosUsuario dados) {
            _dados = dados;
        }

        public List<string> BuscaArquivosDownload() {

            List<string> ArqABaixar = new List<string>();

            Arquivos = Directory.GetFiles(_dados.LocalDownload);

            foreach (string arq in Arquivos) {
                if (ComparaArquivos(arq)) {
                    ArqABaixar.Add(arq);
                }

            }

            return ArqABaixar;

        }

        private bool ComparaArquivos(string arqAtual) {
     
            string arq = _dados.BaixarPara + '/' + Path.GetFileNameWithoutExtension(arqAtual);
            if (System.IO.File.Exists(arq)){
                if (VerificaAlteracao(arq, )) {
                    return true;
                } else {
                    return false;
                }
            }

            return false;
            //verifica se o arqAtual existe na outra pasta (_dados.BaixarPara)
            // horario alteração diferente, true, adiciona em ArqBaixar
        }

        private bool VerificaAlteracao(string caminhoArqServ, string caminhoArqLocal) {

        }

        // método que retorna list com quais arq eu devo baixar
        // pegar todos os "arq" do _dados.ArquivoDownload(mudar nome)
        // com as extensões escolhidas e comparar as datas de cada
    }
}
