using Campo_TPFinal_DALContracts;

namespace Campo_TPFinal_DAL
{
    public class BitacoraRepository: IBitacoraRepository
    {
        private readonly IDataAccess dataAccess;

        public BitacoraRepository(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public void GuardarBitacora(string descripcion)
        {
            var fechaHora = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss.FFF";
            string _commandText = "INSERT INTO Bitacora (descripcion,fechaHora) VALUES ('"+ descripcion + "', '"+ fechaHora.ToString(format) + "' )";
            dataAccess.ExecuteNonQuery(_commandText);
        }
    }
}
