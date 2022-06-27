using Campo_TPFinal_BE.Usuario;
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
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly IDataAccess _dataAccess;

        public UsuarioRepository(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public List<Usuario> Listar()
        {
            var list = _dataAccess.ExecuteDataSet("SELECT * FROM [Campo].[dbo].[Usuario] where Bloqueado = 0");
            var _list = new List<Usuario>();
            foreach (DataRow item in list.Tables[0].Rows)
            {
                Usuario user = new Usuario();
                ValorizarEntidad(user, item);
                _list.Add(user);
            }
            return _list;
        }

        public List<Usuario> ListarBloqueados()
        {
            var list = _dataAccess.ExecuteDataSet("SELECT * FROM [Campo].[dbo].[Usuario] where Bloqueado = 1");
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


        public void AgregarUsuario(Usuario user)
        {           
            string _commandText = "INSERT INTO [dbo].[Usuario] ([usuario] ,[contraseña], bloqueado, id_rol) VALUES ('" + user.alias + "', '" + user.password + "' ,"+ 0 +","+ user.rol.id +")";
            _dataAccess.ExecuteNonQuery(_commandText);
        }

        public void BorrarUsuario(int userId)
        {
            string _commandText = "DELETE FROM [dbo].[Usuario] WHERE id = " + userId;
            _dataAccess.ExecuteNonQuery(_commandText);
        }

        public void ActualizarUsuario(Usuario user)
        {
            string _commandText = "UPDATE [dbo].[Usuario] SET [usuario] = '" + user.alias + "' ,[contraseña] ='" + user.password + "',[id_rol] = "+ user.rol.id + " WHERE id = " + user.Id;
            _dataAccess.ExecuteNonQuery(_commandText);
        }
        public void desbloquear(int userId)
        {
            string _commandText = "UPDATE [dbo].[Usuario] SET [bloqueado] = 0 WHERE id = " + userId;
            _dataAccess.ExecuteNonQuery(_commandText);
        }

        public void bloquear(int userId)
        {
            string _commandText = "UPDATE [dbo].[Usuario]  SET [bloqueado] = 1 WHERE id = " + userId;
            _dataAccess.ExecuteNonQuery(_commandText);
        }
    }
}
