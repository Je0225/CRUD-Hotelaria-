using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelariaForms {

    public partial class FormSelecionaSuite: Form {

        private readonly List<Suite> Suites;
        public Int32 IndiceSuite => lvSuites.SelectedIndices[0];
        
        public FormSelecionaSuite(List<Suite> suites) {
            InitializeComponent();
            Suites = suites;

            foreach (var suite in Suites) {
                lvSuites.Items.Add(new ListViewItem(new[] {suite.Id.ToString(), suite.Tipo, suite.Capacidade.ToString("N0"), suite.Diaria.ToString("F2") }));
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e) {
            if (lvSuites.SelectedIndices.Count > 0) {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

    }

}