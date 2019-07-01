namespace Presentacion
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.lblVenta = new System.Windows.Forms.Label();
            this.btnVenta = new System.Windows.Forms.Button();
            this.lblCompra = new System.Windows.Forms.Label();
            this.btnCompra = new System.Windows.Forms.Button();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnCliente = new System.Windows.Forms.Button();
            this.lblFactura = new System.Windows.Forms.Label();
            this.btnFactura = new System.Windows.Forms.Button();
            this.lblProducto = new System.Windows.Forms.Label();
            this.btnProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVenta
            // 
            this.lblVenta.AutoSize = true;
            this.lblVenta.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenta.Location = new System.Drawing.Point(1200, 457);
            this.lblVenta.Name = "lblVenta";
            this.lblVenta.Size = new System.Drawing.Size(106, 45);
            this.lblVenta.TabIndex = 23;
            this.lblVenta.Text = "Venta";
            // 
            // btnVenta
            // 
            this.btnVenta.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVenta.BackgroundImage")));
            this.btnVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVenta.FlatAppearance.BorderSize = 0;
            this.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenta.Location = new System.Drawing.Point(1179, 284);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(129, 138);
            this.btnVenta.TabIndex = 22;
            this.btnVenta.UseVisualStyleBackColor = false;
            // 
            // lblCompra
            // 
            this.lblCompra.AutoSize = true;
            this.lblCompra.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompra.Location = new System.Drawing.Point(908, 457);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(139, 45);
            this.lblCompra.TabIndex = 21;
            this.lblCompra.Text = "Compra";
            this.lblCompra.Visible = false;
            // 
            // btnCompra
            // 
            this.btnCompra.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCompra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCompra.BackgroundImage")));
            this.btnCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompra.FlatAppearance.BorderSize = 0;
            this.btnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompra.Location = new System.Drawing.Point(911, 284);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(129, 138);
            this.btnCompra.TabIndex = 20;
            this.btnCompra.UseVisualStyleBackColor = false;
            this.btnCompra.Visible = false;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(632, 457);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(176, 45);
            this.lblProveedor.TabIndex = 19;
            this.lblProveedor.Text = "Proveedor";
            // 
            // btnProveedor
            // 
            this.btnProveedor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProveedor.BackgroundImage")));
            this.btnProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedor.FlatAppearance.BorderSize = 0;
            this.btnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedor.Location = new System.Drawing.Point(643, 284);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(129, 138);
            this.btnProveedor.TabIndex = 18;
            this.btnProveedor.UseVisualStyleBackColor = false;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(371, 457);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(123, 45);
            this.lblCliente.TabIndex = 17;
            this.lblCliente.Text = "Cliente";
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCliente.BackgroundImage")));
            this.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Location = new System.Drawing.Point(375, 284);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(129, 138);
            this.btnCliente.TabIndex = 16;
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactura.Location = new System.Drawing.Point(1447, 457);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(131, 45);
            this.lblFactura.TabIndex = 15;
            this.lblFactura.Text = "Factura";
            // 
            // btnFactura
            // 
            this.btnFactura.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFactura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFactura.BackgroundImage")));
            this.btnFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFactura.FlatAppearance.BorderSize = 0;
            this.btnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactura.Location = new System.Drawing.Point(1447, 284);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(129, 138);
            this.btnFactura.TabIndex = 14;
            this.btnFactura.UseVisualStyleBackColor = false;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(94, 457);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(157, 45);
            this.lblProducto.TabIndex = 13;
            this.lblProducto.Text = "Producto";
            // 
            // btnProducto
            // 
            this.btnProducto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProducto.BackgroundImage")));
            this.btnProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducto.FlatAppearance.BorderSize = 0;
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducto.Location = new System.Drawing.Point(102, 284);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(134, 138);
            this.btnProducto.TabIndex = 12;
            this.btnProducto.UseVisualStyleBackColor = false;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1724, 829);
            this.Controls.Add(this.lblVenta);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.lblCompra);
            this.Controls.Add(this.btnCompra);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.btnProveedor);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.lblFactura);
            this.Controls.Add(this.btnFactura);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.btnProducto);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1750, 900);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1750, 900);
            this.Name = "frmInicio";
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVenta;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Label lblCompra;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Button btnProducto;
    }
}

