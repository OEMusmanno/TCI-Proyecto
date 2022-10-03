namespace Campo_TPFinal_DALContracts.Sistema.DB
{
    public interface IDigitoVerificadorRepository
    {
        void CalcularDigitoVerificadorVertical();
        void CalcularDigitoVerificadorHorizontal();
        bool CheckDigitoVerificadorHorizontal();
        bool CheckDigitoVerificadorVertical();
    }
}
