using System;

namespace e_agenda.WinApp
{
    public class Tarefa
    {
        public Tarefa()
        {
        }

        public Tarefa(int n, string p, string t)
        {
            Numero = n;
            Prioridade = p;
            Titulo = t;
            DataCriacao = DateTime.Now;
        }

        public int Numero { get; set; } 
        public string Prioridade { get; set; }
        public string Titulo { get; set; }
        
        public DateTime DataCriacao { get;}
        

        public override string ToString()
        {
            return $"Número: {Numero}, Prioridade: {Prioridade}, Titulo: {Titulo}";
        }
    }   
}