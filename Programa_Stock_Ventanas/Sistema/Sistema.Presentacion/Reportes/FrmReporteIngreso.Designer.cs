namespace Sistema.Presentacion.Reportes
{
    partial class FrmReporteIngreso
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
            this.ingresolistarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ingreso_listarTableAdapter = new Sistema.Presentacion.Reportes.DsSistemaTableAdapters.ingreso_listarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingresolistarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DtsIngreso";
            reportDataSource1.Value = this.ingresolistarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema.Presentacion.Reportes.RptIngresos.rdlc";
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
            // ingresolistarBindingSource
            // 
            this.ingresolistarBindingSource.DataMember = "ingreso_listar";
            this.ingresolistarBindingSource.DataSource = this.dsSistema;
            // 
            // ingreso_listarTableAdapter
            // 
            this.ingreso_listarTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteIngreso";
            this.Text = "FrmReporteIngreso";
            this.Load += new System.EventHandler(this.FrmReporteIngreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingresolistarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DsSistema dsSistema;
        private System.Windows.Forms.BindingSource ingresolistarBindingSource;
        private DsSistemaTableAdapters.ingreso_listarTableAdapter ingreso_listarTableAdapter;
    }
}