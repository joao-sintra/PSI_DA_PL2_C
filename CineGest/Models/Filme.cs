﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineGest
{
    internal class Filme
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public TimeSpan Duracao { get; set; }
        public bool Activo { get; set; }
        
    }
}