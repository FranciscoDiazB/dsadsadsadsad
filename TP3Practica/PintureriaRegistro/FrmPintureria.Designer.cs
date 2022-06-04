namespace PintureriaRegistro
{
    partial class FrmPintureria
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnIngresoDatos = new System.Windows.Forms.Button();
            this.btnListarDatos = new System.Windows.Forms.Button();
            this.btnImportarArchivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(13, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(775, 89);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Pintureria FRADBAR";
            // 
            // btnIngresoDatos
            // 
            this.btnIngresoDatos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIngresoDatos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIngresoDatos.ForeColor = System.Drawing.Color.White;
            this.btnIngresoDatos.Location = new System.Drawing.Point(110, 142);
            this.btnIngresoDatos.Name = "btnIngresoDatos";
            this.btnIngresoDatos.Size = new System.Drawing.Size(558, 74);
            this.btnIngresoDatos.TabIndex = 2;
            this.btnIngresoDatos.Text = "Ingresar Datos de Venta al Sistema";
            this.btnIngresoDatos.UseVisualStyleBackColor = false;
            this.btnIngresoDatos.Click += new System.EventHandler(this.btnIngresoDatos_Click);
            // 
            // btnListarDatos
            // 
            this.btnListarDatos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnListarDatos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnListarDatos.ForeColor = System.Drawing.Color.White;
            this.btnListarDatos.Location = new System.Drawing.Point(110, 234);
            this.btnListarDatos.Name = "btnListarDatos";
            this.btnListarDatos.Size = new System.Drawing.Size(558, 74);
            this.btnListarDatos.TabIndex = 3;
            this.btnListarDatos.Text = "Listar el Registro de Ventas";
            this.btnListarDatos.UseVisualStyleBackColor = false;
            this.btnListarDatos.Click += new System.EventHandler(this.btnListarDatos_Click);
            // 
            // btnImportarArchivo
            // 
            this.btnImportarArchivo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnImportarArchivo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnImportarArchivo.ForeColor = System.Drawing.Color.White;
            this.btnImportarArchivo.Location = new System.Drawing.Point(110, 326);
            this.btnImportarArchivo.Name = "btnImportarArchivo";
            this.btnImportarArchivo.Size = new System.Drawing.Size(558, 74);
            this.btnImportarArchivo.TabIndex = 4;
            this.btnImportarArchivo.Text = "Importar Datos de un Archivo";
            this.btnImportarArchivo.UseVisualStyleBackColor = false;
            this.btnImportarArchivo.Click += new System.EventHandler(this.btnImportarArchivo_Click);
            // 
            // FrmPintureria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImportarArchivo);
            this.Controls.Add(this.btnListarDatos);
            this.Controls.Add(this.btnIngresoDatos);
            this.Controls.Add(this.lblTitulo);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPintureria";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pintureria FRADBAR";
            this.Load += new System.EventHandler(this.FrmPintureria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnIngresoDatos;
        private System.Windows.Forms.Button btnListarDatos;
        private System.Windows.Forms.Button btnImportarArchivo;
    }
}
