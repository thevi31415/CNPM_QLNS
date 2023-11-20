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

namespace CNPM_QLNS.Employees
{
    public partial class NhanVien_FormChucVu : Form
    {
        public NhanVien nv;
        BL_ChucVu blcv = new BL_ChucVu();
     
        public NhanVien_FormChucVu(NhanVien nv)
        {
            InitializeComponent();
            this.nv = nv;
            List<ChucVu> cv = new List<ChucVu>();
            cv = blcv.LayDanhSachChucVuTheoMaCV(nv.MaCV);
            if(cv.Count > 0 )
            {
                lblMaCV.Text = cv[0].MaCV.ToString();
                lblTenChucVu.Text = cv[0].TenCV.ToString();
                lblLuongCoBan.Text = cv[0].LuongCoBan.ToString();
                txtMoTa.Text = cv[0].MoTa.ToString();



            }
            txtMoTa.Enabled = false;
        }

        private void NhanVien_FormChucVu_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
