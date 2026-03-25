using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebEjem.Models
{
    public class UsuarioConRoles
    {
        public int IdUsuario { get; set; }
        public int IdRol { get; set; }
        public string Nombre { get; set; }
        public string NombreRol { get; set; }
        public string Descripcion { get; set; }
    }
}