using ClosedXML.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
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

namespace Sistema.Presentacion
{
    public partial class FrmIngreso : Form
    {
        private DataTable DtDetalle = new DataTable();

        public FrmIngreso()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                DgvListado.DataSource = IngresoSN.Listar();
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
                DgvListado.DataSource = IngresoSN.Buscar(TxtBuscar.Text);
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
            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[1].Visible = false;
            DgvListado.Columns[2].Visible = false;
            DgvListado.Columns[0].Width = 100;
            DgvListado.Columns[3].Width = 150;
            DgvListado.Columns[4].Width = 150;
            DgvListado.Columns[5].Width = 100;
            DgvListado.Columns[5].HeaderText = "Documento";
            DgvListado.Columns[6].Width = 70;
            DgvListado.Columns[6].HeaderText = "Serie";
            DgvListado.Columns[7].Width = 70;
            DgvListado.Columns[7].HeaderText = "Número";
            DgvListado.Columns[8].Width = 100;
            DgvListado.Columns[9].Width = 100;
            DgvListado.Columns[10].Width = 100;
            DgvListado.Columns[11].Width = 100;
        }
        private void Limpiar()
        {
            TxtBuscar.Clear();
            TxtId.Clear();
            TxtCodigo.Clear();
            TxtIdProveedor.Clear();
            TxtnNombreProveedor.Clear();
            TxtSerieComprobante.Clear();
            TxtNumComprobante.Clear();
            DtDetalle.Clear();
            TxtSubTotal.Text = "0.00";
            TxtTotalImpuesto.Text = "0.00";
            TxtTotal.Text = "0.00";

            //BtnInsertar.Visible = true;            
            //ErrorIcono.Clear();


            DgvListado.Columns[0].Visible = false;
            BtnAnular.Visible = false;
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
        private void CrearTabla()
        {
            this.DtDetalle.Columns.Add("idarticulo", System.Type.GetType("System.Int32"));
            this.DtDetalle.Columns.Add("codigo", System.Type.GetType("System.String"));
            this.DtDetalle.Columns.Add("articulo", System.Type.GetType("System.String"));
            //this.DtDetalle.Columns.Add("marca", System.Type.GetType("System.String"));
            this.DtDetalle.Columns.Add("cantidad", System.Type.GetType("System.Int32"));
            this.DtDetalle.Columns.Add("precio", System.Type.GetType("System.Decimal"));
            this.DtDetalle.Columns.Add("importe", System.Type.GetType("System.Decimal"));

            DgvDetalle.DataSource = this.DtDetalle;

            DgvDetalle.Columns[0].Visible = false;
            DgvDetalle.Columns[1].HeaderText = "CODIGO";
            DgvDetalle.Columns[1].Width = 100;
            DgvDetalle.Columns[2].HeaderText = "ARTICULO";
            DgvDetalle.Columns[2].Width = 150;
            // DgvDetalle.Columns[3].HeaderText = "MARCA"; // NUEVO
            //DgvDetalle.Columns[3].Width = 150;
            DgvDetalle.Columns[3].HeaderText = "CANTIDAD";
            DgvDetalle.Columns[3].Width = 70;
            DgvDetalle.Columns[4].HeaderText = "PRECIO";
            DgvDetalle.Columns[4].Width = 70;
            DgvDetalle.Columns[5].HeaderText = "IMPORTE";
            DgvDetalle.Columns[5].Width = 80;

            DgvDetalle.Columns[1].ReadOnly = true;
            DgvDetalle.Columns[2].ReadOnly = true;
            DgvDetalle.Columns[5].ReadOnly = true;


        }


        private void FormatoArticulos()
        {
            DgvArticulos.Columns[1].Visible = false;
            DgvArticulos.Columns[2].Width = 100;
            DgvArticulos.Columns[2].HeaderText = "Categoría";
            DgvArticulos.Columns[3].Width = 100;
            DgvArticulos.Columns[3].HeaderText = "Código";
            DgvArticulos.Columns[4].Width = 150;
            DgvArticulos.Columns[5].Width = 150;
            DgvArticulos.Columns[6].Width = 100;
            DgvArticulos.Columns[6].HeaderText = "Precio Venta";
            DgvArticulos.Columns[7].Width = 60;
            DgvArticulos.Columns[8].Width = 200;
            DgvArticulos.Columns[8].HeaderText = "Descripción";
            DgvArticulos.Columns[9].Width = 100;

        }


        private void FrmIngreso_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.CrearTabla();
            this.CalcularTotalesGeneral();
        }
   
        private void ExportarDatosAExcel(DataTable dataTable)
        {
            using (XLWorkbook workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Ingreso");

                // Agregar los encabezados en negrita
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    worksheet.Cell(1, i + 1).Value = dataTable.Columns[i].ColumnName;
                    worksheet.Cell(1, i + 1).Style.Font.Bold = true;
                }

                // Agregar los datos
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        worksheet.Cell(i + 2, j + 1).Value = dataTable.Rows[i][j].ToString();
                    }
                }

                // Configurar y mostrar el cuadro de diálogo para guardar el archivo
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    Title = "Guardar como Excel",
                    FileName = "Ingreso.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Datos exportados correctamente", "Exportación a Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
            this.CalcularTotalesGeneral();
        }

        private void BtnBuscarProveedor_Click(object sender, EventArgs e)
        {
            FrmVista_ProveedorIngreso vista = new FrmVista_ProveedorIngreso();
            vista.ShowDialog();
            TxtIdProveedor.Text = Convert.ToString(Variables.IdProveedor);
            TxtnNombreProveedor.Text = Convert.ToString(Variables.NombreProveedor);
        }

        private void TxtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    DataTable Tabla = new DataTable();
                    Tabla = ArticuloSN.BuscarCodigo(TxtCodigo.Text.Trim());
                    if (Tabla.Rows.Count <= 0)
                    {
                        this.MensajeError("No existe articulo con ese código de barras.");
                    }
                    else
                    {
                        this.AgregarDetalle(Convert.ToInt32(Tabla.Rows[0][0]), Convert.ToString(Tabla.Rows[0][1]), Convert.ToString(Tabla.Rows[0][2]), Convert.ToDecimal(Tabla.Rows[0][3]));

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AgregarDetalle(int IdArticulo, string Codigo, string Nombre, decimal Precio)
        {

            try
            {
                bool Agregar = true;
                foreach (DataRow FilaTemp in DtDetalle.Rows)
                {
                    if (FilaTemp.RowState != DataRowState.Deleted)
                    {
                        if (Convert.ToInt32(FilaTemp["idarticulo"]) == IdArticulo)
                        {
                            Agregar = false;
                            this.MensajeError("El artículo ya ha sido agregado.");
                        }
                    }
                }
                if (Agregar)
                {
                    DataRow Fila = DtDetalle.NewRow();
                    Fila["idarticulo"] = IdArticulo;
                    Fila["codigo"] = Codigo;
                    Fila["articulo"] = Nombre;
                    Fila["cantidad"] = 1;
                    Fila["precio"] = Precio;
                    Fila["importe"] = Precio;
                    this.DtDetalle.Rows.Add(Fila);
                    this.DtDetalle.AcceptChanges();
                    this.CalcularTotales();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                throw;
            }


        }

        private void CalcularTotales()
        {
            decimal Total = 0;
            decimal Subtotal = 0;
            if (DgvDetalle.Rows.Count == 0)
            {
                Total = 0;
            }
            else
            {
                foreach (DataRow FilaTemp in DtDetalle.Rows)
                {
                    try
                    {
                        if (FilaTemp.RowState != DataRowState.Deleted)
                            Total = Total + Convert.ToDecimal(FilaTemp["importe"]);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }
            }

            Subtotal = Total / (1 + Convert.ToDecimal(TxtImpuesto.Text));
            TxtTotal.Text = Total.ToString("#0.00#");
            TxtSubTotal.Text = Subtotal.ToString("#0.00#");
            TxtTotalImpuesto.Text = (Total - Subtotal).ToString("#0.00#");
        }
        private void CalcularTotalesGeneral()
        {
            decimal Total = 0;

            // Recorrer cada fila del DgvListado
            foreach (DataGridViewRow fila in DgvListado.Rows)
            {
                // Verificar si el valor de la columna TOTAL no es nulo ni DBNull
                if (fila.Cells["Total"].Value != null && fila.Cells["Total"].Value != DBNull.Value)
                {
                    // Sumar el valor de la columna TOTAL a la variable Total
                    Total += Convert.ToDecimal(fila.Cells["Total"].Value);
                }
            }

            // Mostrar el total en el TextBox correspondiente
            TxtTotalGeneral.Text = Total.ToString("#0.00#");
        }
        private void BtnVerArticulo_Click(object sender, EventArgs e)
        {
            PanelArticulos.Visible = true;
        }

        private void BtnCerrarArticulos_Click(object sender, EventArgs e)
        {
            PanelArticulos.Visible = false;
        }

        private void BtnFiltrarArticulos_Click(object sender, EventArgs e)
        {
            try
            {
                DgvArticulos.DataSource = ArticuloSN.BuscarVenta(TxtBuscarArticulo.Text.Trim());
                this.FormatoArticulos();
                LblTotalArticulos.Text = "Total Registros: " + Convert.ToString(DgvArticulos.Rows.Count);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DgvArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int IdArticulo;
            string Codigo, Nombre;
            decimal Precio;
            IdArticulo = Convert.ToInt32(DgvArticulos.CurrentRow.Cells["ID"].Value);
            Codigo = Convert.ToString(DgvArticulos.CurrentRow.Cells["Codigo"].Value);
            Nombre = Convert.ToString(DgvArticulos.CurrentRow.Cells["Nombre"].Value);
            Precio = Convert.ToDecimal(DgvArticulos.CurrentRow.Cells["Precio_Venta"].Value);
            this.AgregarDetalle(IdArticulo, Codigo, Nombre, Precio);

        }

        private void DgvDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataRow Fila = (DataRow)DtDetalle.Rows[e.RowIndex];
            decimal Precio = Convert.ToDecimal(Fila["precio"]);
            int Cantidad = Convert.ToInt32(Fila["cantidad"]);
            Fila["importe"] = Precio * Cantidad;
            this.CalcularTotales();
        }


        private void DgvDetalle_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.CalcularTotales();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (TxtIdProveedor.Text == string.Empty || TxtImpuesto.Text == string.Empty || TxtNumComprobante.Text == string.Empty || DtDetalle.Rows.Count == 0)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    ErrorIcono.SetError(TxtIdProveedor, "Seleccione un proveedor.");
                    ErrorIcono.SetError(TxtImpuesto, "Ingrese un impuesto.");
                    ErrorIcono.SetError(TxtNumComprobante, "Ingrese el número del comprobante.");
                    ErrorIcono.SetError(DgvDetalle, "Debe tener al menos un detalle.");
                }
                else
                {
                    DialogResult result = MessageBox.Show("¿Está seguro de ingresar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        Rpta = IngresoSN.Insertar(Convert.ToInt32(TxtIdProveedor.Text), Variables.IdUsuario, CboComprobante.Text, TxtSerieComprobante.Text.Trim(), TxtNumComprobante.Text.Trim(), Convert.ToDecimal(TxtImpuesto.Text), Convert.ToDecimal(TxtTotal.Text), DtDetalle);
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se insertó de forma correcta el registro.");
                            this.Limpiar();
                            this.Listar();
                        }
                        else
                        {
                            this.MensajeError(Rpta);
                        }
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
                //CALCULO PARA OBTENER Y MOSTRAR EL SUB, TI y T 
                DgvMostrarDetalle.DataSource = IngresoSN.ListarDetalle(Convert.ToInt32(DgvListado.CurrentRow.Cells["ID"].Value));
                decimal Total, SubTotal;
                decimal Impuesto = Convert.ToDecimal(DgvListado.CurrentRow.Cells["Impuesto"].Value);
                Total = Convert.ToDecimal(DgvListado.CurrentRow.Cells["Total"].Value);
                SubTotal = Total / (1 + Impuesto);
                TxtSubTotalD.Text = SubTotal.ToString("#0.00#");
                TxtTotalImpuestoD.Text = (Total - SubTotal).ToString("#0.00#");
                TxtTotalD.Text = Total.ToString("#0.00#");
                PanelMostrar.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnVerArticulo_Click_1(object sender, EventArgs e)
        {
            PanelArticulos.Visible = true;
        }

        private void BtnCerrarDetalle_Click(object sender, EventArgs e)
        {
            PanelMostrar.Visible = false;
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
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);

            }
        }

        private void ChkSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkSeleccionar.Checked)
            {
                DgvListado.Columns[0].Visible = true;
                BtnAnular.Visible = true;

            }
            else
            {
                DgvListado.Columns[0].Visible = false;
                BtnAnular.Visible = false;

            }
        }

        private void BtnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente deseas anular el(los) registro(s)?", "Sistema V2024", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = IngresoSN.Anular(Codigo);

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se anuló el registro: " + Convert.ToString(row.Cells[6].Value) + "-" + Convert.ToString(row.Cells[7].Value));

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

        private void BtnExportarExcelD_Click(object sender, EventArgs e)
        {
            // Crear un nuevo libro de Excel
            using (var workbook = new XLWorkbook())
            {
                // Agregar una hoja de cálculo
                var worksheet = workbook.Worksheets.Add("Datos");

                // Obtener la primera fila (encabezado de la tabla)
                var headerRow = worksheet.Row(1);

                // Agregar los nombres de las columnas
                headerRow.Cell(1).Value = "ID";
                headerRow.Cell(2).Value = "CODIGO";
                headerRow.Cell(3).Value = "ARTICULO";
                headerRow.Cell(4).Value = "CANTIDAD";
                headerRow.Cell(5).Value = "PRECIO";
                headerRow.Cell(6).Value = "IMPORTE";

                // Establecer estilo para el encabezado (opcional)
                headerRow.Style.Font.Bold = true;

                // Llenar la hoja de cálculo con datos de un DataGridView
                for (int i = 0; i < DgvMostrarDetalle.Rows.Count; i++)
                {
                    for (int j = 0; j < DgvMostrarDetalle.Columns.Count; j++)
                    {
                        worksheet.Cell(i + 2, j + 1).Value = DgvMostrarDetalle.Rows[i].Cells[j].Value.ToString();
                    }
                }

                // Guardar el archivo Excel
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Guardar como Excel";
                saveFileDialog.FileName = "Exportacion.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Datos exportados correctamente", "Exportación a Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnExportarExcel_Click(object sender, EventArgs e)
        {

            try
            {
                if (DgvListado.DataSource == null || DgvListado.Rows.Count == 0)
                {
                    MensajeError("No hay datos para exportar.");
                    return;
                }

                DataTable dataTable = ((DataTable)DgvListado.DataSource).Copy();

                if (dataTable.Columns.Contains("ID"))
                    dataTable.Columns.Remove("ID");

                if (dataTable.Columns.Contains("idusuario"))
                    dataTable.Columns.Remove("idusuario");

                ExportarDatosAExcel(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            Reportes.FrmReporteIngreso Reporte = new Reportes.FrmReporteIngreso();
            Reporte.ShowDialog();
        }

        private void BtnReportDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que haya una fila seleccionada en el DataGridView
                if (DgvListado.CurrentRow != null)
                {
                    Variables.IdIngreso = Convert.ToInt32(DgvListado.CurrentRow.Cells["ID"].Value);
                    Reportes.FrmReporteIngresoDetalle reporte = new Reportes.FrmReporteIngresoDetalle();
                    reporte.ShowDialog();
                }
                else
                {
                    // Mostrar un mensaje de error si no hay una fila seleccionada
                    MensajeError("No hay ninguna fila seleccionada. Por favor, seleccione una fila.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
