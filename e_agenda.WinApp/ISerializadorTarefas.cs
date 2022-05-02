using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_agenda.WinApp
{
    public interface ISerializadorTarefas
    {
        List<Tarefa> CarregarTarefasDoArquivo();

        void GravarTarefasEmArquivo(List<Tarefa> tarefas);    
    }
}
