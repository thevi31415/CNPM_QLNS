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
    public partial class Item_PhongBan : Form
    {
        public PhongBan pb;
        public Admin_FormMain formmain;
        BL_PhongBan blphongban = new BL_PhongBan();
        public Item_PhongBan(PhongBan pb, Admin_FormMain formnmain)
        {
            InitializeComponent();
            this.pb = pb;
            this.formmain = formnmain;
            this.pb.SoLuongNV = blphongban.LaySoLuongNhanVienMoiPhongBan(pb.MaPB);
        }

        private void Item_PhongBan_Load(object sender, EventArgs e)
        {
            lblTenPhongBan.Text = pb.TenPhongBan.ToString();
            lblSoLuongNV.Text =pb.SoLuongNV.ToString();
            lblMaPB.Text = this.pb.MaPB.ToString();
        }

        private void Item_PhongBan_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#56A9FF");
        }

        private void Item_PhongBan_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#77CCFF");
        }

        private void picAvatar_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#56A9FF");
        }

        private void picAvatar_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#77CCFF");
        }

        private void btnXoa_Click(object sender, EventArgs e)
            
        {
           // MessageBox.Show(pb.MaPB);
            
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa phòng ban này ?", "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {



                if (blphongban.SetNullMaPBNhanVien(pb.MaPB.ToString().Trim()) && blphongban.XoaPhongBan(pb.MaPB))
                {
                    formmain.LoadFormPhongBan();
                    MessageBox.Show("Xóa thành công !");

                }
                else
                {
                    MessageBox.Show("Không thể xóa !");
                }
            }
        }

        private void lblSoLuongNV_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#56A9FF");
        }

        private void lblSoLuongNV_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#77CCFF");
        }

        private void Item_PhongBan_MouseClick(object sender, MouseEventArgs e)
        {
            Admin_ChiTietPhongBan frmxempb = new Admin_ChiTietPhongBan(pb, formmain);
            frmxempb.ShowDialog();
        }
    }
}
