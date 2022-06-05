using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Environment;

namespace BiblioTP3
{
    public static class ManejarArchivos
    {
        public static void GuardarArchivo(string path, string texto, bool concatenar)
        {
            try
            {
                using(StreamWriter sw = new StreamWriter(path, concatenar))
                {
                    sw.WriteLine(texto);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static string LeerArchivo(string path)
        {
            try
            {
                using(StreamReader sr = new StreamReader(path))
                {
                    return sr.ReadToEnd();
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
