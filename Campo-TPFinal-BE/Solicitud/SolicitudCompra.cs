using Campo_TPFinal_BE.Vehiculo;

namespace Campo_TPFinal_BE.Solicitud
{
    public class SolicitudCompra
    {
        public SolicitudCompra()
        {
            itemDeCompras = new List<ItemDeCompra>();
        }
        public int Id { get; set; }
        public List<ItemDeCompra> itemDeCompras { get; set; }
        public double Total { get; set; }
        public DateTime fechaDeSolicitud { get; set; }
        public Campo_TPFinal_BE.Usuario.Usuario Usuario { get; set; }

        public override string ToString()
        {
            return Id +" - "+ Usuario.alias;
        }
    }

    public class ItemDeCompra 
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public TipoVehiculo tipoVehiculo { get; set; }
        public int cantidad { get; set; }
        public double precioUnitario { get; set; }
        public double subtotal { get { return precioUnitario * cantidad; } }
        public TipoCambio TipoCambio { get; set; }
        public TipoPago TipoPago { get; set; }

    }

    public enum TipoCambio 
    { 
        Pesos=1,
        Dolar=2    
    }
    public enum TipoPago
    {
        Transferencia = 1,
        Efectivo = 2
    }
}
