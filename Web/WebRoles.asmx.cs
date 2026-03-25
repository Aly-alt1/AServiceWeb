using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using webExamen.Data;
using webExamen.Models;

namespace webExamen.Web
{
    /// <summary>
    /// Descripción breve de WebRoles
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebRoles : System.Web.Services.WebService
    {
        
        [WebMethod]
        public bool Craete(Rol rol)
        {
            roles roles = new roles();
            roles.strValor = rol.StrValor;
            roles.strDescripcion = rol.StrDescripcion;

            Services.ServicesRoles servicesRoles = new Services.ServicesRoles();
            servicesRoles.Create(roles);
            return true;
        }


        [WebMethod]
        public List<Rol> GetALLRoles()
        {
            Services.ServicesRoles servicesRoles = new Services.ServicesRoles();
            //aca se regresa uno aparte de la base de datos
            List<Rol> Roles = new List<Rol>();
            foreach (var item in servicesRoles.GetRoles())
            {
                //se crea el rol que no va con la base de datos
                Rol rol = new Rol();
                rol.IdRoles = item.idRoles;
                rol.StrValor = item.strValor;
                rol.StrDescripcion = item.strDescripcion;
                //se asigna a la nueva lista de roles
                Roles.Add(rol);
            }
            //se regresa la lista de roles que ya no tienen que ver con la base de datos
            return Roles;
        }
    }
}
