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
        // 

        private static System.Timers.Timer aTimer;

        private DateTimePicker _hrAgendada;

        public Tarefa(DateTimePicker hrAgendada) {
            _hrAgendada = hrAgendada;
            IniciarProcesso();                
        }

        private void IniciarProcesso() {
            if (VerificaHorario()) {

            }
            // inicia a verificação depois o download.
           
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
