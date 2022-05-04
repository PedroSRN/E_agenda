using e_agenda.WinApp.Contato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_agenda.WinApp.Compromissos
{
    public partial class ListagemCompromissos : UserControl
    {
        private RepositorioCompromisso repositorioCompromisso;
        public ListagemCompromissos()
        {
            repositorioCompromisso = new RepositorioCompromisso();
            InitializeComponent();
            CarregarCompromissos();
           

        }

        private void CarregarCompromissos()
        {
            List<Compromissos_> compromissos = repositorioCompromisso.SelecionarTodos();
 
            list_Compromissos.Items.Clear();
            
            foreach (Compromissos_ c in compromissos)
            {
                list_Compromissos.Items.Add(c);
            }

        }

        private void btn_InserirCompromisso_Click(object sender, EventArgs e)
        {
            CadastroCompromissos tela = new CadastroCompromissos();

            tela.Compromisso = new Compromissos_();

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioCompromisso.Inserir(tela.Compromisso);
                CarregarCompromissos();
            }
        }

        private void btn_EditarCompromisso_Click(object sender, EventArgs e)
        {
            Compromissos_ compromissosSelecionado = (Compromissos_)list_Compromissos.SelectedItem;
           
            if (compromissosSelecionado == null)
            {
                MessageBox.Show("Selecione um compromisso primeiro?"
                , "Edição de Compromissos", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                return;
            }

            CadastroCompromissos tela = new CadastroCompromissos();

            tela.Compromisso = compromissosSelecionado;

            DialogResult resultado = tela.ShowDialog();

            if(resultado == DialogResult.OK)
            {
                repositorioCompromisso.Editar(compromissosSelecionado);
                CarregarCompromissos();
            }
        }
        

        private void btn_ExcluirCompromisso_Click_1(object sender, EventArgs e)
        {
            Compromissos_ compromissosSelecionado = (Compromissos_)list_Compromissos.SelectedItem;

            if (compromissosSelecionado == null)
            {
                MessageBox.Show("Selecione um compromisso primeiro?"
                , "Exclusão de Compromisso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir esse Compromisso?"
                , "Exclusão de Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioCompromisso.Excluir(compromissosSelecionado);
                CarregarCompromissos();
            }
        }
    }
}
