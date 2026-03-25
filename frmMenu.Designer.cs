namespace examenForms
{
    partial class frmMenu
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
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suspenderCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reactivarCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirAlLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarUsuarioPorIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosLosUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarUsuariosPorNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.perfilToolStripMenuItem,
            this.administracionToolStripMenuItem,
            this.rolesToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(800, 28);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            this.menuBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuBar_ItemClicked);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarPerfilToolStripMenuItem,
            this.suspenderCuentaToolStripMenuItem,
            this.borrarCuentaToolStripMenuItem,
            this.reactivarCuentaToolStripMenuItem,
            this.salirAlLoginToolStripMenuItem});
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.perfilToolStripMenuItem.Text = "Perfil";
            // 
            // editarPerfilToolStripMenuItem
            // 
            this.editarPerfilToolStripMenuItem.Name = "editarPerfilToolStripMenuItem";
            this.editarPerfilToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.editarPerfilToolStripMenuItem.Text = "Editar perfil";
            this.editarPerfilToolStripMenuItem.Click += new System.EventHandler(this.editarPerfilToolStripMenuItem_Click);
            // 
            // suspenderCuentaToolStripMenuItem
            // 
            this.suspenderCuentaToolStripMenuItem.Name = "suspenderCuentaToolStripMenuItem";
            this.suspenderCuentaToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.suspenderCuentaToolStripMenuItem.Text = "Suspender Cuenta";
            this.suspenderCuentaToolStripMenuItem.Click += new System.EventHandler(this.suspenderCuentaToolStripMenuItem_Click);
            // 
            // borrarCuentaToolStripMenuItem
            // 
            this.borrarCuentaToolStripMenuItem.Name = "borrarCuentaToolStripMenuItem";
            this.borrarCuentaToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.borrarCuentaToolStripMenuItem.Text = "Borrar Cuenta";
            this.borrarCuentaToolStripMenuItem.Click += new System.EventHandler(this.borrarCuentaToolStripMenuItem_Click);
            // 
            // reactivarCuentaToolStripMenuItem
            // 
            this.reactivarCuentaToolStripMenuItem.Name = "reactivarCuentaToolStripMenuItem";
            this.reactivarCuentaToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.reactivarCuentaToolStripMenuItem.Text = "Reactivar cuenta";
            this.reactivarCuentaToolStripMenuItem.Click += new System.EventHandler(this.reactivarCuentaToolStripMenuItem_Click);
            // 
            // salirAlLoginToolStripMenuItem
            // 
            this.salirAlLoginToolStripMenuItem.Name = "salirAlLoginToolStripMenuItem";
            this.salirAlLoginToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.salirAlLoginToolStripMenuItem.Text = "Salir al login";
            this.salirAlLoginToolStripMenuItem.Click += new System.EventHandler(this.salirAlLoginToolStripMenuItem_Click);
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarUsuarioPorIdToolStripMenuItem,
            this.todosLosUsuariosToolStripMenuItem,
            this.buscarUsuariosPorNombreToolStripMenuItem,
            this.buscarToolStripMenuItem});
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.administracionToolStripMenuItem.Text = "Administracion";
            // 
            // buscarUsuarioPorIdToolStripMenuItem
            // 
            this.buscarUsuarioPorIdToolStripMenuItem.Name = "buscarUsuarioPorIdToolStripMenuItem";
            this.buscarUsuarioPorIdToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.buscarUsuarioPorIdToolStripMenuItem.Text = "Buscar usuario por id";
            // 
            // todosLosUsuariosToolStripMenuItem
            // 
            this.todosLosUsuariosToolStripMenuItem.Name = "todosLosUsuariosToolStripMenuItem";
            this.todosLosUsuariosToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.todosLosUsuariosToolStripMenuItem.Text = "Todos los usuarios";
            // 
            // buscarUsuariosPorNombreToolStripMenuItem
            // 
            this.buscarUsuariosPorNombreToolStripMenuItem.Name = "buscarUsuariosPorNombreToolStripMenuItem";
            this.buscarUsuariosPorNombreToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.buscarUsuariosPorNombreToolStripMenuItem.Text = "Buscar usuarios por nombre";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearRolToolStripMenuItem});
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.rolesToolStripMenuItem.Text = "Roles";
            // 
            // crearRolToolStripMenuItem
            // 
            this.crearRolToolStripMenuItem.Name = "crearRolToolStripMenuItem";
            this.crearRolToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.crearRolToolStripMenuItem.Text = "Crear Rol";
            this.crearRolToolStripMenuItem.Click += new System.EventHandler(this.crearRolToolStripMenuItem_Click);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(530, 9);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(54, 16);
            this.lblNombreUsuario.TabIndex = 1;
            this.lblNombreUsuario.Text = "Usuario";
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(321, 125);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(139, 25);
            this.lblMenu.TabIndex = 2;
            this.lblMenu.Text = "Menu principal";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managerUsuariosToolStripMenuItem,
            this.asignacionDeUsuariosToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // managerUsuariosToolStripMenuItem
            // 
            this.managerUsuariosToolStripMenuItem.Name = "managerUsuariosToolStripMenuItem";
            this.managerUsuariosToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.managerUsuariosToolStripMenuItem.Text = "Manager Usuarios";
            // 
            // asignacionDeUsuariosToolStripMenuItem
            // 
            this.asignacionDeUsuariosToolStripMenuItem.Name = "asignacionDeUsuariosToolStripMenuItem";
            this.asignacionDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.asignacionDeUsuariosToolStripMenuItem.Text = "Asignacion de Usuarios";
            this.asignacionDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.asignacionDeUsuariosToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suspenderCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarUsuarioPorIdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reactivarCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosLosUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarUsuariosPorNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.ToolStripMenuItem salirAlLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearRolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionDeUsuariosToolStripMenuItem;
    }
}