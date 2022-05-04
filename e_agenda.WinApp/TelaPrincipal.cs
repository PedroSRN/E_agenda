using e_agenda.Infra.Arquivos;
using e_agenda.WinApp.Compromissos;
using System.Windows.Forms;

namespace e_agenda.WinApp
{
    public partial class TelaPrincipal : Form
    {
        //Tarefas
             // private readonly ISerializadorTarefas serializador = new SerializadorTarefasEmBinario();
             private readonly ISerializadorTarefas serializador = new SerializadorTarefasEmXml();
             private readonly RepositorioTarefaEmArquivo repositorioTarefa;
             private readonly ListagemTarefas tarefas;
        //----------------------------------------------------//
        
        //Contatos
             private readonly RepositorioContato repositorioContato;
             private readonly ListagemContatos contatos;
        //----------------------------------------------------//

        //Compromissos

             private readonly ListagemCompromissos compromissos;
        //----------------------------------------------------//
       
        public TelaPrincipal()
        {
            InitializeComponent();//inicialização geral
           
            // Painel Tarefas
            repositorioTarefa = new RepositorioTarefaEmArquivo(serializador) ;
            tarefas = new ListagemTarefas(repositorioTarefa);
            panel_Tarefas.Controls.Add(tarefas);

            //----------------------------------------------------//

            //PainelContatos
            repositorioContato = new RepositorioContato();
            contatos = new ListagemContatos();
            panel_Contatos.Controls.Add(contatos);

            //----------------------------------------------------//
            
            // Painel Compromissos

            compromissos = new ListagemCompromissos();
            panel_Compromissos.Controls.Add(compromissos);

            //----------------------------------------------------//
        }
    }
}
