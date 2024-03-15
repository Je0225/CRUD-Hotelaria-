using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelariaForms {

    public partial class FormSelecionaHospedes: Form {

        private List<Pessoa> Hospedes;

        public ListView.SelectedIndexCollection IndicesSuites => lvHospedes.SelectedIndices;

        public FormSelecionaHospedes(List<Pessoa> hospedes) {
            InitializeComponent();
            Hospedes = hospedes;

            foreach (Pessoa hospede in Hospedes) {
                lvHospedes.Items.Add(new ListViewItem(new[] { hospede.Nome, hospede.Sobrenome }));
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e) {
            if (IndicesSuites.Count > 0) {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

    }

}