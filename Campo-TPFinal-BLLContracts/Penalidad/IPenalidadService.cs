namespace Campo_TPFinal_BLLContracts.Penalidad
{
    public interface IPenalidadService
    {
        List<Campo_TPFinal_BE.Usuario.Penalidad> Listar();
        void AplicarPenalidad(string penalidad, int idUsuario);
    }
}
