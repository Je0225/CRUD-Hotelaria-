namespace HotelariaForms
{
    partial class FormListaReservas
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
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lvReservas = new System.Windows.Forms.ListView();
            this.clmSuite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDiasReservados = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTotalReserva = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmQuantidadeHospedes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(505, 101);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(86, 34);
            this.btnRemover.TabIndex = 5;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(505, 34);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(86, 34);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lvReservas
            // 
            this.lvReservas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmSuite,
            this.clmDiasReservados,
            this.clmTotalReserva,
            this.clmQuantidadeHospedes});
            this.lvReservas.FullRowSelect = true;
            this.lvReservas.GridLines = true;
            this.lvReservas.HideSelection = false;
            this.lvReservas.Location = new System.Drawing.Point(36, 34);
            this.lvReservas.MultiSelect = false;
            this.lvReservas.Name = "lvReservas";
            this.lvReservas.Size = new System.Drawing.Size(453, 355);
            this.lvReservas.TabIndex = 3;
            this.lvReservas.UseCompatibleStateImageBehavior = false;
            this.lvReservas.View = System.Windows.Forms.View.Details;
            // 
            // clmSuite
            // 
            this.clmSuite.Text = "Suite";
            this.clmSuite.Width = 123;
            // 
            // clmDiasReservados
            // 
            this.clmDiasReservados.Text = "Dias reservados";
            this.clmDiasReservados.Width = 137;
            // 
            // clmTotalReserva
            // 
            this.clmTotalReserva.Text = "Total da reserva";
            // 
            // clmQuantidadeHospedes
            // 
            this.clmQuantidadeHospedes.Text = "Quantidade de Hospedes";
            this.clmQuantidadeHospedes.Width = 125;
            // 
            // FormListaReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 426);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lvReservas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormListaReservas";
            this.Text = "FormListaReservas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListView lvReservas;
        private System.Windows.Forms.ColumnHeader clmSuite;
        private System.Windows.Forms.ColumnHeader clmDiasReservados;
        private System.Windows.Forms.ColumnHeader clmTotalReserva;
        private System.Windows.Forms.ColumnHeader clmQuantidadeHospedes;
    }
}