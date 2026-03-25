using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebEjem.Data;

namespace WebEjem.Models
{
    public class PerfilUsuario
    {
        public int IdPerfilUsuario { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }

        public string Rfc { get; set; }
        public List<direcciones> Direcciones { get; set; }
        public List<telefonos> Telefonos { get; set; }
    }
}