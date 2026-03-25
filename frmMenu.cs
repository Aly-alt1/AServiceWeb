using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examenForms
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        public frmMenu(string userName)
        {
            InitializeComponent();
            this.lblNombreUsuario.Text = "Fecha"+ new DateTime().Date
                +"Usuario"+userName;
        }

        private void menuBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void editarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPerfil perfil = new FrmPerfil();
            perfil.Show();
        }

        private void suspenderCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPerfil perfil = new FrmPerfil();
            perfil.Show();
        }

        private void borrarCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPerfil perfil = new FrmPerfil();
            perfil.Show();
        }

        private void reactivarCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPerfil perfil = new FrmPerfil();
            perfil.Show();
        }

        private void salirAlLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForms login = new LoginForms();
            login.Show();
            this.FormClosed += (s,args) => { 
                this.Close();
            };
        }

        private void crearRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRoles roles = new FrmRoles();
            roles.Show();
        }

        private void asignacionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
