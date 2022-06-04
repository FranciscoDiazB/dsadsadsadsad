using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTP3
{
    public class Cliente : Persona
    {
        private string metodoPago; 

        public string MetodoPago
        {
            get { return metodoPago; }
            set { metodoPago = value; }
        }
        
        public Cliente(string nombre, string apellido, string pago) : base(nombre, apellido)
        {
            this.metodoPago = pago;
        }

        public override string MostrarDatos()
        {
            return $"Cliente: {base.MostrarDatos()} - Pago: {this.MetodoPago}";
        }

    }
}
