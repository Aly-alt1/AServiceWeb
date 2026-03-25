using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsEjem
{
    public partial class FrmPerfilUsuario : Form
    {

        private ServiceUsuarioPerfil.WebPerfilUsuarioSoapClient perfilUsuarioSoapClient = null;
        private List<ServiceUsuarioPerfil.direcciones> direccion = null;
        private List<ServiceUsuarioPerfil.telefonos> telefonos = null;
        private ServiceUsuarioPerfil.PerfilUsuario perfilUsuario = null; 
        public FrmPerfilUsuario()
        {
            InitializeComponent();
            perfilUsuarioSoapClient = new ServiceUsuarioPerfil.WebPerfilUsuarioSoapClient();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ServiceUsuarioPerfil.PerfilUsuario usuario = new ServiceUsuarioPerfil.PerfilUsuario();
            usuario.Nombre =this.txtNombre.Text.Trim().ToLower();

            ServiceUsuarioPerfil.direcciones direccion = new ServiceUsuarioPerfil.direcciones();
            direccion.calle = this.txtCalle.Text.Trim().ToLower();

            List<ServiceUsuarioPerfil.direcciones> direcciones = new List<ServiceUsuarioPerfil.direcciones>();
            direcciones.Add(direccion);

            usuario.Direcciones = direcciones.ToArray();

            ServiceUsuarioPerfil.telefonos telefono = new ServiceUsuarioPerfil.telefonos();
            telefono.celular = this.txtCelular.Text.Trim().ToLower();

            List<ServiceUsuarioPerfil.telefonos> telefonos = new List<ServiceUsuarioPerfil.telefonos>();
            telefonos.Add(telefono);
            usuario.Telefonos = telefonos.ToArray();

            MessageBox.Show(usuario.Nombre + "" + usuario.Direcciones[0].calle + " "+telefono);
        }
    }
}
