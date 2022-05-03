using System;
using System.Collections.Generic;
using System.Linq;

namespace e_agenda.Dominio
{
    [Serializable]
    public class Tarefa
    {
        private List<ItemTarefa> itens = new List<ItemTarefa>(); 
        public Tarefa()
        {
            DataCriacao = DateTime.Now;

        }

        public Tarefa(int n, string p, string t) :this()
        {
            Numero = n;
            Prioridade = p;
            Titulo = t;
            DataConclusao = null;
        }

        public int Numero { get; set; } 
        public string Prioridade { get; set; }
        public string Titulo { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataConclusao { get; set; }

        public List<ItemTarefa> Itens { get {return itens; } }

        public override string ToString()
        {
            var percentual = CalcularPercentualConcluido();

            if (DataConclusao.HasValue)
            {
                return $"Número: {Numero}, Prioridade: {Prioridade}, Titulo: {Titulo}, Percentual: {percentual}," +
                        $" Concluido em: {DataConclusao.Value.ToShortDateString()}";
            }

            return $"Número: {Numero}, Prioridade: {Prioridade}, Titulo: {Titulo}, Percentual: {percentual}";
        }

        public void AdicionarItem(ItemTarefa item)
        {
            if (Itens.Exists(x => x.Equals(item)) == false)
                itens.Add(item);
        }

        public void ConcluirItem(ItemTarefa item)
        {
           ItemTarefa itemTarefa = itens.Find(x => x.Equals(item));

            itemTarefa?.Concluir();

            var percentual = CalcularPercentualConcluido();

            if (percentual == 100)
                DataConclusao = DateTime.Now;
        }
        public void MarcarPendente(ItemTarefa item)
        {

            ItemTarefa itemTarefa = itens.Find(x => x.Equals(item));
            
            itemTarefa?.MarcarPendente();
        }

        public decimal CalcularPercentualConcluido()
        {
            if(itens.Count == 0)
            {
                return 0;
            }

            int qtdConcluidas = itens.Count(x => x.Concluido);

            var percentualConcluido = (qtdConcluidas / (decimal)itens.Count()) * 100;
            
            return Math.Round(percentualConcluido, 2);
        }

        
    }   
}