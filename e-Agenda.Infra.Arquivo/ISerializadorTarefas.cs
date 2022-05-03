using e_agenda.Dominio;
using System.Collections.Generic;


namespace e_agenda.Infra.Arquivos
{
    public interface ISerializadorTarefas
    {
        List<Tarefa> CarregarTarefasDoArquivo();

        void GravarTarefasEmArquivo(List<Tarefa> tarefas);    
    }
}
