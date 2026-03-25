using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webExamen.Data;

namespace webExamen.Models
{
    public partial class Usuarios
    {
        public int IdUsuario { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public bool suspendido { get; set; }

        public List<UsuarioRol> UsuariosRoles { get; set; }

         
    }
}