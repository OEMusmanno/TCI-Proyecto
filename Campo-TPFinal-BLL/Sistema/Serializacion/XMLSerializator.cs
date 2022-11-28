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
        public override object Deserializar(string str)
        {
            var serializer = new XmlSerializer(typeof(T));
            TextReader tr = new StreamReader(str);
            var o = serializer.Deserialize(tr);
            tr.Close();
            return o;
        }

        public override object Serializar(object obj, string path)
        {
            string dateFormat = "yyyy-MM-dd-HH-mm-ss";
            string filename = path + "\\xml" + DateTime.Now.ToString(dateFormat) + ".xml";           
            using (FileStream sourceStream = File.Open(filename , FileMode.OpenOrCreate))
            {
                sourceStream.Seek(0, SeekOrigin.Begin);
                StreamWriter writer = new StreamWriter(sourceStream);
                var ser = new XmlSerializer(typeof(T), new Type[] { typeof(T) });
                ser.Serialize(writer, obj);
                writer.Close();
                return sourceStream.Name;
            }
        }
    }
}
