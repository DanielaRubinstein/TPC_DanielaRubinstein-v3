namespace Presentacion
{
    partial class frmCliente
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
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtCUIL = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbDireccion = new System.Windows.Forms.GroupBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbDireccion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCliente.Location = new System.Drawing.Point(165, 61);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(48, 36);
            this.lblIdCliente.TabIndex = 0;
            this.lblIdCliente.Text = "ID:";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuit.Location = new System.Drawing.Point(135, 112);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(76, 36);
            this.lblCuit.TabIndex = 1;
            this.lblCuit.Text = "CUIT:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Razon social:";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(224, 168);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(371, 31);
            this.txtRazonSocial.TabIndex = 14;
            // 
            // txtCUIL
            // 
            this.txtCUIL.Location = new System.Drawing.Point(224, 112);
            this.txtCUIL.Name = "txtCUIL";
            this.txtCUIL.Size = new System.Drawing.Size(371, 31);
            this.txtCUIL.TabIndex = 15;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(438, 804);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(202, 52);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Aceptar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gbDireccion
            // 
            this.gbDireccion.Controls.Add(this.txtLocalidad);
            this.gbDireccion.Controls.Add(this.txtDireccion);
            this.gbDireccion.Controls.Add(this.lblLocalidad);
            this.gbDireccion.Controls.Add(this.lblDireccion);
            this.gbDireccion.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDireccion.Location = new System.Drawing.Point(47, 235);
            this.gbDireccion.Name = "gbDireccion";
            this.gbDireccion.Size = new System.Drawing.Size(592, 220);
            this.gbDireccion.TabIndex = 21;
            this.gbDireccion.TabStop = false;
            this.gbDireccion.Text = "Direccion";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(160, 62);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(383, 40);
            this.txtLocalidad.TabIndex = 17;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(160, 124);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(383, 40);
            this.txtDireccion.TabIndex = 13;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.Location = new System.Drawing.Point(20, 62);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(134, 36);
            this.lblLocalidad.TabIndex = 11;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(21, 128);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(133, 36);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Direccion:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.lblMail);
            this.groupBox1.Controls.Add(this.txtContacto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblTelefono);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(47, 495);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 255);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contacto";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(160, 189);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(383, 40);
            this.txtMail.TabIndex = 20;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(160, 128);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(383, 40);
            this.txtTelefono.TabIndex = 19;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(63, 190);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(76, 36);
            this.lblMail.TabIndex = 18;
            this.lblMail.Text = "Mail:";
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(160, 62);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(383, 40);
            this.txtContacto.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 36);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(21, 128);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(122, 36);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "Telefono:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(207, 804);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(203, 52);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(687, 868);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbDireccion);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCUIL);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCuit);
            this.Controls.Add(this.lblIdCliente);
            this.MaximumSize = new System.Drawing.Size(1694, 939);
            this.MinimumSize = new System.Drawing.Size(713, 939);
            this.Name = "frmCliente";
            this.Text = "Formulario cliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.gbDireccion.ResumeLayout(false);
            this.gbDireccion.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtCUIL;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gbDireccion;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Button btnCancelar;
    }
}