namespace e_agenda.WinApp
{
    partial class AtualizacaoItensTarefa
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
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.checkedList_ItensTarefa = new System.Windows.Forms.CheckedListBox();
            this.lb_TituloTarefa = new System.Windows.Forms.Label();
            this.lb_Tarefa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancelar.Location = new System.Drawing.Point(347, 243);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(115, 46);
            this.btn_Cancelar.TabIndex = 3;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Gravar.Location = new System.Drawing.Point(226, 243);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(115, 46);
            this.btn_Gravar.TabIndex = 2;
            this.btn_Gravar.Text = "Gravar";
            this.btn_Gravar.UseVisualStyleBackColor = true;
            // 
            // checkedList_ItensTarefa
            // 
            this.checkedList_ItensTarefa.CheckOnClick = true;
            this.checkedList_ItensTarefa.FormattingEnabled = true;
            this.checkedList_ItensTarefa.Location = new System.Drawing.Point(12, 89);
            this.checkedList_ItensTarefa.Name = "checkedList_ItensTarefa";
            this.checkedList_ItensTarefa.Size = new System.Drawing.Size(450, 148);
            this.checkedList_ItensTarefa.TabIndex = 4;
            // 
            // lb_TituloTarefa
            // 
            this.lb_TituloTarefa.AutoSize = true;
            this.lb_TituloTarefa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_TituloTarefa.Location = new System.Drawing.Point(60, 31);
            this.lb_TituloTarefa.Name = "lb_TituloTarefa";
            this.lb_TituloTarefa.Size = new System.Drawing.Size(62, 15);
            this.lb_TituloTarefa.TabIndex = 8;
            this.lb_TituloTarefa.Text = "-----------";
            // 
            // lb_Tarefa
            // 
            this.lb_Tarefa.AutoSize = true;
            this.lb_Tarefa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Tarefa.Location = new System.Drawing.Point(12, 31);
            this.lb_Tarefa.Name = "lb_Tarefa";
            this.lb_Tarefa.Size = new System.Drawing.Size(45, 15);
            this.lb_Tarefa.TabIndex = 7;
            this.lb_Tarefa.Text = "Tarefa:";
            // 
            // AtualizacaoItensTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(483, 301);
            this.Controls.Add(this.lb_TituloTarefa);
            this.Controls.Add(this.lb_Tarefa);
            this.Controls.Add(this.checkedList_ItensTarefa);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Gravar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AtualizacaoItensTarefa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualização dos Itens na Tarefa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.CheckedListBox checkedList_ItensTarefa;
        private System.Windows.Forms.Label lb_TituloTarefa;
        private System.Windows.Forms.Label lb_Tarefa;
    }
}