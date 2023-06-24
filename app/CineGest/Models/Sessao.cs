using System;

namespace CineGest {
    internal class Sessao {
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public float Preco { get; set; }
        public Sala SalaID { get; set; }
        public Filme FilmeID { get; set; }

        public override string ToString() {
            return this.Id.ToString();
        }
    }
}
