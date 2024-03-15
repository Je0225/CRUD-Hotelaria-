namespace HotelariaForms
{
    partial class FormSelecionaSuite
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
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.lvSuites = new System.Windows.Forms.ListView();
            this.clmTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCapacidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDiaria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(328, 241);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionar.TabIndex = 1;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // lvSuites
            // 
            this.lvSuites.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmId,
            this.clmTipo,
            this.clmCapacidade,
            this.clmDiaria});
            this.lvSuites.FullRowSelect = true;
            this.lvSuites.GridLines = true;
            this.lvSuites.HideSelection = false;
            this.lvSuites.HoverSelection = true;
            this.lvSuites.Location = new System.Drawing.Point(12, 28);
            this.lvSuites.MultiSelect = false;
            this.lvSuites.Name = "lvSuites";
            this.lvSuites.Size = new System.Drawing.Size(391, 192);
            this.lvSuites.TabIndex = 4;
            this.lvSuites.UseCompatibleStateImageBehavior = false;
            this.lvSuites.View = System.Windows.Forms.View.Details;
            // 
            // clmTipo
            // 
            this.clmTipo.Text = "Tipo";
            this.clmTipo.Width = 107;
            // 
            // clmCapacidade
            // 
            this.clmCapacidade.Text = "Capacidade";
            this.clmCapacidade.Width = 99;
            // 
            // clmDiaria
            // 
            this.clmDiaria.Text = "Diaria";
            this.clmDiaria.Width = 111;
            // 
            // clmId
            // 
            this.clmId.Text = "ID";
            this.clmId.Width = 72;
            // 
            // FormSelecionaSuite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 286);
            this.Controls.Add(this.lvSuites);
            this.Controls.Add(this.btnSelecionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSelecionaSuite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleção da suite";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.ListView lvSuites;
        private System.Windows.Forms.ColumnHeader clmTipo;
        private System.Windows.Forms.ColumnHeader clmCapacidade;
        private System.Windows.Forms.ColumnHeader clmDiaria;
        private System.Windows.Forms.ColumnHeader clmId;
    }
}