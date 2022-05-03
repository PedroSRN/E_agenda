using System;
using System.Windows.Forms;

namespace e_agenda.WinApp.Contato
{
    public partial class CadastroContatos : Form
    {
        private Contato_ contato;
        public CadastroContatos()
        {
            InitializeComponent();
            
        }
        public Contato_ Contato
        {
            get
            { 
                return contato; 
            }
            set
            {
                contato = value;
                
                txt_NomeContato.Text = contato.Nome;
                txt_EmailContato.Text = contato.Email;
                txt_TelefoneContato.Text = contato.Telefone;
                txt_EmpresaContato.Text = contato.Empresa;
                txt_CargoContato.Text = contato.Cargo;


            }
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            
            contato.Nome = txt_NomeContato.Text;
            contato.Email = txt_EmailContato.Text;
            contato.Telefone = txt_TelefoneContato.Text;
            contato.Empresa = txt_EmpresaContato.Text;
            contato.Cargo = txt_CargoContato.Text;
        }
    }
}
