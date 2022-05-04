namespace e_agenda.WinApp.Compromissos
{
    partial class ListagemCompromissos
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
            this.btn_ExcluirCompromisso = new System.Windows.Forms.Button();
            this.btn_EditarCompromisso = new System.Windows.Forms.Button();
            this.btn_InserirCompromisso = new System.Windows.Forms.Button();
            this.list_Compromissos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_ExcluirCompromisso
            // 
            this.btn_ExcluirCompromisso.Location = new System.Drawing.Point(407, 29);
            this.btn_ExcluirCompromisso.Name = "btn_ExcluirCompromisso";
            this.btn_ExcluirCompromisso.Size = new System.Drawing.Size(131, 40);
            this.btn_ExcluirCompromisso.TabIndex = 10;
            this.btn_ExcluirCompromisso.Text = "EXCLUIR";
            this.btn_ExcluirCompromisso.UseVisualStyleBackColor = true;
            this.btn_ExcluirCompromisso.Click += new System.EventHandler(this.btn_ExcluirCompromisso_Click_1);
            // 
            // btn_EditarCompromisso
            // 
            this.btn_EditarCompromisso.Location = new System.Drawing.Point(201, 29);
            this.btn_EditarCompromisso.Name = "btn_EditarCompromisso";
            this.btn_EditarCompromisso.Size = new System.Drawing.Size(131, 40);
            this.btn_EditarCompromisso.TabIndex = 9;
            this.btn_EditarCompromisso.Text = "EDITAR";
            this.btn_EditarCompromisso.UseVisualStyleBackColor = true;
            this.btn_EditarCompromisso.Click += new System.EventHandler(this.btn_EditarCompromisso_Click);
            // 
            // btn_InserirCompromisso
            // 
            this.btn_InserirCompromisso.Location = new System.Drawing.Point(3, 29);
            this.btn_InserirCompromisso.Name = "btn_InserirCompromisso";
            this.btn_InserirCompromisso.Size = new System.Drawing.Size(131, 40);
            this.btn_InserirCompromisso.TabIndex = 8;
            this.btn_InserirCompromisso.Text = "INSERIR";
            this.btn_InserirCompromisso.UseVisualStyleBackColor = true;
            this.btn_InserirCompromisso.Click += new System.EventHandler(this.btn_InserirCompromisso_Click);
            // 
            // list_Compromissos
            // 
            this.list_Compromissos.FormattingEnabled = true;
            this.list_Compromissos.ItemHeight = 15;
            this.list_Compromissos.Location = new System.Drawing.Point(3, 87);
            this.list_Compromissos.Name = "list_Compromissos";
            this.list_Compromissos.ScrollAlwaysVisible = true;
            this.list_Compromissos.Size = new System.Drawing.Size(730, 259);
            this.list_Compromissos.TabIndex = 7;
            // 
            // ListagemCompromissos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_ExcluirCompromisso);
            this.Controls.Add(this.btn_EditarCompromisso);
            this.Controls.Add(this.btn_InserirCompromisso);
            this.Controls.Add(this.list_Compromissos);
            this.Name = "ListagemCompromissos";
            this.Size = new System.Drawing.Size(773, 375);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ExcluirCompromisso;
        private System.Windows.Forms.Button btn_EditarCompromisso;
        private System.Windows.Forms.Button btn_InserirCompromisso;
        private System.Windows.Forms.ListBox list_Compromissos;
    }
}
