﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineGest
{
    internal class Pessoa
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Morada { get; set; }

        public override string ToString() {
            return this.Nome;
        }
    }
}
