namespace Sistema.Presentacion
{
    partial class FrmArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TxtMaterial = new System.Windows.Forms.TextBox();
            this.TxtAnchoXalto = new System.Windows.Forms.TextBox();
            this.TxtColor = new System.Windows.Forms.TextBox();
            this.TxtGrosor = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.TxtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PanelCodigo = new System.Windows.Forms.Panel();
            this.BtnGuardarCodigo = new System.Windows.Forms.Button();
            this.BtnGenerarCodigo = new System.Windows.Forms.Button();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PicImagen = new System.Windows.Forms.PictureBox();
            this.BtnCargarImagen = new System.Windows.Forms.Button();
            this.TxtImagen = new System.Windows.Forms.TextBox();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CboCategoria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TabGeneral = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnReporte = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnDesactivar = new System.Windows.Forms.Button();
            this.BtnActivar = new System.Windows.Forms.Button();
            this.ChkSeleccionar = new System.Windows.Forms.CheckBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ComboCategoriaAc = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtPrecioCategoria = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtBuscar2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicImagen)).BeginInit();
            this.TabGeneral.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(76, 563);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(124, 23);
            this.BtnActualizar.TabIndex = 8;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 533);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "(*) Indica que el dato es obligatorio";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(375, 562);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(124, 23);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Location = new System.Drawing.Point(206, 562);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(124, 23);
            this.BtnInsertar.TabIndex = 5;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(354, 17);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 20);
            this.TxtId.TabIndex = 4;
            this.TxtId.Visible = false;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(829, 319);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(285, 119);
            this.TxtDescripcion.TabIndex = 3;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(94, 88);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(377, 20);
            this.TxtNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(704, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TxtMaterial);
            this.tabPage2.Controls.Add(this.TxtAnchoXalto);
            this.tabPage2.Controls.Add(this.TxtColor);
            this.tabPage2.Controls.Add(this.TxtGrosor);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.TxtStock);
            this.tabPage2.Controls.Add(this.TxtPrecioVenta);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.PanelCodigo);
            this.tabPage2.Controls.Add(this.BtnGuardarCodigo);
            this.tabPage2.Controls.Add(this.BtnGenerarCodigo);
            this.tabPage2.Controls.Add(this.TxtCodigo);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.PicImagen);
            this.tabPage2.Controls.Add(this.BtnCargarImagen);
            this.tabPage2.Controls.Add(this.TxtImagen);
            this.tabPage2.Controls.Add(this.TxtMarca);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.CboCategoria);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.BtnActualizar);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.BtnCancelar);
            this.tabPage2.Controls.Add(this.BtnInsertar);
            this.tabPage2.Controls.Add(this.TxtId);
            this.tabPage2.Controls.Add(this.TxtDescripcion);
            this.tabPage2.Controls.Add(this.TxtNombre);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1174, 592);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TxtMaterial
            // 
            this.TxtMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMaterial.Location = new System.Drawing.Point(590, 130);
            this.TxtMaterial.Name = "TxtMaterial";
            this.TxtMaterial.Size = new System.Drawing.Size(121, 20);
            this.TxtMaterial.TabIndex = 37;
            // 
            // TxtAnchoXalto
            // 
            this.TxtAnchoXalto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAnchoXalto.Location = new System.Drawing.Point(613, 57);
            this.TxtAnchoXalto.Name = "TxtAnchoXalto";
            this.TxtAnchoXalto.Size = new System.Drawing.Size(98, 20);
            this.TxtAnchoXalto.TabIndex = 36;
            // 
            // TxtColor
            // 
            this.TxtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtColor.Location = new System.Drawing.Point(590, 96);
            this.TxtColor.Name = "TxtColor";
            this.TxtColor.Size = new System.Drawing.Size(121, 20);
            this.TxtColor.TabIndex = 35;
            // 
            // TxtGrosor
            // 
            this.TxtGrosor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGrosor.Location = new System.Drawing.Point(613, 17);
            this.TxtGrosor.Name = "TxtGrosor";
            this.TxtGrosor.Size = new System.Drawing.Size(98, 20);
            this.TxtGrosor.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(508, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Material (*)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(508, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Color (*)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(508, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "AnchoXAlto (*)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(508, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Grosor (*)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(131, 449);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "PESOS $/.";
            // 
            // TxtStock
            // 
            this.TxtStock.Location = new System.Drawing.Point(197, 485);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(354, 20);
            this.TxtStock.TabIndex = 28;
            // 
            // TxtPrecioVenta
            // 
            this.TxtPrecioVenta.Location = new System.Drawing.Point(197, 442);
            this.TxtPrecioVenta.Name = "TxtPrecioVenta";
            this.TxtPrecioVenta.Size = new System.Drawing.Size(354, 20);
            this.TxtPrecioVenta.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 488);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Stock (*)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 449);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Precio Venta (*)";
            // 
            // PanelCodigo
            // 
            this.PanelCodigo.Location = new System.Drawing.Point(182, 285);
            this.PanelCodigo.Name = "PanelCodigo";
            this.PanelCodigo.Size = new System.Drawing.Size(377, 120);
            this.PanelCodigo.TabIndex = 24;
            // 
            // BtnGuardarCodigo
            // 
            this.BtnGuardarCodigo.Enabled = false;
            this.BtnGuardarCodigo.Location = new System.Drawing.Point(434, 230);
            this.BtnGuardarCodigo.Name = "BtnGuardarCodigo";
            this.BtnGuardarCodigo.Size = new System.Drawing.Size(125, 23);
            this.BtnGuardarCodigo.TabIndex = 23;
            this.BtnGuardarCodigo.Text = "Guardar Codigo";
            this.BtnGuardarCodigo.UseVisualStyleBackColor = true;
            this.BtnGuardarCodigo.Click += new System.EventHandler(this.BtnGuardarCodigo_Click);
            // 
            // BtnGenerarCodigo
            // 
            this.BtnGenerarCodigo.Location = new System.Drawing.Point(182, 230);
            this.BtnGenerarCodigo.Name = "BtnGenerarCodigo";
            this.BtnGenerarCodigo.Size = new System.Drawing.Size(136, 23);
            this.BtnGenerarCodigo.TabIndex = 22;
            this.BtnGenerarCodigo.Text = "Generar Codigo";
            this.BtnGenerarCodigo.UseVisualStyleBackColor = true;
            this.BtnGenerarCodigo.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(182, 185);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(377, 20);
            this.TxtCodigo.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Codigo de barras";
            // 
            // PicImagen
            // 
            this.PicImagen.Location = new System.Drawing.Point(829, 85);
            this.PicImagen.Name = "PicImagen";
            this.PicImagen.Size = new System.Drawing.Size(285, 221);
            this.PicImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicImagen.TabIndex = 19;
            this.PicImagen.TabStop = false;
            // 
            // BtnCargarImagen
            // 
            this.BtnCargarImagen.Location = new System.Drawing.Point(1073, 23);
            this.BtnCargarImagen.Name = "BtnCargarImagen";
            this.BtnCargarImagen.Size = new System.Drawing.Size(69, 23);
            this.BtnCargarImagen.TabIndex = 18;
            this.BtnCargarImagen.Text = "...";
            this.BtnCargarImagen.UseVisualStyleBackColor = true;
            this.BtnCargarImagen.Click += new System.EventHandler(this.BtnCargarImagen_Click);
            // 
            // TxtImagen
            // 
            this.TxtImagen.Enabled = false;
            this.TxtImagen.Location = new System.Drawing.Point(857, 25);
            this.TxtImagen.Name = "TxtImagen";
            this.TxtImagen.Size = new System.Drawing.Size(195, 20);
            this.TxtImagen.TabIndex = 17;
            // 
            // TxtMarca
            // 
            this.TxtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMarca.Location = new System.Drawing.Point(94, 130);
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(377, 20);
            this.TxtMarca.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Marca (*)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(734, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Imagen";
            // 
            // CboCategoria
            // 
            this.CboCategoria.FormattingEnabled = true;
            this.CboCategoria.Location = new System.Drawing.Point(244, 51);
            this.CboCategoria.Name = "CboCategoria";
            this.CboCategoria.Size = new System.Drawing.Size(227, 21);
            this.CboCategoria.TabIndex = 13;
            this.CboCategoria.SelectedIndexChanged += new System.EventHandler(this.CboCategoria_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Categoria (*)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre (*)";
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // TabGeneral
            // 
            this.TabGeneral.Controls.Add(this.tabPage1);
            this.TabGeneral.Controls.Add(this.tabPage2);
            this.TabGeneral.Controls.Add(this.tabPage3);
            this.TabGeneral.Location = new System.Drawing.Point(0, 0);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(1182, 618);
            this.TabGeneral.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.BtnReporte);
            this.tabPage1.Controls.Add(this.BtnEliminar);
            this.tabPage1.Controls.Add(this.BtnDesactivar);
            this.tabPage1.Controls.Add(this.BtnActivar);
            this.tabPage1.Controls.Add(this.ChkSeleccionar);
            this.tabPage1.Controls.Add(this.BtnBuscar);
            this.tabPage1.Controls.Add(this.TxtBuscar);
            this.tabPage1.Controls.Add(this.LblTotal);
            this.tabPage1.Controls.Add(this.DgvListado);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1174, 592);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            // 
            // BtnReporte
            // 
            this.BtnReporte.Location = new System.Drawing.Point(879, 15);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(119, 23);
            this.BtnReporte.TabIndex = 8;
            this.BtnReporte.Text = "Reporte";
            this.BtnReporte.UseVisualStyleBackColor = true;
            this.BtnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(645, 361);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(98, 23);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnDesactivar
            // 
            this.BtnDesactivar.Location = new System.Drawing.Point(451, 361);
            this.BtnDesactivar.Name = "BtnDesactivar";
            this.BtnDesactivar.Size = new System.Drawing.Size(98, 23);
            this.BtnDesactivar.TabIndex = 6;
            this.BtnDesactivar.Text = "Desactivar";
            this.BtnDesactivar.UseVisualStyleBackColor = true;
            this.BtnDesactivar.Click += new System.EventHandler(this.BtnDesactivar_Click);
            // 
            // BtnActivar
            // 
            this.BtnActivar.Location = new System.Drawing.Point(260, 361);
            this.BtnActivar.Name = "BtnActivar";
            this.BtnActivar.Size = new System.Drawing.Size(98, 23);
            this.BtnActivar.TabIndex = 5;
            this.BtnActivar.Text = "Activar";
            this.BtnActivar.UseVisualStyleBackColor = true;
            this.BtnActivar.Click += new System.EventHandler(this.BtnActivar_Click);
            // 
            // ChkSeleccionar
            // 
            this.ChkSeleccionar.AutoSize = true;
            this.ChkSeleccionar.Location = new System.Drawing.Point(3, 365);
            this.ChkSeleccionar.Name = "ChkSeleccionar";
            this.ChkSeleccionar.Size = new System.Drawing.Size(82, 17);
            this.ChkSeleccionar.TabIndex = 4;
            this.ChkSeleccionar.Text = "Seleccionar";
            this.ChkSeleccionar.UseVisualStyleBackColor = true;
            this.ChkSeleccionar.CheckedChanged += new System.EventHandler(this.ChkSeleccionar_CheckedChanged);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(754, 15);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(119, 23);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(8, 18);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(740, 20);
            this.TxtBuscar.TabIndex = 2;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(943, 371);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(34, 13);
            this.LblTotal.TabIndex = 1;
            this.LblTotal.Text = "Total:";
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.AllowUserToOrderColumns = true;
            this.DgvListado.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.DgvListado.Location = new System.Drawing.Point(6, 53);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(1015, 284);
            this.DgvListado.TabIndex = 0;
            this.DgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellContentClick);
            this.DgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkBlue;
            this.tabPage3.Controls.Add(this.checkBox1);
            this.tabPage3.Controls.Add(this.ComboCategoriaAc);
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.TxtPrecioCategoria);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.TxtBuscar2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1174, 592);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Actualizar Precios";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(11, 388);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 17);
            this.checkBox1.TabIndex = 34;
            this.checkBox1.Text = "Seleccionar";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ComboCategoriaAc
            // 
            this.ComboCategoriaAc.FormattingEnabled = true;
            this.ComboCategoriaAc.Location = new System.Drawing.Point(173, 46);
            this.ComboCategoriaAc.Name = "ComboCategoriaAc";
            this.ComboCategoriaAc.Size = new System.Drawing.Size(227, 21);
            this.ComboCategoriaAc.TabIndex = 33;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(747, 45);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 32;
            this.button7.Text = "Disminuir";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(651, 45);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 31;
            this.button5.Text = "Aumentar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(154, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Modificar Precios por Categoria";
            // 
            // TxtPrecioCategoria
            // 
            this.TxtPrecioCategoria.Location = new System.Drawing.Point(403, 46);
            this.TxtPrecioCategoria.Name = "TxtPrecioCategoria";
            this.TxtPrecioCategoria.Size = new System.Drawing.Size(242, 20);
            this.TxtPrecioCategoria.TabIndex = 28;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(259, 382);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Actualizar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(403, 382);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(957, 382);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Total:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
            this.dataGridView1.Location = new System.Drawing.Point(11, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1015, 284);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Seleccionar";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(553, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Reporte";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(770, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtBuscar2
            // 
            this.TxtBuscar2.Location = new System.Drawing.Point(8, 13);
            this.TxtBuscar2.Name = "TxtBuscar2";
            this.TxtBuscar2.Size = new System.Drawing.Size(740, 20);
            this.TxtBuscar2.TabIndex = 9;
            // 
            // FrmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1185, 626);
            this.Controls.Add(this.TabGeneral);
            this.Name = "FrmArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.FrmArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicImagen)).EndInit();
            this.TabGeneral.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.TabControl TabGeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnDesactivar;
        private System.Windows.Forms.Button BtnActivar;
        private System.Windows.Forms.CheckBox ChkSeleccionar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox PicImagen;
        private System.Windows.Forms.Button BtnCargarImagen;
        private System.Windows.Forms.TextBox TxtImagen;
        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnGuardarCodigo;
        private System.Windows.Forms.Button BtnGenerarCodigo;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Panel PanelCodigo;
        private System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.TextBox TxtPrecioVenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnReporte;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtColor;
        private System.Windows.Forms.TextBox TxtGrosor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtMaterial;
        private System.Windows.Forms.TextBox TxtAnchoXalto;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TxtPrecioCategoria;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TxtBuscar2;
        private System.Windows.Forms.ComboBox ComboCategoriaAc;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}