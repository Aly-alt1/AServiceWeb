namespace examenForms
{
    partial class FrmPerfil
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
            this.lblNomUsuario = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnEditarUser = new System.Windows.Forms.Button();
            this.btnSuspender = new System.Windows.Forms.Button();
            this.btnReactivarCuenta = new System.Windows.Forms.Button();
            this.btnBorrarCuenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomUsuario
            // 
            this.lblNomUsuario.AutoSize = true;
            this.lblNomUsuario.Location = new System.Drawing.Point(80, 98);
            this.lblNomUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomUsuario.Name = "lblNomUsuario";
            this.lblNomUsuario.Size = new System.Drawing.Size(151, 20);
            this.lblNomUsuario.TabIndex = 0;
            this.lblNomUsuario.Text = "Nombre de usuario";
            this.lblNomUsuario.Click += new System.EventHandler(this.lblNomUsuario_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(84, 163);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(89, 20);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Contaseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(260, 98);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(270, 26);
            this.txtUsuario.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(260, 163);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(270, 26);
            this.txtPassword.TabIndex = 3;
            // 
            // btnEditarUser
            // 
            this.btnEditarUser.Location = new System.Drawing.Point(129, 260);
            this.btnEditarUser.Name = "btnEditarUser";
            this.btnEditarUser.Size = new System.Drawing.Size(135, 36);
            this.btnEditarUser.TabIndex = 4;
            this.btnEditarUser.Text = "Editar Usuario";
            this.btnEditarUser.UseVisualStyleBackColor = true;
            // 
            // btnSuspender
            // 
            this.btnSuspender.Location = new System.Drawing.Point(375, 260);
            this.btnSuspender.Name = "btnSuspender";
            this.btnSuspender.Size = new System.Drawing.Size(167, 36);
            this.btnSuspender.TabIndex = 5;
            this.btnSuspender.Text = "Suspender Usuario";
            this.btnSuspender.UseVisualStyleBackColor = true;
            // 
            // btnReactivarCuenta
            // 
            this.btnReactivarCuenta.Location = new System.Drawing.Point(375, 348);
            this.btnReactivarCuenta.Name = "btnReactivarCuenta";
            this.btnReactivarCuenta.Size = new System.Drawing.Size(167, 36);
            this.btnReactivarCuenta.TabIndex = 6;
            this.btnReactivarCuenta.Text = "Reactivar Cuenta";
            this.btnReactivarCuenta.UseVisualStyleBackColor = true;
            // 
            // btnBorrarCuenta
            // 
            this.btnBorrarCuenta.Location = new System.Drawing.Point(129, 348);
            this.btnBorrarCuenta.Name = "btnBorrarCuenta";
            this.btnBorrarCuenta.Size = new System.Drawing.Size(135, 36);
            this.btnBorrarCuenta.TabIndex = 7;
            this.btnBorrarCuenta.Text = "Borrar Cuenta";
            this.btnBorrarCuenta.UseVisualStyleBackColor = true;
            // 
            // FrmPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 541);
            this.Controls.Add(this.btnBorrarCuenta);
            this.Controls.Add(this.btnReactivarCuenta);
            this.Controls.Add(this.btnSuspender);
            this.Controls.Add(this.btnEditarUser);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblNomUsuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPerfil";
            this.Text = "FrmPerfil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnEditarUser;
        private System.Windows.Forms.Button btnSuspender;
        private System.Windows.Forms.Button btnReactivarCuenta;
        private System.Windows.Forms.Button btnBorrarCuenta;
    }
}