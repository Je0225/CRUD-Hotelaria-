using System;

namespace HotelariaForms {

    public class Suite {

        public Int32 Id { get; set; }
        public String Tipo { get;  }
        public Int32 Capacidade { get; }
        public Double Diaria { get; }


        public Suite(Int32 id, String tipo, Int32 capacidade, Double diaria) {
            Tipo = tipo;
            Capacidade = capacidade;
            Diaria = diaria;
            Id = id;
        }

    }

}