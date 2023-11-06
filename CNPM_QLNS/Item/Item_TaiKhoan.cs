using CNPM_QLNS.Admin;
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

namespace CNPM_QLNS.Item
{
    public partial class Item_TaiKhoan : Form
    {
        public Admin_FormMain formMain;
        public TaiKhoan tk;
        BL_TaiKhoan bltk = new BL_TaiKhoan();
        public Item_TaiKhoan(Admin_FormMain formMain, TaiKhoan tk)
        {
            InitializeComponent();
            this.formMain = formMain;
            this.tk = tk;
        }

        private void Item_TaiKhoan_Load(object sender, EventArgs e)
        {
            lblMaNV.Text = tk.MaNV;
            lblEmail.Text = tk.Email;
            btnTrangThai.Text = tk.TrangThai;
            lblTruyCap.Text = tk.TruyCap.ToString();

            btnPhanQuyen.Text = tk.PhanQuyen.ToString();
            if( tk.PhanQuyen.Trim() == "Admin" ) {
              btnPhanQuyen.BackColor = ColorTranslator.FromHtml("#17A7EC");
            }
            else
            {
              btnPhanQuyen.BackColor = ColorTranslator.FromHtml("#797EF6");
            }
            btnTrangThai.Text = tk.TrangThai.ToString();
            if (tk.TrangThai.Trim() == "Active")
            {
                btnTrangThai.BackColor = ColorTranslator.FromHtml("#06B635");
            }
            else
            {
                btnTrangThai.BackColor = ColorTranslator.FromHtml("#F44336");
            }


        }

        private void Item_TaiKhoan_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#ABD0F9");
        }

        private void Item_TaiKhoan_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void Item_TaiKhoan_MouseClick(object sender, MouseEventArgs e)
        {
          Admin_FormXemChinhSuaTaiKhoan   frmxemtk = new Admin_FormXemChinhSuaTaiKhoan(tk, formMain);
            frmxemtk.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này ra khỏi hệ thống ?", "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                if (bltk.XoaTaiKhoan(tk.MaNV))
                {
                    MessageBox.Show("Xóa thành công !");
                    formMain.LoadFormTaiKhoan();
                }
                else
                {
                    MessageBox.Show("Không thể xóa tài khoản này ");
                }

               
            }
        }
    }
}
