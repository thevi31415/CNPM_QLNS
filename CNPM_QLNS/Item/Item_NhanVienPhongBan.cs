using CNPM_QLNS.Admin;
using CNPM_QLNS.BS_Layer;
using CNPM_QLNS.Class;
using CNPM_QLNS.DB_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CNPM_QLNS.Item
{
    public partial class Item_NhanVienPhongBan : Form
    {

        public NhanVien nv;
        public Admin_FormMain formmain;
        public Admin_ChiTietPhongBan chiTietPhongBan;
        public PhongBan pb;
        DBMain db = new DBMain();
        BL_NhanVien blnv = new BL_NhanVien();
        BL_Luong blluong = new BL_Luong();
        BL_PhanCong blphancog = new BL_PhanCong();
        BL_PhongBan blpb = new BL_PhongBan();
        public Item_NhanVienPhongBan(PhongBan pb, NhanVien nv, Admin_FormMain formnmain, Admin_ChiTietPhongBan ctpb)
        {
            InitializeComponent();
            this.nv = nv;
            this.formmain = formnmain;
            this.chiTietPhongBan= ctpb;
            this.pb = pb;
        }

        private void Item_NhanVienPhongBan_Load(object sender, EventArgs e)
        {
            lblMaNV.Text = nv.MaNV;
            lblGioiTinh.Text = nv.GioiTinh;
            lblHoTen.Text = nv.HoTen;
            lblNgaySinh.Text = nv.NgaySinh.ToString("dd/MM/yyyy");
            lblTrangThai.Text = nv.TrangThai;
          //  checkBox1.Size = new Size(200, 200);
            if (lblTrangThai.Text == "Đang làm việc")
            {
                lblTrangThai.BackColor = ColorTranslator.FromHtml("#0FD99B");
            }
            if (lblTrangThai.Text == "Đã nghỉ việc")
            {
                lblTrangThai.BackColor = ColorTranslator.FromHtml("#FF0000");
            }
            if (lblTrangThai.Text == "Nghỉ việc tạm thời")
            {
                lblTrangThai.BackColor = ColorTranslator.FromHtml("#EC9E0C");

            }
        }

        private void Item_NhanVienPhongBan_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Item_NhanVienPhongBan_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#ABD0F9");
        }

        private void Item_NhanVienPhongBan_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void Item_NhanVienPhongBan_MouseClick(object sender, MouseEventArgs e)
        {
            Admin_FormXemNhanVien frmxemnx = new Admin_FormXemNhanVien(nv);
            frmxemnx.ShowDialog();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này ra khỏi phòng ban?" + nv.MaNV, "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {



                if (blpb.SetNullMaPBMotNhanVien(nv.MaNV))
                {
                    chiTietPhongBan.nhanVienList = this.chiTietPhongBan.blpb.LayNhanVienTheoMaPB(pb.MaPB);
                    chiTietPhongBan.LoadData(chiTietPhongBan.nhanVienList);
                    formmain.LoadFormPhongBan();
                    MessageBox.Show("Xóa thành công !");

                }
                else
                {
                    MessageBox.Show("Không thể xóa !");
                }
            }
        }
    }
}
