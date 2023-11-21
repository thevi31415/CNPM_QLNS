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

namespace CNPM_QLNS.Admin
{
    public partial class Admin_FormThemChucVu : Form
    {
        public Admin_FormMain formMain;
        BL_ChucVu blcv = new BL_ChucVu();
        public Admin_FormThemChucVu(Admin_FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }

        private void Admin_FormThemChucVu_Load(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(blcv.ThemChucVu(txtMaCV.Text.Trim(), txtTenCV.Text.Trim(), 
                Convert.ToInt32(txtLuongCB.Text), txtMoTa.Text))
            {
                formMain.LoadFormChucVu();
                this.Close();
                MessageBox.Show("Thêm thành công !");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
