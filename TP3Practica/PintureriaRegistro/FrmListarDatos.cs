using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BiblioTP3;
using static System.Environment;

namespace PintureriaRegistro
{
    public partial class FrmListarDatos : Form
    {
        List<Ventas> ventas;

        public List<Ventas> Venta
        {
            get { return this.ventas; }
        }

        public FrmListarDatos()
        {
            InitializeComponent();
        }

        public FrmListarDatos(List<Ventas> venta) : this()
        {
            this.ventas = venta;
        }

        private void FrmListarDatos_Load(object sender, EventArgs e)
        {
            if( this.Venta != null)
            {
                foreach(Ventas ventas in this.Venta)
                {
                    lsbListadoVentas.Items.Add(ventas.ToString());
                }
            }
        }

        private void btnAgregarArchivo_Click(object sender, EventArgs e)
        {

            try
            {
                string path = GetFolderPath(SpecialFolder.Desktop) + @"\Prueba Archivo\MiArchivo.txt";

                if(lsbListadoVentas.Items.Count > 0)
                {
                    foreach (Ventas ventas in this.ventas)
                    {
                        ManejarArchivos.GuardarArchivo(path, ventas.ToString(), true);
                    }
                }
                else
                {
                    MessageBox.Show("Debe tener datos cargados en la lista para poder cargar datos a un Archivo de Texto", "Error");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Excepcion Encontrada");
            }
        }

        private void btnAgregarXml_Click(object sender, EventArgs e)
        {
           try
           {
                string path = GetFolderPath(SpecialFolder.Desktop) + @"\Prueba Archivo\Ventas.xml";

                if (lsbListadoVentas.Items.Count > 0)
                {
                    Serializador<List<Ventas>>.GuardarArchivoXml(Venta, path);
                }
                else
                {
                    MessageBox.Show("Debe tener datos cargados en la lista", "Error");
                }
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message, "Excepcion Encontrada");
           }          
        }
    }
}
