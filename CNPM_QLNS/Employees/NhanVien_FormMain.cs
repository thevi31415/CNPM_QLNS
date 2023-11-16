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
        public NhanVien_FormMain(string MaNV)
        {
            InitializeComponent();
            this.MaNV = MaNV.Trim();
            lblTen.Text = MaNV;
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

        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv = blnhanvien.LayDanhSachNhanVienTheoMaNV(MaNV)[0];
            loadform(new NhanVien_FormNhanVien(nv));
            lblLink.Text = "Admin / Nhân viên";
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = new TaiKhoan();
                taiKhoan = bltaikhoan.Lay1TaiKhoan(MaNV);
                
                lblLink.Text = "Admin / Tài khoản";
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {

            NhanVien nv = new NhanVien();
            nv = blnhanvien.LayDanhSachNhanVienTheoMaNV(MaNV)[0];
            loadform(new NhanVien_FormLuong(nv, null));
            lblLink.Text = "Admin / Lương";
          
        }

        public void LoadFormTaiKhoan()
        {

        }
    }
}
