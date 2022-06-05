using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace BiblioTP3
{
    public static class Serializador <T> where T : class, new()
    {
        public static void GuardarArchivoXml(T listaVentas, string path)
        {
            try
            {
                using(StreamWriter sm = new StreamWriter(path))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));

                    serializer.Serialize(sm, listaVentas);
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }
        [XmlInclude (typeof(Ventas))]

        public static T LeerArchivoXml(string path)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                    return xmlSerializer.Deserialize(sr) as T;
                }
            }
            catch(Exception ex)
            {
                throw;
            }          
        }
    }
}
