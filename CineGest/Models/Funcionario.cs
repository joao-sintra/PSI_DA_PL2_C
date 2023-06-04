using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineGest
{
    internal class Funcionario
    {
        public int Id { get; set; }

        public float Salario { get; set; }

        public string Funcao { get; set; }

        public Pessoa PessoaId { get; set; }
    }
}
