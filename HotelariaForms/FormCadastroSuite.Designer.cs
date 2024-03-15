using System.Runtime.CompilerServices;

namespace HotelariaForms
{
    partial class FormCadastroSuite
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblCapacidade = new System.Windows.Forms.Label();
            this.tbCapacidade = new System.Windows.Forms.TextBox();
            this.tbDiaria = new System.Windows.Forms.TextBox();
            this.lblDiaria = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(271, 141);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(177, 141);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.Location = new System.Drawing.Point(12, 23);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(68, 23);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCapacidade
            // 
            this.lblCapacidade.Location = new System.Drawing.Point(12, 58);
            this.lblCapacidade.Name = "lblCapacidade";
            this.lblCapacidade.Size = new System.Drawing.Size(68, 13);
            this.lblCapacidade.TabIndex = 3;
            this.lblCapacidade.Text = "Capacidade";
            this.lblCapacidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbCapacidade
            // 
            this.tbCapacidade.Location = new System.Drawing.Point(86, 58);
            this.tbCapacidade.Name = "tbCapacidade";
            this.tbCapacidade.Size = new System.Drawing.Size(133, 20);
            this.tbCapacidade.TabIndex = 5;
            this.tbCapacidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCapacidade_KeyPress);
            this.tbCapacidade.Leave += new System.EventHandler(this.tbCapacidade_Leave);
            // 
            // tbDiaria
            // 
            this.tbDiaria.Location = new System.Drawing.Point(86, 93);
            this.tbDiaria.Name = "tbDiaria";
            this.tbDiaria.Size = new System.Drawing.Size(133, 20);
            this.tbDiaria.TabIndex = 7;
            this.tbDiaria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDiaria_KeyPress);
            this.tbDiaria.Leave += new System.EventHandler(this.tbDiaria_Leave);
            // 
            // lblDiaria
            // 
            this.lblDiaria.Location = new System.Drawing.Point(12, 93);
            this.lblDiaria.Name = "lblDiaria";
            this.lblDiaria.Size = new System.Drawing.Size(68, 13);
            this.lblDiaria.TabIndex = 6;
            this.lblDiaria.Text = "Diária";
            this.lblDiaria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbTipo.Location = new System.Drawing.Point(87, 24);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(132, 21);
            this.cbTipo.TabIndex = 8;
            // 
            // FormCadastroSuite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 181);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.tbDiaria);
            this.Controls.Add(this.lblDiaria);
            this.Controls.Add(this.tbCapacidade);
            this.Controls.Add(this.lblCapacidade);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroSuite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Suite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblCapacidade;
        private System.Windows.Forms.TextBox tbCapacidade;
        private System.Windows.Forms.TextBox tbDiaria;
        private System.Windows.Forms.Label lblDiaria;
        private System.Windows.Forms.ComboBox cbTipo;
    }
}