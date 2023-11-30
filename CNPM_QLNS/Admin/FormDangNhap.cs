using CNPM_QLNS.BS_Layer;
using CNPM_QLNS.Class;
using CNPM_QLNS.Employees;
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
    public partial class FormDangNhap : Form
    {
        BL_TaiKhoan bltaikhoan = new BL_TaiKhoan();
        TaiKhoan tk = new TaiKhoan();
        public FormDangNhap()
        {
            InitializeComponent();
            txtMatKhau.UseSystemPasswordChar = true;
        }

     

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (bltaikhoan.LayTaiKhoanTheoEmailMatKhau(txtEmail.Text, txtMatKhau.Text).Count() > 0)
            {



                tk = bltaikhoan.LayTaiKhoanTheoEmailMatKhau(txtEmail.Text, txtMatKhau.Text)[0];

                if(tk.TrangThai == "Inactive")
                {
                    MessageBox.Show("Tài khoản đã bị khóa không thể đăng nhập !");
                }
                else
                {
                    if (tk.PhanQuyen == "Admin")
                    {
                        Admin_FormMain frmmainadmin = new Admin_FormMain(tk.MaNV);
                        this.Hide();
                        frmmainadmin.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        NhanVien_FormMain frmformnhanvien = new NhanVien_FormMain(tk.MaNV);
                        this.Hide();
                        frmformnhanvien.ShowDialog();
                        this.Show();
                    }


                }
                
                txtEmail.Clear();
                txtMatKhau.Clear();
            }
            else
            {
                txtEmail.Clear();
                txtMatKhau.Clear();
                MessageBox.Show("Bạn nhập mật khẩu hoặc email sai ! Vui lòng nhập lại !");
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
