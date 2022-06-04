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
        public static void Guardar(string path, string texto)
        {

            try
            {
                StreamWriter streamWriter = new StreamWriter(path);

                streamWriter.WriteLine(texto);

                streamWriter.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
