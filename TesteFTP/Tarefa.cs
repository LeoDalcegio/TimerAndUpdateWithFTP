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
            if (VerificaHorario())
                IniciarProcesso();
        }

        public void IniciarProcesso() {
            // inicia a verificação depois o download.
            

        }

        private static void SetTimer() {
            // TODO
        }

        public bool VerificaHorario() {
            // TODO
            
            return true;
        }
    }
}
