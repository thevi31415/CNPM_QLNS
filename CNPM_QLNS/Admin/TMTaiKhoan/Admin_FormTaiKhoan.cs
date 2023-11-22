using CNPM_QLNS.BS_Layer;
using CNPM_QLNS.Class;
using CNPM_QLNS.Employees;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace CNPM_QLNS.Admin
{
    public partial class Admin_FormTaiKhoan : Form
    {
        public List<TaiKhoan> taikhoanlist;
        BL_TaiKhoan tk = new BL_TaiKhoan();
        public List<TaiKhoan> ketquatimkiemtk = new List<TaiKhoan>();
        public Admin_FormMain formain;
        public NhanVien_FormMain nv_formMain;
        BL_TimKiem timKiem = new BL_TimKiem();
        int check = 0;
        public Admin_FormTaiKhoan(Admin_FormMain formmain)
        {
            InitializeComponent();
            this.formain = formmain;
            this.taikhoanlist = tk.LayTaiKhoan();
            check = 1;
            cbMaNV.Checked = true;
            txtTimKiem.Text = "Tìm kiếm...";
            txtTimKiem.ForeColor = ColorTranslator.FromHtml("#D6D4D2");
        }
        public void LoadData(List<TaiKhoan> tkList)
        {

            panelListTaiKhoan.Controls.Clear();
          
            //  nvList = nv.LayNhanVien();
            panelListTaiKhoan.Padding = new Padding(10, 0, 10, 0);
           // MessageBox.Show(taikhoanlist.Count().ToString());
            if (tkList.Count > 0)
            {
                //  MessageBox.Show(nhanVienList.Count().ToString());
                foreach (TaiKhoan taikhoan in tkList)
                {
                    Item_TaiKhoan item_taikhoan = new Item_TaiKhoan(formain, nv_formMain, taikhoan) ; // Pass the reference
                    item_taikhoan.TopLevel = false;
                    panelListTaiKhoan.Controls.Add(item_taikhoan);
                    item_taikhoan.Show();
                }
            }
            else
            {
                MessageBox.Show("Khong tim thay nhan vien nao =)))");
            }


        }
        private void Admin_FormTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadData(this.taikhoanlist);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Admin_FormThemTaiKhoan frmthemnv = new Admin_FormThemTaiKhoan(formain);
            frmthemnv.ShowDialog();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ThuocTinhTimKiem = "";
            if (check == 1)
            {
                ThuocTinhTimKiem = "MaNV";
            }
            else
            {
                ThuocTinhTimKiem = "Email";
            }
            if (txtTimKiem.Text.ToString() == "Tìm kiếm...")
            {
                ketquatimkiemtk = timKiem.TimKiemTaiKhoan("", ThuocTinhTimKiem);
            }
            else
            {
                ketquatimkiemtk = timKiem.TimKiemTaiKhoan(txtTimKiem.Text.ToString().Trim(), ThuocTinhTimKiem);
            }

           //  MessageBox.Show(ketquatimkiemtk.Count().ToString());
            LoadData(ketquatimkiemtk);
        }

        private void cbMaNV_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMaNV.Checked)
            {
                cbEmail.Checked = false; // Đảm bảo chỉ có một trong hai checkbox được chọn
                check = 1;
            }
        }

        private void cbEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEmail.Checked)
            {
                cbMaNV.Checked = false; // Đảm bảo chỉ có một trong hai checkbox được chọn
                check = 2;
            }
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
    }
}
