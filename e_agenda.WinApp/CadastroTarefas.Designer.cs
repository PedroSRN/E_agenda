namespace e_agenda.WinApp
{
    partial class CadastroTarefas
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
            this.lb_Prioridade = new System.Windows.Forms.Label();
            this.txt_Prioridade = new System.Windows.Forms.TextBox();
            this.txt_Titulo = new System.Windows.Forms.TextBox();
            this.lb_Titulo = new System.Windows.Forms.Label();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Prioridade
            // 
            this.lb_Prioridade.AutoSize = true;
            this.lb_Prioridade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Prioridade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_Prioridade.Location = new System.Drawing.Point(12, 23);
            this.lb_Prioridade.Name = "lb_Prioridade";
            this.lb_Prioridade.Size = new System.Drawing.Size(64, 15);
            this.lb_Prioridade.TabIndex = 0;
            this.lb_Prioridade.Text = "Prioridade";
            // 
            // txt_Prioridade
            // 
            this.txt_Prioridade.Location = new System.Drawing.Point(79, 20);
            this.txt_Prioridade.Name = "txt_Prioridade";
            this.txt_Prioridade.Size = new System.Drawing.Size(137, 23);
            this.txt_Prioridade.TabIndex = 1;
            // 
            // txt_Titulo
            // 
            this.txt_Titulo.Location = new System.Drawing.Point(79, 77);
            this.txt_Titulo.Name = "txt_Titulo";
            this.txt_Titulo.Size = new System.Drawing.Size(247, 23);
            this.txt_Titulo.TabIndex = 3;
            // 
            // lb_Titulo
            // 
            this.lb_Titulo.AutoSize = true;
            this.lb_Titulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Titulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_Titulo.Location = new System.Drawing.Point(12, 80);
            this.lb_Titulo.Name = "lb_Titulo";
            this.lb_Titulo.Size = new System.Drawing.Size(39, 15);
            this.lb_Titulo.TabIndex = 2;
            this.lb_Titulo.Text = "Titulo";
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Gravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Gravar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Gravar.Location = new System.Drawing.Point(380, 108);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(122, 46);
            this.btn_Gravar.TabIndex = 4;
            this.btn_Gravar.Text = "Gravar";
            this.btn_Gravar.UseVisualStyleBackColor = true;
            this.btn_Gravar.Click += new System.EventHandler(this.btn_Gravar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelar.Location = new System.Drawing.Point(380, 165);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(122, 46);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // CadastroTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(514, 218);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_Gravar);
            this.Controls.Add(this.txt_Titulo);
            this.Controls.Add(this.lb_Titulo);
            this.Controls.Add(this.txt_Prioridade);
            this.Controls.Add(this.lb_Prioridade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroTarefas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroTarefas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Prioridade;
        private System.Windows.Forms.TextBox txt_Prioridade;
        private System.Windows.Forms.TextBox txt_Titulo;
        private System.Windows.Forms.Label lb_Titulo;
        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}