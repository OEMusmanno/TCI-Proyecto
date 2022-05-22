using Campo_TPFinal_BE.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_DALContracts
{
    public interface IUsuarioRepository
    {
        public Usuario ObtenerPorAlias(string alias);
    }
}
