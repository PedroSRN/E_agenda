namespace e_agenda.WinApp
{
    partial class ListagemContatos
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ExcluirContato = new System.Windows.Forms.Button();
            this.btn_EditarContato = new System.Windows.Forms.Button();
            this.btn_InserirContato = new System.Windows.Forms.Button();
            this.list_Contatos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_ExcluirContato
            // 
            this.btn_ExcluirContato.Location = new System.Drawing.Point(407, 43);
            this.btn_ExcluirContato.Name = "btn_ExcluirContato";
            this.btn_ExcluirContato.Size = new System.Drawing.Size(131, 40);
            this.btn_ExcluirContato.TabIndex = 10;
            this.btn_ExcluirContato.Text = "EXCLUIR";
            this.btn_ExcluirContato.UseVisualStyleBackColor = true;
            this.btn_ExcluirContato.Click += new System.EventHandler(this.btn_ExcluirContato_Click);
            // 
            // btn_EditarContato
            // 
            this.btn_EditarContato.Location = new System.Drawing.Point(201, 43);
            this.btn_EditarContato.Name = "btn_EditarContato";
            this.btn_EditarContato.Size = new System.Drawing.Size(131, 40);
            this.btn_EditarContato.TabIndex = 9;
            this.btn_EditarContato.Text = "EDITAR";
            this.btn_EditarContato.UseVisualStyleBackColor = true;
            this.btn_EditarContato.Click += new System.EventHandler(this.btn_EditarContato_Click);
            // 
            // btn_InserirContato
            // 
            this.btn_InserirContato.Location = new System.Drawing.Point(3, 43);
            this.btn_InserirContato.Name = "btn_InserirContato";
            this.btn_InserirContato.Size = new System.Drawing.Size(131, 40);
            this.btn_InserirContato.TabIndex = 8;
            this.btn_InserirContato.Text = "INSERIR";
            this.btn_InserirContato.UseVisualStyleBackColor = true;
            this.btn_InserirContato.Click += new System.EventHandler(this.btn_InserirContato_Click);
            // 
            // list_Contatos
            // 
            this.list_Contatos.FormattingEnabled = true;
            this.list_Contatos.ItemHeight = 15;
            this.list_Contatos.Location = new System.Drawing.Point(3, 89);
            this.list_Contatos.Name = "list_Contatos";
            this.list_Contatos.ScrollAlwaysVisible = true;
            this.list_Contatos.Size = new System.Drawing.Size(722, 259);
            this.list_Contatos.TabIndex = 7;
            // 
            // ListagemContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_ExcluirContato);
            this.Controls.Add(this.btn_EditarContato);
            this.Controls.Add(this.btn_InserirContato);
            this.Controls.Add(this.list_Contatos);
            this.Name = "ListagemContatos";
            this.Size = new System.Drawing.Size(773, 375);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ExcluirContato;
        private System.Windows.Forms.Button btn_EditarContato;
        private System.Windows.Forms.Button btn_InserirContato;
        private System.Windows.Forms.ListBox list_Contatos;
    }
}
