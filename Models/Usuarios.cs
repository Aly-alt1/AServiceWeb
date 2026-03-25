using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebEjem.Models
{
    public class Usuarios
    {
        public int idUser { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool suspendido { get; set; }
        public List<UsuarioRol> UsuarioRoles { get; set; }
    }
}