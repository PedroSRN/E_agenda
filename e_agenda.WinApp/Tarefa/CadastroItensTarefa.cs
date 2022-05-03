using e_agenda.Dominio;
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
    public partial class CadastroItensTarefa : Form
    {
        private readonly Tarefa tarefa;

        public CadastroItensTarefa(Tarefa tarefa)
        {
            InitializeComponent();
            
            this.tarefa = tarefa;

            lb_TituloTarefa.Text = tarefa.Titulo;

            foreach  (ItemTarefa item in tarefa.Itens)
            {
                list_ItensTarefa.Items.Add(item);
            }

            
        }

        public List<ItemTarefa> ItensAdicionados 
        {
            get
            {
                return list_ItensTarefa.Items.Cast<ItemTarefa>().ToList();
            }
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            List<string> titulos = ItensAdicionados.Select(x => x.Titulo).ToList();

            if (titulos.Count == 0 || titulos.Contains(txt_titulo.Text) == false)
            {
                ItemTarefa itemTarefa = new ItemTarefa();

                itemTarefa.Titulo = txt_titulo.Text;

               list_ItensTarefa.Items.Add(itemTarefa);
            }
        }
    }
}
