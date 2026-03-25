using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webExamen.Models
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public string NombreCategorias { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public string Medida { get; set; }
        public string Caducidad { get; set; }
        public string CodigoBarras { get; set; }



    }
}