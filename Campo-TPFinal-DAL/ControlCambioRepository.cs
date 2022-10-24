using Campo_TPFinal_BE.Sistema;
using Campo_TPFinal_BE.Usuario;
using Campo_TPFinal_BLL.Seguridad;
using Campo_TPFinal_DALContracts;
using Campo_TPFinal_DALContracts.Sistema.DB;
using Microsoft.SqlServer.Server;
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

        public void GuardarCambios(int UsuarioId, string value, string property, string descripcion)
        {
            var fechaHora = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss.FFF";
            string _commandText = "INSERT INTO ControlCambio (usuario,descripcion,fechaHora, property,value) VALUES ('" + UsuarioId + "','" + descripcion + "', '" + fechaHora.ToString(format) + "', '" + property + "', '" + value + "' )";
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

        private ControlCambio ObtenerPorId(string id)
        {
            var list = dataAccess.ExecuteDataSet("SELECT * FROM [ControlCambio] where id = " + id);
            var _list = new ControlCambio();
            foreach (DataRow item in list.Tables[0].Rows)
            {
                ValorizarEntidad(_list, item);
            }
            return _list;
        }

        public void RestaurarVersion(string id)
        {
            var cambio = ObtenerPorId(id);
            string _commandText = $"Update Usuario SET {cambio.property}";
            switch (cambio.property)
            {
                case "id_rol":
                    _commandText += $" = {int.Parse(cambio.value)}";
                    break;
                case "Contraseña":
                    _commandText += $" = '{cambio.value}'";
                    break;
                case "bloqueado":
                    _commandText += $" = {byte.Parse( cambio.value)}";
                    break;
                case "usuario":
                    _commandText += $" = '{cambio.value}'";
                    break;
                default:
                    break;
            }
            _commandText += $" Where id = {cambio.usuario.Id}";
            dataAccess.ExecuteNonQuery(_commandText);
            GuardarCambios(cambio.usuario.Id, cambio.value, cambio.property, "Se restaura a una version anterior");
        }

        private void ValorizarEntidad(ControlCambio control, DataRow item)
        {
            control.id = item["id"].ToString();
            control.value = item["value"].ToString();
            control.usuario = usuarioRepository.ObtenerPorId(int.Parse(item["usuario"].ToString()));
            control.property = item["property"].ToString();
            control.descripcion = item["descripcion"].ToString();
            control.fecha = DateTime.Parse(item["fechaHora"].ToString());
        }
    }
}
