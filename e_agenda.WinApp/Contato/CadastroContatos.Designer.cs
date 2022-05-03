namespace e_agenda.WinApp.Contato
{
    partial class CadastroContatos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_NomeContato = new System.Windows.Forms.TextBox();
            this.txt_EmailContato = new System.Windows.Forms.TextBox();
            this.txt_TelefoneContato = new System.Windows.Forms.TextBox();
            this.txt_EmpresaContato = new System.Windows.Forms.TextBox();
            this.txt_CargoContato = new System.Windows.Forms.TextBox();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(296, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(296, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Empresa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(7, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cargo:";
            // 
            // txt_NomeContato
            // 
            this.txt_NomeContato.Location = new System.Drawing.Point(10, 45);
            this.txt_NomeContato.Name = "txt_NomeContato";
            this.txt_NomeContato.Size = new System.Drawing.Size(223, 23);
            this.txt_NomeContato.TabIndex = 5;
            // 
            // txt_EmailContato
            // 
            this.txt_EmailContato.Location = new System.Drawing.Point(296, 45);
            this.txt_EmailContato.Name = "txt_EmailContato";
            this.txt_EmailContato.Size = new System.Drawing.Size(223, 23);
            this.txt_EmailContato.TabIndex = 6;
            // 
            // txt_TelefoneContato
            // 
            this.txt_TelefoneContato.Location = new System.Drawing.Point(10, 112);
            this.txt_TelefoneContato.Name = "txt_TelefoneContato";
            this.txt_TelefoneContato.Size = new System.Drawing.Size(223, 23);
            this.txt_TelefoneContato.TabIndex = 7;
            // 
            // txt_EmpresaContato
            // 
            this.txt_EmpresaContato.Location = new System.Drawing.Point(299, 112);
            this.txt_EmpresaContato.Name = "txt_EmpresaContato";
            this.txt_EmpresaContato.Size = new System.Drawing.Size(223, 23);
            this.txt_EmpresaContato.TabIndex = 8;
            // 
            // txt_CargoContato
            // 
            this.txt_CargoContato.Location = new System.Drawing.Point(10, 177);
            this.txt_CargoContato.Name = "txt_CargoContato";
            this.txt_CargoContato.Size = new System.Drawing.Size(223, 23);
            this.txt_CargoContato.TabIndex = 9;
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Gravar.Location = new System.Drawing.Point(296, 169);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(109, 36);
            this.btn_Gravar.TabIndex = 10;
            this.btn_Gravar.Text = "Gravar";
            this.btn_Gravar.UseVisualStyleBackColor = true;
            this.btn_Gravar.Click += new System.EventHandler(this.btn_Gravar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancelar.Location = new System.Drawing.Point(413, 169);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(109, 36);
            this.btn_Cancelar.TabIndex = 11;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // CadastroContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(548, 235);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Gravar);
            this.Controls.Add(this.txt_CargoContato);
            this.Controls.Add(this.txt_EmpresaContato);
            this.Controls.Add(this.txt_TelefoneContato);
            this.Controls.Add(this.txt_EmailContato);
            this.Controls.Add(this.txt_NomeContato);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroContatos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroContatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_NomeContato;
        private System.Windows.Forms.TextBox txt_EmailContato;
        private System.Windows.Forms.TextBox txt_TelefoneContato;
        private System.Windows.Forms.TextBox txt_EmpresaContato;
        private System.Windows.Forms.TextBox txt_CargoContato;
        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}