using e_agenda.Dominio;
using System.Collections.Generic;
using System.Linq;


namespace e_agenda.Infra.Arquivos
{
    public class RepositorioTarefaEmArquivo: IRepositorioTarefa
    {
        private readonly ISerializadorTarefas serializador;
        List<Tarefa> tarefas;
        private int contador = 0;

        public RepositorioTarefaEmArquivo(ISerializadorTarefas serializador)
        {
            // tarefas = new List<Tarefa>();

            this.serializador = serializador;

            tarefas = serializador.CarregarTarefasDoArquivo();

            if (tarefas.Count > 0)
                contador = tarefas.Max(x => x.Numero);

        }


        public List<Tarefa> SelecionarTodos()
        {
            return tarefas;
        }


        public void Inserir(Tarefa novaTarefa)
        {
            novaTarefa.Numero = ++contador;
            tarefas.Add(novaTarefa);

            serializador.GravarTarefasEmArquivo(tarefas);
        }


        public void Editar(Tarefa tarefa)
        {
            foreach (var item in tarefas)
            {
                if (item.Numero == tarefa.Numero)
                {
                    item.Titulo = tarefa.Titulo;
                    break;
                }
            }

            serializador.GravarTarefasEmArquivo(tarefas);
        }

        public void Excluir(Tarefa tarefa)
        {
            tarefas.Remove(tarefa);

            serializador.GravarTarefasEmArquivo(tarefas);
        }

        public void AdicionarItens(Tarefa tarefaSelecionada, List<ItemTarefa> itens)
        {
            foreach (var item in itens)
            {
                tarefaSelecionada.AdicionarItem(item);
            }
            serializador.GravarTarefasEmArquivo(tarefas);
        }

        public void AtualizarItens(Tarefa tarefaSelecionada, List<ItemTarefa> itensConcluidos, List<ItemTarefa> itensPendentes)
        {
            foreach (var item in itensConcluidos)
            {
                tarefaSelecionada.ConcluirItem(item);
            }

            foreach (var item in itensPendentes)
            {
                tarefaSelecionada.MarcarPendente(item);
            }

            serializador.GravarTarefasEmArquivo(tarefas);
        }
        public List<Tarefa> SelecionarTarefasConcluidas()
        {
            return tarefas.Where(x => x.CalcularPercentualConcluido() == 100).ToList();
        }

        public List<Tarefa> SelecionarTarefasPendentes()
        {
            return tarefas.Where(x => x.CalcularPercentualConcluido() < 100).ToList();
        }

       
    }
}