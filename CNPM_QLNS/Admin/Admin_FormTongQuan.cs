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

namespace CNPM_QLNS.Admin
{
    public partial class Admin_FormTongQuan : Form
    {
        public List<NhanVien> nhanVienList = new List<NhanVien>();
        BL_NhanVien nv = new BL_NhanVien();
        public Admin_FormTongQuan()
        {
            InitializeComponent();
            this.nhanVienList = nv.LayNhanVien();
            lblSLNhanVien.Text = nhanVienList.Count.ToString();

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
                excelExport.ExportToExcel(nhanVienList, saveFileDialog.FileName);

                MessageBox.Show("Xuất file Excel thành công!");

                // Mở file Excel sau khi lưu (nếu muốn)
                System.Diagnostics.Process.Start(saveFileDialog.FileName);
            }
        }
    }
}
