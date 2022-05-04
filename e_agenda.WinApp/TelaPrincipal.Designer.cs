namespace e_agenda.WinApp
{
    partial class TelaPrincipal
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
            this.tabTarefa = new System.Windows.Forms.TabPage();
            this.panel_Tarefas = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel_Contatos = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel_Compromissos = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabTarefa.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTarefa);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(780, 389);
            this.tabControl1.TabIndex = 3;
            // 
            // tabTarefa
            // 
            this.tabTarefa.BackColor = System.Drawing.Color.MediumAquamarine;
            this.tabTarefa.Controls.Add(this.panel_Tarefas);
            this.tabTarefa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabTarefa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabTarefa.Location = new System.Drawing.Point(4, 24);
            this.tabTarefa.Name = "tabTarefa";
            this.tabTarefa.Padding = new System.Windows.Forms.Padding(3);
            this.tabTarefa.Size = new System.Drawing.Size(772, 361);
            this.tabTarefa.TabIndex = 0;
            this.tabTarefa.Text = "Tarefas";
            // 
            // panel_Tarefas
            // 
            this.panel_Tarefas.Location = new System.Drawing.Point(0, 3);
            this.panel_Tarefas.Name = "panel_Tarefas";
            this.panel_Tarefas.Size = new System.Drawing.Size(772, 358);
            this.panel_Tarefas.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MediumPurple;
            this.tabPage2.Controls.Add(this.panel_Contatos);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(772, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Contatos";
            // 
            // panel_Contatos
            // 
            this.panel_Contatos.Location = new System.Drawing.Point(3, 3);
            this.panel_Contatos.Name = "panel_Contatos";
            this.panel_Contatos.Size = new System.Drawing.Size(769, 362);
            this.panel_Contatos.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.YellowGreen;
            this.tabPage3.Controls.Add(this.panel_Compromissos);
            this.tabPage3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(772, 361);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Compromissos";
            // 
            // panel_Compromissos
            // 
            this.panel_Compromissos.Location = new System.Drawing.Point(3, 3);
            this.panel_Compromissos.Name = "panel_Compromissos";
            this.panel_Compromissos.Size = new System.Drawing.Size(769, 355);
            this.panel_Compromissos.TabIndex = 0;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(780, 389);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TelaPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Agenda";
            this.tabControl1.ResumeLayout(false);
            this.tabTarefa.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTarefa;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel_Tarefas;
        private System.Windows.Forms.Panel panel_Contatos;
        private System.Windows.Forms.Panel panel_Compromissos;
    }
}
