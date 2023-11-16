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
    public partial class NhanVien_FormDoiMatKhau : Form
    {
        public TaiKhoan tk;
        public NhanVien_FormDoiMatKhau(TaiKhoan tk)
        {
            InitializeComponent();
            this.tk = tk;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NhanVien_FormDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            BL_TaiKhoan bltk = new BL_TaiKhoan();
            if(txtMatKhauOld.Text.Trim() == bltk.Lay1TaiKhoan(tk.MaNV).MatKhau.Trim())
            {
                if(bltk.DoiMatKhau(tk.MaNV, txtMatKhauNew.Text.Trim()))
                {
                    MessageBox.Show("Đổi mật khẩu thành công !");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể thay đổi mật khẩu !");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng ! Vui lòng nhập lại. Nếu quên mật khẩu liên hệ QTV !");
            }
            
        }
    }
}
