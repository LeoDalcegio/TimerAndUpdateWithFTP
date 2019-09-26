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
        // tafera vai ser executada com base no timer, que será definido na tela pelo usuário


        private DateTimePicker _hrAgendada;
        public DadosUsuario _dados;

        public Tarefa(DateTimePicker hrAgendada) {
            _hrAgendada = hrAgendada;
            IniciarProcesso();                
        }

        public Tarefa(DateTimePicker hrAgendada, DadosUsuario dados) : this(hrAgendada) {
            _hrAgendada = hrAgendada;
            _dados = dados;
            IniciarProcesso(dados);
        }

        private void IniciarProcesso(DadosUsuario dados) {
            FuncoesFTP funcoesFtp = new FuncoesFTP(dados);
            if (VerificaHorario()) {

                // buscar arquivos, retorna list, download arquivos da list
                // _dados._arquivoDownload list item
                // foreach n funcoesFtp.DownloadArquivo()
            }

        }

        // verificar se precisa
        private void IniciarProcesso() {
            
            if (VerificaHorario()) {
               
            }

        }

        private static void SetTimer() {
            // TODO -> salvar timer em algum lugar, texto ou banco
        }

        private bool VerificaHorario() {
            // TODO
            if (_hrAgendada.Value == DateTime.Now) {

            }

            
            return true;
        }
    }
}
