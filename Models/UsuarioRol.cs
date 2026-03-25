using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebEjem.Models
{
    public class UsuarioRol
    {
        public int IdUsuarioRoles { get; set; }
        public Usuarios usuarios { get; set; }
        public Rol rol { get; set; }

    }
}