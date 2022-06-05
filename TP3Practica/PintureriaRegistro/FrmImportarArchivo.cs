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
    public partial class FrmImportarArchivo : Form
    {
        List<Ventas> listaVentas; 

        public FrmImportarArchivo()
        {
            InitializeComponent();
        }

        public FrmImportarArchivo(List<Ventas> lista) : this()
        {
            this.listaVentas = lista;
        }

        public List<Ventas> ListaVentas
        {
            get { return listaVentas; }
            set { listaVentas = value; }
        }

        private void FrmImportarArchivo_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrarArchivoTexto_Click(object sender, EventArgs e)
        {

            try
            {
                string path = GetFolderPath(SpecialFolder.Desktop) + @"\Prueba Archivo\MiArchivo.txt";
                rtbMostrarTexto.Text = ManejarArchivos.LeerArchivo(path);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Excepcion Encontrada");
            }
        }

        private void btnImportarXLM_Click(object sender, EventArgs e)
        {
            try
            {
                string path = GetFolderPath(SpecialFolder.Desktop) + @"\Prueba Archivo\Ventas.xml";
                ListaVentas = Serializador<List<Ventas>>.LeerArchivoXml(path);
                if(listaVentas.Count > 0)
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
