using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace e_agenda.WinApp
{
    public class SerializadorTarefasEmXml : ISerializadorTarefas
    {
        private const string arquivoTarefas = @"D:\temp\tarefas.xml";

        public List<Tarefa> CarregarTarefasDoArquivo()
        {
            if (File.Exists(arquivoTarefas) == false)
            {
                return new List<Tarefa>();
            }

            XmlSerializer serializador = new XmlSerializer(typeof(List<Tarefa>));

            byte[] bytesTarefa = File.ReadAllBytes(arquivoTarefas);

            MemoryStream ms = new MemoryStream(bytesTarefa);

            return (List<Tarefa>)serializador.Deserialize(ms);
        }

        public void GravarTarefasEmArquivo(List<Tarefa> tarefas)
        {
           XmlSerializer serializador = new XmlSerializer(typeof(List<Tarefa>));
            
            MemoryStream ms = new MemoryStream();

            serializador.Serialize(ms, tarefas);

            byte[] bytesTarefa = ms.ToArray();

            File.WriteAllBytes(arquivoTarefas, bytesTarefa);

        }
    }
}
