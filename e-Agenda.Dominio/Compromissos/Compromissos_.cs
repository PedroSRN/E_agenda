using System;

namespace e_agenda.WinApp.Compromissos
{
    public class Compromissos_
    {
        public Compromissos_()
        {
        }


        public Compromissos_(int numero, string assunto, string local,Contato_ contato ,DateTime dataCompromisso,DateTime horaInicio, DateTime horaTermino)
        {
            Numero = numero;
            Assunto = assunto;
            Local = local;
            Contato = contato ;
            DataCompromisso = dataCompromisso;
            HoraInicio = horaInicio;
            HoraTermino = horaTermino;
        }
        public int Numero { get; set; }
        public string Assunto { get; set; }
        public string Local { get; set; }
        public DateTime DataCompromisso { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraTermino { get; set; }
        public Contato_ Contato { get; set; }

        public override string ToString()
        {
            string contatoExistente = Contato is null ? "Não disponivel" : Contato.Nome;

            return $"Numero: {Numero}, Assunto: {Assunto}, Local: {Local},Contato: {contatoExistente}, Data Compromisso: {DataCompromisso.ToString("dd/MM/yyyy")}, Hora de Inicio {HoraInicio.ToString("HH:mm")}, Hora de Término{HoraTermino.ToString("HH:mm")}";
        }
    }
}
