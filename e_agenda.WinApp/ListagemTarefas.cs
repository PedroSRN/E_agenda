using e_agenda.Dominio;
using e_agenda.Infra.Arquivos;
using System;
using System.Collections.Generic;

using System.Windows.Forms;

//namespace e_agenda.Dominio
namespace e_agenda.WinApp

{
    public partial class ListagemTarefas : UserControl
    {
        IRepositorioTarefa repositorioTarefa;
        
        public ListagemTarefas(RepositorioTarefaEmArquivo  repositorioTarefa)
        {
            // SerializadorTarefasEmBinario serializador = new SerializadorTarefasEmBinario();
            SerializadorTarefasEmXml serializador = new SerializadorTarefasEmXml();

            this.repositorioTarefa = new RepositorioTarefaEmArquivo(serializador);

            InitializeComponent();
            CarregarTarefas();
        }


        public void CarregarTarefas()
        {
            List<Tarefa> tarefasConcluidas = repositorioTarefa.SelecionarTarefasConcluidas();

            list_TarefasConcluidas.Items.Clear();

            foreach (Tarefa t in tarefasConcluidas)
            {
                list_TarefasConcluidas.Items.Add(t);
            }

            List<Tarefa> tarefasPendentes = repositorioTarefa.SelecionarTarefasPendentes();

            list_TarefasPendentes.Items.Clear();

            foreach (Tarefa t in tarefasPendentes)
            {
                list_TarefasPendentes.Items.Add(t);
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
            Tarefa tarefaSelecionada = (Tarefa)list_TarefasPendentes.SelectedItem;
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
            Tarefa tarefaSelecionada = (Tarefa)list_TarefasPendentes.SelectedItem;

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
            Tarefa tarefaSelecionada = (Tarefa)list_TarefasPendentes.SelectedItem;

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
            Tarefa tarefaSelecionada = (Tarefa)list_TarefasPendentes.SelectedItem;

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
