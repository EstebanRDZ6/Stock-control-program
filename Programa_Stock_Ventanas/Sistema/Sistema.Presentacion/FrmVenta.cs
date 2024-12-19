using ClosedXML.Excel;
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
    public partial class FrmVenta : Form
    {
        private DataTable DtDetalle = new DataTable();
        public FrmVenta()
        {
            InitializeComponent();
            CalcularTotales();
        }
        private void Listar()
        {
            try
            {
                DgvListado.DataSource = VentaSN.Listar();
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
                DgvListado.DataSource = VentaSN.Buscar(TxtBuscar.Text);
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
            TxtIdCliente.Clear();
            TxtnNombreCliente.Clear();
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
            this.DtDetalle.Columns.Add("stock", System.Type.GetType("System.Int32"));
            this.DtDetalle.Columns.Add("cantidad", System.Type.GetType("System.Int32"));
            this.DtDetalle.Columns.Add("precio", System.Type.GetType("System.Decimal"));
            this.DtDetalle.Columns.Add("descuento", System.Type.GetType("System.Decimal"));
            this.DtDetalle.Columns.Add("importe", System.Type.GetType("System.Decimal"));

            DgvDetalle.DataSource = this.DtDetalle;

            DgvDetalle.Columns[0].Visible = false;
            DgvDetalle.Columns[1].HeaderText = "CODIGO";
            DgvDetalle.Columns[1].Width = 100;
            DgvDetalle.Columns[2].HeaderText = "ARTICULO";
            DgvDetalle.Columns[2].Width = 150;
            DgvDetalle.Columns[3].HeaderText = "STOCK";
            DgvDetalle.Columns[3].Width = 60;
            // DgvDetalle.Columns[3].HeaderText = "MARCA"; // NUEVO
            //DgvDetalle.Columns[3].Width = 150;
            DgvDetalle.Columns[4].HeaderText = "CANTIDAD";
            DgvDetalle.Columns[4].Width = 80;
            DgvDetalle.Columns[5].HeaderText = "PRECIO";
            DgvDetalle.Columns[5].Width = 70;
            DgvDetalle.Columns[6].HeaderText = "DESCUENTO";
            DgvDetalle.Columns[6].Width = 80;
            DgvDetalle.Columns[7].HeaderText = "IMPORTE";
            DgvDetalle.Columns[7].Width = 80;

            DgvDetalle.Columns[1].ReadOnly = true;
            DgvDetalle.Columns[2].ReadOnly = true;
            DgvDetalle.Columns[3].ReadOnly = true;
            DgvDetalle.Columns[7].ReadOnly = true;
            


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
        private void FrmVenta_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.CrearTabla();
            this.CalcularTotalesGeneral();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
            this.CalcularTotalesGeneral();
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            FrmVista_ClienteVenta vista = new FrmVista_ClienteVenta();
            vista.ShowDialog();
            TxtIdCliente.Text = Convert.ToString(Variables.IdCliente);
            TxtnNombreCliente.Text = Variables.NombreCliente;
        }

        private void TxtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    DataTable Tabla = new DataTable();
                    Tabla = ArticuloSN.BuscarCodigoVenta(TxtCodigo.Text.Trim());
                    if (Tabla.Rows.Count <= 0)
                    {
                        this.MensajeError("No existe articulo con ese código de barras o no hay stock de ese articulo.");
                    }
                    else
                    {
                        this.AgregarDetalle(Convert.ToInt32(Tabla.Rows[0][0]), Convert.ToString(Tabla.Rows[0][1]), Convert.ToString(Tabla.Rows[0][2]), Convert.ToInt32(Tabla.Rows[0][4]), Convert.ToDecimal(Tabla.Rows[0][3]));

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AgregarDetalle(int IdArticulo, string Codigo, string Nombre,int Stock, decimal Precio)
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
                    Fila["stock"] = Stock;
                    Fila["cantidad"] = 1;
                    Fila["precio"] = Precio;
                    Fila["descuento"] = 0;
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
            decimal tipoCambio = 3.83m; // Define la tasa de cambio de soles a dólares, aquí por ejemplo 3.83

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

            // Convertir el total a dólares y mostrar en el TextBox correspondiente
            decimal TotalDolar = ConvertirASolesADolares(Total, tipoCambio);
            TxtTotalGeneralDolar.Text = TotalDolar.ToString("#0.00#");
        }

        // Método para convertir de soles a dólares
        private decimal ConvertirASolesADolares(decimal montoEnSoles, decimal tipoCambio)
        {
            return montoEnSoles / tipoCambio;
        }

        private void ExportarDatosAExcel(DataTable dataTable)
        {
            using (XLWorkbook workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Ventas");

                // Agregar los encabezados con estilo de negrita
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    var cell = worksheet.Cell(1, i + 1);
                    cell.Value = dataTable.Columns[i].ColumnName;
                    cell.Style.Font.Bold = true; // Establecer negrita
                }

                // Agregar los datos
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        worksheet.Cell(i + 2, j + 1).Value = dataTable.Rows[i][j].ToString();
                    }
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    Title = "Guardar como Excel",
                    FileName = "Ventas.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Datos exportados correctamente", "Exportación a Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
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
            int Stock;
            IdArticulo = Convert.ToInt32(DgvArticulos.CurrentRow.Cells["ID"].Value);
            Codigo = Convert.ToString(DgvArticulos.CurrentRow.Cells["Codigo"].Value);
            Nombre = Convert.ToString(DgvArticulos.CurrentRow.Cells["Nombre"].Value);
            Stock = Convert.ToInt32(DgvArticulos.CurrentRow.Cells["Stock"].Value);
            Precio = Convert.ToDecimal(DgvArticulos.CurrentRow.Cells["Precio_Venta"].Value);
            this.AgregarDetalle(IdArticulo, Codigo, Nombre, Stock, Precio);
        }

        private void DgvDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataRow Fila = (DataRow)DtDetalle.Rows[e.RowIndex];
            string Articulo = Convert.ToString(Fila["articulo"]);
            int Cantidad = Convert.ToInt32(Fila["cantidad"]);
            int Stock = Convert.ToInt32(Fila["stock"]);
            decimal Precio = Convert.ToDecimal(Fila["precio"]);
            decimal Descuento = Convert.ToDecimal(Fila["descuento"]);

            if(Cantidad>Stock)
            {
                Cantidad = Stock;
                this.MensajeError("La cantidad de venta del producto " + Articulo + " supera el stock disponible " + Stock);
                Fila["Cantidad"] = Cantidad;
            }
            Fila["importe"] = (Precio * Cantidad) - Descuento;
            this.CalcularTotales();

            /* si la categoria fue selecionada, entonces se va aumentar el precio actual de todos los productos de una sola categoria  y
             lo que se ingrese en el nuevo boton aumentara o disminuira DataRow Fila = (DataRow)DtDetalle.Rows[e.RowIndex];
            ColumnaAum["precio"] = (Precio + Aumento)
            ColumnaDis["precio"] = (Precio - Aumento)*/
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (TxtIdCliente.Text == string.Empty || TxtImpuesto.Text == string.Empty || TxtNumComprobante.Text == string.Empty || DtDetalle.Rows.Count == 0)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    ErrorIcono.SetError(TxtIdCliente, "Seleccione un cliente.");
                    ErrorIcono.SetError(TxtImpuesto, "Ingrese un impuesto.");
                    ErrorIcono.SetError(TxtNumComprobante, "Ingrese el número del comprobante.");
                    ErrorIcono.SetError(DgvDetalle, "Debe tener al menos un detalle.");
                }
                else
                {
                    DialogResult result = MessageBox.Show("¿Está seguro de ingresar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        Rpta = VentaSN.Insertar(Convert.ToInt32(TxtIdCliente.Text), Variables.IdUsuario, CboComprobante.Text, TxtSerieComprobante.Text.Trim(), TxtNumComprobante.Text.Trim(), Convert.ToDecimal(TxtImpuesto.Text), Convert.ToDecimal(TxtTotal.Text), DtDetalle);
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            TabGeneral.SelectedIndex = 0;
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //CALCULO PARA OBTENER Y MOSTRAR EL SUB, TI y T 
                DgvMostrarDetalle.DataSource = VentaSN.ListarDetalle(Convert.ToInt32(DgvListado.CurrentRow.Cells["ID"].Value));
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
        private void DgvDetalle_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.CalcularTotales();
        }

        private void BtnCerrarDetalle_Click(object sender, EventArgs e)
        {
            PanelMostrar.Visible = false;
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
                            Rpta = VentaSN.Anular(Codigo);

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


        private void BtnComprobante_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que haya una fila seleccionada en el DataGridView
                if (DgvListado.CurrentRow != null)
                {
                    Variables.IdVenta = Convert.ToInt32(DgvListado.CurrentRow.Cells["ID"].Value);
                    Reportes.FrmReporteComprobanteVenta reporte = new Reportes.FrmReporteComprobanteVenta();
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
                headerRow.Cell(6).Value = "DESCUENTO";
                headerRow.Cell(7).Value = "IMPORTE";

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
    }
}
