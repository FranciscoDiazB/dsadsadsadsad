﻿namespace PintureriaRegistro
{
    partial class FrmRegistroDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCodigoProducto = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblLitros = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbLitros = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.lblDatosCliente = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.txtApellCliente = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblApellidoCliente = new System.Windows.Forms.Label();
            this.lblPago = new System.Windows.Forms.Label();
            this.cmbPago = new System.Windows.Forms.ComboBox();
            this.lblDatosExtra = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblCantidadDeProductos = new System.Windows.Forms.Label();
            this.txtUnidades = new System.Windows.Forms.TextBox();
            this.rtbVenta = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAgregarVenta = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtNombreVendedor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.White;
            this.txtMarca.ForeColor = System.Drawing.Color.Black;
            this.txtMarca.Location = new System.Drawing.Point(23, 74);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(149, 27);
            this.txtMarca.TabIndex = 0;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblProducto.Location = new System.Drawing.Point(23, 13);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(119, 31);
            this.lblProducto.TabIndex = 1;
            this.lblProducto.Text = "Producto";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(23, 180);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(84, 27);
            this.txtPrecio.TabIndex = 3;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(23, 127);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(149, 27);
            this.txtCodigo.TabIndex = 4;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(23, 51);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(50, 20);
            this.lblMarca.TabIndex = 5;
            this.lblMarca.Text = "Marca";
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.Location = new System.Drawing.Point(23, 104);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(147, 20);
            this.lblCodigoProducto.TabIndex = 6;
            this.lblCodigoProducto.Text = "Codigo del Producto";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(23, 157);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(111, 20);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio por Litro";
            // 
            // lblLitros
            // 
            this.lblLitros.AutoSize = true;
            this.lblLitros.Location = new System.Drawing.Point(23, 210);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(45, 20);
            this.lblLitros.TabIndex = 8;
            this.lblLitros.Text = "Litros";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(21, 317);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(132, 20);
            this.lblColor.TabIndex = 9;
            this.lblColor.Text = "Color de la Pintura";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(23, 263);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(110, 20);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "Tipo de Pintura";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(21, 286);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(113, 28);
            this.cmbTipo.TabIndex = 11;
            // 
            // cmbLitros
            // 
            this.cmbLitros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLitros.FormattingEnabled = true;
            this.cmbLitros.Location = new System.Drawing.Point(23, 233);
            this.cmbLitros.Name = "cmbLitros";
            this.cmbLitros.Size = new System.Drawing.Size(50, 28);
            this.cmbLitros.TabIndex = 12;
            // 
            // cmbColor
            // 
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(21, 340);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(113, 28);
            this.cmbColor.TabIndex = 13;
            // 
            // lblDatosCliente
            // 
            this.lblDatosCliente.AutoSize = true;
            this.lblDatosCliente.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblDatosCliente.Location = new System.Drawing.Point(249, 13);
            this.lblDatosCliente.Name = "lblDatosCliente";
            this.lblDatosCliente.Size = new System.Drawing.Size(169, 31);
            this.lblDatosCliente.TabIndex = 14;
            this.lblDatosCliente.Text = "Datos Cliente";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 450);
            this.splitter1.TabIndex = 15;
            this.splitter1.TabStop = false;
            // 
            // txtApellCliente
            // 
            this.txtApellCliente.Location = new System.Drawing.Point(249, 127);
            this.txtApellCliente.Name = "txtApellCliente";
            this.txtApellCliente.Size = new System.Drawing.Size(148, 27);
            this.txtApellCliente.TabIndex = 16;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(249, 74);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(148, 27);
            this.txtCliente.TabIndex = 17;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(249, 51);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(139, 20);
            this.lblNombreCliente.TabIndex = 18;
            this.lblNombreCliente.Text = "Nombre del Cliente";
            // 
            // lblApellidoCliente
            // 
            this.lblApellidoCliente.AutoSize = true;
            this.lblApellidoCliente.Location = new System.Drawing.Point(249, 104);
            this.lblApellidoCliente.Name = "lblApellidoCliente";
            this.lblApellidoCliente.Size = new System.Drawing.Size(141, 20);
            this.lblApellidoCliente.TabIndex = 19;
            this.lblApellidoCliente.Text = "Apellido del Cliente";
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(249, 157);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(120, 20);
            this.lblPago.TabIndex = 20;
            this.lblPago.Text = "Metodo de Pago";
            // 
            // cmbPago
            // 
            this.cmbPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPago.FormattingEnabled = true;
            this.cmbPago.Location = new System.Drawing.Point(249, 179);
            this.cmbPago.Name = "cmbPago";
            this.cmbPago.Size = new System.Drawing.Size(148, 28);
            this.cmbPago.TabIndex = 21;
            // 
            // lblDatosExtra
            // 
            this.lblDatosExtra.AutoSize = true;
            this.lblDatosExtra.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblDatosExtra.Location = new System.Drawing.Point(249, 227);
            this.lblDatosExtra.Name = "lblDatosExtra";
            this.lblDatosExtra.Size = new System.Drawing.Size(194, 31);
            this.lblDatosExtra.TabIndex = 22;
            this.lblDatosExtra.Text = "Datos Vendedor";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(249, 263);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(157, 20);
            this.lblVendedor.TabIndex = 23;
            this.lblVendedor.Text = "Nombre del Vendedor";
            // 
            // lblCantidadDeProductos
            // 
            this.lblCantidadDeProductos.AutoSize = true;
            this.lblCantidadDeProductos.Location = new System.Drawing.Point(21, 371);
            this.lblCantidadDeProductos.Name = "lblCantidadDeProductos";
            this.lblCantidadDeProductos.Size = new System.Drawing.Size(156, 20);
            this.lblCantidadDeProductos.TabIndex = 24;
            this.lblCantidadDeProductos.Text = "Cantidad de Unidades";
            // 
            // txtUnidades
            // 
            this.txtUnidades.Location = new System.Drawing.Point(23, 394);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Size = new System.Drawing.Size(55, 27);
            this.txtUnidades.TabIndex = 27;
            // 
            // rtbVenta
            // 
            this.rtbVenta.BackColor = System.Drawing.SystemColors.Window;
            this.rtbVenta.Location = new System.Drawing.Point(458, 57);
            this.rtbVenta.Name = "rtbVenta";
            this.rtbVenta.Size = new System.Drawing.Size(314, 173);
            this.rtbVenta.TabIndex = 29;
            this.rtbVenta.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(508, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 30);
            this.label1.TabIndex = 30;
            this.label1.Text = "Resumen de la Venta";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(458, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(314, 60);
            this.button1.TabIndex = 31;
            this.button1.Text = "Resumir Venta";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAgregarVenta
            // 
            this.btnAgregarVenta.BackColor = System.Drawing.Color.Black;
            this.btnAgregarVenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarVenta.ForeColor = System.Drawing.Color.White;
            this.btnAgregarVenta.Location = new System.Drawing.Point(458, 316);
            this.btnAgregarVenta.Name = "btnAgregarVenta";
            this.btnAgregarVenta.Size = new System.Drawing.Size(314, 60);
            this.btnAgregarVenta.TabIndex = 32;
            this.btnAgregarVenta.Text = "Agregar al Registro de Ventas";
            this.btnAgregarVenta.UseVisualStyleBackColor = false;
            this.btnAgregarVenta.Click += new System.EventHandler(this.btnAgregarVenta_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Black;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(458, 382);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(314, 56);
            this.btnVolver.TabIndex = 33;
            this.btnVolver.Text = "Volver al Inicio";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtNombreVendedor
            // 
            this.txtNombreVendedor.Location = new System.Drawing.Point(249, 287);
            this.txtNombreVendedor.Name = "txtNombreVendedor";
            this.txtNombreVendedor.Size = new System.Drawing.Size(148, 27);
            this.txtNombreVendedor.TabIndex = 35;
            // 
            // FrmRegistroDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNombreVendedor);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAgregarVenta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbVenta);
            this.Controls.Add(this.txtUnidades);
            this.Controls.Add(this.lblCantidadDeProductos);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.lblDatosExtra);
            this.Controls.Add(this.cmbPago);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.lblApellidoCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtApellCliente);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.lblDatosCliente);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.cmbLitros);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblLitros);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCodigoProducto);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.txtMarca);
            this.Name = "FrmRegistroDatos";
            this.Text = "Registrar Datos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRegistroDatos_FormClosing);
            this.Load += new System.EventHandler(this.FrmRegistroDatos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCodigoProducto;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblLitros;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbLitros;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label lblDatosCliente;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox txtApellCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblApellidoCliente;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.ComboBox cmbPago;
        private System.Windows.Forms.Label lblDatosExtra;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblCantidadDeProductos;
        private System.Windows.Forms.TextBox txtUnidades;
        private System.Windows.Forms.RichTextBox rtbVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAgregarVenta;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtNombreVendedor;
    }
}