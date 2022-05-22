using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BE.Auto
{
    public class TipoVehiculo
    {
        public string Nombre { get; set; }    
        public double MinutoRecorrido { get; set; }
        public double MinutoDetenido { get; set; }
        public double PrecioHora { get; set; }
        public double PrecioDia { get; set; }
        public double PrecioKmExtra { get; set; }
        public int Id { get; set; }

        public TipoVehiculo(string nombre, double minutoRecorrido, double minutoDetenido, double precioHora, double precioDia, double precioKmExtra)
        {
            Nombre = nombre;
            MinutoRecorrido = minutoRecorrido;
            MinutoDetenido = minutoDetenido;
            PrecioHora = precioHora;
            PrecioDia = precioDia;
            PrecioKmExtra = precioKmExtra;
        }

        public TipoVehiculo()
        {
        }
    }
}
