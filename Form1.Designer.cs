
namespace clinica_reportes
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CLINICADataSet = new clinica_reportes.CLINICADataSet();
            this.MedicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MedicosTableAdapter = new clinica_reportes.CLINICADataSetTableAdapters.MedicosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CLINICADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedicosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MedicosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "clinica_reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(714, 518);
            this.reportViewer1.TabIndex = 0;
            // 
            // CLINICADataSet
            // 
            this.CLINICADataSet.DataSetName = "CLINICADataSet";
            this.CLINICADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MedicosBindingSource
            // 
            this.MedicosBindingSource.DataMember = "Medicos";
            this.MedicosBindingSource.DataSource = this.CLINICADataSet;
            // 
            // MedicosTableAdapter
            // 
            this.MedicosTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 518);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CLINICADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedicosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MedicosBindingSource;
        private CLINICADataSet CLINICADataSet;
        private CLINICADataSetTableAdapters.MedicosTableAdapter MedicosTableAdapter;
    }
}

