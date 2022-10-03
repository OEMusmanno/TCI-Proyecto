using Campo_TPFinal_BE.Sistema;
using Campo_TPFinal_BLL.Seguridad;
using Campo_TPFinal_DALContracts;
using Campo_TPFinal_DALContracts.Sistema.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_DAL
{
    public class ControlCambioRepository: IControlCambioRepository
    {

        private readonly IDataAccess dataAccess;
        private readonly IUsuarioRepository usuarioRepository;

        public ControlCambioRepository(IDataAccess dataAccess, IUsuarioRepository usuarioRepository)
        {
            this.dataAccess = dataAccess;
            this.usuarioRepository = usuarioRepository;
        }


        public void GuardarCambios(string Version, string descripcion)
        {
            var fechaHora = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss.FFF";
            string _commandText = "INSERT INTO ControlCambio (usuario,descripcion,fechaHora, version) VALUES ('" + (Session.GetInstance()?.usuario?.Id ?? 102) + "','" + descripcion + "', '" + fechaHora.ToString(format) + "', '" + Version + "' )";
            dataAccess.ExecuteNonQuery(_commandText);
        }

        public List<ControlCambio> Listar()
        {
            var list = dataAccess.ExecuteDataSet("SELECT * FROM [ControlCambio]");
            var _list = new List<ControlCambio>();
            foreach (DataRow item in list.Tables[0].Rows)
            {
                ControlCambio control = new ControlCambio();
                ValorizarEntidad(control, item);
                _list.Add(control);
            }
            return _list;
        }

        private void ValorizarEntidad(ControlCambio control, DataRow item)
        {
            control.id = item["id"].ToString();
            control.descripcion = item["descripcion"].ToString();
            control.usuario = usuarioRepository.ObtenerPorId(int.Parse(item["usuario"].ToString()));
            control.version = item["version"].ToString();
            control.fecha = DateTime.Parse(item["fechaHora"].ToString());
        }
    }
}
