namespace CineGest {
    internal class Sala {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Colunas { get; set; }
        public int Filas { get; set; }
        public int Lugares { get; set; }
        public override string ToString() {
            return this.Nome;
        }

    }
}
