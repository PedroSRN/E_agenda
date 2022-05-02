using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace e_agenda.WinApp
{
    public class SerializadorTarefasEmBinario : ISerializadorTarefas
    {

        private const string arquivoTarefas = @"D:\temp\tarefas.bin";

        public List<Tarefa> CarregarTarefasDoArquivo()
        {
            if (File.Exists(arquivoTarefas) == false)
            {
                return new List<Tarefa>();
            }

            BinaryFormatter serializador = new BinaryFormatter();

            byte[] bytesTarefa = File.ReadAllBytes(arquivoTarefas);

            MemoryStream ms = new MemoryStream(bytesTarefa);

            return (List<Tarefa>)serializador.Deserialize(ms);
        }
        public void GravarTarefasEmArquivo(List<Tarefa> tarefas)
        {
            BinaryFormatter serializador = new BinaryFormatter();

            MemoryStream ms = new MemoryStream();

            serializador.Serialize(ms, tarefas);

            byte[] bytesTarefa = ms.ToArray();

            File.WriteAllBytes(arquivoTarefas, bytesTarefa);
        }
       
    }
}
