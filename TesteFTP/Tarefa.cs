using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace TesteFTP
{
    class Tarefa
    {
        // nao precisa ter botao no timer, mas pode,
        // qndo usuario "fecha" programa
        // botao salvar


        private DateTimePicker _hrAgendada;
        public DadosUsuario _dados;

        public Tarefa(DateTimePicker hrAgendada, DadosUsuario dados) {
            _hrAgendada = hrAgendada;
            _dados = dados;
            IniciarProcessoDownload();                              
        }

        // chamada pelo botão de download
        public Tarefa(DadosUsuario dados) {
            _dados = dados;
            IniciarProcessoDownload();
        }
        
        private void IniciarProcessoDownload() {

            FuncoesFTP funcoesFtp = new FuncoesFTP(_dados);
            GerenciaArquivos arquivos = new GerenciaArquivos(_dados);

            Backup backup = new Backup(_dados, arquivos._ArqsBaixar);
            
            foreach (string arq in arquivos._ArqsBaixar) {

                funcoesFtp.DownloadArquivo();
                
            }
             
        }

        private bool VerificaHorario() {
            if (_hrAgendada.Value == DateTime.Now) {
                return true;
            }          
            return false;
        }
    }
}
