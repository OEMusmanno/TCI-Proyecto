using Campo_TPFinal_BE.Sistema.Idioma;
using Campo_TPFinal_DALContracts.Sistema.DB;
using System.Data;

namespace Campo_TPFinal_DALContracts.Sistema.Idioma
{
    public class TraductorRepository : ITraductorRepository
    {

        private readonly IDataAccess _dataAccess;

        public TraductorRepository(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public List<Lenguaje> ObtenerIdiomas()
        {
            var list = _dataAccess.ExecuteDataSet("SELECT * FROM [Campo].[dbo].[Idioma]");
            var _list = new List<Lenguaje>();
            foreach (DataRow item in list.Tables[0].Rows)
            {
                Lenguaje lenguaje = new Lenguaje();
                lenguaje.Default = (bool)item["Default"];
                lenguaje.Nombre = item["Nombre"].ToString();
                lenguaje.id = (int)item["Id"];
                
                _list.Add(lenguaje);
            }
            return _list;
        }

        public  Lenguaje ObtenerIdiomaDefault() => ObtenerIdiomas().FirstOrDefault(i => i.Default);

        public Lenguaje ObtenerIdioma(string nombre) => ObtenerIdiomas().FirstOrDefault(i => i.Nombre == nombre);

        public IDictionary<string, Traduccion> ObtenerTraducciones(Lenguaje idioma = null)
        {
            //si no hay idioma definido, traigo el idioma por default
            if (idioma == null)
            {
                idioma = ObtenerIdiomaDefault();
            }

            var list = _dataAccess.ExecuteDataSet("SELECT t.id ,t.texto as texto, t.tag FROM traduccion t  WHERE t.id_idioma = " + idioma.id);
            IDictionary<string, Traduccion> _traducciones = new Dictionary<string, Traduccion>();

            foreach (DataRow item in list.Tables[0].Rows)
            {
                Traduccion traduccion = new Traduccion();
                traduccion.Id = int.Parse(item["id"].ToString());
                traduccion.Etiqueta = item["Tag"].ToString();
                traduccion.Texto = item["Texto"].ToString();  
                _traducciones.Add(traduccion.Etiqueta, traduccion);
            }
            return _traducciones;
        }

        public void CrearIdioma(string nombre)
        {
            string _commandText = string.Format("INSERT INTO IDIOMA (nombre, [default]) VALUES ('{0}',0)", nombre);
            _dataAccess.ExecuteNonQuery(_commandText);
        }

        public void CrearTraduccionesVaciasParaNuevoIdioma(int id_Idioma) {

            var _commandText= new System.Text.StringBuilder(); 

            foreach (var item in ObtenerTraducciones(ObtenerIdiomaDefault()).Keys)
            {
                _commandText.AppendLine( string.Format("\nINSERT INTO Traduccion (id_Idioma, tag, texto) VALUES ({0},'{1}', '')", id_Idioma, item));

            }
            _dataAccess.ExecuteNonQuery(_commandText.ToString());
        }

        public void BorrarIdioma(int id)
        {
            string _commandText = string.Format("DELETE FROM IDIOMA WHERE ID = {0}", id);
            _dataAccess.ExecuteNonQuery(_commandText);
        }

        public void EditarTraduccion(string texto ,int id)
        {
            string _commandText = string.Format("UPDATE TRADUCCION SET TEXTO = '{0}' WHERE ID = {1}", texto ,id);
            _dataAccess.ExecuteNonQuery(_commandText);
        }
    }   
}
