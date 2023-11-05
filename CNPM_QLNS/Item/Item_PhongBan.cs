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
        public Item_PhongBan(PhongBan pb, Admin_FormMain formnmain)
        {
            InitializeComponent();
            this.pb = pb;
        }

        private void Item_PhongBan_Load(object sender, EventArgs e)
        {
            lblTenPhongBan.Text = pb.TenPhongBan.ToString();
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
    }
}
