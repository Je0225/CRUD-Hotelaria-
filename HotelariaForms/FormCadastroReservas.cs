using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelariaForms {

    public partial class FormCadastroReservas: Form {

        public Suite Suite;

        private readonly List<Suite> Suites;

        private readonly List<Pessoa> Hospedes;

        private readonly List<Reserva> Reservas;

        public List<Pessoa> HospedesReserva;

        public Int32 DiasReservados;

        public Double TotalReserva;

        public FormCadastroReservas(List<Suite> suites, List<Pessoa> hospedes, List<Reserva> reservas) {
            InitializeComponent();
            Suites = suites;
            Hospedes = hospedes;
            Reservas = reservas;
        }

        private void btnAddSuite_Click(object sender, EventArgs e) {
            FormSelecionaSuite formSelecionaSuite = new FormSelecionaSuite(Suites);
            formSelecionaSuite.ShowDialog();

            if (formSelecionaSuite.DialogResult != DialogResult.OK)
                return;

            foreach (Reserva reserva in Reservas) {
                if (reserva.Suite.Equals(Suites[formSelecionaSuite.IndiceSuite])) {
                    MessageBox.Show("Essa suite já está ocupada");
                    return;
                }
            }
            Suite = Suites[formSelecionaSuite.IndiceSuite];
            tbSuite.Text = Suite.Tipo;
            CalculaTotalReserva();
        }

        private void btnAddHospede_Click(object sender, EventArgs e) {
            if (HospedesReserva == null)
                HospedesReserva = new List<Pessoa>();

            FormSelecionaHospedes selecionaHospedes = new FormSelecionaHospedes(Hospedes);
            selecionaHospedes.ShowDialog();

            foreach (Reserva reserva in Reservas) {
                foreach (Pessoa hospede in reserva.Hospedes) {
                    foreach (Int32 indice in selecionaHospedes.IndicesSuites) {
                        if (hospede.Equals(Hospedes[indice])) {
                            MessageBox.Show($"O(a) hospede {Hospedes[indice].Nome} já está em outra reserva");
                            return;
                        }
                    }
                }
            }
            foreach (Pessoa hospede in HospedesReserva) {
                foreach (Object indice in selecionaHospedes.IndicesSuites) {
                    if (hospede.Equals(Hospedes[(Int32)indice])) {
                        MessageBox.Show("O hospede selecionado já está nessa reserva");
                        return;
                    }
                }
            }
            foreach (Object indice in selecionaHospedes.IndicesSuites) {
                if (!HospedesReserva.Contains(Hospedes[(Int32)indice])) {
                    HospedesReserva.Add(Hospedes[(Int32)indice]);
                    lvHospedes.Items.Add(new ListViewItem(new[] { Hospedes[(Int32)indice].Nome, Hospedes[(Int32)indice].Sobrenome }));
                }
            }
            if (HospedesReserva.Count.Equals(0)) {
                foreach (Object indice in selecionaHospedes.IndicesSuites) {
                    HospedesReserva.Add(Hospedes[(Int32)indice]);
                    lvHospedes.Items.Add(new ListViewItem(new[] { Hospedes[(Int32)indice].Nome, Hospedes[(Int32)indice].Sobrenome }));
                }
            }
        }

        private void CalculaTotalReserva() {
            if (!tbDiasReservados.Text.Trim().Equals("") && Suite != null) {
                if (DiasReservados <= 10 && !DiasReservados.Equals(0)) {
                    TotalReserva = DiasReservados * Suite.Diaria;
                } else {
                    TotalReserva = DiasReservados * Suite.Diaria * 0.9;
                }
            } else {
                TotalReserva = 0;
            }
            tbTotalReserva.Text = TotalReserva.ToString("F");
        }

        private void tbDiasReservados_TextChanged(object sender, EventArgs e) {
            CalculaTotalReserva();
        }

        private Boolean ValidaFormulario() {
            if (Suite == null) {
                MessageBox.Show("Não há nenhuma suite selecionada");
                return false;
            }

            if (DiasReservados == null || DiasReservados <= 0) {
                MessageBox.Show("Informe a quantidade de dias reservados");
                return false;
            }

            if (TotalReserva == null || TotalReserva <= 0) {
                MessageBox.Show("Verifique a quantia de dias reservados para calcular o total da reserva");
                return false;
            }

            if (HospedesReserva == null || HospedesReserva.Count.Equals(0)) {
                MessageBox.Show("Não há hospedes na reserva");
                return false;
            }

            if (HospedesReserva.Count > Suite.Capacidade) {
                MessageBox.Show("A quantidade de hospedes é maior do que a capacidade da suite");
                return false;
            }

            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            if (!ValidaFormulario())
                return;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void tbDiasReservados_KeyPress(object sender, KeyPressEventArgs e) {
            if ((!Char.IsNumber(e.KeyChar) && !e.KeyChar.Equals('\b')) || e.KeyChar.Equals('¹') || e.KeyChar.Equals('²') || e.KeyChar.Equals('³')) {
                e.Handled = true;
            }

        }

        private void tbDiasReservados_Leave(object sender, EventArgs e) {
            Int32 n = 0;
            Int32.TryParse(tbDiasReservados.Text.Trim(), out n);
            tbDiasReservados.Text = n.ToString("N0");
            DiasReservados = n;
        }

    }

}