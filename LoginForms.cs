using examenForms.ServiceProductos;
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
    public partial class LoginForms : Form
    {
        usuarioServices.WebUsuariosSoapClient usuariosSoapClient;
        public LoginForms()
        {
            InitializeComponent();
            usuariosSoapClient = new usuarioServices.WebUsuariosSoapClient();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtUsuario.Text.Equals("") && !txtPassword.Text.Equals(""))
                {

                    usuarioServices.usuarios user = new usuarioServices.usuarios();
                    user.username = txtUsuario.Text.ToLower().Trim();
                    user.password = txtPassword.Text.ToLower().Trim();

                    if (usuariosSoapClient.GetUsuario(user).idUser > 0)
                    {
                        MessageBox.Show("Se encontro el usuario");
                        this.Hide();
                        frmMenu menu = new frmMenu(user.username);
                        menu.Visible = true;
                        
                    }
                }

                }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo completar la transaccion");
                limpiar();
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtUsuario.Text.Equals("") && !txtPassword.Text.Equals("")) {

                    usuarioServices.usuarios user = new usuarioServices.usuarios();
                    user.username = txtUsuario.Text.ToLower();
                    user.password = txtPassword.Text.ToLower();
                    if (usuariosSoapClient.Create(user)) { 

                    MessageBox.Show("Usuario creado");
                        limpiar();
                    }
                }
            }
            catch(Exception ex)
            {

                MessageBox.Show("No se pudo completar la transaccion");
                limpiar();
            }
        }

        private void limpiar()
        {
            this.txtUsuario.Text = "";
            this.txtPassword.Text = "";
        }

        private void linkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                FrmRegistro registro = new FrmRegistro();
                registro.Visible = true;

                this.FormClosed += (s, args) => {
                    this.Close();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo completar la transaccion");
                limpiar();
            }
        }
    }
}
