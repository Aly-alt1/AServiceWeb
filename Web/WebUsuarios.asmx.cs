using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using webExamen.Data;
using webExamen.Models;

namespace webExamen.Services
{
    /// <summary>
    /// Descripción breve de WebUsuarios
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebUsuarios : System.Web.Services.WebService
    {
        /*
        [WebMethod]

        public bool Create(usuarios usuario)
        {
            Services.ServicesUsuarios usuarioServices = new Services.ServicesUsuarios();
            return usuarioServices.CreateUsuario(usuario);
        }
        [WebMethod]
        public usuarios GetUsuario(usuarios usuario)
        {
            Services.ServicesUsuarios servicesUsuarios = new Services.ServicesUsuarios();
            return servicesUsuarios.GetUsuario(usuario);
        }

        [WebMethod]
        public bool ValidarLogin(usuarios usuario)
        {
            Services.ServicesUsuarios servicesUsuarios = new Services.ServicesUsuarios();
            return servicesUsuarios.ValidarLogin(usuario);
        }

        [WebMethod]
        public bool Delete(int id)
        {
            Services.ServicesUsuarios servicesUsuarios = new Services.ServicesUsuarios();
            return servicesUsuarios.deleteUsuario(id);
        }

        [WebMethod]
        public bool Suspender(usuarios usuario)
        {
            Services.ServicesUsuarios servicesUsuarios = new Services.ServicesUsuarios();
            return servicesUsuarios.SuspenderCuenta(usuario);
        }

        [WebMethod]
        public bool ValidarSuspension(usuarios usuario)
        {
            Services.ServicesUsuarios servicesUsuarios = new Services.ServicesUsuarios();
            return servicesUsuarios.ValidarSuspension(usuario);
        }
        [WebMethod]
        public bool ReactivarCuenta(usuarios usuario)
        {
            Services.ServicesUsuarios servicesUsuarios = new Services.ServicesUsuarios();
            return servicesUsuarios.ActivarSuspencion(usuario);
        }

        [WebMethod]
        public bool EditarUsuario(usuarios usuario)
        {
            Services.ServicesUsuarios servicesUsuarios = new Services.ServicesUsuarios();
            return servicesUsuarios.EditarUsuario(usuario);
        }

        [WebMethod]
        public List<usuarios> GetAll()
        {
            Services.ServicesUsuarios servicesUsuarios = new Services.ServicesUsuarios();
            return servicesUsuarios.GetAllUsuarios();
        }
        */

        [WebMethod]
        public bool Crear(Usuarios u)
        { 
            usuarios usuarios = new usuarios();
            usuarios.username = u.username.Trim().ToLower();
            usuarios.password = u.password.Trim().ToLower();
            usuarios.suspendido = u.suspendido;

            List<UsuarioRoles> userRoles = new List<UsuarioRoles>();

            foreach (var userR in u.UsuariosRoles)
            {
                userRoles.Add(new UsuarioRoles
                {
                  //idUser = userR.usuarios.IdUsuario,
                  idRoles = userR.rol.IdRoles
                });
            }
            usuarios.UsuarioRoles = userRoles;
            Services.ServicesUsuarios servicesUsuarios = new Services.ServicesUsuarios();
            return servicesUsuarios.Crear(usuarios);
        }

        [WebMethod]
        public usuarios Login(Usuarios user)
        {
            //aca se tiene que pasar el usuario que no esta en la base de datos a la base de datos
            usuarios usuario = new usuarios();
            usuario.suspendido = false;
            usuario.username = user.username.Trim().ToLower();
            usuario.password = user.password.Trim().ToLower();

            //aca estae l problema, se asigna el rol al usuario 
            //pero se neceita el id para saber su rol, y para saber su id se necesita el id

            //se recorre toda la lista para cambiar los valores al rol y usuario

            List<UsuarioRoles> userRoles = new List<UsuarioRoles>(); 

            foreach (var userR in user.UsuariosRoles)
            {
                userRoles.Add(new UsuarioRoles
                {
                    idUser = userR.usuarios.IdUsuario,
                    idRoles = userR.rol.IdRoles
                });
            }
            usuario.UsuarioRoles = userRoles;
            Services.ServicesUsuarios servicesUsuarios = new Services.ServicesUsuarios();
            return servicesUsuarios.Login(user);
        }

        [WebMethod]
        public List<usuarios> GetSuspendidos_SP()
        {
            Services.ServicesUsuarios servicesUsuarios = new Services.ServicesUsuarios();
            return servicesUsuarios.GetSuspendidosSp();
        }

        [WebMethod]
        public usuarios GetUsuarioByName(string username)
        {
            Services.ServicesUsuarios servicesUsuarios = new Services.ServicesUsuarios();
            return servicesUsuarios.GetUsuarioByName(username);
        }

        [WebMethod]
        public List<UsuarioRol> GetAllUsuariosRoles()
        {
            Services.ServicesUsuarios servicesUsuarios = new Services.ServicesUsuarios();
            return servicesUsuarios.GetUsuarioRoles();
        }

    }
}
