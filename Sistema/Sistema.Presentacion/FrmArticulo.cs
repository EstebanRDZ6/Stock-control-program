using Sistema.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkiaSharp;
using BarcodeStandard;
using System.Drawing.Imaging;
using System.IO;





namespace Sistema.Presentacion
{
    public partial class FrmArticulo : Form
    {

        private string RutaOrigen; // Vamos almacenar la ruta de la  imagen de forma string!
        private string RutaDestino; //Directorio para cargar la imagen
        private string Directorio = "C:\\SistemaMaster\\";
        private string NombreAnt;
        

        public FrmArticulo()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                DgvListado.DataSource = ArticuloSN.Listar();
                this.Formato();
                this.Limpiar();
                LblTotal.Text = "Total registros: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Buscar()
        {
            try
            {
                DgvListado.DataSource = ArticuloSN.Buscar(TxtBuscar.Text);
                this.Formato();
                LblTotal.Text = "Total registros: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Formato()
        {
            DgvListado.Columns[0].Visible = false; //   id_registro
            DgvListado.Columns[2].Visible = false; // id_categoria
            DgvListado.Columns[0].Width = 50; // id_registro
            DgvListado.Columns[1].Width = 50; // idarticulo
            DgvListado.Columns[3].Width = 50; 
            DgvListado.Columns[3].HeaderText = "Categoría";
            DgvListado.Columns[4].Width = 50;
            DgvListado.Columns[4].HeaderText = "Serie";
            DgvListado.Columns[5].Width = 150;
            DgvListado.Columns[5].HeaderText = "Codigo";
            DgvListado.Columns[6].Width = 100; //nombre
            DgvListado.Columns[7].Width = 50; //marca
            DgvListado.Columns[8].Width = 50; // tipo
            DgvListado.Columns[9].Width = 50; //grosor
            DgvListado.Columns[10].Width = 50; //ancho
            DgvListado.Columns[11].Width = 50; //color
            DgvListado.Columns[12].Width = 50; //material
            DgvListado.Columns[13].Width = 50; //peso
            DgvListado.Columns[14].Width = 50; //precio_venta_menor
            DgvListado.Columns[14].HeaderText = "Precio_Menor";
            DgvListado.Columns[15].Width = 50; //precio_venta_mayor
            DgvListado.Columns[15].HeaderText = "Precio_Mayor";
            DgvListado.Columns[16].Width = 50; //pv
            DgvListado.Columns[16].HeaderText = "PV";
            DgvListado.Columns[17].Width = 50; //stock
            DgvListado.Columns[18].Width = 50; //descripcion
            DgvListado.Columns[18].HeaderText = "Descripción";
            DgvListado.Columns[19].Width = 50;
            DgvListado.Columns[20].Width = 50;
            
       


        }
        private void Limpiar()
        {
            TxtBuscar.Clear();
            TxtNombre.Clear();
            TxtMarca.Clear();
            TxtId.Clear();
            TxtCodigo.Clear();
            PanelCodigo.BackgroundImage = null;
            BtnGuardarCodigo.Enabled = true;
            TxtPrecioVenta.Clear();
            TxtStock.Clear();
            TxtImagen.Clear();
            PicImagen.Image = null;
            TxtDescripcion.Clear();
            BtnInsertar.Visible = true;
            BtnActualizar.Visible = false;
            ErrorIcono.Clear();
            this.RutaDestino = "";
            this.RutaOrigen = "";


            DgvListado.Columns[0].Visible = false;
            BtnActivar.Visible = false;
            BtnDesactivar.Visible = false;
            BtnEliminar.Visible = false;
            ChkSeleccionar.Checked = false;

        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "SISTEMA v2024", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "SISTEMA v2024", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void CargarCategoria()
        {
            try
            {
                CboCategoria.DataSource = CategoriaSN.Seleccionar();       
                CboCategoria.ValueMember = "idcategoria";
                CboCategoria.DisplayMember = "nombre";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FrmArticulo_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.CargarCategoria();

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void BtnCargarImagen_Click(object sender, EventArgs e)
        {

            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Imagen file (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if(file.ShowDialog() == DialogResult.OK)
            {
                PicImagen.Image = Image.FromFile(file.FileName);
                TxtImagen.Text = file.FileName.Substring(file.FileName.LastIndexOf("\\")+1); // Obtener todo el directorio, utilizando substring para obtener solo el nombre de la imagen pero despues de esto \\ le pongo mas 1 para que capture solo el nombre no el directorio
                this.RutaOrigen = file.FileName;
                
            }



        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {

            try
            {
                if (TxtCodigo.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar el Codigo de barras, sera remarcado.");
                    ErrorIcono.SetError(TxtCodigo, "Ingrese el Codigo.");
                }
                else
                {
                    BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
                    Codigo.IncludeLabel = true;
                    PanelCodigo.BackgroundImage = Codigo.Encode(BarcodeLib.TYPE.CODE128, TxtCodigo.Text, Color.Black, Color.White, 400, 100);
                    BtnGuardarCodigo.Enabled = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void BtnGuardarCodigo_Click(object sender, EventArgs e)
        {
            Image imgFinal = (Image)PanelCodigo.BackgroundImage.Clone();

            SaveFileDialog DialogoGuardar = new SaveFileDialog();
            DialogoGuardar.AddExtension = true;
            DialogoGuardar.Filter = "Image PNG (*.png) |*.png";
            DialogoGuardar.ShowDialog();
            if (!string.IsNullOrEmpty(DialogoGuardar.FileName))
            {
                imgFinal.Save(DialogoGuardar.FileName, ImageFormat.Png);
            }
            imgFinal.Dispose();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (CboCategoria.Text == string.Empty ||  TxtNombre.Text == string.Empty || TxtMarca.Text == string.Empty || TxtPrecioVenta.Text == string.Empty || TxtStock.Text == string.Empty)

                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    ErrorIcono.SetError(CboCategoria, "Seleccione una categoría.");
                    ErrorIcono.SetError(TxtNombre, "Ingrese un nombre.");
                    ErrorIcono.SetError(TxtMarca, "Ingrese la marca.");
                    ErrorIcono.SetError(TxtPrecioVenta, "Ingrese un precio.");
                    ErrorIcono.SetError(TxtStock, "Ingrese un stock inicial.");
                    ErrorIcono.SetError(TxtSerie, "Ingrese la serie del producto");
                    ErrorIcono.SetError(TxtTipo, "Ingrese el tipo");
                    ErrorIcono.SetError(TxtGrosor, "Ingrese el grosor");
                    ErrorIcono.SetError(TxtAncho, "Ingrese el ancho");
                    ErrorIcono.SetError(TxtColor, "Ingrese el Color del articulo");
                    ErrorIcono.SetError(TxtMaterial, "Ingrese el Material");
                    ErrorIcono.SetError(TxtPeso, "Ingrese el Peso");
                    ErrorIcono.SetError(TxtPrecioVentaRollo, "Ingrese el Precio por Rollo");
                    ErrorIcono.SetError(TxtPrecioVentaKilo, "Ingrese el Precio por Kilo");

                }
                else
                {
                    Rpta = ArticuloSN.Insertar(Convert.ToInt32(CboCategoria.SelectedValue),TxtSerie.Text.Trim(),TxtCodigo.Text.Trim(),TxtNombre.Text.Trim(),TxtMarca.Text.Trim(), TxtTipo.Text.Trim(),TxtGrosor.Text.Trim(),TxtAncho.Text.Trim(),TxtColor.Text.Trim(),TxtMaterial.Text.Trim(), Convert.ToDecimal(TxtPeso.Text), Convert.ToDecimal(TxtPrecioVentaKilo.Text), Convert.ToDecimal(TxtPrecioVentaRollo.Text), Convert.ToDecimal(TxtPrecioVenta.Text),Convert.ToInt32(TxtStock.Text),TxtDescripcion.Text.Trim(),TxtImagen.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se inserto de forma correcta el registro");
                        if (TxtImagen.Text != string.Empty)
                        {
                            this.RutaDestino = this.Directorio + TxtImagen.Text;
                            File.Copy(this.RutaOrigen,this.RutaDestino);

                        }                       
                        this.Listar();

                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                BtnActualizar.Visible = true;
                BtnInsertar.Visible = false;
                TxtId.Text = Convert.ToString(DgvListado.CurrentRow.Cells["ID"].Value);
                CboCategoria.SelectedValue = Convert.ToString(DgvListado.CurrentRow.Cells["idcategoria"].Value);
                TxtCodigo.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Codigo"].Value);
                this.NombreAnt = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                TxtNombre.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                TxtMarca.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Marca"].Value);
                TxtPrecioVenta.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Precio_Venta"].Value);
                TxtStock.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Stock"].Value);
                TxtDescripcion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Descripcion"].Value);
                string Imagen;
                Imagen = Convert.ToString(DgvListado.CurrentRow.Cells["Imagen"].Value);
                if(Imagen != string.Empty)
                {
                    PicImagen.Image = Image.FromFile(this.Directorio + Imagen);
                    TxtImagen.Text = Imagen;
                }
                else
                {
                    PicImagen.Image = null;
                    TxtImagen.Text = "";
                }
                TabGeneral.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione desde la celda nombre." + "| error: " + ex.Message);

            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (TxtId.Text == string.Empty || CboCategoria.Text == string.Empty || TxtNombre.Text == string.Empty || TxtMarca.Text == string.Empty || TxtPrecioVenta.Text == string.Empty || TxtStock.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    ErrorIcono.SetError(CboCategoria, "Seleccione una categoría.");
                    ErrorIcono.SetError(TxtNombre, "Ingrese un nombre.");
                    ErrorIcono.SetError(TxtMarca, "Ingrese la marca.");
                    ErrorIcono.SetError(TxtPrecioVenta, "Ingrese un precio.");
                    ErrorIcono.SetError(TxtStock, "Ingrese un stock inicial.");
                    ErrorIcono.SetError(TxtSerie, "Ingrese la serie del producto");
                    ErrorIcono.SetError(TxtTipo, "Ingrese el tipo");
                    ErrorIcono.SetError(TxtGrosor, "Ingrese el grosor");
                    ErrorIcono.SetError(TxtAncho, "Ingrese el ancho");
                    ErrorIcono.SetError(TxtColor, "Ingrese el Color del articulo");
                    ErrorIcono.SetError(TxtMaterial, "Ingrese el Material");
                    ErrorIcono.SetError(TxtPeso, "Ingrese el Peso");
                    ErrorIcono.SetError(TxtPrecioVentaRollo, "Ingrese el Precio por Rollo");
                    ErrorIcono.SetError(TxtPrecioVentaKilo, "Ingrese el Precio por Kilo");
                }
                else
                {
                    Rpta = ArticuloSN.Actualizar(Convert.ToInt32(TxtId.Text), Convert.ToInt32(CboCategoria.SelectedValue), TxtSerie.Text.Trim(), TxtCodigo.Text.Trim(), this.NombreAnt, TxtNombre.Text.Trim(), TxtMarca.Text.Trim(), TxtTipo.Text.Trim(), TxtGrosor.Text.Trim(), TxtAncho.Text.Trim(), TxtColor.Text.Trim(), TxtMaterial.Text.Trim(), Convert.ToDecimal(TxtPeso.Text), Convert.ToDecimal(TxtPrecioVentaKilo.Text), Convert.ToDecimal(TxtPrecioVentaRollo.Text), Convert.ToDecimal(TxtPrecioVenta.Text), Convert.ToInt32(TxtStock.Text), TxtDescripcion.Text.Trim(), TxtImagen.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se actualizó de forma correcta el registro");
                        if (TxtImagen.Text != string.Empty && this.RutaOrigen != string.Empty)
                        {
                            this.RutaDestino = this.Directorio + TxtImagen.Text;
                            File.Copy(this.RutaOrigen, this.RutaDestino);
                        }
                        this.Listar();
                        TabGeneral.SelectedIndex = 0;
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            TabGeneral.SelectedIndex = 0;
        }

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DgvListado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)DgvListado.Rows[e.RowIndex].Cells["Seleccionar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value); /*PUEDES ESTAR MARCADO O NO*/

            }
        }

        private void ChkSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkSeleccionar.Checked)
            {
                DgvListado.Columns[0].Visible = true;
                BtnActivar.Visible = true;
                BtnDesactivar.Visible = true;
                BtnEliminar.Visible = true;
            }
            else
            {
                DgvListado.Columns[0].Visible = false;
                BtnActivar.Visible = false;
                BtnDesactivar.Visible = false;
                BtnEliminar.Visible = false;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente deseas eliminar el(los) registro(s)?", "Sistema V2024", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";
                    string Imagen = "";

                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Imagen = Convert.ToString(row.Cells[10].Value);
                            Rpta = ArticuloSN.Eliminar(Codigo);

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se elimino el registro: " + Convert.ToString(row.Cells[5].Value));
                                File.Delete(this.Directorio + Imagen);

                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }


                        }
                    }
                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnDesactivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente deseas desactivar el(los) registro(s)?", "Sistema V2024", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = ArticuloSN.Desactivar(Codigo);

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se desactivó el registro: " + Convert.ToString(row.Cells[5].Value));

                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }


                        }
                    }
                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente deseas activar el(los) registro(s)?", "Sistema V2024", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = ArticuloSN.Activar(Codigo);

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se activó el registro: " + Convert.ToString(row.Cells[5].Value));

                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }


                        }
                    }
                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            Reportes.FrmReporteArticulos Reporte = new Reportes.FrmReporteArticulos();
            Reporte.ShowDialog();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
