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
    public partial class AtualizacaoItensTarefa : Form
    {
        private readonly Tarefa tarefa;

        public AtualizacaoItensTarefa(Tarefa tarefa)
        {
            InitializeComponent();
            this.tarefa = tarefa;

            lb_TituloTarefa.Text = tarefa.Titulo;

            CarregararItensTarefa(tarefa);
        }

        private void CarregararItensTarefa(Tarefa tarefa)
        {
            int i = 0;
            foreach (var item in tarefa.Itens)
            {
                checkedList_ItensTarefa.Items.Add(item);

                if (item.Concluido)
                    checkedList_ItensTarefa.SetItemChecked(i, true);

                i++;
            }
        }

        public List<ItemTarefa> ItensConcluidos
        {
            get
            {
                return checkedList_ItensTarefa.CheckedItems
                    .Cast<ItemTarefa>()
                    .ToList();
            }
        }
        public List<ItemTarefa> ItensPendentes
        {
            get
            {
                return checkedList_ItensTarefa.Items
                    .Cast<ItemTarefa>()
                    .Except(ItensConcluidos)
                    .ToList();
            }
        }
    }
}
