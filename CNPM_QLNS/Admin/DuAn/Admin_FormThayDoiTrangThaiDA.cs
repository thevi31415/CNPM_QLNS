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

namespace CNPM_QLNS.Admin
{
    public partial class Admin_FormThayDoiTrangThaiDA : Form
    {
        public DuAn da;
        public Admin_FormMain FormMain;
        BL_DuAn blda = new BL_DuAn();
        public Admin_FormThayDoiTrangThaiDA(DuAn da, Admin_FormMain formMain)
        {
            InitializeComponent();
            this.da = da;
            this.FormMain = formMain;
            cmbTrangThai.Items.Add("Đã hoàn thành");
            cmbTrangThai.Items.Add("Đang thực hiện");
            cmbTrangThai.Items.Add("Chưa khỏi công");
            cmbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_FormThayDoiTrangThaiDA_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int trangthai = 0;
            if(cmbTrangThai.Text.Trim()== "Đã hoàn thành")
            {
                trangthai = 2;
            }
            if (cmbTrangThai.Text.Trim() == "Đang thực hiện")
            {
                trangthai = 1;
            }
            if (cmbTrangThai.Text.Trim() == "Chưa khỏi công")
            {
                trangthai = 0;
            }
            if(blda.CapNhatTrangThaiDuAn(da.MaDA, trangthai))
            {
                this.Close();
                this.FormMain.LoadFormDuAn();
                MessageBox.Show("Cập nhật trạng thái thành công !");
            }
            else
            {
                MessageBox.Show("Không thể cập nhật !");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
