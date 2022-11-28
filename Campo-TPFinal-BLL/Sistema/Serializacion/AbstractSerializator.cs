using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BLL.Sistema.Serializacion
{
    public abstract class AbstractSerializator
    {
        public abstract object Deserializar(Stream str);
        public abstract object Serializar(object obj, string path);
    }
}
