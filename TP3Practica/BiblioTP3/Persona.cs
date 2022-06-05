using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTP3
{
    public class Persona
    {
        string nombre;
        string apellido; 

        public Persona()
        {

        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public virtual string MostrarDatos()
        {
            return $"{this.nombre} {this.apellido}";
        }


    }
}
