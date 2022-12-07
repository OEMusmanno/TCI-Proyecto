using Campo_TPFinal_BE.Sistema;
using Campo_TPFinal_BE.Usuario;
using Campo_TPFinal_BLL.Seguridad;
using Campo_TPFinal_DAL.Sistema.DB;
using Campo_TPFinal_DALContracts;
using Campo_TPFinal_DALContracts.Sistema.DB;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
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

        public void GuardarCambios(string UsuarioId, string value, string property, string descripcion)
        {            
            string _commandText = $"INSERT INTO ControlCambio (usuario,descripcion,fechaHora, property,value) VALUES ('{UsuarioId}','{descripcion}', '{DataAccess.FechaHora()}', '{property}', '{value}')";
            dataAccess.ExecuteNonQuery(_commandText);
        }

        public List<ControlCambio> Listar()
        {
            var list = dataAccess.SelectExecuteDataSet("ControlCambio");
            var _list = new List<ControlCambio>();
            if (list.Tables[0].Rows.Count == 0)
            {
                return _list;
            }            
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
            var list = dataAccess.GetPorIdExecuteDataSet("ControlCambio", id);
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
                    _commandText += $" = {byte.Parse(cambio.value)}";
                    break;
                case "usuario":
                    _commandText += $" = '{cambio.value}'";
                    break;
                default:
                    break;
            }
            _commandText += $" Where id = {cambio.Usuario.Id}";
            dataAccess.ExecuteNonQuery(_commandText);
            GuardarCambios(cambio.Usuario.Id.ToString(), cambio.value, cambio.property, "Se restaura a una version anterior");
        }

        private void ValorizarEntidad(ControlCambio control, DataRow item)
        {
            control.id = item["id"].ToString();
            control.value = item["value"].ToString();
            control.Usuario = usuarioRepository.ObtenerPorId(int.Parse(item["usuario"].ToString()));
            control.property = item["property"].ToString();
            control.descripcion = item["descripcion"].ToString();
            control.fecha = DateTime.Parse(item["fechaHora"].ToString());
        }
    }
}
