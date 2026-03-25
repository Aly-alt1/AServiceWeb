using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebEjem.Models
{
    public class Rol
    {
        public int IdRoles { get; set; }
        public string StrValor { get; set; }
        public string StrDescripcion { get; set; }
        
        public List<UsuarioRol> UsuarioRoles { get; set; }
    }
}