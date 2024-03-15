using System;
using System.Collections.Generic;

namespace HotelariaForms {

    public class Reserva {

        public Suite Suite { get; }

        public Int32 DiasReservados { get; }

        public List<Pessoa> Hospedes { get; }

        public Double TotalReserva { get; }

        public Int32 QtdHospedes { get; }

        public Reserva(Suite suite, Int32 diasReservados, List<Pessoa> hospedes, Double totalReserva) {
            Suite = suite;
            DiasReservados = diasReservados;
            Hospedes = hospedes;
            TotalReserva = totalReserva;
            QtdHospedes = Hospedes.Count;
        }

    }

}
