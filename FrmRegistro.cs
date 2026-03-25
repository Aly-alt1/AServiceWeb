using examenForms.ServiceRoles;
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
    public partial class FrmRegistro : Form
    {
         private ServiceRoles.WebRolesSoapClient soapClient= null;
         private usuarioServices.WebUsuariosSoapClient usuariosSoapClient = null;
        private int idRoles = 0;
        public FrmRegistro()
        {
            soapClient = new ServiceRoles.WebRolesSoapClient();
            InitializeComponent();

            //llenado del combobox de roles
            this.cmbRoles.DataSource = soapClient.GetALLRoles();
            this.cmbRoles.DisplayMember = "StrValor";
            this.cmbRoles.SelectedIndex = 0;
            this.cmbRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.ValueMember = "IdValor";
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNombreUsuario.Text.Equals("") && !txtPassword.Text.Equals(""))
                {

                    usuarioServices.usuarios user = new usuarioServices.usuarios();
                    user.username = txtNombreUsuario.Text.ToLower();
                    user.password = txtPassword.Text.ToLower();
                    if (usuariosSoapClient.Create(user))
                    {

                        MessageBox.Show("Usuario creado");
                        this.Hide();
                        LoginForms login = new LoginForms();
                        login.Visible = true;
                        limpiar();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo completar la transaccion");
                limpiar();
            }
        }

        private void limpiar()
        {
            this.txtNombreUsuario.Text = "";
            this.txtPassword.Text = "";
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                LoginForms login = new LoginForms();
                login.Visible = true;
            }
            catch(Exception ex)
            {

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbRoles.SelectedIndex > -1)
            {
               ServiceRoles.Rol rol = (ServiceRoles.Rol)this.cmbRoles.SelectedItem;
                this.idRoles = rol.IdRoles;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            usuariosSoapClient = new usuarioServices.WebUsuariosSoapClient();
            usuarioServices.Usuario user = new usuarioServices.Usuario();
            user.Username = txtNombreUsuario.Text.Trim().ToLower();
            user.Password = txtPassword.Text.Trim().ToLower();
            user.suspendido = false;

            usuarioServices.Rol rol = new usuarioServices.Rol(Id= this.idRoles);

            usuarioServices.UsuarioRol userRol = new usuarioServices.UsuarioRol
            {
                Rol = rol
            };
            List<usuarioServices.UsuarioRol> listado = new List<usuarioServices.UsuarioRol>();
            listado.Add(userRol);
            user.UsuarioRoles = listado.ToArray<usuarioServices.UsuarioRol>;
            usuariosSoapClient.Create(user);

            if (usuariosSoapClient.Crear(user))
            {
                MessageBox.Show("los datos se insertaron correctamente");
            }
            else
            {
                MessageBox.Show("no se pudo insertar el usuario");
            }
        }
    }
}
