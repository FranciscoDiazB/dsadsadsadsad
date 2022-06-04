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
            get { return ventas; }
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
                string path = GetFolderPath(SpecialFolder.Desktop) + @"\TP3\MiArchivo.txt";

                if(this.ventas != null)
                {
                    foreach (Ventas ventas in this.Venta)
                    {
                        ManejarArchivos.Guardar(path, ventas.ToString());
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
