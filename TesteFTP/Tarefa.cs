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
        // nao precisa ter botao no time, mas pode,
        // qndo usuario "fecha" programa
        // botao salvar


        private DateTimePicker _hrAgendada;
        public DadosUsuario _dados;

        public Tarefa(DateTimePicker hrAgendada, DadosUsuario dados) {
            _hrAgendada = hrAgendada;
            _dados = dados;
            IniciarTimer();
            IniciarProcesso();// usuario preenche tudo, ok no timer, qndo da ok,
                              // inicia timer, qndo chegar, inicio o processo
                              // no Preenche dados usuario
            //antes teria que fazer a validação dos form, mover a q esta em func ftp
        }

        private void IniciarTimer() {
            if (VerificaHorario()) {
                

            }

        }

        private void IniciarProcesso() {
            
            if (VerificaHorario()) {
                GerenciaArquivos arquivos = new GerenciaArquivos(_dados);

                // retorna list, foreach na list
                // gerencia arquivos, DadosUsuario - retornará List
                
                
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
