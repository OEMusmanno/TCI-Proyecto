using Campo_TPFinal_BE.Sistema.Idioma;
using Campo_TPFinal_BE.Sistema.Perfil;

namespace Campo_TPFinal_BE.Usuario
{
    public class Usuario
    {
        public string alias { get; set; }
        public string password { get; set; }
        public bool bloqueado { get; set; }
        public int Id { get; set; }
        public Lenguaje idioma;
        public List<Penalidad> Penalidades{ get; set; }

        public Rol rol { get; set; }

        public override string ToString()
        {
            return alias;
        }
    }
}
