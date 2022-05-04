using System;
using System.Collections.Generic;

namespace e_agenda.WinApp.Compromissos
{
    public class RepositorioCompromisso
    {
        List<Compromissos_> compromissos = new List<Compromissos_>();
        private int contador = 0;
        public List<Compromissos_> SelecionarTodos()
        {
            return compromissos;
                
        }

        public void Inserir(Compromissos_ compromisso)
        {
            compromisso.Numero = ++contador;
           compromissos.Add(compromisso);
        }

        public void Editar(Compromissos_ compromisso)
        {
            foreach(var item in compromissos)
            {
                if(item.Numero == compromisso.Numero)
                {
                    item.Assunto = compromisso.Assunto;
                    item.Local = compromisso.Local;
                    item.Contato = compromisso.Contato;
                    item.DataCompromisso = compromisso.DataCompromisso;
                    item.HoraInicio = compromisso.HoraInicio;
                    item.HoraTermino = compromisso.HoraTermino;
                    
                    break;
                }
            }
        }

        public void Excluir(Compromissos_ compromisso)
        {
            compromissos.Remove(compromisso);
        }
    }
}
