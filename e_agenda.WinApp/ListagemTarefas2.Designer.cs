namespace e_agenda.WinApp
{
    partial class ListagemTarefas2
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
            this.btn_ExcluirTarefa = new System.Windows.Forms.Button();
            this.btn_EditarTarefa = new System.Windows.Forms.Button();
            this.btn_InserirTarefa = new System.Windows.Forms.Button();
            this.list_Tarefas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_ExcluirTarefa
            // 
            this.btn_ExcluirTarefa.Location = new System.Drawing.Point(407, 18);
            this.btn_ExcluirTarefa.Name = "btn_ExcluirTarefa";
            this.btn_ExcluirTarefa.Size = new System.Drawing.Size(131, 40);
            this.btn_ExcluirTarefa.TabIndex = 7;
            this.btn_ExcluirTarefa.Text = "EXCLUIR";
            this.btn_ExcluirTarefa.UseVisualStyleBackColor = true;
            this.btn_ExcluirTarefa.Click += new System.EventHandler(this.btn_ExcluirTarefa_Click);
            // 
            // btn_EditarTarefa
            // 
            this.btn_EditarTarefa.Location = new System.Drawing.Point(201, 18);
            this.btn_EditarTarefa.Name = "btn_EditarTarefa";
            this.btn_EditarTarefa.Size = new System.Drawing.Size(131, 40);
            this.btn_EditarTarefa.TabIndex = 6;
            this.btn_EditarTarefa.Text = "EDITAR";
            this.btn_EditarTarefa.UseVisualStyleBackColor = true;
            this.btn_EditarTarefa.Click += new System.EventHandler(this.btn_EditarTarefa_Click);
            // 
            // btn_InserirTarefa
            // 
            this.btn_InserirTarefa.Location = new System.Drawing.Point(3, 18);
            this.btn_InserirTarefa.Name = "btn_InserirTarefa";
            this.btn_InserirTarefa.Size = new System.Drawing.Size(131, 40);
            this.btn_InserirTarefa.TabIndex = 5;
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
            this.list_Tarefas.Location = new System.Drawing.Point(3, 77);
            this.list_Tarefas.Name = "list_Tarefas";
            this.list_Tarefas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.list_Tarefas.ScrollAlwaysVisible = true;
            this.list_Tarefas.Size = new System.Drawing.Size(624, 259);
            this.list_Tarefas.TabIndex = 4;
            // 
            // ListagemTarefas2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_ExcluirTarefa);
            this.Controls.Add(this.btn_EditarTarefa);
            this.Controls.Add(this.btn_InserirTarefa);
            this.Controls.Add(this.list_Tarefas);
            this.Name = "ListagemTarefas2";
            this.Size = new System.Drawing.Size(678, 375);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ExcluirTarefa;
        private System.Windows.Forms.Button btn_EditarTarefa;
        private System.Windows.Forms.Button btn_InserirTarefa;
        private System.Windows.Forms.ListBox list_Tarefas;
    }
}
