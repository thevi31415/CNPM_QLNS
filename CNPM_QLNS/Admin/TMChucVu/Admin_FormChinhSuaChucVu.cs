using System;
using CNPM_QLNS.BS_Layer;
using CNPM_QLNS.Class;
using CNPM_QLNS.Item;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_QLNS.Admin.TMChucVu
{
    public partial class Admin_FormChinhSuaChucVu : Form
    {
        public Admin_FormMain formain;
        public ChucVuNV cv;
        BL_ChucVu blcv = new BL_ChucVu();
        public Admin_FormChinhSuaChucVu(Admin_FormMain formMain, ChucVuNV cv)
        {
            InitializeComponent();
            this.formain = formMain;
            this.cv = cv;
            txtMaCV.Text = cv.MaCV.ToString();
            txtMaCV.Enabled = false;
            txtTenCV.Text = cv.TenCV.ToString();
            txtLuongCB.Text =cv.LuongCoBan.ToString();
            txtMoTa.Text = cv.MoTa.ToString();
        }

        private void Admin_FormChinhSuaChucVu_Load(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtLuongCB.Text.Trim()=="" || txtMoTa.Text.Trim()=="" || txtLuongCB.Text.Trim()==""
                || txtTenCV.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin vui lòng nhập lại !");
            }
            else
            {
                if(blcv.CapNhatChucVu(txtMaCV.Text.Trim(), txtTenCV.Text,
                    Convert.ToInt32(txtLuongCB.Text.Trim()), txtMoTa.Text)) {
                    formain.LoadFormChucVu();
                    this.Close();
                    MessageBox.Show("Cập nhật thành công !");
                }
                else {
                    MessageBox.Show("Không thể cập nhật !");
                }
            }
        }
    }
}
