using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Services;
using webExamen.Models;

namespace webExamen.Services
{
    /// <summary>
    /// Descripción breve de productos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class productos : System.Web.Services.WebService
    {
        private static List<Producto> products = new List<Producto>();

        [WebMethod]
        public List<Producto> GetProductos(Producto[] p)
        {
            try
            {
                if (p != null && p.Length > 0)
                {
                    products.AddRange(p);
                }
                return products;
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.Message);
            }
        }

        [WebMethod]
        public Producto[] GetProductosArray()
        {
            return products.ToArray();
        }


        [WebMethod]
        public byte[] GetPDF(List<Producto> listado)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                Document doc = new Document(PageSize.A4, 5, 5, 7, 7);
                PdfWriter pw = PdfWriter.GetInstance(doc, ms);

                doc.Open();

                //titulo y autor
                doc.AddTitle("Listado de productos");
                doc.AddAuthor("Yaral");

                //fuente
                iTextSharp.text.Font font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                //encabezado
                doc.Add(new Paragraph("Listado de productos", font));
                doc.Add(Chunk.NEWLINE);

                //encabezado de columna
                PdfPTable table = new PdfPTable(4);
                table.WidthPercentage = 100;

                //nombre de columna
                PdfPCell clNombre = new PdfPCell(new Phrase("Nombre", font));
                clNombre.BorderWidth = 0;
                clNombre.BorderWidthBottom = 0.75f;

                PdfPCell clDescripcion = new PdfPCell(new Phrase("Descripción", font));
                clDescripcion.BorderWidth = 0;
                clDescripcion.BorderWidthBottom = 0.75f;

                PdfPCell clPrecio = new PdfPCell(new Phrase("Precio", font));
                clPrecio.BorderWidth = 0;
                clPrecio.BorderWidthBottom = 0.75f;

                PdfPCell clMedida = new PdfPCell(new Phrase("Medida", font));
                clMedida.BorderWidth = 0;
                clMedida.BorderWidthBottom = 0.75f;



                //encabezadp
                table.AddCell(clNombre);
                table.AddCell(clDescripcion);
                table.AddCell(clPrecio);
                table.AddCell(clMedida);

                foreach (var producto in listado)
                {
                    // crear y agregar celdas con datos
                    PdfPCell cellNombre = new PdfPCell(new Phrase(producto.NombreProducto, font));
                    cellNombre.BorderWidth = 0;
                    table.AddCell(cellNombre);

                    PdfPCell cellDescripcion = new PdfPCell(new Phrase(producto.Descripcion, font));
                    cellDescripcion.BorderWidth = 0;
                    table.AddCell(cellDescripcion);

                    PdfPCell cellPrecio = new PdfPCell(new Phrase(producto.Precio.ToString("C2"), font));
                    cellPrecio.BorderWidth = 0;
                    table.AddCell(cellPrecio);


                    PdfPCell cellMedida = new PdfPCell(new Phrase(producto.Medida, font));
                    cellMedida.BorderWidth = 0;
                    table.AddCell(cellMedida);


                }
                doc.Add(table);
                doc.Close();
                pw.Close();

                return ms.ToArray();

            }
        }



        [WebMethod]

        public bool GetImagen(byte[] imageBytes, string fileName)
        {
            try
            {
                string path = Server.MapPath("~/Imagenes/");


                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);


                File.WriteAllBytes(Path.Combine(path, fileName), imageBytes);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //usuario
       

       
    }
}
