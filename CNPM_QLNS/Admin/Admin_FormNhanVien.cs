using CNPM_QLNS.BS_Layer;
using CNPM_QLNS.Class;
using CNPM_QLNS.Item;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace CNPM_QLNS.Admin
{
    public partial class Admin_FormNhanVien : Form
    {
        public List<NhanVien> nhanVienList = new List<NhanVien>();
        public List<NhanVien> ketquatimkiemnv = new List<NhanVien>();
        BL_NhanVien nv = new BL_NhanVien();
        BL_TimKiem  timKiem = new BL_TimKiem();
        public Admin_FormMain formmain;
        int check = 0;
        public Admin_FormNhanVien(Admin_FormMain formmain)
        {
            InitializeComponent();
       
            this.formmain = formmain;
            txtTimKiem.Text = "Tìm kiếm...";
            txtTimKiem.ForeColor = ColorTranslator.FromHtml("#D6D4D2");
            cbMaNV.Checked = true;
            check = 1;
        }
        public void LoadData(List<NhanVien> nvList)
        {
           
            panelListNhanVien.Controls.Clear();
           this.nhanVienList = nv.LayNhanVien();
          //  nvList = nv.LayNhanVien();
            panelListNhanVien.Padding = new Padding(10, 0, 10, 0); ;
            if(nvList.Count > 0)
            {
               //  MessageBox.Show(nhanVienList.Count().ToString());
                foreach (NhanVien nhanVien in nvList)
                {
                    Item_NhanVien item_nhanvien = new Item_NhanVien(nhanVien, formmain); // Pass the reference
                    item_nhanvien.TopLevel = false;
                    panelListNhanVien.Controls.Add(item_nhanvien);
                    item_nhanvien.Show();
                }
            }
            else
            {
                MessageBox.Show("Khong tim thay nhan vien nao =)))");
            }
          

        }

     

        private void Admin_FormNhanVien_Load(object sender, EventArgs e)
        {
            this.nhanVienList = nv.LayNhanVien();
            LoadData(nhanVienList);
        }

     
  
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ThuocTinhTimKiem = "";
            if(check == 1)
            {
                ThuocTinhTimKiem = "MaNV";
            }
            else
            {
                ThuocTinhTimKiem = "HoTen";
            }
            if (txtTimKiem.Text.ToString() == "Tìm kiếm...")
            {
                ketquatimkiemnv = timKiem.TimKiemNhanVien("", ThuocTinhTimKiem);
            }
            else
            {
                ketquatimkiemnv = timKiem.TimKiemNhanVien(txtTimKiem.Text.ToString().Trim(), ThuocTinhTimKiem);
            }
         
          //  MessageBox.Show(ketquatimkiemnv.Count().ToString());
            LoadData(ketquatimkiemnv);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Admin_FormThemNhanVien frmthemnv = new Admin_FormThemNhanVien(formmain);
            frmthemnv.ShowDialog();
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm kiếm...")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = ColorTranslator.FromHtml("#1C1C1C");
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "Tìm kiếm...";
                txtTimKiem.ForeColor = ColorTranslator.FromHtml("#D6D4D2");
            }
        }

        private void cbMaNV_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMaNV.Checked)
            {
               cbHoTen.Checked = false; // Đảm bảo chỉ có một trong hai checkbox được chọn
                check = 1;
            }
        }

        private void cbHoTen_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHoTen.Checked)
            {
               cbMaNV.Checked = false; // Đảm bảo chỉ có một trong hai checkbox được chọn
               check = 2;
            }
        }

    }
}
