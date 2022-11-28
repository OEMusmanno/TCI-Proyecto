using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Campo_TPFinal_BLL.Sistema.Serializacion
{
    public class XMLSerializator<T> : AbstractSerializator
    {
        public override object Deserializar(Stream str)
        {
            var serializer = new XmlSerializer(typeof(T));
            TextReader tr = new StreamReader(str);
            var o = serializer.Deserialize(tr);
            tr.Close();
            return o;
        }

        public override object Serializar(object obj, string path)
        {
            using (FileStream sourceStream = File.Open(path , FileMode.OpenOrCreate))
            {
                sourceStream.Seek(0, SeekOrigin.Begin);
                StreamWriter writer = new StreamWriter(sourceStream);
                var ser = new XmlSerializer(typeof(T));
                ser.Serialize(writer, obj);
                writer.Close();
                return sourceStream.Name;
            }
        }
    }
}
