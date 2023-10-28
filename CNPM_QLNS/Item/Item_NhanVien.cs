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
    public partial class Item_NhanVien : Form
    {

        public NhanVien nv;
        public Item_NhanVien(NhanVien nv)
        {
            InitializeComponent();
            this.nv = nv;
        }

        private void Item_NhanVien_Load(object sender, EventArgs e)
        {
            lblMaNV.Text = nv.MaNV;
            lblGioiTinh.Text = nv.GioiTinh;
            lblHoTen.Text = nv.HoTen;
            lblNgaySinh.Text = nv.NgaySinh.ToString();
            lblTrangThai.Text = nv.TrangThai;
            checkBox1.Size = new Size(200, 200);
        }
        
        private void Item_NhanVien_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#EFF6FF");
        }

        private void Item_NhanVien_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
