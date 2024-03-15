using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelariaForms {

    public partial class FormListaSuites: Form {

        private readonly List<Suite> Suites;
        private readonly List<Reserva> Reservas;

        public FormListaSuites(List<Suite> suites, List<Reserva> reservas) {
            InitializeComponent();
            Suites = suites;
            Reservas = reservas;

            foreach (Suite suite in Suites) {
                lvSuites.Items.Add(new ListViewItem(new[] { suite.Id.ToString(), suite.Tipo, suite.Capacidade.ToString("N0"), suite.Diaria.ToString("F2") }));
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {
            FormCadastroSuite cadastroSuite = new FormCadastroSuite();
            cadastroSuite.ShowDialog(this);
            DialogResult dialogCadSuite = cadastroSuite.DialogResult;
            
            if (dialogCadSuite != DialogResult.OK)
                return;

            Int32 IdSuite = Suites.Count + 1;
            Suite suite = new Suite(IdSuite, cadastroSuite.Tipo, cadastroSuite.Capacidade, cadastroSuite.Diaria);
            Suites.Add(suite);
            lvSuites.Items.Add(new ListViewItem(new[] { suite.Id.ToString(), suite.Tipo, suite.Capacidade.ToString("N0"), suite.Diaria.ToString("F2") }));
        }

        private void btnRemover_Click(object sender, EventArgs e) {
            ListView.SelectedIndexCollection idxExcluirSuite = lvSuites.SelectedIndices;

            if (idxExcluirSuite.Count.Equals(0)) 
                return;

            Int32 indx = (Int32)idxExcluirSuite[0];
            foreach (Reserva reserva in Reservas) {
                if (reserva.Suite.Equals(Suites[indx])) {
                    MessageBox.Show("Essa suite está em uma reserva");
                    return;
                }
            }

            DialogResult resultado = MessageBox.Show("Dejesa excluir este registro? ", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resultado != DialogResult.Yes)
                return;
            
            Suites.RemoveAt(indx); 
            lvSuites.Items.RemoveAt(indx);
        }

    }

}