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
    public partial class FrmConsulta_VentaFechas : Form
    {
        public FrmConsulta_VentaFechas()
        {
            InitializeComponent();
            DtpFechaInicio.Value = DateTime.Today; // Establecer la fecha actual
            DtpFechaFin.Value = DateTime.Today;   // Establecer la fecha actual
            Buscar();
        }
        private void Buscar()
        {
            try
            {
                if (DtpFechaInicio.Value > DtpFechaFin.Value)
                {
                    MensajeError("La fecha de inicio no puede ser mayor a la fecha de fin.");
                    return;
                }

                DgvListado.DataSource = VentaSN.ConsultaFechas(Convert.ToDateTime(DtpFechaInicio.Value), Convert.ToDateTime(DtpFechaFin.Value));
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

            DgvListado.Columns[0].Visible = false;


        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "SISTEMA v2024", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "SISTEMA v2024", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExportarDatosAExcel(DataTable dataTable)
        {
            using (XLWorkbook workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Ventas");

                // Agregar los encabezados en negrita
                var headerRow = worksheet.Row(1);
                headerRow.Style.Font.Bold = true;

                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    worksheet.Cell(1, i + 1).Value = dataTable.Columns[i].ColumnName;
                }

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


        private void FrmConsulta_VentaFechas_Load(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
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

        private void BtnCerrarDetalle_Click(object sender, EventArgs e)
        {
            PanelMostrar.Visible = false;
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


