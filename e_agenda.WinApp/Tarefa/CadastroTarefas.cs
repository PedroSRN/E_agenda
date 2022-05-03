using e_agenda.Dominio;
using System;
using System.Windows.Forms;

namespace e_agenda.WinApp
{
    public partial class CadastroTarefas : Form
    {
        private Tarefa tarefa;

        public CadastroTarefas()
        {
            InitializeComponent();
        }

        public Tarefa Tarefa
        {
            get 
            {
                return tarefa;
            }
            set
            {
                tarefa = value;
                txt_Prioridade.Text = tarefa.Prioridade;
                txt_Titulo.Text = tarefa.Titulo;
            }
        }


        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            tarefa.Titulo = txt_Titulo.Text;
            tarefa.Prioridade = txt_Prioridade.Text;
        }
    }
}
