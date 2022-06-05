using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTP3
{
    public static class MetodosAyuda
    {

        public static string Mostrar(string precio, string marca, string codigo, object pago, string nombreCliente, string apellidoCliente, string nombreVendedor, string unidades)
        {
            float total;
            StringBuilder sb = new StringBuilder();
            try
            {
                total = (float)float.Parse(precio) * float.Parse(unidades);
                sb.AppendLine($"{marca} {codigo}");
                sb.AppendLine($"Total: ${AplicarDescuentoCorrespondiente(total, pago.ToString())} Pago: {pago}");
                sb.AppendLine($"Cliente: {apellidoCliente}, {nombreCliente}");
                sb.AppendLine($"Vendedor: {nombreVendedor} "); 
            }
            catch (Exception ex)
            {
                throw;
            }
            return sb.ToString();
        }

        public static float CalcularComision(float total)
        {
            float comision;
   
            if (total > 0 && total < 15000)
            {
                comision = 0;
            }
            else if (total >= 15000 && total < 30000)
            {
                comision = (float)(total * 0.05);
            }
            else
            {
                comision = (float)(total * 0.1);
            }

            return comision;
        }

        public static float CalcularTotal(float precio, string unidades)
        {
            return (float)precio * int.Parse(unidades);
        }

        public static float AplicarDescuentoCorrespondiente(float precio, string pago)
        {
            if(pago == "Efectivo")
            {
                precio = (float) (precio * 0.9);
            }
            else if(pago == "Transferencia" || pago == "Tarjeta de Debito")
            {
                precio = (float)(precio * 0.95);
            }
            return precio;
        }

    }
}
