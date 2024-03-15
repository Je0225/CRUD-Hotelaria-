namespace HotelariaForms
{
    partial class FormPrincipal
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHospedes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSuites = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReserva = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiListarReservas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadastros,
            this.tsmReserva});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.MdiWindowListItem = this.tsmReserva;
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(427, 24);
            this.menuPrincipal.TabIndex = 0;
            // 
            // tsmCadastros
            // 
            this.tsmCadastros.AutoSize = false;
            this.tsmCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHospedes,
            this.tsmiSuites});
            this.tsmCadastros.Name = "tsmCadastros";
            this.tsmCadastros.Size = new System.Drawing.Size(122, 20);
            this.tsmCadastros.Tag = "Cadastros";
            this.tsmCadastros.Text = "Cadastros";
            // 
            // tsmiHospedes
            // 
            this.tsmiHospedes.Name = "tsmiHospedes";
            this.tsmiHospedes.Size = new System.Drawing.Size(126, 22);
            this.tsmiHospedes.Text = "Hospedes";
            this.tsmiHospedes.Click += new System.EventHandler(this.tsmiHospedes_Click);
            // 
            // tsmiSuites
            // 
            this.tsmiSuites.Name = "tsmiSuites";
            this.tsmiSuites.Size = new System.Drawing.Size(126, 22);
            this.tsmiSuites.Text = "Suites";
            this.tsmiSuites.Click += new System.EventHandler(this.tsmiSuites_Click);
            // 
            // tsmReserva
            // 
            this.tsmReserva.AutoSize = false;
            this.tsmReserva.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiListarReservas});
            this.tsmReserva.Name = "tsmReserva";
            this.tsmReserva.Size = new System.Drawing.Size(122, 20);
            this.tsmReserva.Text = "Reservas";
            // 
            // tsmiListarReservas
            // 
            this.tsmiListarReservas.Name = "tsmiListarReservas";
            this.tsmiListarReservas.Size = new System.Drawing.Size(147, 22);
            this.tsmiListarReservas.Text = "Listar reservas";
            this.tsmiListarReservas.Click += new System.EventHandler(this.tsmiListar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(427, 417);
            this.Controls.Add(this.menuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuPrincipal;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.Text = "Hotelaria";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastros;
        private System.Windows.Forms.ToolStripMenuItem tsmReserva;
        private System.Windows.Forms.ToolStripMenuItem tsmiHospedes;
        private System.Windows.Forms.ToolStripMenuItem tsmiSuites;
        private System.Windows.Forms.ToolStripMenuItem tsmiListarReservas;
    }
}

