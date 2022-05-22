using Campo_TPFinal_BE;

namespace Campo_TPFinal_DALContracts.Vehiculo
{
    public interface IEstacionamientoRepository
    {
        List<Estacionamiento> Listar();
        Estacionamiento ObtenerPorId(int id);
    }
}
