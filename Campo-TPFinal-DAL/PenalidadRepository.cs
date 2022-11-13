using Campo_TPFinal_BE.Usuario;
using Campo_TPFinal_DAL.Sistema.DB;
using Campo_TPFinal_DALContracts;
using Campo_TPFinal_DALContracts.Sistema.DB;
using System.Data;

namespace Campo_TPFinal_DAL
{
    public class PenalidadRepository: IPenalidadRepository
    {
        private readonly IDataAccess _dataAccess;

        public PenalidadRepository(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public void AplicarPenalidad(int idPenalidad, int idUsuario)
        {
            string _commandText = "INSERT INTO [dbo].[UsuarioPenalidad] ([id_Penalidad] ,[id_usuario] ,[fecha]) VALUES (" + idPenalidad + ", " + idUsuario + ",'" + DataAccess.FechaHora() + "')";
            _dataAccess.ExecuteNonQuery(_commandText);
        }

        public List<Penalidad> Listar()
        {
            var list = _dataAccess.ExecuteDataSet("SELECT * FROM [Campo].[dbo].[Penalidad]");
            var _list = new List<Penalidad>();
            foreach (DataRow item in list.Tables[0].Rows)
            {
                Penalidad penalidad = new Penalidad();
                ValorizarEntidad(penalidad, item);
                _list.Add(penalidad);
            }
            return _list;
        }

        void ValorizarEntidad(Penalidad penalidad, DataRow pDataRow)
        {
            penalidad.id = int.Parse(pDataRow["Id"].ToString());
            penalidad.descripcion = pDataRow["descripcion"].ToString();
            penalidad.precio = double.Parse(pDataRow["precio"].ToString());
        }       

        public int ObtenerPenalidad(string penalidad)
        {
            var value = (int)_dataAccess.ExecuteScalar(
                  "SELECT Id FROM [Penalidad] Where descripcion LIKE ('%"+ penalidad + "%')");

            return value;
        }
    }
}
