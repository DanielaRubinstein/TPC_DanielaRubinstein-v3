namespace Presentacion
{
    partial class frmProducto
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblStockMin = new System.Windows.Forms.Label();
            this.lblStockActual = new System.Windows.Forms.Label();
            this.gbStock = new System.Windows.Forms.GroupBox();
            this.txtStockActual = new System.Windows.Forms.TextBox();
            this.txtStockMin = new System.Windows.Forms.TextBox();
            this.lblProfundidad = new System.Windows.Forms.Label();
            this.lblAlto = new System.Windows.Forms.Label();
            this.lblAncho = new System.Windows.Forms.Label();
            this.gbMedidas = new System.Windows.Forms.GroupBox();
            this.gbPrecios = new System.Windows.Forms.GroupBox();
            this.txtPrecioFinal = new System.Windows.Forms.TextBox();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.txtPrecioNeto = new System.Windows.Forms.TextBox();
            this.lblImpuesto = new System.Windows.Forms.Label();
            this.lblPrecioNeto = new System.Windows.Forms.Label();
            this.lblPrecioFInal = new System.Windows.Forms.Label();
            this.gbCostos = new System.Windows.Forms.GroupBox();
            this.txtCostoSIVA = new System.Windows.Forms.TextBox();
            this.txtCostoNeto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbID = new System.Windows.Forms.TextBox();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbStock.SuspendLayout();
            this.gbMedidas.SuspendLayout();
            this.gbPrecios.SuspendLayout();
            this.gbCostos.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(30, 52);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(46, 33);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(25, 111);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(148, 33);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(25, 171);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(91, 33);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(25, 229);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(126, 33);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(25, 288);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(134, 33);
            this.lblProveedor.TabIndex = 4;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // lblStockMin
            // 
            this.lblStockMin.AutoSize = true;
            this.lblStockMin.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockMin.Location = new System.Drawing.Point(23, 63);
            this.lblStockMin.Name = "lblStockMin";
            this.lblStockMin.Size = new System.Drawing.Size(128, 33);
            this.lblStockMin.TabIndex = 5;
            this.lblStockMin.Text = "Stock min:";
            // 
            // lblStockActual
            // 
            this.lblStockActual.AutoSize = true;
            this.lblStockActual.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockActual.Location = new System.Drawing.Point(20, 127);
            this.lblStockActual.Name = "lblStockActual";
            this.lblStockActual.Size = new System.Drawing.Size(152, 33);
            this.lblStockActual.TabIndex = 6;
            this.lblStockActual.Text = "Stock actual:";
            // 
            // gbStock
            // 
            this.gbStock.Controls.Add(this.txtStockActual);
            this.gbStock.Controls.Add(this.txtStockMin);
            this.gbStock.Controls.Add(this.lblStockMin);
            this.gbStock.Controls.Add(this.lblStockActual);
            this.gbStock.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStock.Location = new System.Drawing.Point(64, 437);
            this.gbStock.Name = "gbStock";
            this.gbStock.Size = new System.Drawing.Size(578, 215);
            this.gbStock.TabIndex = 7;
            this.gbStock.TabStop = false;
            this.gbStock.Text = "STOCK";
            // 
            // txtStockActual
            // 
            this.txtStockActual.Location = new System.Drawing.Point(182, 122);
            this.txtStockActual.Name = "txtStockActual";
            this.txtStockActual.Size = new System.Drawing.Size(372, 40);
            this.txtStockActual.TabIndex = 14;
            // 
            // txtStockMin
            // 
            this.txtStockMin.Location = new System.Drawing.Point(182, 63);
            this.txtStockMin.Name = "txtStockMin";
            this.txtStockMin.Size = new System.Drawing.Size(372, 40);
            this.txtStockMin.TabIndex = 13;
            // 
            // lblProfundidad
            // 
            this.lblProfundidad.AutoSize = true;
            this.lblProfundidad.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfundidad.Location = new System.Drawing.Point(20, 162);
            this.lblProfundidad.Name = "lblProfundidad";
            this.lblProfundidad.Size = new System.Drawing.Size(156, 33);
            this.lblProfundidad.TabIndex = 6;
            this.lblProfundidad.Text = "Profundidad:";
            // 
            // lblAlto
            // 
            this.lblAlto.AutoSize = true;
            this.lblAlto.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlto.Location = new System.Drawing.Point(20, 61);
            this.lblAlto.Name = "lblAlto";
            this.lblAlto.Size = new System.Drawing.Size(67, 33);
            this.lblAlto.TabIndex = 5;
            this.lblAlto.Text = "Alto:";
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAncho.Location = new System.Drawing.Point(20, 110);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(91, 33);
            this.lblAncho.TabIndex = 7;
            this.lblAncho.Text = "Ancho:";
            // 
            // gbMedidas
            // 
            this.gbMedidas.Controls.Add(this.lblAncho);
            this.gbMedidas.Controls.Add(this.lblAlto);
            this.gbMedidas.Controls.Add(this.lblProfundidad);
            this.gbMedidas.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMedidas.Location = new System.Drawing.Point(64, 667);
            this.gbMedidas.Name = "gbMedidas";
            this.gbMedidas.Size = new System.Drawing.Size(578, 215);
            this.gbMedidas.TabIndex = 8;
            this.gbMedidas.TabStop = false;
            this.gbMedidas.Text = "MEDIDAS";
            this.gbMedidas.Visible = false;
            // 
            // gbPrecios
            // 
            this.gbPrecios.Controls.Add(this.txtPrecioFinal);
            this.gbPrecios.Controls.Add(this.txtImpuesto);
            this.gbPrecios.Controls.Add(this.txtPrecioNeto);
            this.gbPrecios.Controls.Add(this.lblImpuesto);
            this.gbPrecios.Controls.Add(this.lblPrecioNeto);
            this.gbPrecios.Controls.Add(this.lblPrecioFInal);
            this.gbPrecios.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrecios.Location = new System.Drawing.Point(671, 53);
            this.gbPrecios.Name = "gbPrecios";
            this.gbPrecios.Size = new System.Drawing.Size(578, 263);
            this.gbPrecios.TabIndex = 9;
            this.gbPrecios.TabStop = false;
            this.gbPrecios.Text = "PRECIOS";
            // 
            // txtPrecioFinal
            // 
            this.txtPrecioFinal.Location = new System.Drawing.Point(169, 202);
            this.txtPrecioFinal.Name = "txtPrecioFinal";
            this.txtPrecioFinal.Size = new System.Drawing.Size(372, 40);
            this.txtPrecioFinal.TabIndex = 16;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(169, 129);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(372, 40);
            this.txtImpuesto.TabIndex = 15;
            // 
            // txtPrecioNeto
            // 
            this.txtPrecioNeto.Location = new System.Drawing.Point(169, 61);
            this.txtPrecioNeto.Name = "txtPrecioNeto";
            this.txtPrecioNeto.Size = new System.Drawing.Size(372, 40);
            this.txtPrecioNeto.TabIndex = 14;
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.AutoSize = true;
            this.lblImpuesto.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpuesto.Location = new System.Drawing.Point(18, 132);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(126, 33);
            this.lblImpuesto.TabIndex = 7;
            this.lblImpuesto.Text = "Impuesto:";
            // 
            // lblPrecioNeto
            // 
            this.lblPrecioNeto.AutoSize = true;
            this.lblPrecioNeto.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioNeto.Location = new System.Drawing.Point(18, 61);
            this.lblPrecioNeto.Name = "lblPrecioNeto";
            this.lblPrecioNeto.Size = new System.Drawing.Size(145, 33);
            this.lblPrecioNeto.TabIndex = 5;
            this.lblPrecioNeto.Text = "Precio neto:";
            // 
            // lblPrecioFInal
            // 
            this.lblPrecioFInal.AutoSize = true;
            this.lblPrecioFInal.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioFInal.Location = new System.Drawing.Point(19, 209);
            this.lblPrecioFInal.Name = "lblPrecioFInal";
            this.lblPrecioFInal.Size = new System.Drawing.Size(142, 33);
            this.lblPrecioFInal.TabIndex = 6;
            this.lblPrecioFInal.Text = "Precio final:";
            // 
            // gbCostos
            // 
            this.gbCostos.Controls.Add(this.txtCostoSIVA);
            this.gbCostos.Controls.Add(this.txtCostoNeto);
            this.gbCostos.Controls.Add(this.label1);
            this.gbCostos.Controls.Add(this.label2);
            this.gbCostos.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCostos.Location = new System.Drawing.Point(671, 355);
            this.gbCostos.Name = "gbCostos";
            this.gbCostos.Size = new System.Drawing.Size(578, 242);
            this.gbCostos.TabIndex = 10;
            this.gbCostos.TabStop = false;
            this.gbCostos.Text = "COSTOS";
            // 
            // txtCostoSIVA
            // 
            this.txtCostoSIVA.Location = new System.Drawing.Point(169, 167);
            this.txtCostoSIVA.Name = "txtCostoSIVA";
            this.txtCostoSIVA.Size = new System.Drawing.Size(372, 40);
            this.txtCostoSIVA.TabIndex = 18;
            // 
            // txtCostoNeto
            // 
            this.txtCostoNeto.Location = new System.Drawing.Point(169, 89);
            this.txtCostoNeto.Name = "txtCostoNeto";
            this.txtCostoNeto.Size = new System.Drawing.Size(372, 40);
            this.txtCostoNeto.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Costo s/IVA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "Costo neto:";
            // 
            // txtbID
            // 
            this.txtbID.Location = new System.Drawing.Point(182, 55);
            this.txtbID.Name = "txtbID";
            this.txtbID.Size = new System.Drawing.Size(372, 31);
            this.txtbID.TabIndex = 11;
            this.txtbID.Visible = false;
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.cmbProveedor);
            this.gbDatos.Controls.Add(this.txtCategoria);
            this.gbDatos.Controls.Add(this.txtMarca);
            this.gbDatos.Controls.Add(this.txtDescripcion);
            this.gbDatos.Controls.Add(this.lblCategoria);
            this.gbDatos.Controls.Add(this.txtbID);
            this.gbDatos.Controls.Add(this.lblID);
            this.gbDatos.Controls.Add(this.lblDescripcion);
            this.gbDatos.Controls.Add(this.lblMarca);
            this.gbDatos.Controls.Add(this.lblProveedor);
            this.gbDatos.Location = new System.Drawing.Point(64, 57);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(578, 355);
            this.gbDatos.TabIndex = 12;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "DATOS";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(182, 298);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(372, 33);
            this.cmbProveedor.TabIndex = 15;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(182, 232);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(372, 31);
            this.txtCategoria.TabIndex = 14;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(182, 173);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(372, 31);
            this.txtMarca.TabIndex = 13;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(182, 114);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(372, 31);
            this.txtDescripcion.TabIndex = 12;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(1075, 667);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(173, 45);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(861, 667);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(173, 45);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 933);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.gbCostos);
            this.Controls.Add(this.gbPrecios);
            this.Controls.Add(this.gbMedidas);
            this.Controls.Add(this.gbStock);
            this.Name = "frmProducto";
            this.Text = "Formulario Producto";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            this.gbStock.ResumeLayout(false);
            this.gbStock.PerformLayout();
            this.gbMedidas.ResumeLayout(false);
            this.gbMedidas.PerformLayout();
            this.gbPrecios.ResumeLayout(false);
            this.gbPrecios.PerformLayout();
            this.gbCostos.ResumeLayout(false);
            this.gbCostos.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblStockMin;
        private System.Windows.Forms.Label lblStockActual;
        private System.Windows.Forms.GroupBox gbStock;
        private System.Windows.Forms.Label lblProfundidad;
        private System.Windows.Forms.Label lblAlto;
        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.GroupBox gbMedidas;
        private System.Windows.Forms.GroupBox gbPrecios;
        private System.Windows.Forms.Label lblImpuesto;
        private System.Windows.Forms.Label lblPrecioNeto;
        private System.Windows.Forms.Label lblPrecioFInal;
        private System.Windows.Forms.GroupBox gbCostos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbID;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtStockActual;
        private System.Windows.Forms.TextBox txtStockMin;
        private System.Windows.Forms.TextBox txtPrecioFinal;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.TextBox txtPrecioNeto;
        private System.Windows.Forms.TextBox txtCostoSIVA;
        private System.Windows.Forms.TextBox txtCostoNeto;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}