using CNPM_QLNS.Admin;
using CNPM_QLNS.BS_Layer;
using CNPM_QLNS.Class;
using CNPM_QLNS.DB_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_QLNS.Item
{
    public partial class Item_NhanVien : Form
    {

        public NhanVien nv;
        public Admin_FormMain formmain;
        DBMain db = new DBMain();
        BL_NhanVien blnv = new BL_NhanVien();
        BL_Luong blluong = new BL_Luong();
        BL_PhanCong blphancog = new BL_PhanCong();
        public Item_NhanVien(NhanVien nv, Admin_FormMain formnmain)
        {
            InitializeComponent();
            this.nv = nv;
            this.formmain = formnmain;
        }

        private void Item_NhanVien_Load(object sender, EventArgs e)
        {
            lblMaNV.Text = nv.MaNV;
            lblGioiTinh.Text = nv.GioiTinh;
            lblHoTen.Text = nv.HoTen;
            lblNgaySinh.Text = nv.NgaySinh.ToString("dd/MM/yyyy");
            lblTrangThai.Text = nv.TrangThai;
            checkBox1.Size = new Size(200, 200);
            if(lblTrangThai .Text== "Đang làm việc")
            {
                lblTrangThai.BackColor = ColorTranslator.FromHtml("#0FD99B");
            } 
            if(lblTrangThai.Text == "Đã nghỉ việc")
            {
                lblTrangThai.BackColor = ColorTranslator.FromHtml("#FF0000");
            }
            if(lblTrangThai.Text == "Nghỉ việc tạm thời")
            {
                lblTrangThai.BackColor = ColorTranslator.FromHtml("#EC9E0C");

            }
        }
        
        private void Item_NhanVien_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#ABD0F9");
        }

        private void Item_NhanVien_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void Item_NhanVien_MouseClick(object sender, MouseEventArgs e)
        {
            Admin_FormXemNhanVien frmxemnx = new Admin_FormXemNhanVien(nv);
            frmxemnx.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này? \n Chú ý: Khi xóa sẽ xóa tất cả thông tin của nhân viên đó (Lương, Dự Án, Phòng Ban, ...) ra khỏi hệ thống.", "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                


                if (blphancog.XoaPhanCong(lblMaNV.Text.ToString()) &&
                    blluong.XoaLuong(lblMaNV.Text.ToString()) && blnv.XoaNhanVien(lblMaNV.Text.ToString()) ==true)
                {
                    formmain.LoadFormNhanVien();
                    MessageBox.Show("Xóa thành công !");
                    
                }
                else
                {
                    MessageBox.Show("Không thể xóa !");
                }
            }
        }

        private void lblMaNV_Click(object sender, EventArgs e)
        {
            Admin_FormXemNhanVien frmxemnx = new Admin_FormXemNhanVien(nv);
            frmxemnx.ShowDialog();
        }

        private void lblHoTen_Click(object sender, EventArgs e)
        {
            Admin_FormXemNhanVien frmxemnx = new Admin_FormXemNhanVien(nv);
            frmxemnx.ShowDialog();
        }

        private void lblNgaySinh_Click(object sender, EventArgs e)
        {
            Admin_FormXemNhanVien frmxemnx = new Admin_FormXemNhanVien(nv);
            frmxemnx.ShowDialog();
        }

        private void lblGioiTinh_Click(object sender, EventArgs e)
        {
            Admin_FormXemNhanVien frmxemnx = new Admin_FormXemNhanVien(nv);
            frmxemnx.ShowDialog();
        }

        private void lblTrangThai_Click(object sender, EventArgs e)
        {
            Admin_FormXemNhanVien frmxemnx = new Admin_FormXemNhanVien(nv);
            frmxemnx.ShowDialog();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            Admin_FormChinhSuaNhanVien frmchinhsua = new Admin_FormChinhSuaNhanVien(nv, formmain);
            frmchinhsua.ShowDialog();
        }

        private void picChanDung_Click(object sender, EventArgs e)
        {

        }

        private void lblTrangThai_Click_1(object sender, EventArgs e)
        {

        }
    }
}
