﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineGest
{
    internal class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Activa { get; set; }

        public override string ToString() {
            return this.Nome;
        }
    }
}