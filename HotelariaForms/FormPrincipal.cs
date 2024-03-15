using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelariaForms {

    public partial class FormPrincipal: Form {

        private readonly List<Pessoa> hospedes;
        private readonly List<Suite> suites;
        private readonly List<Reserva> reservas;

        public FormPrincipal() {
            InitializeComponent();
            hospedes = new List<Pessoa>();
            suites = new List<Suite>();
            reservas = new List<Reserva>();
        }

        private void tsmiHospedes_Click(object sender, EventArgs e) {
            FormListaHospedes listaHospedes = new FormListaHospedes(hospedes,reservas);
            listaHospedes.ShowDialog(this);
        }

        private void tsmiSuites_Click(object sender, EventArgs e) {
            FormListaSuites listaSuite = new FormListaSuites(suites,reservas);
            listaSuite.ShowDialog(this);
        }

        private void tsmiListar_Click(object sender, EventArgs e) {
            FormListaReservas listaReservas = new FormListaReservas(reservas,suites,hospedes);
            listaReservas.ShowDialog(this);
        }

    }

}