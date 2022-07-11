﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BE.Sistema.Idioma
{
    public class Traduccion
    {
        public int Id { get; set; }
        public string Etiqueta { get; set; }
        public string Texto { get; set; }

        public override string ToString()
        {
            return Texto;
        }
    }
}
