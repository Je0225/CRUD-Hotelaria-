using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelariaForms {

    public partial class FormListaReservas: Form {

        private readonly List<Reserva> Reservas;

        private readonly List<Suite> Suites;

        private readonly List<Pessoa> Hospedes;

        public FormListaReservas(List<Reserva> reservas, List<Suite> suites, List<Pessoa> hospedes) {
            InitializeComponent();
            Reservas = reservas;
            Suites = suites;
            Hospedes = hospedes;

            foreach (Reserva reserva in Reservas) {
                lvReservas.Items.Add(new ListViewItem(new[] { reserva.Suite.Tipo, reserva.DiasReservados.ToString("N0"), reserva.TotalReserva.ToString("F2"), reserva.QtdHospedes.ToString("N0") }));
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {
            FormCadastroReservas cadastroReservas = new FormCadastroReservas(Suites, Hospedes, Reservas);
            cadastroReservas.ShowDialog(this);
            DialogResult DialogCadReservas = cadastroReservas.DialogResult;

            if (DialogCadReservas != DialogResult.OK)
                return;

            Reserva reserva = new Reserva(cadastroReservas.Suite, cadastroReservas.DiasReservados, cadastroReservas.HospedesReserva, cadastroReservas.TotalReserva);
            Reservas.Add(reserva);
            lvReservas.Items.Add(new ListViewItem(new[] { reserva.Suite.Tipo, reserva.DiasReservados.ToString("N0"), reserva.TotalReserva.ToString("F2"), reserva.QtdHospedes.ToString("N0") }));
        }

        private void btnRemover_Click(object sender, EventArgs e) {
            ListView.SelectedIndexCollection idxExcluirReserva = lvReservas.SelectedIndices;

            if (idxExcluirReserva.Count.Equals(0))
                return;

            DialogResult resultado = MessageBox.Show("Dejesa excluir este registro? ", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (!resultado.Equals(DialogResult.Yes)) 
                return;

            foreach (Int32 idx in idxExcluirReserva) {
                Reservas.RemoveAt(idx);
                lvReservas.Items.RemoveAt(idx);
            }

        }

    }

}