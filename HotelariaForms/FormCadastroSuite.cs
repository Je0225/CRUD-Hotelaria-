using System;
using System.Windows.Forms;

namespace HotelariaForms {

    public partial class FormCadastroSuite: Form {

        public String Tipo => cbTipo.SelectedItem.ToString();

        public Int32 Capacidade;

        public Double Diaria; 

        public FormCadastroSuite() {
            InitializeComponent();

            cbTipo.Items.Insert(0, "Padrão");
            cbTipo.Items.Insert(1, "Luxo");
            cbTipo.Items.Insert(2, "Muito luxo");
        }

        private Boolean ValidaFormulario() {
            if (cbTipo.SelectedIndex < 0) {
                MessageBox.Show("Não é possível salvar a informação se o campo 'Tipo' não estiver selecionado");
                return false;
            }
            if (Capacidade <= 0) {
                MessageBox.Show("Não é possível salvar a informação se o campo 'Capacidade' estiver vazio ou igual a zero");
                return false;
            }
            if (Diaria <= 0) {
                MessageBox.Show("Não é possível salvar a informação se o campo 'Diária' estiver vazio ou igual a zero");
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

        private void tbCapacidade_KeyPress(object sender, KeyPressEventArgs e) {
            if ((!Char.IsNumber(e.KeyChar) && !e.KeyChar.Equals('\b')) || e.KeyChar.Equals('¹') || e.KeyChar.Equals('²') || e.KeyChar.Equals('³')) {
                e.Handled = true;
            }
        }

        private void tbDiaria_KeyPress(object sender, KeyPressEventArgs e) {

            switch (e.KeyChar) {
                case '.':
                    e.Handled = true;
                    if (!tbDiaria.Text.Trim().Equals("")) {
                        SendKeys.Send(",");
                    }
                    break;
                case ',':
                    if (tbDiaria.Text.Trim().Equals("") || tbDiaria.Text.Contains(",")) {
                        e.Handled = true;
                    }
                    break;
                default:
                    if (e.KeyChar.Equals('¹') || e.KeyChar.Equals('²') || e.KeyChar.Equals('³'))
                        e.Handled = true;

                    if (!Char.IsNumber(e.KeyChar) && !e.KeyChar.Equals('\b'))
                        e.Handled = true;

                    Int32 idxVirgula = tbDiaria.Text.IndexOf(',');
                    if (idxVirgula < tbDiaria.SelectionStart && tbDiaria.Text.Length - 3 == idxVirgula && idxVirgula >= 0 && !e.KeyChar.Equals('\b'))
                        e.Handled = true;
                    break;
            }
        }

        private void tbCapacidade_Leave(object sender, EventArgs e) {
            Int32 n = 0;
            int.TryParse(tbCapacidade.Text, out n);
            tbCapacidade.Text = n.ToString("N0");
            Capacidade = n;
        }

        private void tbDiaria_Leave(object sender, EventArgs e) {
            Double n = 0; 
            Double.TryParse(tbDiaria.Text, out n);
            tbDiaria.Text = n.ToString("N");
            Diaria = n;
        }

    }

}