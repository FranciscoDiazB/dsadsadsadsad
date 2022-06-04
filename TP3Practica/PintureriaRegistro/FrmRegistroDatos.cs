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
    public partial class FrmRegistroDatos : Form
    {
        List<Ventas> ventas;

        public FrmRegistroDatos()
        {
            InitializeComponent();

        }


        public FrmRegistroDatos(List<Ventas> ventas) : this()
        {
            this.ventas = ventas;
        }
        public List<Ventas> Ventas
        {
            get { return ventas; }
        }

        private void FrmRegistroDatos_Load(object sender, EventArgs e)
        {
            cmbLitros.Items.Add(1);
            cmbLitros.Items.Add(2);
            cmbLitros.Items.Add(4);
            cmbLitros.Items.Add(10);
            cmbLitros.Items.Add(20);

            cmbPago.Items.Add("Tarjeta de Credito");
            cmbPago.Items.Add("Tarjeta de Debito");
            cmbPago.Items.Add("Efectivo");
            cmbPago.Items.Add("Transferencia");

            cmbColor.Items.Add(ColorPintura.Rosa);
            cmbColor.Items.Add(ColorPintura.Blanco);
            cmbColor.Items.Add(ColorPintura.Gris);
            cmbColor.Items.Add(ColorPintura.Beige);
            cmbColor.Items.Add(ColorPintura.Negro);
            cmbColor.Items.Add(ColorPintura.Azul);
            cmbColor.Items.Add(ColorPintura.Amarillo);
            cmbColor.Items.Add(ColorPintura.Verde);

            cmbTipo.Items.Add(TipoPintura.Latex);
            cmbTipo.Items.Add(TipoPintura.Esmalte);
            cmbTipo.Items.Add(TipoPintura.Cieloraso);
            cmbTipo.Items.Add(TipoPintura.Barniz);

        }

        private void FrmRegistroDatos_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
                string unidades;
                float total = 0;
                StringBuilder sb = new StringBuilder();
        
                unidades = txtUnidades.Text;
                try
                {

                    total = (float) float.Parse(txtPrecio.Text) * float.Parse(unidades);
                    sb.AppendLine($"{txtMarca.Text} {txtCodigo.Text}");
                    sb.AppendLine($"Total: ${total} Pago: {cmbPago.SelectedItem}");
                    sb.AppendLine($"Cliente: {txtApellCliente.Text}, {txtCliente.Text}");
                    sb.AppendLine($"Vendedor: {txtNombreVendedor.Text} ");

                    if ( string.IsNullOrEmpty(txtApellCliente.Text) || string.IsNullOrEmpty(txtCliente.Text) || 
                         string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtMarca.Text) || 
                         string.IsNullOrEmpty(txtPrecio.Text) || string.IsNullOrEmpty(txtUnidades.Text) || 
                         cmbTipo.SelectedItem == null || cmbPago.SelectedItem == null ||
                         cmbColor.SelectedItem == null || cmbLitros == null || string.IsNullOrEmpty(txtNombreVendedor.Text))
                    {

                    MessageBox.Show("Se deben ingresar todos los datos antes de poder continuar");
                     
                    }
                    else
                    {
                        rtbVenta.Text = sb.ToString();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            float precio = 0;
            float comision = 0;
            int unidades = 0;
            ColorPintura color;
            TipoPintura tipo;
            int litros = 0;
            float total = 0;

            try
            {
                if (string.IsNullOrEmpty(txtApellCliente.Text) || string.IsNullOrEmpty(txtCliente.Text) ||
                            string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtMarca.Text) ||
                            string.IsNullOrEmpty(txtPrecio.Text) || string.IsNullOrEmpty(txtUnidades.Text) ||
                            cmbTipo.SelectedItem == null || cmbPago.SelectedItem == null ||
                            cmbColor.SelectedItem == null || cmbLitros.SelectedItem == null || string.IsNullOrEmpty(txtNombreVendedor.Text))
                {
                    MessageBox.Show("Se deben ingresar todos los datos antes de poder continuar");
                }
                else
                {
                    precio = float.Parse(txtPrecio.Text);
                    unidades = int.Parse(txtUnidades.Text);
                    tipo = (TipoPintura) cmbTipo.SelectedItem;
                    color = (ColorPintura)cmbColor.SelectedItem;
                    litros = (int) cmbLitros.SelectedItem;
                    total = (float) precio * unidades;

                    if(total > 0 && total < 15000)
                    {
                        comision = 0;                      
                    }
                    else if(total >= 15000  && total < 30000)
                    {
                        comision = (float) (total * 0.05);                   
                    }
                    else
                    {
                        comision = (float)(total * 0.1);
                    }

                    Cliente nuevoCliente = new Cliente(txtCliente.Text, txtApellCliente.Text, cmbPago.SelectedItem.ToString());
                    Pintura nuevaPintura = new Pintura(txtMarca.Text, txtCodigo.Text, precio, color, litros, tipo);
                    Vendedor nuevoVendedor = new Vendedor(txtNombreVendedor.Text, "", comision);

                    if (nuevoCliente != null && nuevaPintura != null && nuevoVendedor != null)
                    {
                        Ventas nuevaVenta = new Ventas(unidades, nuevoCliente, nuevaPintura, nuevoVendedor, total);

                        if (nuevaVenta != null)
                        {
                            this.Ventas.Add(nuevaVenta);

                            if(this.Ventas != null)
                            {
                                MessageBox.Show("La venta fue agregada a la lista");
                            }
                        }                   
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
