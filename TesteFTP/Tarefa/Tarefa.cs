using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace TesteFTP.Tarefas
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
        }

        // chamada pelo botão de download
        public Tarefa(DadosUsuario dados) {
            _dados = dados;
        }
        
        public void IniciarProcessoDownload() {

            FuncoesFTP funcoesFtp = new FuncoesFTP(_dados);
            GerenciaArquivos arquivos = new GerenciaArquivos(_dados);

            var listArqs = arquivos.BuscaArquivosDownload();

            Backup backup = new Backup(_dados, listArqs);
            backup.RealizaBackup();
            
            foreach (string arq in listArqs) {

                funcoesFtp.DownloadArquivo();
                
            }
             
        }

        public void GerenciaTimer()
        {
            
            IniciarProcessoDownload();
        }

        // passar para a classe timer
        private bool VerificaHorario() {
            if (_hrAgendada.Value == DateTime.Now) {
                return true;
            }          
            return false;
        }
    }
}
