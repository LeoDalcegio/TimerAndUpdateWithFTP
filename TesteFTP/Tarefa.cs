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
        // tafera vai ser executada com base no timer, 
        // que será definido na tela pelo usuário

        // criar Windows Service


        private DateTimePicker _hrAgendada;
        public DadosUsuario _dados;
        
        public Tarefa(DateTimePicker hrAgendada) {
            _hrAgendada = hrAgendada;
            IniciarProcesso();                
        }

        public Tarefa(DateTimePicker hrAgendada, DadosUsuario dados) {
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

        private void IniciarProcesso() {
            
            if (VerificaHorario()) {
                FuncoesFTP funcao = new FuncoesFTP(_dados);
                // gerencia arquivos, DadosUsuario - retornará List
                // foreach arq com flag (map?) DownloadArquivo
                funcao.DownloadArquivo();
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
