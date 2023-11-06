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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CNPM_QLNS.Admin
{
    public partial class Admin_FormXemChinhSuaTaiKhoan : Form
    {
        public TaiKhoan tk;
        public Admin_FormMain formain;
        BL_TaiKhoan bltk = new BL_TaiKhoan();
        public Admin_FormXemChinhSuaTaiKhoan(TaiKhoan tk, Admin_FormMain formmain)
        {
            InitializeComponent();
            this.tk = tk;
            this.formain = formmain;
            txtEmail.Text = tk.Email;   
            txtMatKhau.Text = tk.MatKhau.ToString();
            lblMaNV.Text = tk.MaNV.ToString();
            lblTruyCap.Text = tk.TruyCap.ToString();
            cmbPhanQuyen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPhanQuyen.Items.Add("Admin");
            cmbPhanQuyen.Items.Add("User");
            cmbPhanQuyen.Text = tk.PhanQuyen.ToString();    
            cmbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTrangThai.Items.Add("Active");
            cmbTrangThai.Items.Add("Inactive");
            cmbTrangThai.Text = tk.TrangThai.ToString();


            txtEmail.Enabled = false;
            txtMatKhau.Enabled = false;
            cmbPhanQuyen.Enabled = false;
            cmbTrangThai.Enabled = false;
            btnLuu.Enabled = false;
            btnChinhSua.Enabled = true;
            txtMatKhau.PasswordChar = '*';

        }

        private void Admin_FormXemChinhSuaTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            txtEmail.Enabled = true;
            txtMatKhau.Enabled = true;
            cmbPhanQuyen.Enabled = true;
            cmbTrangThai.Enabled = true;
            btnLuu.Enabled = true;
            btnChinhSua.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(bltk.CapNhatTaiKhoan(tk.MaNV, txtEmail.Text.Trim(), txtMatKhau.Text.Trim(), 
                cmbPhanQuyen.Text, cmbTrangThai.Text))
            {

                txtEmail.Enabled = false;
                txtMatKhau.Enabled = false;
                cmbPhanQuyen.Enabled = false;
                cmbTrangThai.Enabled = false;
                btnLuu.Enabled = false;
                btnChinhSua.Enabled = true;
                formain.LoadFormTaiKhoan();
                MessageBox.Show("Cập nhật thành công !");
            }
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '\0')
            {
                // Nếu hiện tại đang hiển thị mật khẩu thì đặt lại ký tự '*' để ẩn mật khẩu
                txtMatKhau.PasswordChar = '*';
              
                 btnShowPass.Image = Properties.Resources.invisible;
            }
            else
            {
                // Nếu hiện tại đang ẩn mật khẩu thì đặt PasswordChar thành '\0' để hiển thị bình thường
                txtMatKhau.PasswordChar = '\0';
                btnShowPass.Image = Properties.Resources.view;
            }
        }
    }
}
