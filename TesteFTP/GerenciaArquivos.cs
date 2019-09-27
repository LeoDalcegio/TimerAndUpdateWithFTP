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
                if(ComparaArquivos(arq) = true) {
                    ArqABaixar.Add(arq);
                }

            }

            return ArqABaixar;
            
            // foreach _dados.LocalDownload
            // compara se existe em _dados.BaixarPara
            // horario alteração diferente, adiciona em Arquivos
        }

        private bool ComparaArquivos(string arqAtual) {
            //verifica se o arqAtual existe na outra pasta

        }

        // método que retorna list com quais arq eu devo baixar

        // pegar todos os "arq" do _dados.ArquivoDownload(mudar nome)
        // com as extensões escolhidas e comparar as datas de cada
    }
}
