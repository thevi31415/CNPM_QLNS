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

namespace CNPM_QLNS.Admin.PhuCap
{
    public partial class Admin_FormChinhSuaPhuCap : Form
    {
        public PhuCapNV phucap;
        public Admin_FormMain formain;
        BL_PhuCap blpc = new BL_PhuCap();
        public Admin_FormChinhSuaPhuCap(Admin_FormMain formMain, PhuCapNV pc)
        {
            InitializeComponent();
            phucap = pc;
            this.formain = formMain;
            txtMaPhuCap.Enabled = false;
            txtMaPhuCap.Text = phucap.MaPC.Trim();
            txtLoaiPC.Text = phucap.LoaiPC;
            txtTienPhuCap.Text = phucap.GiaTriPC.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(blpc.CapNhatPhuCap(phucap.MaPC, txtLoaiPC.Text, Convert.ToInt32(txtTienPhuCap.Text.Trim()))){
                formain.LoadFormPhuCap();
                this.Close();
                MessageBox.Show("Cập nhật thành công !");
            }
            else
            {
                MessageBox.Show("Không thể cập nhật 1");
            }
        }

        private void Admin_FormChinhSuaPhuCap_Load(object sender, EventArgs e)
        {

        }
    }
}
