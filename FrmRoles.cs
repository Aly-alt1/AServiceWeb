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
    public partial class FrmRoles : Form
    {
        ServiceRoles.WebRolesSoapClient soapClient = null;
        public FrmRoles()
        {
            InitializeComponent();

            soapClient = new ServiceRoles.WebRolesSoapClient();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtNombre.Text))
            {
                ServiceRoles.Rol rol = new ServiceRoles.Rol();

                rol.StrValor = this.txtNombre.Text.Trim();
                rol.StrDescripcion = this.Text.Trim();
                soapClient.Craete(rol);

                MessageBox.Show("Se ha creado el rol");

                this.Close();
            }
        }
    }
}
