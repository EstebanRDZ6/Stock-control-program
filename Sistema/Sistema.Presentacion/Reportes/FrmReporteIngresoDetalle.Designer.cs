namespace Sistema.Presentacion.Reportes
{
    partial class FrmReporteIngresoDetalle
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsSistema = new Sistema.Presentacion.Reportes.DsSistema();
            this.ingresocomprobanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ingreso_comprobanteTableAdapter = new Sistema.Presentacion.Reportes.DsSistemaTableAdapters.ingreso_comprobanteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingresocomprobanteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsComprobanteIngreso";
            reportDataSource1.Value = this.ingresocomprobanteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema.Presentacion.Reportes.RptComprobanteIngreso.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsSistema
            // 
            this.dsSistema.DataSetName = "DsSistema";
            this.dsSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ingresocomprobanteBindingSource
            // 
            this.ingresocomprobanteBindingSource.DataMember = "ingreso_comprobante";
            this.ingresocomprobanteBindingSource.DataSource = this.dsSistema;
            // 
            // ingreso_comprobanteTableAdapter
            // 
            this.ingreso_comprobanteTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteIngresoDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteIngresoDetalle";
            this.Text = "FrmReporteIngresoDetalle";
            this.Load += new System.EventHandler(this.FrmReporteIngresoDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingresocomprobanteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ingresocomprobanteBindingSource;
        private DsSistema dsSistema;
        private DsSistemaTableAdapters.ingreso_comprobanteTableAdapter ingreso_comprobanteTableAdapter;
    }
}