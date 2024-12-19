using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Presentacion.Reportes.DsSistemaTableAdapters;

namespace Sistema.Presentacion.Reportes
{
    public partial class FrmReporteIngresoDetalle : Form
    {
        public FrmReporteIngresoDetalle()
        {
            InitializeComponent();
        }

        private void FrmReporteIngresoDetalle_Load(object sender, EventArgs e)
        {
            // Asegúrate de que dsSistema y Variables estén correctamente inicializados y accesibles
             // Método para obtener el idIngreso

            // TODO: esta línea de código carga datos en la tabla 'dsSistema.ingreso_listar_detalle' Puede moverla o quitarla según sea necesario.
            this.ingreso_comprobanteTableAdapter.Fill(this.dsSistema.ingreso_comprobante,Variables.IdIngreso);

            this.reportViewer1.RefreshReport();
        }

    
    }
}
