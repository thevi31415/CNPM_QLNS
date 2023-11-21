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
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtpSelectMonth = new System.Windows.Forms.DateTimePicker();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataSetQLNS = new CNPM_QLNS.DataSetQLNS();
            this.reportLuongNVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportLuongNVTableAdapter = new CNPM_QLNS.DataSetQLNSTableAdapters.ReportLuongNVTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLNS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportLuongNVBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            reportDataSource1.Name = "DataSetLuong";
            reportDataSource1.Value = this.reportLuongNVBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "CNPM_QLNS.Reports.ReportLuong.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 43);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(1467, 641);
            this.reportViewer.TabIndex = 0;
            // 
            // dtpSelectMonth
            // 
            this.dtpSelectMonth.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSelectMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSelectMonth.Location = new System.Drawing.Point(143, 7);
            this.dtpSelectMonth.Name = "dtpSelectMonth";
            this.dtpSelectMonth.Size = new System.Drawing.Size(200, 30);
            this.dtpSelectMonth.TabIndex = 85;
            this.dtpSelectMonth.CloseUp += new System.EventHandler(this.dtpSelectMonth_CloseUp);
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLoc.FlatAppearance.BorderSize = 0;
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.ForeColor = System.Drawing.Color.White;
            this.btnLoc.Image = global::CNPM_QLNS.Properties.Resources.filter_filled_tool_symbol;
            this.btnLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoc.Location = new System.Drawing.Point(360, 7);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(116, 30);
            this.btnLoc.TabIndex = 86;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.OrangeRed;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(491, 7);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(116, 30);
            this.btnBack.TabIndex = 87;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataSetQLNS
            // 
            this.dataSetQLNS.DataSetName = "DataSetQLNS";
            this.dataSetQLNS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportLuongNVBindingSource
            // 
            this.reportLuongNVBindingSource.DataMember = "ReportLuongNV";
            this.reportLuongNVBindingSource.DataSource = this.dataSetQLNS;
            // 
            // reportLuongNVTableAdapter
            // 
            this.reportLuongNVTableAdapter.ClearBeforeFill = true;
            // 
            // Admin_FormReportLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 684);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.dtpSelectMonth);
            this.Controls.Add(this.reportViewer);
            this.Name = "Admin_FormReportLuong";
            this.Text = "FormReportLuong";
            this.Load += new System.EventHandler(this.FormReportLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLNS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportLuongNVBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.DateTimePicker dtpSelectMonth;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnBack;
        private DataSetQLNS dataSetQLNS;
        private System.Windows.Forms.BindingSource reportLuongNVBindingSource;
        private DataSetQLNSTableAdapters.ReportLuongNVTableAdapter reportLuongNVTableAdapter;
    }
}