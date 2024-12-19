using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion.Reportes
{
    public partial class FrmReporteIngreso : Form
    {
        public FrmReporteIngreso()
        {
            InitializeComponent();
        }

        private void FrmReporteIngreso_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsSistema.ingreso_listar' Puede moverla o quitarla según sea necesario.
            this.ingreso_listarTableAdapter.Fill(this.dsSistema.ingreso_listar);
      

            this.reportViewer1.RefreshReport();
        }
    }
}
