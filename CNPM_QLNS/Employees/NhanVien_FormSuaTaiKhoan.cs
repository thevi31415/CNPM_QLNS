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

namespace CNPM_QLNS.Employees
{
    public partial class NhanVien_FormSuaTaiKhoan : Form
    {
        public TaiKhoan tk;
        public NhanVien_FormMain nv_formMain;
        BL_NhanVien blnv = new BL_NhanVien();
        BL_TaiKhoan bltk = new BL_TaiKhoan();
        public NhanVien_FormSuaTaiKhoan(TaiKhoan tk)
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            this.txtMaNV.Text = this.tk.MaNV;
            this.txtEmail.Text = this.tk.Email;
            this.txtMatKhau.Text = this.tk.MatKhau;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim() == "" || txtMatKhau.Text.Trim() =="" || txtMaNV.Text.Trim()=="")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin vui lòng nhập lại !");

            }
            else
            {
                if (bltk.NhanVien_CapNhatTaiKhoan(txtMaNV.Text.Trim(), txtEmail.Text.Trim()
                    , txtMatKhau.Text.Trim()))
                {
                    MessageBox.Show("Sửa thành công !");
                    nv_formMain.LoadFormTaiKhoan();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại !");
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void NhanVien_FormSuaTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
