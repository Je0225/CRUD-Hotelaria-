using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelariaForms {

    public partial class FormListaHospedes: Form {

        private readonly List<Pessoa> Hospedes;

        private readonly List<Reserva> Reservas;

        public FormListaHospedes(List<Pessoa> hospedes, List<Reserva> reservas) {
            InitializeComponent();
            Hospedes = hospedes;
            Reservas = reservas;

            foreach (Pessoa hospede in Hospedes) {
                lvHospedes.Items.Add(new ListViewItem(new[] { hospede.Id.ToString(), hospede.Nome, hospede.Sobrenome }));
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {
            FormCadastroHospedes cadastroHospedes = new FormCadastroHospedes();
            cadastroHospedes.ShowDialog();
            DialogResult result = cadastroHospedes.DialogResult;

            if (result != DialogResult.OK)
                return;

            Int32 IdHospede = Hospedes.Count + 1;
            Pessoa hospede = new Pessoa(IdHospede, cadastroHospedes.Nome, cadastroHospedes.Sobrenome);
            Hospedes.Add(hospede);
            lvHospedes.Items.Add(new ListViewItem(new[] { IdHospede.ToString(), hospede.Nome, hospede.Sobrenome }));
        }

        private void btnRemover_Click(object sender, EventArgs e) {
            ListView.SelectedIndexCollection idxExcluirHospede = lvHospedes.SelectedIndices;

            if (idxExcluirHospede.Count.Equals(0)) {
                return;
            }

            Int32 indx = (Int32)idxExcluirHospede[0];
            foreach (Reserva reserva in Reservas) {
                    foreach (Pessoa hospede in reserva.Hospedes) {
                        if (hospede.Equals(Hospedes[indx])) {
                            MessageBox.Show("Esse hospede está em uma reserva");
                             return;
                        }
                    }
            }
            
            DialogResult resultado = MessageBox.Show("Dejesa excluir este registro? ", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (!resultado.Equals(DialogResult.Yes))
                return;

            Hospedes.RemoveAt(indx);
            lvHospedes.Items.RemoveAt(indx);
            
        }

    }

}