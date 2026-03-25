using examenForms.ServiceProductos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using PdfiumViewer;

namespace examenForms
{
    public partial class Form1 : Form
    {

        private ServiceCategorias.categoriasSoapClient clientCategorias = null;
        private string nombre_categoria = string.Empty;
        private ServiceProductos.productosSoapClient clientProductos = null;
        private List<ServiceProductos.Producto> listado;
        private byte[] imagenBytes = null; 
        private string nombreImagen = string.Empty;
        public Form1()
        {
            InitializeComponent();
            clientCategorias = new ServiceCategorias.categoriasSoapClient();
            llenarComboBoxCategorias();
            this.listado = new List<ServiceProductos.Producto>();
            InicializarDataGridView();
        }

        private void llenarComboBoxCategorias()
        {
            this.cmbCategorias.DataSource = clientCategorias.GetCategorias();
            this.cmbCategorias.DisplayMember = "NombreCategorias";
            this.cmbCategorias.ValueMember = "NombreCategorias";
        }

        private void cmbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbCategorias.SelectedItem != null)
            {
                this.nombre_categoria = this.cmbCategorias.SelectedValue.ToString();

                MostrarImagen(this.nombre_categoria);
            }
        }

        private void MostrarImagen(string categoria)
        {
            try
            {
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) +
                              "\\Downloads\\" + categoria + ".jpg";

                if (System.IO.File.Exists(ruta))
                {
                    picImagen.Image = System.Drawing.Image.FromFile(ruta);
                    picImagen.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    picImagen.Image = null;
                }
            }
            catch
            {
                picImagen.Image = null;
            }
        }

        private void Limpiar()
        {

            this.txtProductNombre.Text = "";
            this.txtDescripcion.Text = "";
            this.txtPrecio.Text = "";
            chbCaducado.Checked = false;
            chbNoCaducado.Checked = false;
            rbGramo.Checked = false;
            rbKilo.Checked = false;
            rbLitro.Checked = false;
            this.txtCodigoBarra.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ServiceProductos.Producto producto = new ServiceProductos.Producto();
            producto.NombreProducto = this.txtProductNombre.Text.Trim().ToLower();
            producto.Descripcion = this.txtDescripcion.Text.Trim().ToLower();
            producto.Precio = double.Parse(this.txtPrecio.Text.Trim().ToLower());
            producto.NombreCategorias = this.nombre_categoria;

            if (chbCaducado.Checked)
            {
                producto.Caducidad = "Si";
            }
            else if (chbNoCaducado.Checked)
            {
                producto.Caducidad = "No";
            }

            if (chbCaducado.Checked && chbNoCaducado.Checked)
            {
                MessageBox.Show("selecciona solo una");
                return;
            }

            if (!chbCaducado.Checked && !chbNoCaducado.Checked)
            {
                MessageBox.Show("selecciona almenos una");
                return;
            }



            if (rbGramo.Checked)
                producto.Medida = "Gramo";
            else if (rbKilo.Checked)
                producto.Medida = "Kilo";
            else if (rbLitro.Checked)
                producto.Medida = "Litros";
            else
            {
                MessageBox.Show("selecciona una");
                return;
            }
            

            this.listado.Add(producto);

            ActualizarDataGridView();
            Limpiar();
        }

        private void btnConsumir_Click(object sender, EventArgs e)
        {
            if (listado.Count == 0)
            {
                MessageBox.Show("No hay productos");
                return;
            }

            clientProductos = new ServiceProductos.productosSoapClient();
            try
            {
                var list = clientProductos.GetProductos(this.listado.ToArray());
                MessageBox.Show("Productos enviados al web");

                lstPrevisualizar.Items.Clear();

                int contador = 1;
                foreach (var producto in listado)
                {
                    lstPrevisualizar.Items.Add(contador + ". " + producto.NombreProducto);
                    contador++;
                }

                lstPrevisualizar.Items.Add("");
                lstPrevisualizar.Items.Add("se enviaron " + listado.Count + " productos");

            }
            catch 
            {
                MessageBox.Show("error");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscar = txtBuscar.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(buscar))
            {
                MessageBox.Show("ingresa algo");
                return;
            }


            bool encontrado = false;

            foreach (ServiceProductos.Producto producto in listado)
            {
                if (producto.NombreProducto.ToLower().Equals(buscar))
                {
                    listDatos.Items.Add("Nombre: " + producto.NombreProducto + " descripción:" + producto.Descripcion + " precio: " + producto.Precio + " categoria "+ producto.NombreCategorias);
                    encontrado = true;
                    MostrarImagen(producto.NombreCategorias);
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("no hay producto");
            }

            
        }



        private void btnUltimoAgregado_Click(object sender, EventArgs e)
        {

            if (listado.Count > 0)
            {
                var ultimoProducto = listado.Last();

                listPrecio.Items.Clear();
                listPrecio.Items.Add("Nombre:" + ultimoProducto.NombreProducto);
                listPrecio.Items.Add("Descripción: " + ultimoProducto.Descripcion);
                listPrecio.Items.Add("Precio:  " + ultimoProducto.Precio);
                MostrarImagen(ultimoProducto.NombreCategorias);

            }
            else
            {
                MessageBox.Show("no hay nada");
            }
           
        }

        private void btnPrecio_Click(object sender, EventArgs e)
        {
            if (listado.Count > 0)
            {
                var productoMasCaro = listado.OrderByDescending(p => p.Precio).First();
                var precioMasAlto = productoMasCaro.Precio;


                listPrecio.Items.Clear();
                listPrecio.Items.Add("Producto mas caro: " + productoMasCaro.NombreProducto);
                listPrecio.Items.Add("su precio es de " + precioMasAlto);
                MostrarImagen(productoMasCaro.NombreCategorias);

            }
            else
            {
                MessageBox.Show("no hay nada");
            }

          
        }

        private void btnPrimerAgregado_Click(object sender, EventArgs e)
        {
            if (listado.Count > 0)
            {
                var primerProducto = listado.First();
                listPrecio.Items.Clear();
                listPrecio.Items.Add("Nombre: " + primerProducto.NombreProducto);
                listPrecio.Items.Add("Descripción: " + primerProducto.Descripcion);
                listPrecio.Items.Add("Precio: " + primerProducto.Precio);

                MostrarImagen(primerProducto.NombreCategorias);

            }
            else
            {
                MessageBox.Show("no hay nada");
            }
            



        }

        private void btnImprimir_Click(object sender, EventArgs e)

        {
            if (listado.Count == 0)
            {
                MessageBox.Show("no hay nada");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.FileName = "ListadoProductos.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    clientProductos = new ServiceProductos.productosSoapClient();
                    ServiceProductos.Producto[] arrayProductos = listado.ToArray();
                    byte[] pdfBytes = clientProductos.GetPDF(arrayProductos);
                    File.WriteAllBytes(saveFileDialog.FileName, pdfBytes);
                    MessageBox.Show("ya esta el pdf");
                }
                catch 
                {
                    MessageBox.Show("error con el pdf ");
                }



            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InicializarDataGridView()
        {

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;


            dataGridView1.Columns.Add("NombreProducto", "Nombre");
            dataGridView1.Columns.Add("Descripcion", "Descripción");
            dataGridView1.Columns.Add("Precio", "Precio");
            dataGridView1.Columns.Add("Medida", "Medida");
            dataGridView1.Columns.Add("Caducidad", "Caducable");
            dataGridView1.Columns.Add("NombreCategoria", "Categoria");;

        }

        private void ActualizarDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (var producto in listado)
            {
               
                dataGridView1.Rows.Add(
                    producto.NombreProducto,
                    producto.Descripcion,
                    producto.Precio.ToString("C2"),
                    producto.Medida,
                    producto.Caducidad,
                    producto.NombreCategorias
                );
            }
        }

        private void btnGuardarImg_Click(object sender, EventArgs e)
        {
            if (imagenBytes == null)
            {
                MessageBox.Show("Primero selecciona una imagen");
                return;
            }



            clientProductos = new ServiceProductos.productosSoapClient();

            
            bool resultado = clientProductos.GetImagen(imagenBytes, nombreImagen);

            if (resultado)
            {
                MessageBox.Show("se guardo la imagen");
            }
        }

        private void btnSeleccionarImg_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imagenBytes = File.ReadAllBytes(openFileDialog1.FileName);
                nombreImagen = Path.GetFileName(openFileDialog1.FileName);

                using (MemoryStream ms = new MemoryStream(imagenBytes))
                {
                    picImagen.Image = System.Drawing.Image.FromStream(ms);
                }

            }
        }

        private async void btnVerPDF_Click(object sender, EventArgs e)
        {
            if (listado.Count == 0)
            {
                MessageBox.Show("no hay nada");
                return;
            }

            try
            {
                clientProductos = new ServiceProductos.productosSoapClient();
                byte[] pdfBytes = clientProductos.GetPDF(listado.ToArray());

                string tempFile = Path.GetTempPath() + "vistaprevia_" + DateTime.Now.Ticks + ".pdf";
                File.WriteAllBytes(tempFile, pdfBytes);

                await webView21.EnsureCoreWebView2Async(null);
                webView21.CoreWebView2.Navigate(tempFile);

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            /*
              lstPrevisualizar.Items.Clear();

              lstPrevisualizar.Items.Add("Listado de productos");
              lstPrevisualizar.Items.Add("---------------------");

              foreach (var producto in listado)
              {
                  lstPrevisualizar.Items.Add(producto.NombreProducto + " | " +producto.Descripcion +" | "+ producto.Precio + " | " + producto.Medida);
              }

              */
        }


       
    }
}
