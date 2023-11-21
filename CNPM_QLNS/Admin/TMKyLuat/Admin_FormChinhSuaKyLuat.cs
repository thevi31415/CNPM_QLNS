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
    public partial class Admin_FormChinhSuaKyLuat : Form
    {
        public KyLuatNV kl;
        public Admin_FormMain formain;
        BL_KyLuat blkl = new BL_KyLuat();
        public Admin_FormChinhSuaKyLuat(Admin_FormMain formMain, KyLuatNV kl)
        {
            InitializeComponent();
            this.kl = kl;
            this.formain = formMain;
            txtMaKyLuat.Enabled = false;
            txtMaKyLuat.Text = this.kl.MaKL;
            txtTenKL.Text = this.kl.LoaiKL;
            txtTienPhat.Text = this.kl.TienPhat.ToString();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_FormChinhSuaKyLuat_Load(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(blkl.CapNhatKyLuat(kl.MaKL, txtTenKL.Text.Trim(),
                Convert.ToInt32(txtTienPhat.Text.ToString())))
            {
                this.Close() ;
                formain.LoadFormKyLuat();
                MessageBox.Show("Cập nhật thành công !");

            }
            else
            {
                MessageBox.Show("Không thể cập nhật thành công !");
            }
        }
    }
}
