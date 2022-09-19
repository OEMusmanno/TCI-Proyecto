using Campo_TPFinal_BE.Sistema.Perfil;
using Campo_TPFinal_BE.Usuario;
using Campo_TPFinal_DALContracts.Sistema.DB;
using Campo_TPFinal_DALContracts.Sistema.Perfiles;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_DAL.Sistema.Perfiles
{
    public class PerfilRepository : IPerfilRepository
    {
        private readonly IDataAccess _dataAccess;

        public PerfilRepository(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        private List<Rol> getRoles(int familiaId)
        {

            var list = _dataAccess.ExecuteDataSet("SELECT * FROM [Campo].[dbo].[Patente_Familia]");
            var _list = new List<Rol>();
            foreach (DataRow item in list.Tables[0].Rows)
            {                
                if (item["tipo"].ToString() == "patente")
                {
                    _list.Add(getPatente((int)item["id_patente"]));
                }
                else
                {
                    _list.Add(getFamilia((int)item["id_familia"]));
                }
            }
            return _list;
        }

        private List<Rol> getRolesPorFamilia(int familiaId)
        {

            var list = _dataAccess.ExecuteDataSet("SELECT * FROM [Campo].[dbo].[Patente_Familia] where id_familia =" + familiaId);
            var _list = new List<Rol>();
            foreach (DataRow item in list.Tables[0].Rows)
            {
                if (item["tipo"].ToString() == "patente")
                {
                    _list.Add(getPatente((int)item["id_patente"]));
                }
                else
                {
                    _list.Add(getAllFamiliaPorId((int)item["id_patente"]));
                }
            }
            return _list;
        }

        public List<Rol> getAllRoles()
        {
            var listRol = new List<Rol>();
            listRol.AddRange(getAllFamilia());
            listRol.AddRange(getAllPatente());

            return listRol;
        }

        public List<Familia> getAllFamilia()
        {

            var list = _dataAccess.ExecuteDataSet("SELECT * FROM [Familia]");
            var _list = new List<Familia>();
            foreach (DataRow item in list.Tables[0].Rows)
            {
                _list.Add(new Familia() { name = item["nombre"].ToString(), id = (int)item["id"], patentes = getRolesPorFamilia((int)item["id"]) });
            }
            return _list;
        }

        public Rol getAllFamiliaPorId(int familiaId)
        {

            var list = _dataAccess.ExecuteDataSet(string.Format("SELECT * FROM [Familia] WHERE id = {0}", familiaId));
            var _list = new List<Familia>();
            foreach (DataRow item in list.Tables[0].Rows)
            {
                _list.Add(new Familia() { name = item["nombre"].ToString(), id = (int)item["id"], patentes = getRolesPorFamilia((int)item["id"]) });
            }
            return _list.FirstOrDefault();
        }


        public Familia getFamilia(int familiaId)
        {
            var list = _dataAccess.ExecuteDataSet("SELECT * FROM [Familia] where [id] = "+  familiaId);
            var _list = new List<Familia>();
            foreach (DataRow item in list.Tables[0].Rows)
            {
                Familia Familia = new Familia();
                Familia.id = (int)item["Id"];
                Familia.name = item["nombre"].ToString();
                _list.Add(Familia);
            }
            return _list.FirstOrDefault();
        }

        private Patente getPatente(int patenteId)
        {
            var list = _dataAccess.ExecuteDataSet("SELECT * FROM [Patente] where [id] = " + patenteId);
            var _list = new List<Patente>();
            foreach (DataRow item in list.Tables[0].Rows)
            {
                Patente Patente = new Patente();
                Patente.id = (int)item["Id"];
                Patente.name = item["nombre"].ToString();
                _list.Add(Patente);
            }
            return _list.FirstOrDefault();
        }

        private Familia getFamiliaPorNombre(string familia)
        {
            var list = _dataAccess.ExecuteDataSet("SELECT * FROM [Familia] where [nombre] = '" + familia+ "'");
            var _list = new List<Familia>();
            foreach (DataRow item in list.Tables[0].Rows)
            {
                Familia Familia = new Familia();
                Familia.id = (int)item["Id"];
                Familia.name = item["nombre"].ToString();
                _list.Add(Familia);
            }
            return _list.FirstOrDefault();
        }

        private Patente getPatentePorNombre(string patente)
        {
            var list = _dataAccess.ExecuteDataSet("SELECT * FROM [Patente] where [nombre] = '" + patente + "'");
            var _list = new List<Patente>();
            foreach (DataRow item in list.Tables[0].Rows)
            {
                Patente Patente = new Patente();
                Patente.id = (int)item["Id"];
                Patente.name = item["nombre"].ToString();
                _list.Add(Patente);
            }
            return _list.FirstOrDefault();
        }

        public List<Patente> getAllPatente()
        {
            var list = _dataAccess.ExecuteDataSet("SELECT * FROM [Campo].[dbo].[Patente]");
            var _list = new List<Patente>();
            foreach (DataRow item in list.Tables[0].Rows)
            {
                Patente Patente = new Patente();
                Patente.id = (int)item["Id"];
                Patente.name = item["nombre"].ToString();
                _list.Add(Patente);
            }
            return _list;
        }

        public void AddRol(Rol rol)
        {
            string _commandText = string.Format("INSERT INTO {0} (nombre) VALUES ('{1}');", rol.GetType().Name == "Familia" ? "familia" : "patente", rol.name );
            _dataAccess.ExecuteNonQuery(_commandText);
                      
            if (rol.GetType().Name == "Familia")
            {
                var familia = (Familia)rol;
                foreach (var child in familia.patentes)
                {
                    familia = getFamiliaPorNombre(familia.name);
                    Rol subchild = familia;
                    if (child.GetType().Name == "Familia")
                    {
                        subchild = getFamiliaPorNombre(child.name);
                    }
                    else
                    {
                        subchild = getPatentePorNombre(child.name);
                    }
                    _commandText = string.Format("INSERT INTO [Patente_Familia] (id_familia, id_patente, tipo) VALUES ('{0}', '{1}', '{2}');", familia.id, subchild.id, child.GetType().Name == "Familia" ? "familia" : "patente");
                    _dataAccess.ExecuteNonQuery(_commandText);
                }               
            }
        }
        public void DeleteRol(Rol rol)
        {
            string _commandText = string.Format("DELETE FROM patente_familia WHERE id_Familia = {0} or id_patente = {0}", rol.id);
            _dataAccess.ExecuteNonQuery(_commandText);

             _commandText = string.Format("DELETE FROM {0} WHERE id = {1}", rol.GetType().Name == "Familia" ? "familia" : "patente", rol.id);
            _dataAccess.ExecuteNonQuery(_commandText);
            
             
        }

        public void FirstRun() { 
            
            
        
        }
    }
}
