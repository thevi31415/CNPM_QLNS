namespace CNPM_QLNS.Admin
{
    partial class Admin_FormReportLuong
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
            this.reportLuongNVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetQLNS = new CNPM_QLNS.DB_Layer.DataSet.DataSetQLNS();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportLuongNVTableAdapter = new CNPM_QLNS.DB_Layer.DataSet.DataSetQLNSTableAdapters.ReportLuongNVTableAdapter();
            this.reportLuongNVBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportLuongNVBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.reportLuongNVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLNS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportLuongNVBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportLuongNVBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // reportLuongNVBindingSource
            // 
            this.reportLuongNVBindingSource.DataMember = "ReportLuongNV";
            this.reportLuongNVBindingSource.DataSource = this.dataSetQLNS;
            // 
            // dataSetQLNS
            // 
            this.dataSetQLNS.DataSetName = "DataSetQLNS";
            this.dataSetQLNS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetLuong";
            reportDataSource1.Value = this.reportLuongNVBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "CNPM_QLNS.Reports.ReportLuong.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(1364, 684);
            this.reportViewer.TabIndex = 0;
            // 
            // reportLuongNVTableAdapter
            // 
            this.reportLuongNVTableAdapter.ClearBeforeFill = true;
            // 
            // reportLuongNVBindingSource1
            // 
            this.reportLuongNVBindingSource1.DataMember = "ReportLuongNV";
            this.reportLuongNVBindingSource1.DataSource = this.dataSetQLNS;
            // 
            // reportLuongNVBindingSource2
            // 
            this.reportLuongNVBindingSource2.DataMember = "ReportLuongNV";
            this.reportLuongNVBindingSource2.DataSource = this.dataSetQLNS;
            // 
            // Admin_FormReportLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 684);
            this.Controls.Add(this.reportViewer);
            this.Name = "Admin_FormReportLuong";
            this.Text = "FormReportLuong";
            this.Load += new System.EventHandler(this.FormReportLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportLuongNVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLNS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportLuongNVBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportLuongNVBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private DB_Layer.DataSet.DataSetQLNS dataSetQLNS;
        private System.Windows.Forms.BindingSource reportLuongNVBindingSource;
        private DB_Layer.DataSet.DataSetQLNSTableAdapters.ReportLuongNVTableAdapter reportLuongNVTableAdapter;
        private System.Windows.Forms.BindingSource reportLuongNVBindingSource1;
        private System.Windows.Forms.BindingSource reportLuongNVBindingSource2;
    }
}