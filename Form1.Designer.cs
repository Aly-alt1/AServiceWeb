namespace examenForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.gbProductos = new System.Windows.Forms.GroupBox();
            this.lstPrevisualizar = new System.Windows.Forms.ListBox();
            this.btnVerPDF = new System.Windows.Forms.Button();
            this.btnSeleccionarImg = new System.Windows.Forms.Button();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.btnGuardarImg = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPrecio = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnPrimerAgregado = new System.Windows.Forms.Button();
            this.btnUltimoAgregado = new System.Windows.Forms.Button();
            this.listPrecio = new System.Windows.Forms.ListBox();
            this.txtCodigoBarra = new System.Windows.Forms.TextBox();
            this.gbCaducidad = new System.Windows.Forms.GroupBox();
            this.chbNoCaducado = new System.Windows.Forms.CheckBox();
            this.chbCaducado = new System.Windows.Forms.CheckBox();
            this.gbMedida = new System.Windows.Forms.GroupBox();
            this.rbLitro = new System.Windows.Forms.RadioButton();
            this.rbKilo = new System.Windows.Forms.RadioButton();
            this.rbGramo = new System.Windows.Forms.RadioButton();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtProductNombre = new System.Windows.Forms.TextBox();
            this.listDatos = new System.Windows.Forms.ListBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnConsumir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblOrdenar = new System.Windows.Forms.Label();
            this.lblCaducidad = new System.Windows.Forms.Label();
            this.lblCodigoBarra = new System.Windows.Forms.Label();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblProductoNombre = new System.Windows.Forms.Label();
            this.cmbCategorias = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.gbProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbCaducidad.SuspendLayout();
            this.gbMedida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // gbProductos
            // 
            this.gbProductos.Controls.Add(this.webView21);
            this.gbProductos.Controls.Add(this.lstPrevisualizar);
            this.gbProductos.Controls.Add(this.btnVerPDF);
            this.gbProductos.Controls.Add(this.btnSeleccionarImg);
            this.gbProductos.Controls.Add(this.picImagen);
            this.gbProductos.Controls.Add(this.btnGuardarImg);
            this.gbProductos.Controls.Add(this.btnImprimir);
            this.gbProductos.Controls.Add(this.dataGridView1);
            this.gbProductos.Controls.Add(this.btnPrecio);
            this.gbProductos.Controls.Add(this.btnBuscar);
            this.gbProductos.Controls.Add(this.btnPrimerAgregado);
            this.gbProductos.Controls.Add(this.btnUltimoAgregado);
            this.gbProductos.Controls.Add(this.listPrecio);
            this.gbProductos.Controls.Add(this.txtCodigoBarra);
            this.gbProductos.Controls.Add(this.gbCaducidad);
            this.gbProductos.Controls.Add(this.gbMedida);
            this.gbProductos.Controls.Add(this.txtPrecio);
            this.gbProductos.Controls.Add(this.txtDescripcion);
            this.gbProductos.Controls.Add(this.txtProductNombre);
            this.gbProductos.Controls.Add(this.listDatos);
            this.gbProductos.Controls.Add(this.txtBuscar);
            this.gbProductos.Controls.Add(this.btnConsumir);
            this.gbProductos.Controls.Add(this.btnAgregar);
            this.gbProductos.Controls.Add(this.lblOrdenar);
            this.gbProductos.Controls.Add(this.lblCaducidad);
            this.gbProductos.Controls.Add(this.lblCodigoBarra);
            this.gbProductos.Controls.Add(this.lblUnidad);
            this.gbProductos.Controls.Add(this.lblPrecio);
            this.gbProductos.Controls.Add(this.lblDescripcion);
            this.gbProductos.Controls.Add(this.lblProductoNombre);
            this.gbProductos.Controls.Add(this.cmbCategorias);
            this.gbProductos.Controls.Add(this.lblCategoria);
            this.gbProductos.Location = new System.Drawing.Point(49, 12);
            this.gbProductos.Name = "gbProductos";
            this.gbProductos.Size = new System.Drawing.Size(1490, 579);
            this.gbProductos.TabIndex = 1;
            this.gbProductos.TabStop = false;
            this.gbProductos.Text = "productos";
            // 
            // lstPrevisualizar
            // 
            this.lstPrevisualizar.FormattingEnabled = true;
            this.lstPrevisualizar.ItemHeight = 16;
            this.lstPrevisualizar.Location = new System.Drawing.Point(988, 61);
            this.lstPrevisualizar.Name = "lstPrevisualizar";
            this.lstPrevisualizar.Size = new System.Drawing.Size(157, 292);
            this.lstPrevisualizar.TabIndex = 33;
            // 
            // btnVerPDF
            // 
            this.btnVerPDF.Location = new System.Drawing.Point(969, 370);
            this.btnVerPDF.Name = "btnVerPDF";
            this.btnVerPDF.Size = new System.Drawing.Size(176, 33);
            this.btnVerPDF.TabIndex = 32;
            this.btnVerPDF.Text = "Previsualizar PDF";
            this.btnVerPDF.UseVisualStyleBackColor = true;
            this.btnVerPDF.Click += new System.EventHandler(this.btnVerPDF_Click);
            // 
            // btnSeleccionarImg
            // 
            this.btnSeleccionarImg.Location = new System.Drawing.Point(785, 381);
            this.btnSeleccionarImg.Name = "btnSeleccionarImg";
            this.btnSeleccionarImg.Size = new System.Drawing.Size(176, 32);
            this.btnSeleccionarImg.TabIndex = 30;
            this.btnSeleccionarImg.Text = "Seleccionar Imagen";
            this.btnSeleccionarImg.UseVisualStyleBackColor = true;
            this.btnSeleccionarImg.Click += new System.EventHandler(this.btnSeleccionarImg_Click);
            // 
            // picImagen
            // 
            this.picImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImagen.Image = global::examenForms.Properties.Resources.higiene;
            this.picImagen.Location = new System.Drawing.Point(542, 370);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(210, 153);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagen.TabIndex = 29;
            this.picImagen.TabStop = false;
            // 
            // btnGuardarImg
            // 
            this.btnGuardarImg.Location = new System.Drawing.Point(785, 429);
            this.btnGuardarImg.Name = "btnGuardarImg";
            this.btnGuardarImg.Size = new System.Drawing.Size(176, 34);
            this.btnGuardarImg.TabIndex = 28;
            this.btnGuardarImg.Text = "Guardar Imagen";
            this.btnGuardarImg.UseVisualStyleBackColor = true;
            this.btnGuardarImg.Click += new System.EventHandler(this.btnGuardarImg_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(386, 362);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 27;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(538, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(423, 150);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnPrecio
            // 
            this.btnPrecio.Location = new System.Drawing.Point(128, 362);
            this.btnPrecio.Name = "btnPrecio";
            this.btnPrecio.Size = new System.Drawing.Size(75, 23);
            this.btnPrecio.TabIndex = 25;
            this.btnPrecio.Text = "Precio";
            this.btnPrecio.UseVisualStyleBackColor = true;
            this.btnPrecio.Click += new System.EventHandler(this.btnPrecio_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(775, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnPrimerAgregado
            // 
            this.btnPrimerAgregado.Location = new System.Drawing.Point(305, 362);
            this.btnPrimerAgregado.Name = "btnPrimerAgregado";
            this.btnPrimerAgregado.Size = new System.Drawing.Size(75, 23);
            this.btnPrimerAgregado.TabIndex = 23;
            this.btnPrimerAgregado.Text = "Primero";
            this.btnPrimerAgregado.UseVisualStyleBackColor = true;
            this.btnPrimerAgregado.Click += new System.EventHandler(this.btnPrimerAgregado_Click);
            // 
            // btnUltimoAgregado
            // 
            this.btnUltimoAgregado.Location = new System.Drawing.Point(224, 362);
            this.btnUltimoAgregado.Name = "btnUltimoAgregado";
            this.btnUltimoAgregado.Size = new System.Drawing.Size(75, 23);
            this.btnUltimoAgregado.TabIndex = 22;
            this.btnUltimoAgregado.Text = "Ultimo";
            this.btnUltimoAgregado.UseVisualStyleBackColor = true;
            this.btnUltimoAgregado.Click += new System.EventHandler(this.btnUltimoAgregado_Click);
            // 
            // listPrecio
            // 
            this.listPrecio.FormattingEnabled = true;
            this.listPrecio.HorizontalScrollbar = true;
            this.listPrecio.ItemHeight = 16;
            this.listPrecio.Location = new System.Drawing.Point(30, 394);
            this.listPrecio.Name = "listPrecio";
            this.listPrecio.Size = new System.Drawing.Size(222, 100);
            this.listPrecio.TabIndex = 20;
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.Location = new System.Drawing.Point(154, 286);
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.Size = new System.Drawing.Size(226, 22);
            this.txtCodigoBarra.TabIndex = 19;
            // 
            // gbCaducidad
            // 
            this.gbCaducidad.Controls.Add(this.chbNoCaducado);
            this.gbCaducidad.Controls.Add(this.chbCaducado);
            this.gbCaducidad.Location = new System.Drawing.Point(170, 245);
            this.gbCaducidad.Name = "gbCaducidad";
            this.gbCaducidad.Size = new System.Drawing.Size(277, 34);
            this.gbCaducidad.TabIndex = 18;
            this.gbCaducidad.TabStop = false;
            this.gbCaducidad.Text = "_";
            // 
            // chbNoCaducado
            // 
            this.chbNoCaducado.AutoSize = true;
            this.chbNoCaducado.Location = new System.Drawing.Point(106, 12);
            this.chbNoCaducado.Name = "chbNoCaducado";
            this.chbNoCaducado.Size = new System.Drawing.Size(47, 20);
            this.chbNoCaducado.TabIndex = 1;
            this.chbNoCaducado.Text = "No";
            this.chbNoCaducado.UseVisualStyleBackColor = true;
            // 
            // chbCaducado
            // 
            this.chbCaducado.AutoSize = true;
            this.chbCaducado.Location = new System.Drawing.Point(22, 13);
            this.chbCaducado.Name = "chbCaducado";
            this.chbCaducado.Size = new System.Drawing.Size(41, 20);
            this.chbCaducado.TabIndex = 0;
            this.chbCaducado.Text = "Si";
            this.chbCaducado.UseVisualStyleBackColor = true;
            // 
            // gbMedida
            // 
            this.gbMedida.Controls.Add(this.rbLitro);
            this.gbMedida.Controls.Add(this.rbKilo);
            this.gbMedida.Controls.Add(this.rbGramo);
            this.gbMedida.Location = new System.Drawing.Point(154, 199);
            this.gbMedida.Name = "gbMedida";
            this.gbMedida.Size = new System.Drawing.Size(293, 35);
            this.gbMedida.TabIndex = 17;
            this.gbMedida.TabStop = false;
            this.gbMedida.Text = "_";
            // 
            // rbLitro
            // 
            this.rbLitro.AutoSize = true;
            this.rbLitro.Location = new System.Drawing.Point(195, 15);
            this.rbLitro.Name = "rbLitro";
            this.rbLitro.Size = new System.Drawing.Size(60, 20);
            this.rbLitro.TabIndex = 2;
            this.rbLitro.TabStop = true;
            this.rbLitro.Text = "Litros";
            this.rbLitro.UseVisualStyleBackColor = true;
            // 
            // rbKilo
            // 
            this.rbKilo.AutoSize = true;
            this.rbKilo.Location = new System.Drawing.Point(106, 15);
            this.rbKilo.Name = "rbKilo";
            this.rbKilo.Size = new System.Drawing.Size(50, 20);
            this.rbKilo.TabIndex = 1;
            this.rbKilo.TabStop = true;
            this.rbKilo.Text = "Kilo";
            this.rbKilo.UseVisualStyleBackColor = true;
            // 
            // rbGramo
            // 
            this.rbGramo.AutoSize = true;
            this.rbGramo.Location = new System.Drawing.Point(16, 14);
            this.rbGramo.Name = "rbGramo";
            this.rbGramo.Size = new System.Drawing.Size(69, 20);
            this.rbGramo.TabIndex = 0;
            this.rbGramo.TabStop = true;
            this.rbGramo.Text = "Gramo";
            this.rbGramo.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(154, 171);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(226, 22);
            this.txtPrecio.TabIndex = 16;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(128, 131);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(252, 22);
            this.txtDescripcion.TabIndex = 15;
            // 
            // txtProductNombre
            // 
            this.txtProductNombre.Location = new System.Drawing.Point(154, 88);
            this.txtProductNombre.Name = "txtProductNombre";
            this.txtProductNombre.Size = new System.Drawing.Size(226, 22);
            this.txtProductNombre.TabIndex = 14;
            // 
            // listDatos
            // 
            this.listDatos.FormattingEnabled = true;
            this.listDatos.HorizontalScrollbar = true;
            this.listDatos.ItemHeight = 16;
            this.listDatos.Location = new System.Drawing.Point(538, 50);
            this.listDatos.Name = "listDatos";
            this.listDatos.Size = new System.Drawing.Size(423, 148);
            this.listDatos.TabIndex = 13;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(538, 21);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(214, 22);
            this.txtBuscar.TabIndex = 11;
            // 
            // btnConsumir
            // 
            this.btnConsumir.Location = new System.Drawing.Point(128, 327);
            this.btnConsumir.Name = "btnConsumir";
            this.btnConsumir.Size = new System.Drawing.Size(105, 23);
            this.btnConsumir.TabIndex = 10;
            this.btnConsumir.Text = "Consumir";
            this.btnConsumir.UseVisualStyleBackColor = true;
            this.btnConsumir.Click += new System.EventHandler(this.btnConsumir_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(30, 327);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblOrdenar
            // 
            this.lblOrdenar.AutoSize = true;
            this.lblOrdenar.Location = new System.Drawing.Point(27, 362);
            this.lblOrdenar.Name = "lblOrdenar";
            this.lblOrdenar.Size = new System.Drawing.Size(82, 16);
            this.lblOrdenar.TabIndex = 8;
            this.lblOrdenar.Text = "Ordenar por:";
            // 
            // lblCaducidad
            // 
            this.lblCaducidad.AutoSize = true;
            this.lblCaducidad.Location = new System.Drawing.Point(27, 245);
            this.lblCaducidad.Name = "lblCaducidad";
            this.lblCaducidad.Size = new System.Drawing.Size(130, 16);
            this.lblCaducidad.TabIndex = 7;
            this.lblCaducidad.Text = "Producto Caducable";
            // 
            // lblCodigoBarra
            // 
            this.lblCodigoBarra.AutoSize = true;
            this.lblCodigoBarra.Location = new System.Drawing.Point(27, 283);
            this.lblCodigoBarra.Name = "lblCodigoBarra";
            this.lblCodigoBarra.Size = new System.Drawing.Size(105, 16);
            this.lblCodigoBarra.TabIndex = 6;
            this.lblCodigoBarra.Text = "Codigo de barra";
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Location = new System.Drawing.Point(27, 207);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(119, 16);
            this.lblUnidad.TabIndex = 5;
            this.lblUnidad.Text = "Unidad de medida";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(27, 171);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 16);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(27, 131);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(79, 16);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblProductoNombre
            // 
            this.lblProductoNombre.AutoSize = true;
            this.lblProductoNombre.Location = new System.Drawing.Point(24, 91);
            this.lblProductoNombre.Name = "lblProductoNombre";
            this.lblProductoNombre.Size = new System.Drawing.Size(113, 16);
            this.lblProductoNombre.TabIndex = 2;
            this.lblProductoNombre.Text = "Producto Nombre";
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.Location = new System.Drawing.Point(93, 38);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(217, 24);
            this.cmbCategorias.TabIndex = 1;
            this.cmbCategorias.SelectedIndexChanged += new System.EventHandler(this.cmbCategorias_SelectedIndexChanged);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(21, 41);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(66, 16);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Categoria";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(1151, 61);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(296, 402);
            this.webView21.TabIndex = 34;
            this.webView21.ZoomFactor = 1D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1571, 559);
            this.Controls.Add(this.gbProductos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbProductos.ResumeLayout(false);
            this.gbProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbCaducidad.ResumeLayout(false);
            this.gbCaducidad.PerformLayout();
            this.gbMedida.ResumeLayout(false);
            this.gbMedida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbProductos;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblCaducidad;
        private System.Windows.Forms.Label lblCodigoBarra;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblProductoNombre;
        private System.Windows.Forms.ComboBox cmbCategorias;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtProductNombre;
        private System.Windows.Forms.ListBox listDatos;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnConsumir;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblOrdenar;
        private System.Windows.Forms.ListBox listPrecio;
        private System.Windows.Forms.TextBox txtCodigoBarra;
        private System.Windows.Forms.GroupBox gbCaducidad;
        private System.Windows.Forms.CheckBox chbNoCaducado;
        private System.Windows.Forms.CheckBox chbCaducado;
        private System.Windows.Forms.GroupBox gbMedida;
        private System.Windows.Forms.RadioButton rbLitro;
        private System.Windows.Forms.RadioButton rbKilo;
        private System.Windows.Forms.RadioButton rbGramo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnPrimerAgregado;
        private System.Windows.Forms.Button btnUltimoAgregado;
        private System.Windows.Forms.Button btnPrecio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnGuardarImg;
        private System.Windows.Forms.PictureBox picImagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSeleccionarImg;
        private System.Windows.Forms.Button btnVerPDF;
        private System.Windows.Forms.ListBox lstPrevisualizar;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}

