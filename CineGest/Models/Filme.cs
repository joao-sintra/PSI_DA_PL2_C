namespace CineGest {
    internal class Filme {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Duracao { get; set; }

        public bool Activo { get; set; }

        public Categoria CategoriaID { get; set; }
        public override string ToString() {
            return this.Nome;
        }
    }
}
