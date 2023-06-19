namespace CineGest {
    internal class Bilhete {
        public int Id { get; set; }
        public int Lugar { get; set; }
        public bool Estado { get; set; }
        public Cliente ClienteID { get; set; }
        public Funcionario FuncionarioID { get; set; }
        public Sessao SessaoID { get; set; }
      
    }
}

