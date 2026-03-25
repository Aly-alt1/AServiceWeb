using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webExamen.Models
{
    public class UsuarioRol
    {
        public int IdUsuarioRol { get; set; }
        public Usuarios usuarios { get; set; }
        public Rol rol { get; set; }
    }
}