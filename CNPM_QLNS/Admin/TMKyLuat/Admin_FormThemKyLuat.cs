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

namespace CNPM_QLNS.Admin.TMKyLuat
{
    public partial class Admin_FormThemKyLuat : Form
    {
        public Admin_FormMain formain;
        BL_KyLuat blkt = new BL_KyLuat();
        public Admin_FormThemKyLuat(Admin_FormMain formMain)
        {
            InitializeComponent();
            this.formain = formMain;
        }

        private void Admin_FormThemKyLuat_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(blkt.ThemMoiKyLuat(txtMaKyLuat.Text.Trim(),
                    txtTenKL.Text, Convert.ToInt32(txtTienPhat.Text.Trim())))
            {
                formain.LoadFormKyLuat();
                this.Close();
                MessageBox.Show("Thêm thành công !");
            }
            else
            {
                MessageBox.Show("Không thể thêm");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
