using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblioTP3;

namespace PintureriaRegistro
{
    public partial class FrmPintureria : Form
    {
        List<Ventas> listaVenta;

        public FrmPintureria()
        {
            InitializeComponent();
            listaVenta = new List<Ventas>();

        }

        private List<Ventas> Ventas
        {
            get { return listaVenta; }
        }

        private void FrmPintureria_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresoDatos_Click(object sender, EventArgs e)
        {
            FrmRegistroDatos frmRegistrar = new FrmRegistroDatos(Ventas);

            frmRegistrar.Show();

            this.Hide();

            this.Show();

        }

        private void btnListarDatos_Click(object sender, EventArgs e)
        {
            FrmListarDatos frmListarDatos = new FrmListarDatos(Ventas);

            frmListarDatos.Show();
        }

        private void btnImportarArchivo_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("LMP");

            foreach(Ventas venta in this.Ventas)
            {
                MessageBox.Show(venta.ToString());
            }
        }

    }
}
