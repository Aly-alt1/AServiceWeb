using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace webExamen.Services
{
    /// <summary>
    /// Descripción breve de categorias
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class categorias : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Models.Categorias> GetCategorias()
        {
            return new List<Models.Categorias>{
                new Models.Categorias{ IdCategorias = 1, NombreCategorias = "Lacteos" },
                new Models.Categorias{ IdCategorias = 2, NombreCategorias = "Electrodomesticos" },
                new Models.Categorias{ IdCategorias = 3, NombreCategorias = "Ropa" },
                new Models.Categorias{ IdCategorias = 4, NombreCategorias = "Jardin" },
                new Models.Categorias{ IdCategorias = 5, NombreCategorias = "Mascotas" },
                new Models.Categorias{ IdCategorias = 6, NombreCategorias = "Higienicos" },
                };
        }
    }
}
