using System;

namespace HotelariaForms {
    public class Pessoa {

        public Int32 Id { get; }
        public String Nome { get; }
        public String Sobrenome { get; }

        public Pessoa(Int32 id, String nome, String sobrenome) {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
        }

    }

}