using Campo_TPFinal_BE.Usuario;
using Campo_TPFinal_DALContracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_DAL
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly IDataAccess _dataAccess;

        public UsuarioRepository(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public List<Usuario> Listar()
        {
            var list = _dataAccess.ExecuteDataSet("SELECT * FROM [Campo].[dbo].[Usuario]");
            var _list = new List<Usuario>();
            foreach (DataRow item in list.Tables[0].Rows)
            {
                Usuario user = new Usuario();
                ValorizarEntidad(user, item);
                _list.Add(user);
            }
            return _list;
        }
        public Usuario ObtenerPorAlias(string alias)
        {
            var list = _dataAccess.ExecuteDataSet("SELECT * FROM[Campo].[dbo].[Usuario] WHERE usuario = '" + alias + "'");
            Usuario usuario = new Usuario();
            ValorizarEntidad(usuario, list.Tables[0].Rows[0]);
            return usuario;
        }

        void ValorizarEntidad(Usuario _usuario, DataRow pDataRow)
        {
            _usuario.alias = pDataRow["usuario"].ToString();
            _usuario.password = pDataRow["contraseña"].ToString();
            _usuario.Id = int.Parse(pDataRow["Id"].ToString()); 
        }

    }
}
