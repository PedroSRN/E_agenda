using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_agenda.WinApp
{
    public partial class TelaPrincipal : Form
    {
        //Tarefas
        private readonly ISerializadorTarefas serializador = new SerializadorTarefasEmBinario();
        private readonly RepositorioTarefa repositorioTarefa;
       
        private readonly ListagemTarefas tarefas;
        

        //----------------------------------------------------//


        public TelaPrincipal()
        {
            InitializeComponent();//inicialização geral
           
            // Painel Tarefas

            repositorioTarefa = new RepositorioTarefa(serializador) ;
            tarefas = new ListagemTarefas(repositorioTarefa);
            panel_Tarefas.Controls.Add(tarefas);
            //-------------------------------------------
        }

        



        /* public ListagemTarefa()
         {
             repositorioTarefa = new RepositorioTarefa();

             InitializeComponent();
             CarregarTarefas();
         }


         public void CarregarTarefas()
         {
             List<Tarefa> agenda = repositorioTarefa.SelecionarTodos();

             list_Tarefas.Items.Clear();

             foreach (Tarefa t in agenda)
             {
                 list_Tarefas.Items.Add(t);
             }
         }

         private void btn_InserirTarefa_Click(object sender, EventArgs e)
         {
             CadastroTarefas telaCadastroTarefa  = new CadastroTarefas();
             telaCadastroTarefa.Tarefa = new Tarefa();

             DialogResult resultado = telaCadastroTarefa.ShowDialog();

             if (resultado == DialogResult.OK)
             {
                 repositorioTarefa.Inserir(telaCadastroTarefa.Tarefa);
                 CarregarTarefas();
             }

         }

         private void btn_EditarTarefa_Click(object sender, EventArgs e)
         {
             Tarefa tarefaSelecionada = (Tarefa)list_Tarefas.SelectedItem;
             if (tarefaSelecionada == null)
             {
                 MessageBox.Show("Selecione uma tarefa primeiro",
                 "Exclusão de Tarefas", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                 return;
             }
             CadastroTarefas telaCadastroTarefa = new CadastroTarefas();

             telaCadastroTarefa.Tarefa = tarefaSelecionada;

             DialogResult resultado = telaCadastroTarefa.ShowDialog();

             if (resultado == DialogResult.OK)
             {
                 repositorioTarefa.Editar(telaCadastroTarefa.Tarefa);
                 CarregarTarefas();
             }
         }

         private void btn_ExcluirTarefa_Click(object sender, EventArgs e)
         {
             Tarefa tarefaSelecionada = (Tarefa)list_Tarefas.SelectedItem;

             if(tarefaSelecionada == null)
             {
                 MessageBox.Show("Selecione uma tarefa primeiro",
                 "Exclusão de Tarefas", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                 return;
             }

             DialogResult resultado = MessageBox.Show("Deseja realmente excluir a tarefa",
                 "Exclusão de Tarefas", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);

             if(resultado == DialogResult.OK)
             {
                 repositorioTarefa.Excluir(tarefaSelecionada);
                 CarregarTarefas();
             }

         }*/
    }
}
