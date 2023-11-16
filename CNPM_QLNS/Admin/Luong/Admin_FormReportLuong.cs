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
            // TODO: This line of code loads data into the 'dataSetQLNS.ReportLuongNV' table. You can move, or remove it, as needed.
            this.reportLuongNVTableAdapter.Fill(this.dataSetQLNS.ReportLuongNV);

            this.reportViewer.RefreshReport();
        }
    }
}
