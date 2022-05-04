using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace e_agenda.WinApp.Compromissos
{
    public partial class CadastroCompromissos : Form
    {
        private RepositorioContato repositorioContato;
        private Compromissos_ compromisso;
        public CadastroCompromissos()
        {
            InitializeComponent();
            AtualizarTela();
        }

        private void AtualizarTela()
        {
            repositorioContato = new RepositorioContato();
            List<Contato_> contatosDisponiveis = repositorioContato.SelecionarTodosContatos();

            comboBox_Contato.Items.Clear();

            if(contatosDisponiveis.Count > 0)
            {
                foreach (Contato_ contato in contatosDisponiveis)
                {
                    comboBox_Contato.Items.Add(contato);
                }
            }
        }

        public Compromissos_ Compromisso
        {
            get
            {
                return compromisso;
            }
            set
            {
                compromisso = value;
            
                txt_Assunto.Text = compromisso.Assunto;
                txt_Local.Text = compromisso.Local;
                try
                {
                    dateTimePicker_Data.Text = compromisso.DataCompromisso.ToString();
                    dateTimePicker_Inicio.Text = compromisso.HoraInicio.ToString();
                    dateTimePicker_Termino.Text = compromisso.HoraTermino.ToString();
                }
                catch (Exception ex)
                {

                }
                comboBox_Contato.SelectedItem = compromisso.Contato;
            }
        }
        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            //compromisso = new Compromissos_();

            compromisso.Assunto = txt_Assunto.Text;
            compromisso.Local = txt_Local.Text;
            compromisso.Contato = (Contato_)comboBox_Contato.SelectedItem;
            compromisso.DataCompromisso = DateTime.Parse(dateTimePicker_Data.Text);
            compromisso.HoraInicio = DateTime.Parse(dateTimePicker_Inicio.Text);
            compromisso.HoraTermino = DateTime.Parse(dateTimePicker_Termino.Text);
        }
    }
}
