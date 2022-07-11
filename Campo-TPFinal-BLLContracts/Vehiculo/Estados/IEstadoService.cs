using Campo_TPFinal_BE.Vehiculo;
using Campo_TPFinal_BE.Vehiculo.Estado;

namespace Campo_TPFinal_BLLContracts.Vehiculo.Estados
{
    public interface IEstadoService
    {
        public void cambioDeEstado(Reservado estado, Auto auto);
        public void cambioDeEstado(Disponible estado, Auto auto);
        public void cambioDeEstado(bool estado, Auto auto);
    }
}
