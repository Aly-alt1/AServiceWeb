using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebEjem.Web
{
    /// <summary>
    /// Descripción breve de WebPerfilUsuario
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebPerfilUsuario : System.Web.Services.WebService
    {

        [WebMethod]
        public bool CrearPerfilUsuario(Models.PerfilUsuario perfil)
        {
            Data.perfilUsuario perfilUsuario = new Data.perfilUsuario();
            perfilUsuario.nombre = perfil.Nombre;

            List<Data.direcciones> direcciones = new List<Data.direcciones>();
           

            foreach (var d in perfil.Direcciones) {
                Data.direcciones direccion = new Data.direcciones();
                direccion.calle = d.calle;
                direcciones.Add(direccion);
            }
            perfilUsuario.direcciones = direcciones;

            List<Data.telefonos> telefonos= new List<Data.telefonos>();
            foreach(var t in perfil.Telefonos)
            {
                Data.telefonos telefono = new Data.telefonos();
                telefono.celular = t.celular;
                telefonos.Add(telefono);
            }
            perfilUsuario.telefonos = telefonos;
            Services.ServicesPerfilUsuario servicesPerfil= new Services.ServicesPerfilUsuario();
            return servicesPerfil.CrearPerfil(perfilUsuario);

        }
    }
}
