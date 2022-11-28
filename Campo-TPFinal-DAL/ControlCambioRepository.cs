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

        public void GuardarCambios(int UsuarioId, string value, string property, string descripcion, string viejoUsuario, string nuevoUsuario)
        {            
            string _commandText = $"INSERT INTO ControlCambio (usuario,descripcion,fechaHora, property,value, viejaInstancia, nuevaInstancia) VALUES ('{UsuarioId}','{descripcion}', '{DataAccess.FechaHora()}', '{property}', '{value}', '{viejoUsuario}', '{nuevoUsuario}' )";
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
            var list = dataAccess.GetPorIdExecuteDataSet("[ControlCambio]", id);
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
            var usuario = cambio.ViejoUsuario;
            usuarioRepository.ActualizarUsuario(usuario);
            var jsonOldValue = JsonSerializer.Serialize(cambio.usuario);
            var jsonNewValue = JsonSerializer.Serialize(cambio.ViejoUsuario);
            GuardarCambios(cambio.usuario.Id, cambio.value, cambio.property, "Se restaura a una version anterior", jsonOldValue, jsonNewValue);
        }

        private void ValorizarEntidad(ControlCambio control, DataRow item)
        {
            control.id = item["id"].ToString();
            control.value = item["value"].ToString();
            control.usuario = JsonSerializer.Deserialize<Usuario>( item["NuevaInstancia"].ToString());
            control.ViejoUsuario = JsonSerializer.Deserialize<Usuario>( item["ViejaInstancia"].ToString());
            control.property = item["property"].ToString();
            control.descripcion = item["descripcion"].ToString();
            control.fecha = DateTime.Parse(item["fechaHora"].ToString());
        }
    }
}
