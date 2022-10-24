using Campo_TPFinal_BE.Vehiculo;

namespace Campo_TPFinal_DALContracts.Vehiculo
{
    public interface IEstacionamientoRepository
    {
        void Actualizar(string id, string ubicacion, int espacios);
        void Borrar(int idEstacionamiento);
        void Crear(string ubicacion, int espacios);
        void liberarEspacio(int idEstacionamiento);
        List<Estacionamiento> Listar();
        Estacionamiento ObtenerPorId(int id);
        int ObtenerTotalEspaciosLibres();
        void OcuparEspacio(int id);
    }
}
