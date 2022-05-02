namespace e_agenda.WinApp
{
    partial class ListagemTarefas
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
            this.btn_AdicionarItens = new System.Windows.Forms.Button();
            this.btn_AtualizarItens = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ExcluirTarefa
            // 
            this.btn_ExcluirTarefa.Location = new System.Drawing.Point(302, 35);
            this.btn_ExcluirTarefa.Name = "btn_ExcluirTarefa";
            this.btn_ExcluirTarefa.Size = new System.Drawing.Size(131, 40);
            this.btn_ExcluirTarefa.TabIndex = 7;
            this.btn_ExcluirTarefa.Text = "EXCLUIR";
            this.btn_ExcluirTarefa.UseVisualStyleBackColor = true;
            this.btn_ExcluirTarefa.Click += new System.EventHandler(this.btn_ExcluirTarefa_Click);
            // 
            // btn_EditarTarefa
            // 
            this.btn_EditarTarefa.Location = new System.Drawing.Point(152, 35);
            this.btn_EditarTarefa.Name = "btn_EditarTarefa";
            this.btn_EditarTarefa.Size = new System.Drawing.Size(131, 40);
            this.btn_EditarTarefa.TabIndex = 6;
            this.btn_EditarTarefa.Text = "EDITAR";
            this.btn_EditarTarefa.UseVisualStyleBackColor = true;
            this.btn_EditarTarefa.Click += new System.EventHandler(this.btn_EditarTarefa_Click);
            // 
            // btn_InserirTarefa
            // 
            this.btn_InserirTarefa.Location = new System.Drawing.Point(3, 35);
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
            this.list_Tarefas.Location = new System.Drawing.Point(3, 94);
            this.list_Tarefas.Name = "list_Tarefas";
            this.list_Tarefas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.list_Tarefas.ScrollAlwaysVisible = true;
            this.list_Tarefas.Size = new System.Drawing.Size(736, 259);
            this.list_Tarefas.TabIndex = 4;
            // 
            // btn_AdicionarItens
            // 
            this.btn_AdicionarItens.Location = new System.Drawing.Point(457, 35);
            this.btn_AdicionarItens.Name = "btn_AdicionarItens";
            this.btn_AdicionarItens.Size = new System.Drawing.Size(131, 40);
            this.btn_AdicionarItens.TabIndex = 8;
            this.btn_AdicionarItens.Text = "ADICIONAR ITENS";
            this.btn_AdicionarItens.UseVisualStyleBackColor = true;
            this.btn_AdicionarItens.Click += new System.EventHandler(this.btn_AdicionarItens_Click);
            // 
            // btn_AtualizarItens
            // 
            this.btn_AtualizarItens.Location = new System.Drawing.Point(608, 35);
            this.btn_AtualizarItens.Name = "btn_AtualizarItens";
            this.btn_AtualizarItens.Size = new System.Drawing.Size(131, 40);
            this.btn_AtualizarItens.TabIndex = 9;
            this.btn_AtualizarItens.Text = "ATUALIZAR ITENS";
            this.btn_AtualizarItens.UseVisualStyleBackColor = true;
            this.btn_AtualizarItens.Click += new System.EventHandler(this.btn_AtualizarItens_Click);
            // 
            // ListagemTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_AtualizarItens);
            this.Controls.Add(this.btn_AdicionarItens);
            this.Controls.Add(this.btn_ExcluirTarefa);
            this.Controls.Add(this.btn_EditarTarefa);
            this.Controls.Add(this.btn_InserirTarefa);
            this.Controls.Add(this.list_Tarefas);
            this.Name = "ListagemTarefas";
            this.Size = new System.Drawing.Size(773, 375);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ExcluirTarefa;
        private System.Windows.Forms.Button btn_EditarTarefa;
        private System.Windows.Forms.Button btn_InserirTarefa;
        private System.Windows.Forms.ListBox list_Tarefas;
        private System.Windows.Forms.Button btn_AdicionarItens;
        private System.Windows.Forms.Button btn_AtualizarItens;
    }
}
