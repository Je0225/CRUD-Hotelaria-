namespace HotelariaForms
{
    partial class FormSelecionaHospedes
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
            this.clmNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSobrenome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvHospedes = new System.Windows.Forms.ListView();
            this.clmID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(393, 274);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionar.TabIndex = 2;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // clmNome
            // 
            this.clmNome.Text = "Nome";
            this.clmNome.Width = 168;
            // 
            // clmSobrenome
            // 
            this.clmSobrenome.Text = "Sobrenome";
            this.clmSobrenome.Width = 168;
            // 
            // lvHospedes
            // 
            this.lvHospedes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmID,
            this.clmNome,
            this.clmSobrenome});
            this.lvHospedes.FullRowSelect = true;
            this.lvHospedes.GridLines = true;
            this.lvHospedes.HideSelection = false;
            this.lvHospedes.Location = new System.Drawing.Point(41, 37);
            this.lvHospedes.Name = "lvHospedes";
            this.lvHospedes.Size = new System.Drawing.Size(427, 217);
            this.lvHospedes.TabIndex = 1;
            this.lvHospedes.UseCompatibleStateImageBehavior = false;
            this.lvHospedes.View = System.Windows.Forms.View.Details;
            // 
            // clmID
            // 
            this.clmID.Text = "ID";
            this.clmID.Width = 84;
            // 
            // FormSelecionaHospedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 313);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.lvHospedes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSelecionaHospedes";
            this.Text = "FormSelecionaHospedes";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.ColumnHeader clmNome;
        private System.Windows.Forms.ColumnHeader clmSobrenome;
        private System.Windows.Forms.ListView lvHospedes;
        private System.Windows.Forms.ColumnHeader clmID;
    }
}