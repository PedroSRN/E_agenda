using e_agenda.WinApp.Contato;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace e_agenda.WinApp
{
    public partial class ListagemContatos : UserControl
    {
        private RepositorioContato repositorioContato;
        public ListagemContatos()
        {
            repositorioContato = new RepositorioContato();
            InitializeComponent();
            CarregarContatos();
        }

        private void CarregarContatos()
        {
            List<Contato_> contatos = repositorioContato.SelecionarTodosContatos();
            list_Contatos.Items.Clear();
            foreach (Contato_ c in contatos)
            {
                list_Contatos.Items.Add(c);
            }
        }

        private void btn_InserirContato_Click(object sender, EventArgs e)
        {
            CadastroContatos tela = new CadastroContatos();
            tela.Contato = new Contato_();
            
            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioContato.Inserir(tela.Contato);
                CarregarContatos();
            }
        }

        private void btn_EditarContato_Click(object sender, EventArgs e)
        {
            Contato_ contatoSelecionado = (Contato_)list_Contatos.SelectedItem;
          
            if (contatoSelecionado == null)
            {
                MessageBox.Show("Selecione um contato primeiro?"
                , "Edição de Contatos", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                return;
            }
            CadastroContatos tela = new CadastroContatos();
            
            tela.Contato = contatoSelecionado; 
            
            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioContato.Editar(tela.Contato);
                CarregarContatos();
            }
        }

        private void btn_ExcluirContato_Click(object sender, EventArgs e)
        {
            Contato_ contatoSelecionado = (Contato_)list_Contatos.SelectedItem;
            
            if(contatoSelecionado == null)
            {
                MessageBox.Show("Selecione um contato primeiro?"
                , "Exclusão de Contatos", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir esse contato?"
                ,"Exclusão de Contatos",MessageBoxButtons.OK,MessageBoxIcon.Question);
            
            if(resultado == DialogResult.OK)
            {
                repositorioContato.Excluir(contatoSelecionado);
                CarregarContatos();
            }

        }
    }
}
