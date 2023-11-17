using CNPM_QLNS.Admin;
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

namespace CNPM_QLNS.Item
{
    public partial class Item_PhongBanNhanVien : Form
    {
        public PhongBan pb;
        public Admin_FormMain formmain;
        BL_PhongBan blphongban = new BL_PhongBan();
        public Item_PhongBanNhanVien(PhongBan pb)
        {
            InitializeComponent();
            this.pb = pb;
            //this.formmain = formnmain;
            this.pb.SoLuongNV = blphongban.LaySoLuongNhanVienMoiPhongBan(pb.MaPB);
        }

        private void Item_PhongBanNhanVien_Load(object sender, EventArgs e)
        {
            lblTenPhongBan.Text = pb.TenPhongBan.ToString();
            lblSoLuongNV.Text = pb.SoLuongNV.ToString();
            lblMaPB.Text = this.pb.MaPB.ToString();
        }

        private void Item_PhongBanNhanVien_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#0D6E4F");
        }

        private void Item_PhongBanNhanVien_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#6DBF5A");
        }

        private void Item_PhongBanNhanVien_MouseClick(object sender, MouseEventArgs e)
        {
           NhanVien_FormChiTietPhongBan frmxempb = new NhanVien_FormChiTietPhongBan(pb);
            frmxempb.ShowDialog();
        }
    }
}
