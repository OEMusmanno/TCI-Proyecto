using Campo_TPFinal_BE.Vehiculo;

namespace Campo_TPFinal_BLLContracts.Vehiculo
{
    public interface IEstacionamientoService
    {
        void Actualizar(string id,string ubicacion, int espacios);
        void Borrar(int idEstacionamiento);
        void Crear(string ubicacion, int espacios);
        void liberarEspacio(int idEstacionamiento);
        public List<Estacionamiento> Listar();
        public Estacionamiento ObtenerPorId(int id);
        int ObtenerTotalEspaciosLibres();
        void OcuparEspacio(int id);
    }
}
