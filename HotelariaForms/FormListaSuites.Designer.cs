namespace HotelariaForms
{
    partial class FormListaSuites
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
            this.lvSuites = new System.Windows.Forms.ListView();
            this.clmId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCapacidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDiaria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(450, 101);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(86, 34);
            this.btnRemover.TabIndex = 5;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(450, 34);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(86, 34);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
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
            this.lvSuites.Location = new System.Drawing.Point(32, 34);
            this.lvSuites.MultiSelect = false;
            this.lvSuites.Name = "lvSuites";
            this.lvSuites.Size = new System.Drawing.Size(393, 355);
            this.lvSuites.TabIndex = 3;
            this.lvSuites.UseCompatibleStateImageBehavior = false;
            this.lvSuites.View = System.Windows.Forms.View.Details;
            // 
            // clmId
            // 
            this.clmId.Text = "ID";
            // 
            // clmCapacidade
            // 
            this.clmCapacidade.Text = "Capacidade";
            this.clmCapacidade.Width = 99;
            // 
            // clmTipo
            // 
            this.clmTipo.Text = "Tipo";
            this.clmTipo.Width = 118;
            // 
            // clmDiaria
            // 
            this.clmDiaria.Text = "Diaria";
            this.clmDiaria.Width = 111;
            // 
            // FormListaSuites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 429);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lvSuites);
            this.Name = "FormListaSuites";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de suites";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListView lvSuites;
        private System.Windows.Forms.ColumnHeader clmTipo;
        private System.Windows.Forms.ColumnHeader clmCapacidade;
        private System.Windows.Forms.ColumnHeader clmDiaria;
        private System.Windows.Forms.ColumnHeader clmId;
    }
}