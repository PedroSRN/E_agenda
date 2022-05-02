namespace e_agenda.WinApp
{
    partial class ListagemTarefa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_ExcluirTarefa = new System.Windows.Forms.Button();
            this.btn_EditarTarefa = new System.Windows.Forms.Button();
            this.btn_InserirTarefa = new System.Windows.Forms.Button();
            this.list_Tarefas = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_ExcluirContato = new System.Windows.Forms.Button();
            this.btn_EditarContato = new System.Windows.Forms.Button();
            this.btn_InserirContato = new System.Windows.Forms.Button();
            this.list_Contatos = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_ExcluirCompromisso = new System.Windows.Forms.Button();
            this.btn_EditarCompromisso = new System.Windows.Forms.Button();
            this.btn_InserirCompromisso = new System.Windows.Forms.Button();
            this.list_Compromissos = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(650, 389);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.tabPage1.Controls.Add(this.btn_ExcluirTarefa);
            this.tabPage1.Controls.Add(this.btn_EditarTarefa);
            this.tabPage1.Controls.Add(this.btn_InserirTarefa);
            this.tabPage1.Controls.Add(this.list_Tarefas);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(642, 361);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tarefas";
            // 
            // btn_ExcluirTarefa
            // 
            this.btn_ExcluirTarefa.Location = new System.Drawing.Point(412, 35);
            this.btn_ExcluirTarefa.Name = "btn_ExcluirTarefa";
            this.btn_ExcluirTarefa.Size = new System.Drawing.Size(131, 40);
            this.btn_ExcluirTarefa.TabIndex = 3;
            this.btn_ExcluirTarefa.Text = "EXCLUIR";
            this.btn_ExcluirTarefa.UseVisualStyleBackColor = true;
            this.btn_ExcluirTarefa.Click += new System.EventHandler(this.btn_ExcluirTarefa_Click);
            // 
            // btn_EditarTarefa
            // 
            this.btn_EditarTarefa.Location = new System.Drawing.Point(206, 35);
            this.btn_EditarTarefa.Name = "btn_EditarTarefa";
            this.btn_EditarTarefa.Size = new System.Drawing.Size(131, 40);
            this.btn_EditarTarefa.TabIndex = 2;
            this.btn_EditarTarefa.Text = "EDITAR";
            this.btn_EditarTarefa.UseVisualStyleBackColor = true;
            this.btn_EditarTarefa.Click += new System.EventHandler(this.btn_EditarTarefa_Click);
            // 
            // btn_InserirTarefa
            // 
            this.btn_InserirTarefa.Location = new System.Drawing.Point(8, 35);
            this.btn_InserirTarefa.Name = "btn_InserirTarefa";
            this.btn_InserirTarefa.Size = new System.Drawing.Size(131, 40);
            this.btn_InserirTarefa.TabIndex = 1;
            this.btn_InserirTarefa.Text = "INSERIR";
            this.btn_InserirTarefa.UseVisualStyleBackColor = true;
            this.btn_InserirTarefa.Click += new System.EventHandler(this.btn_InserirTarefa_Click);
            // 
            // list_Tarefas
            // 
            this.list_Tarefas.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.list_Tarefas.BackColor = System.Drawing.SystemColors.Window;
            this.list_Tarefas.FormattingEnabled = true;
            this.list_Tarefas.ItemHeight = 15;
            this.list_Tarefas.Location = new System.Drawing.Point(8, 94);
            this.list_Tarefas.Name = "list_Tarefas";
            this.list_Tarefas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.list_Tarefas.ScrollAlwaysVisible = true;
            this.list_Tarefas.Size = new System.Drawing.Size(624, 259);
            this.list_Tarefas.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MediumPurple;
            this.tabPage2.Controls.Add(this.btn_ExcluirContato);
            this.tabPage2.Controls.Add(this.btn_EditarContato);
            this.tabPage2.Controls.Add(this.btn_InserirContato);
            this.tabPage2.Controls.Add(this.list_Contatos);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(642, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Contatos";
            // 
            // btn_ExcluirContato
            // 
            this.btn_ExcluirContato.Location = new System.Drawing.Point(412, 35);
            this.btn_ExcluirContato.Name = "btn_ExcluirContato";
            this.btn_ExcluirContato.Size = new System.Drawing.Size(131, 40);
            this.btn_ExcluirContato.TabIndex = 6;
            this.btn_ExcluirContato.Text = "EXCLUIR";
            this.btn_ExcluirContato.UseVisualStyleBackColor = true;
            // 
            // btn_EditarContato
            // 
            this.btn_EditarContato.Location = new System.Drawing.Point(206, 35);
            this.btn_EditarContato.Name = "btn_EditarContato";
            this.btn_EditarContato.Size = new System.Drawing.Size(131, 40);
            this.btn_EditarContato.TabIndex = 5;
            this.btn_EditarContato.Text = "EDITAR";
            this.btn_EditarContato.UseVisualStyleBackColor = true;
            // 
            // btn_InserirContato
            // 
            this.btn_InserirContato.Location = new System.Drawing.Point(8, 35);
            this.btn_InserirContato.Name = "btn_InserirContato";
            this.btn_InserirContato.Size = new System.Drawing.Size(131, 40);
            this.btn_InserirContato.TabIndex = 4;
            this.btn_InserirContato.Text = "INSERIR";
            this.btn_InserirContato.UseVisualStyleBackColor = true;
            // 
            // list_Contatos
            // 
            this.list_Contatos.FormattingEnabled = true;
            this.list_Contatos.ItemHeight = 15;
            this.list_Contatos.Location = new System.Drawing.Point(8, 94);
            this.list_Contatos.Name = "list_Contatos";
            this.list_Contatos.ScrollAlwaysVisible = true;
            this.list_Contatos.Size = new System.Drawing.Size(624, 259);
            this.list_Contatos.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.YellowGreen;
            this.tabPage3.Controls.Add(this.btn_ExcluirCompromisso);
            this.tabPage3.Controls.Add(this.btn_EditarCompromisso);
            this.tabPage3.Controls.Add(this.btn_InserirCompromisso);
            this.tabPage3.Controls.Add(this.list_Compromissos);
            this.tabPage3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(642, 361);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Compromissos";
            // 
            // btn_ExcluirCompromisso
            // 
            this.btn_ExcluirCompromisso.Location = new System.Drawing.Point(412, 36);
            this.btn_ExcluirCompromisso.Name = "btn_ExcluirCompromisso";
            this.btn_ExcluirCompromisso.Size = new System.Drawing.Size(131, 40);
            this.btn_ExcluirCompromisso.TabIndex = 6;
            this.btn_ExcluirCompromisso.Text = "EXCLUIR";
            this.btn_ExcluirCompromisso.UseVisualStyleBackColor = true;
            // 
            // btn_EditarCompromisso
            // 
            this.btn_EditarCompromisso.Location = new System.Drawing.Point(206, 36);
            this.btn_EditarCompromisso.Name = "btn_EditarCompromisso";
            this.btn_EditarCompromisso.Size = new System.Drawing.Size(131, 40);
            this.btn_EditarCompromisso.TabIndex = 5;
            this.btn_EditarCompromisso.Text = "EDITAR";
            this.btn_EditarCompromisso.UseVisualStyleBackColor = true;
            // 
            // btn_InserirCompromisso
            // 
            this.btn_InserirCompromisso.Location = new System.Drawing.Point(8, 36);
            this.btn_InserirCompromisso.Name = "btn_InserirCompromisso";
            this.btn_InserirCompromisso.Size = new System.Drawing.Size(131, 40);
            this.btn_InserirCompromisso.TabIndex = 4;
            this.btn_InserirCompromisso.Text = "INSERIR";
            this.btn_InserirCompromisso.UseVisualStyleBackColor = true;
            // 
            // list_Compromissos
            // 
            this.list_Compromissos.FormattingEnabled = true;
            this.list_Compromissos.ItemHeight = 15;
            this.list_Compromissos.Location = new System.Drawing.Point(8, 94);
            this.list_Compromissos.Name = "list_Compromissos";
            this.list_Compromissos.ScrollAlwaysVisible = true;
            this.list_Compromissos.Size = new System.Drawing.Size(624, 259);
            this.list_Compromissos.TabIndex = 0;
            // 
            // ListagemTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(650, 389);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ListagemTarefa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Agenda";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox list_Tarefas;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox list_Contatos;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox list_Compromissos;
        private System.Windows.Forms.Button btn_InserirTarefa;
        private System.Windows.Forms.Button btn_ExcluirTarefa;
        private System.Windows.Forms.Button btn_EditarTarefa;
        private System.Windows.Forms.Button btn_ExcluirContato;
        private System.Windows.Forms.Button btn_EditarContato;
        private System.Windows.Forms.Button btn_InserirContato;
        private System.Windows.Forms.Button btn_ExcluirCompromisso;
        private System.Windows.Forms.Button btn_EditarCompromisso;
        private System.Windows.Forms.Button btn_InserirCompromisso;
    }
}
