using CNPM_QLNS.Admin;
using CNPM_QLNS.BS_Layer;
using CNPM_QLNS.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_QLNS.Employees
{
    public partial class NhanVien_FormMain : Form
    {
        public string MaNV;
        BL_NhanVien blnhanvien = new BL_NhanVien();
        BL_TaiKhoan bltaikhoan = new BL_TaiKhoan();
        BL_Luong blluong = new BL_Luong();
        NhanVien nv = new NhanVien();
        public NhanVien_FormMain(string MaNV)
        {
            InitializeComponent();
            this.MaNV = MaNV.Trim();
            lblTen.Text = MaNV;
            nv = blnhanvien.LayNhanVienTheoMa(MaNV.Trim());
        }
        public void loadform(object Form)
        {
            if (this.panelMain.Controls.Count > 0)
                this.panelMain.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag = f;
            f.Show();
        }
        private void NhanVien_FormMain_Load(object sender, EventArgs e)
        {
            this.Width = 1250;
            this.Height = 780;
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv = blnhanvien.LayDanhSachNhanVienTheoMaNV(MaNV)[0];
            loadform(new NhanVien_FormNhanVien(nv));
            lblLink.Text = " Nhân viên / Nhân viên";
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
                TaiKhoan taiKhoan = new TaiKhoan();
                taiKhoan = bltaikhoan.Lay1TaiKhoan(MaNV);
               loadform(new NhanVien_FormTaiKhoan(taiKhoan));
                lblLink.Text = "Nhân viên / Tài khoản";
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {

            NhanVien nv = new NhanVien();
            nv = blnhanvien.LayDanhSachNhanVienTheoMaNV(MaNV)[0];
            loadform(new NhanVien_FormLuong(nv, null));
            lblLink.Text = "Nhân viên / Lương";
          
        }

        public void LoadFormTaiKhoan()
        {

        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            loadform(new NhanVien_FormPhongBan(nv));
            lblLink.Text = "Nhân viên / Phòng ban";
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            loadform(new NhanVien_FormDuAn(nv));
            lblLink.Text = "Nhân viên / Dự án";
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            loadform(new NhanVien_FormChucVu(nv));
            lblLink.Text = "Nhân viên / Chức vụ";
        }
    }
}
