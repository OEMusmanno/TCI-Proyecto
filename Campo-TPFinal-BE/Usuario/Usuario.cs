using Campo_TPFinal_BE.Sistema.Idioma;
using Campo_TPFinal_BE.Sistema.Perfil;
using System.Xml.Serialization;

namespace Campo_TPFinal_BE.Usuario
{
    public class Usuario
    {

        public string alias { get; set; }
        public string password { get; set; }
        public bool bloqueado { get; set; }
        public int Id { get; set; }
        public Lenguaje idioma;

        public Usuario(string alias, string password, bool bloqueado, int id, Lenguaje idioma, Rol rol)
        {
            this.alias = alias;
            this.password = password;
            this.bloqueado = bloqueado;
            Id = id;
            this.idioma = idioma;
            this.rol = rol;
        }

        public Usuario()
        {
        }

        [XmlIgnore]
        public Rol rol { get; set; }

        public override string ToString()
        {
            return alias;
        }
    }
}
