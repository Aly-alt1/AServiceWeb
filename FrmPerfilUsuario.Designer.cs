namespace FormsEjem
{
    partial class FrmPerfilUsuario
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
            this.gpbPersonales = new System.Windows.Forms.GroupBox();
            this.gpbDireccion = new System.Windows.Forms.GroupBox();
            this.gpbTelefono = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gpbPersonales.SuspendLayout();
            this.gpbDireccion.SuspendLayout();
            this.gpbTelefono.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbPersonales
            // 
            this.gpbPersonales.Controls.Add(this.txtNombre);
            this.gpbPersonales.Controls.Add(this.lblNombre);
            this.gpbPersonales.Location = new System.Drawing.Point(68, 27);
            this.gpbPersonales.Name = "gpbPersonales";
            this.gpbPersonales.Size = new System.Drawing.Size(829, 205);
            this.gpbPersonales.TabIndex = 0;
            this.gpbPersonales.TabStop = false;
            this.gpbPersonales.Text = "Datos Personales";
            // 
            // gpbDireccion
            // 
            this.gpbDireccion.Controls.Add(this.txtCalle);
            this.gpbDireccion.Controls.Add(this.lblCalle);
            this.gpbDireccion.Location = new System.Drawing.Point(84, 252);
            this.gpbDireccion.Name = "gpbDireccion";
            this.gpbDireccion.Size = new System.Drawing.Size(374, 177);
            this.gpbDireccion.TabIndex = 1;
            this.gpbDireccion.TabStop = false;
            this.gpbDireccion.Text = "Datos de Direccion";
            // 
            // gpbTelefono
            // 
            this.gpbTelefono.Controls.Add(this.txtCelular);
            this.gpbTelefono.Controls.Add(this.lblCelular);
            this.gpbTelefono.Location = new System.Drawing.Point(513, 260);
            this.gpbTelefono.Name = "gpbTelefono";
            this.gpbTelefono.Size = new System.Drawing.Size(384, 169);
            this.gpbTelefono.TabIndex = 2;
            this.gpbTelefono.TabStop = false;
            this.gpbTelefono.Text = "Datos de Telefono";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(66, 51);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(163, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(325, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(17, 61);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(38, 16);
            this.lblCalle.TabIndex = 0;
            this.lblCalle.Text = "Calle";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(81, 61);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(255, 22);
            this.txtCalle.TabIndex = 1;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(28, 59);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(49, 16);
            this.lblCelular.TabIndex = 0;
            this.lblCelular.Text = "Celular";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(115, 56);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(185, 22);
            this.txtCelular.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(804, 455);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmPerfilUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 502);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gpbTelefono);
            this.Controls.Add(this.gpbDireccion);
            this.Controls.Add(this.gpbPersonales);
            this.Name = "FrmPerfilUsuario";
            this.Text = "FrmPerfilUsuario";
            this.gpbPersonales.ResumeLayout(false);
            this.gpbPersonales.PerformLayout();
            this.gpbDireccion.ResumeLayout(false);
            this.gpbDireccion.PerformLayout();
            this.gpbTelefono.ResumeLayout(false);
            this.gpbTelefono.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPersonales;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gpbDireccion;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.GroupBox gpbTelefono;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Button btnGuardar;
    }
}