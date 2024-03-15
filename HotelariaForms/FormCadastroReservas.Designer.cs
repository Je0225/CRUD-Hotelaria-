namespace HotelariaForms
{
    partial class FormCadastroReservas
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
            this.tbDiasReservados = new System.Windows.Forms.TextBox();
            this.lblTotalReserva = new System.Windows.Forms.Label();
            this.tbSuite = new System.Windows.Forms.TextBox();
            this.lblDiasReservados = new System.Windows.Forms.Label();
            this.lblSuite = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAddSuite = new System.Windows.Forms.Button();
            this.tbTotalReserva = new System.Windows.Forms.TextBox();
            this.lblHospedes = new System.Windows.Forms.Label();
            this.lvHospedes = new System.Windows.Forms.ListView();
            this.clmNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSobrenome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddHospede = new System.Windows.Forms.Button();
            this.lblListaDeHospedes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbDiasReservados
            // 
            this.tbDiasReservados.Location = new System.Drawing.Point(120, 73);
            this.tbDiasReservados.Name = "tbDiasReservados";
            this.tbDiasReservados.Size = new System.Drawing.Size(133, 20);
            this.tbDiasReservados.TabIndex = 15;
            this.tbDiasReservados.TextChanged += new System.EventHandler(this.tbDiasReservados_TextChanged);
            this.tbDiasReservados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDiasReservados_KeyPress);
            this.tbDiasReservados.Leave += new System.EventHandler(this.tbDiasReservados_Leave);
            // 
            // lblTotalReserva
            // 
            this.lblTotalReserva.Location = new System.Drawing.Point(24, 113);
            this.lblTotalReserva.Name = "lblTotalReserva";
            this.lblTotalReserva.Size = new System.Drawing.Size(90, 13);
            this.lblTotalReserva.TabIndex = 14;
            this.lblTotalReserva.Text = "Total da Reserva";
            this.lblTotalReserva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSuite
            // 
            this.tbSuite.Location = new System.Drawing.Point(120, 34);
            this.tbSuite.Name = "tbSuite";
            this.tbSuite.ReadOnly = true;
            this.tbSuite.Size = new System.Drawing.Size(133, 20);
            this.tbSuite.TabIndex = 13;
            // 
            // lblDiasReservados
            // 
            this.lblDiasReservados.Location = new System.Drawing.Point(24, 73);
            this.lblDiasReservados.Name = "lblDiasReservados";
            this.lblDiasReservados.Size = new System.Drawing.Size(87, 13);
            this.lblDiasReservados.TabIndex = 12;
            this.lblDiasReservados.Text = "Dias reservados";
            this.lblDiasReservados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSuite
            // 
            this.lblSuite.Location = new System.Drawing.Point(68, 32);
            this.lblSuite.Name = "lblSuite";
            this.lblSuite.Size = new System.Drawing.Size(43, 23);
            this.lblSuite.TabIndex = 11;
            this.lblSuite.Text = "Suite";
            this.lblSuite.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(209, 393);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(303, 393);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAddSuite
            // 
            this.btnAddSuite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSuite.Location = new System.Drawing.Point(270, 34);
            this.btnAddSuite.Name = "btnAddSuite";
            this.btnAddSuite.Size = new System.Drawing.Size(35, 29);
            this.btnAddSuite.TabIndex = 17;
            this.btnAddSuite.Text = "+";
            this.btnAddSuite.UseVisualStyleBackColor = true;
            this.btnAddSuite.Click += new System.EventHandler(this.btnAddSuite_Click);
            // 
            // tbTotalReserva
            // 
            this.tbTotalReserva.Location = new System.Drawing.Point(120, 110);
            this.tbTotalReserva.Name = "tbTotalReserva";
            this.tbTotalReserva.ReadOnly = true;
            this.tbTotalReserva.Size = new System.Drawing.Size(133, 20);
            this.tbTotalReserva.TabIndex = 18;
            this.tbTotalReserva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblHospedes
            // 
            this.lblHospedes.Location = new System.Drawing.Point(107, 164);
            this.lblHospedes.Name = "lblHospedes";
            this.lblHospedes.Size = new System.Drawing.Size(20, 13);
            this.lblHospedes.TabIndex = 21;
            this.lblHospedes.Text = " Hospedes";
            this.lblHospedes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lvHospedes
            // 
            this.lvHospedes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmNome,
            this.clmSobrenome});
            this.lvHospedes.FullRowSelect = true;
            this.lvHospedes.GridLines = true;
            this.lvHospedes.HideSelection = false;
            this.lvHospedes.Location = new System.Drawing.Point(27, 180);
            this.lvHospedes.Name = "lvHospedes";
            this.lvHospedes.Size = new System.Drawing.Size(310, 187);
            this.lvHospedes.TabIndex = 22;
            this.lvHospedes.UseCompatibleStateImageBehavior = false;
            this.lvHospedes.View = System.Windows.Forms.View.Details;
            // 
            // clmNome
            // 
            this.clmNome.Text = "Nome";
            this.clmNome.Width = 156;
            // 
            // clmSobrenome
            // 
            this.clmSobrenome.Text = "Sobrenome";
            this.clmSobrenome.Width = 150;
            // 
            // btnAddHospede
            // 
            this.btnAddHospede.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHospede.Location = new System.Drawing.Point(343, 180);
            this.btnAddHospede.Name = "btnAddHospede";
            this.btnAddHospede.Size = new System.Drawing.Size(35, 29);
            this.btnAddHospede.TabIndex = 23;
            this.btnAddHospede.Text = "+";
            this.btnAddHospede.UseVisualStyleBackColor = true;
            this.btnAddHospede.Click += new System.EventHandler(this.btnAddHospede_Click);
            // 
            // lblListaDeHospedes
            // 
            this.lblListaDeHospedes.Location = new System.Drawing.Point(24, 151);
            this.lblListaDeHospedes.Name = "lblListaDeHospedes";
            this.lblListaDeHospedes.Size = new System.Drawing.Size(100, 13);
            this.lblListaDeHospedes.TabIndex = 24;
            this.lblListaDeHospedes.Text = "Lista de Hospedes";
            this.lblListaDeHospedes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormCadastroReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 445);
            this.Controls.Add(this.lblListaDeHospedes);
            this.Controls.Add(this.btnAddHospede);
            this.Controls.Add(this.lvHospedes);
            this.Controls.Add(this.lblHospedes);
            this.Controls.Add(this.tbTotalReserva);
            this.Controls.Add(this.btnAddSuite);
            this.Controls.Add(this.tbDiasReservados);
            this.Controls.Add(this.lblTotalReserva);
            this.Controls.Add(this.tbSuite);
            this.Controls.Add(this.lblDiasReservados);
            this.Controls.Add(this.lblSuite);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroReservas";
            this.Text = "FormCadastroReservas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbDiasReservados;
        private System.Windows.Forms.Label lblTotalReserva;
        private System.Windows.Forms.TextBox tbSuite;
        private System.Windows.Forms.Label lblDiasReservados;
        private System.Windows.Forms.Label lblSuite;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAddSuite;
        private System.Windows.Forms.TextBox tbTotalReserva;
        private System.Windows.Forms.Label lblHospedes;
        private System.Windows.Forms.ListView lvHospedes;
        private System.Windows.Forms.Button btnAddHospede;
        private System.Windows.Forms.Label lblListaDeHospedes;
        private System.Windows.Forms.ColumnHeader clmNome;
        private System.Windows.Forms.ColumnHeader clmSobrenome;
    }
}