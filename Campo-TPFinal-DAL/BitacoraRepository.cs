using Campo_TPFinal_BE.Sistema;
using Campo_TPFinal_BLL.Seguridad;
using Campo_TPFinal_DALContracts;
using Campo_TPFinal_DALContracts.Sistema.DB;
using System.Data;

namespace Campo_TPFinal_DAL
{
    public class BitacoraRepository: IBitacoraRepository
    {
        private readonly IDataAccess dataAccess;
        private readonly IUsuarioRepository usuarioRepository;

        public BitacoraRepository(IDataAccess dataAccess, IUsuarioRepository usuarioRepository)
        {
            this.dataAccess = dataAccess;
            this.usuarioRepository = usuarioRepository;
        }

        public void GuardarBitacora(string descripcion, string riesgo)
        {
            var fechaHora = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss.FFF";
            string _commandText = "INSERT INTO Bitacora (usuario,descripcion,fechaHora, riesgo) VALUES ('" + (Session.GetInstance()?.usuario?.Id ?? 102 )+ "','" + descripcion + "', '"+ fechaHora.ToString(format) + "', '" + riesgo + "' )";
            dataAccess.ExecuteNonQuery(_commandText);
        }

        public List<BitacoraLog> Listar()
        {
            var list = dataAccess.ExecuteDataSet("SELECT * FROM [Campo].[dbo].[Bitacora]");
            var _list = new List<BitacoraLog>();
            foreach (DataRow item in list.Tables[0].Rows)
            {
                BitacoraLog log = new BitacoraLog();
                ValorizarEntidad(log, item);
                _list.Add(log);
            }
            return _list;
        }

        private void ValorizarEntidad(BitacoraLog log, DataRow item)
        {
            log.id = item["id"].ToString();
            log.descripcion = item["descripcion"].ToString();
            log.usuario = usuarioRepository.ObtenerPorId(int.Parse(item["usuario"].ToString()));
            log.riesgo = item["riesgo"].ToString();
            log.fecha = DateTime.Parse(item["fechaHora"].ToString());
        }
    }
}
