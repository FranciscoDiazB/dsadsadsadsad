using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTP3
{
    public class Ventas 
    {
        DateTime fechaDeVenta;
        int cantidadUnidades; 
        Cliente cliente;
        Vendedor vendedor;
        Pintura pintura;
        float precioTotal;

        public int Unidades
        {
            get { return cantidadUnidades; }
            set 
            { 
                if(value > 0)
                {
                    cantidadUnidades = value;
                }
            }
        }

        public Cliente Cliente
        {
            get { return cliente; }
        }

        public Pintura Pintura
        {
            get { return pintura; }
        }

        public Vendedor Vendedor
        {
           get { return vendedor; }
        }

        public float PrecioTotal
        {
            get { return precioTotal; }
        }

        public Ventas(int unidades, Cliente cliente, Pintura pintura, Vendedor vendedor, float precioTotal)
        {
            this.fechaDeVenta = DateTime.Now;
            this.cantidadUnidades = unidades;
            this.cliente = cliente;
            this.vendedor = vendedor;
            this.pintura = pintura;
            this.precioTotal = precioTotal;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this.Pintura.MostrarDatos());
            sb.Append($"Unidades: {this.cantidadUnidades} - Total: ${this.PrecioTotal} - ");
            sb.Append($"{this.Cliente.MostrarDatos()} - ");
            sb.Append(this.Vendedor.MostrarDatos());
            sb.Append($" - Fecha de la Venta: {this.fechaDeVenta}");

            return sb.ToString();
        }

    }
}
