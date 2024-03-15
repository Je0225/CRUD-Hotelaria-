using System;
using System.Windows.Forms;

namespace HotelariaForms {

    public partial class FormCadastroHospedes: Form {

        public String Nome => tbNome.Text.Trim();
        public String Sobrenome => tbSobrenome.Text.Trim();

        public FormCadastroHospedes() {
            InitializeComponent();
        }

        public Boolean ValidaFormulario() {
            if (Sobrenome.Length < 3 || Nome.Length < 3) {
                MessageBox.Show("Nome e sobrenome precisam ter no mínimo 3 letras");
                return false;
            }

            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            if (ValidaFormulario()) {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }

}