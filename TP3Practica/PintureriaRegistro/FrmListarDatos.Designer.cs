﻿namespace PintureriaRegistro
{
    partial class FrmListarDatos
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
            this.lsbListadoVentas = new System.Windows.Forms.ListBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAgregarArchivo = new System.Windows.Forms.Button();
            this.lblListadoDeDatos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsbListadoVentas
            // 
            this.lsbListadoVentas.FormattingEnabled = true;
            this.lsbListadoVentas.HorizontalScrollbar = true;
            this.lsbListadoVentas.ItemHeight = 20;
            this.lsbListadoVentas.Location = new System.Drawing.Point(12, 67);
            this.lsbListadoVentas.Name = "lsbListadoVentas";
            this.lsbListadoVentas.Size = new System.Drawing.Size(1332, 304);
            this.lsbListadoVentas.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Black;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(12, 377);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(156, 63);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver al Inicio";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // btnAgregarArchivo
            // 
            this.btnAgregarArchivo.BackColor = System.Drawing.Color.Black;
            this.btnAgregarArchivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarArchivo.ForeColor = System.Drawing.Color.White;
            this.btnAgregarArchivo.Location = new System.Drawing.Point(1078, 377);
            this.btnAgregarArchivo.Name = "btnAgregarArchivo";
            this.btnAgregarArchivo.Size = new System.Drawing.Size(266, 63);
            this.btnAgregarArchivo.TabIndex = 2;
            this.btnAgregarArchivo.Text = "Agregar datos a un Archivo";
            this.btnAgregarArchivo.UseVisualStyleBackColor = false;
            this.btnAgregarArchivo.Click += new System.EventHandler(this.btnAgregarArchivo_Click);
            // 
            // lblListadoDeDatos
            // 
            this.lblListadoDeDatos.AutoSize = true;
            this.lblListadoDeDatos.Font = new System.Drawing.Font("Times New Roman", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblListadoDeDatos.Location = new System.Drawing.Point(552, 9);
            this.lblListadoDeDatos.Name = "lblListadoDeDatos";
            this.lblListadoDeDatos.Size = new System.Drawing.Size(286, 43);
            this.lblListadoDeDatos.TabIndex = 15;
            this.lblListadoDeDatos.Text = "Listado de Ventas";
            // 
            // FrmListarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1483, 450);
            this.Controls.Add(this.lblListadoDeDatos);
            this.Controls.Add(this.btnAgregarArchivo);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lsbListadoVentas);
            this.Name = "FrmListarDatos";
            this.Text = "FrmListarDatos";
            this.Load += new System.EventHandler(this.FrmListarDatos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbListadoVentas;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAgregarArchivo;
        private System.Windows.Forms.Label lblListadoDeDatos;
    }
}