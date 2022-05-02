namespace e_agenda.WinApp
{
    partial class CadastroItensTarefa
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.list_ItensTarefa = new System.Windows.Forms.ListBox();
            this.lb_Titulo = new System.Windows.Forms.Label();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.lb_Tarefa = new System.Windows.Forms.Label();
            this.lb_TituloTarefa = new System.Windows.Forms.Label();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Gravar.Location = new System.Drawing.Point(223, 246);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(115, 46);
            this.btn_Gravar.TabIndex = 0;
            this.btn_Gravar.Text = "Gravar";
            this.btn_Gravar.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancelar.Location = new System.Drawing.Point(344, 246);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(115, 46);
            this.btn_Cancelar.TabIndex = 1;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // list_ItensTarefa
            // 
            this.list_ItensTarefa.FormattingEnabled = true;
            this.list_ItensTarefa.ItemHeight = 15;
            this.list_ItensTarefa.Location = new System.Drawing.Point(12, 100);
            this.list_ItensTarefa.Name = "list_ItensTarefa";
            this.list_ItensTarefa.Size = new System.Drawing.Size(447, 139);
            this.list_ItensTarefa.TabIndex = 2;
            // 
            // lb_Titulo
            // 
            this.lb_Titulo.AutoSize = true;
            this.lb_Titulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Titulo.Location = new System.Drawing.Point(12, 48);
            this.lb_Titulo.Name = "lb_Titulo";
            this.lb_Titulo.Size = new System.Drawing.Size(39, 15);
            this.lb_Titulo.TabIndex = 3;
            this.lb_Titulo.Text = "Titulo";
            // 
            // txt_titulo
            // 
            this.txt_titulo.Location = new System.Drawing.Point(60, 45);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(191, 23);
            this.txt_titulo.TabIndex = 4;
            // 
            // lb_Tarefa
            // 
            this.lb_Tarefa.AutoSize = true;
            this.lb_Tarefa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Tarefa.Location = new System.Drawing.Point(13, 9);
            this.lb_Tarefa.Name = "lb_Tarefa";
            this.lb_Tarefa.Size = new System.Drawing.Size(45, 15);
            this.lb_Tarefa.TabIndex = 5;
            this.lb_Tarefa.Text = "Tarefa:";
            // 
            // lb_TituloTarefa
            // 
            this.lb_TituloTarefa.AutoSize = true;
            this.lb_TituloTarefa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_TituloTarefa.Location = new System.Drawing.Point(61, 9);
            this.lb_TituloTarefa.Name = "lb_TituloTarefa";
            this.lb_TituloTarefa.Size = new System.Drawing.Size(62, 15);
            this.lb_TituloTarefa.TabIndex = 6;
            this.lb_TituloTarefa.Text = "-----------";
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Location = new System.Drawing.Point(280, 45);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(179, 23);
            this.btn_Adicionar.TabIndex = 7;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // CadastroItensTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(483, 301);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.lb_TituloTarefa);
            this.Controls.Add(this.lb_Tarefa);
            this.Controls.Add(this.txt_titulo);
            this.Controls.Add(this.lb_Titulo);
            this.Controls.Add(this.list_ItensTarefa);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Gravar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroItensTarefa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Itens na Tarefa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.ListBox list_ItensTarefa;
        private System.Windows.Forms.Label lb_Titulo;
        private System.Windows.Forms.TextBox txt_titulo;
        private System.Windows.Forms.Label lb_Tarefa;
        private System.Windows.Forms.Label lb_TituloTarefa;
        private System.Windows.Forms.Button btn_Adicionar;
    }
}