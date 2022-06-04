using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTP3
{
    public class Vendedor : Persona
    {
        private float comision;

        public float Comision
        {
            get { return comision; }
            set { comision = value; }
        }

        public Vendedor(string nombre, string apellido, float numero) : base(nombre, apellido)
        {
            this.comision = numero;   
        }

        public override string MostrarDatos()
        {
            return $"Vendedor: {base.MostrarDatos()} - Comision: ${this.Comision}";
        }

    }
}
