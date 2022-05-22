using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BE
{
    public class Estacionamiento
    {
        public string ubicacion;
        public int Id { get; set; }

        public Estacionamiento()
        {
        }

        public Estacionamiento(string ubicacion)
        {
            this.ubicacion = ubicacion;
        }
    }
}
