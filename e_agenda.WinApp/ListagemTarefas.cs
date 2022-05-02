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
    public partial class ListagemTarefas : UserControl
    {
        RepositorioTarefa repositorioTarefa;
        
        public ListagemTarefas(RepositorioTarefa  repositorioTarefa)
        {
            SerializadorTarefasEmBinario serializador = new SerializadorTarefasEmBinario();

            this.repositorioTarefa = new RepositorioTarefa(serializador);

            InitializeComponent();
            CarregarTarefas();
        }


        public void CarregarTarefas()
        {
            List<Tarefa> tarefa = repositorioTarefa.SelecionarTodos();

            list_Tarefas.Items.Clear();

            foreach (Tarefa t in tarefa)
            {
                list_Tarefas.Items.Add(t);
            }
        }

        private void btn_InserirTarefa_Click(object sender, EventArgs e)
        {
            CadastroTarefas telaCadastroTarefa = new CadastroTarefas();
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

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro",
                "Exclusão de Tarefas", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir a tarefa",
                "Exclusão de Tarefas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioTarefa.Excluir(tarefaSelecionada);
                CarregarTarefas();
            }

        }
        private void btn_AdicionarItens_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)list_Tarefas.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro",
                "Edição de Tarefas", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroItensTarefa tela = new CadastroItensTarefa(tarefaSelecionada);

            if(tela.ShowDialog() == DialogResult.OK)
            {
                List<ItemTarefa> itens = tela.ItensAdicionados;

                repositorioTarefa.AdicionarItens(tarefaSelecionada, itens);

                CarregarTarefas();
            }
        }

        private void btn_AtualizarItens_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)list_Tarefas.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro",
                "Edição de Tarefas", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }

            AtualizacaoItensTarefa tela = new AtualizacaoItensTarefa(tarefaSelecionada);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                List<ItemTarefa> itensConcluidos = tela.ItensConcluidos;

                List<ItemTarefa> itensPendentes = tela.ItensPendentes;

                repositorioTarefa.AtualizarItens(tarefaSelecionada, itensConcluidos, itensPendentes);
                CarregarTarefas();
            }
        }
    }
}
