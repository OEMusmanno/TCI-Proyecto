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

        public IDictionary<string, Traduccion> ObtenerTraducciones(Lenguaje idioma = null)
        {
            //si no hay idioma definido, traigo el idioma por default
            if (idioma == null)
            {
                idioma = ObtenerIdiomaDefault();
            }

            var list = _dataAccess.ExecuteDataSet("SELECT t.id_idioma, t.texto as texto, t.tag FROM traduccion t  WHERE t.id_idioma = " + idioma.id);
            IDictionary<string, Traduccion> _traducciones = new Dictionary<string, Traduccion>();

            foreach (DataRow item in list.Tables[0].Rows)
            {
                Traduccion traduccion = new Traduccion();
                traduccion.Etiqueta = item["Tag"].ToString();
                traduccion.Texto = item["Texto"].ToString();  
                _traducciones.Add(traduccion.Etiqueta, traduccion);
            }
            return _traducciones;
        }
    }
   
}
