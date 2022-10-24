using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BE.Vehiculo
{
    public class Estacionamiento
    {
        public string ubicacion { get; set; }
        public int Id { get; set; }
        public int espaciosTotal { get; set; }
        public int espaciosLibres { get; set; }

        public Estacionamiento()
        {
        }

        public Estacionamiento(string ubicacion, int espacios)
        {
            this.ubicacion = ubicacion;
            this.espaciosTotal = espacios;
            this.espaciosLibres = espacios;
        }

        public override string ToString()
        {
            return Id.ToString(); 
        }

    }
}
