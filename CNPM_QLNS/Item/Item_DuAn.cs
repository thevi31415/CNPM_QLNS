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
    public partial class Item_DuAn : Form
    {
        public DuAn da;
        public Admin_FormMain formmain;
        public Item_DuAn(DuAn da, Admin_FormMain formnmain)
        {
            InitializeComponent();
            this.da = da;
            this.formmain = formnmain;
            lblMaDA.Text = da.MaDA.Trim();
            lblTenDA.Text = da.TenDA.Trim();
            lblGiaTri.Text= da.GiaTri.ToString();
            if(da.TrangThai == 0)
            {
                btnTrangThai.BackColor = ColorTranslator.FromHtml("#FF0000");
                btnTrangThai.Text = "Chưa thực hiện";
            }
            if(da.TrangThai == 1)
            {
                btnTrangThai.BackColor = ColorTranslator.FromHtml("#F9C70D");
                btnTrangThai.Text = "Đang thực hiện";
            }


            if (da.TrangThai == 2)
            {
                btnTrangThai.BackColor = ColorTranslator.FromHtml("#20D374");
                btnTrangThai.Text = "Đã hoàn thành";
            }

        }

        private void Item_DuAn_Load(object sender, EventArgs e)
        {

        }

        private void Item_DuAn_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
