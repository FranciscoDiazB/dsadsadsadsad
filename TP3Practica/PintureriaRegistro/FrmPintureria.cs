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
using static System.Environment;

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

        private void btnIngresoDatos_Click(object sender, EventArgs e)
        {
            FrmRegistroDatos frmRegistrar = new FrmRegistroDatos(Ventas);

            frmRegistrar.Show();

            this.Hide();
        }

        private void btnListarDatos_Click(object sender, EventArgs e)
        {
            FrmListarDatos frmListarDatos = new FrmListarDatos(Ventas);

            frmListarDatos.Show();
        }

        private void btnImportarArchivo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMostrarArchivoTxt_Click(object sender, EventArgs e)
        {
            FrmImportarArchivo frmArchivo = new FrmImportarArchivo(Ventas);

            frmArchivo.Show();
        }

        private void btnImportarXLM_Click(object sender, EventArgs e)
        {
            try
            {
                string path = GetFolderPath(SpecialFolder.Desktop) + @"\Prueba Archivo\Ventas.xml";
                this.listaVenta = Serializador<List<Ventas>>.LeerArchivoXml(path);
                if (this.listaVenta.Count > 0)
                {
                    MessageBox.Show("Lista Cargada", "EXITOS");
                }
                else
                {
                    MessageBox.Show("Problema", "ERROR");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Excepcion Encontrada");
            }
        }
    }
}
