using CNPM_QLNS.BS_Layer;
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
    public partial class Admin_FormThemPhuCap : Form
    {
        public Admin_FormMain formMain;
        BL_PhuCap blpc = new BL_PhuCap();
        public Admin_FormThemPhuCap(Admin_FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(blpc.ThemPhuCap(txtMaPhuCap.Text.Trim(), 
 txtLoaiPC.Text.Trim(), Convert.ToInt32(txtTienPhuCap.Text.Trim())))
            {
                formMain.LoadFormPhuCap();
                this.Close();
                MessageBox.Show("Thêm thành công !");
            }
            else
            {
                MessageBox.Show("Không thể thêm !");
            }
        }

        private void Admin_FormThemPhuCap_Load(object sender, EventArgs e)
        {

        }

        private void txtLoaiPC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
