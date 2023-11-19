using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_QLNS.Admin
{
    public partial class Admin_FormReportLuong : Form
    {
        public Admin_FormReportLuong()
        {
            InitializeComponent();
        }

        private void FormReportLuong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetQLNS.ReportLuongNV' table. You can move, or remove it, as needed.
            this.reportLuongNVTableAdapter.Fill(this.dataSetQLNS.ReportLuongNV);

            this.reportViewer.RefreshReport();
        }

        private void dtpSelectMonth_CloseUp(object sender, EventArgs e)
        {
            dtpSelectMonth.Value = new DateTime(dtpSelectMonth.Value.Year, dtpSelectMonth.Value.Month, 1);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            this.reportLuongNVTableAdapter.FillByThangNam(this.dataSetQLNS.ReportLuongNV, this.dtpSelectMonth.Value.Month, this.dtpSelectMonth.Value.Year);
            this.reportViewer.RefreshReport();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.reportLuongNVTableAdapter.Fill(this.dataSetQLNS.ReportLuongNV);
            this.reportViewer.RefreshReport();

        }
    }
}
