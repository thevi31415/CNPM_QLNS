using CNPM_QLNS.BS_Layer;
using CNPM_QLNS.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CNPM_QLNS.Admin
{
    public partial class Admin_FormTongQuan : Form
    {
        public List<NhanVien> nhanVienList = new List<NhanVien>();
        public List<PhongBan> phongbanList = new List<PhongBan>();
        public List<DuAn> duanList = new List<DuAn>();
        BL_NhanVien nv = new BL_NhanVien();
        BL_PhongBan pb = new BL_PhongBan();
        BL_DuAn da = new BL_DuAn();
        public Admin_FormTongQuan()
        {
            InitializeComponent();
            this.nhanVienList = nv.LayNhanVien();
            this.phongbanList = pb.LayPhongBan();
            this.duanList = da.LayDuAn();
            lblSLNhanVien.Text = nhanVienList.Count.ToString();
            lblSLPhongBan.Text = phongbanList.Count.ToString();
            lblSLDuAn.Text  = duanList.Count.ToString();

        }

        private void btnXuatNhanVien_Click(object sender, EventArgs e)
        {
            // Tạo SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // Thiết lập các thuộc tính của SaveFileDialog
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Chọn nơi lưu file Excel";
            saveFileDialog.FileName = "DanhSachNhanVien.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Tạo đối tượng ExcelExport và xuất file Excel
                BL_XuatExcel excelExport = new BL_XuatExcel();
                excelExport.ExportToExcelNhanVien(nhanVienList, saveFileDialog.FileName);

                MessageBox.Show("Xuất file Excel thành công!");

                // Mở file Excel sau khi lưu (nếu muốn)
                System.Diagnostics.Process.Start(saveFileDialog.FileName);
            }
        }

        private void btnXuatPhongBan_Click(object sender, EventArgs e)
        {
            // Tạo SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // Thiết lập các thuộc tính của SaveFileDialog
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Chọn nơi lưu file Excel";
            saveFileDialog.FileName = "DanhSachPhongBa.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Tạo đối tượng ExcelExport và xuất file Excel
                BL_XuatExcel excelExport = new BL_XuatExcel();
                excelExport.ExportToExcelPhongBan(phongbanList, saveFileDialog.FileName);

                MessageBox.Show("Xuất file Excel thành công!");

                // Mở file Excel sau khi lưu (nếu muốn)
                System.Diagnostics.Process.Start(saveFileDialog.FileName);
            }
        }

        private void Admin_FormTongQuan_Load(object sender, EventArgs e)
        {
           
        }

        private void btnXuatDuAn_Click(object sender, EventArgs e)
        {
            // Tạo SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // Thiết lập các thuộc tính của SaveFileDialog
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Chọn nơi lưu file Excel";
            saveFileDialog.FileName = "DanhSachDuAn.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Tạo đối tượng ExcelExport và xuất file Excel
                BL_XuatExcel excelExport = new BL_XuatExcel();
                excelExport.ExportToExcelDuAn(duanList, saveFileDialog.FileName);

                MessageBox.Show("Xuất file Excel thành công!");

                // Mở file Excel sau khi lưu (nếu muốn)
                System.Diagnostics.Process.Start(saveFileDialog.FileName);
            }
        }
    }
}
