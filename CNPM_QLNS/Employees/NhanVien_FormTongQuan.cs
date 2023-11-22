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
    public partial class NhanVien_FormTongQuan : Form
    {
        public List<NhanVien> nhanVienList = new List<NhanVien>();
        public List<PhongBan> phongbanList = new List<PhongBan>();
        public List<DuAn> duanList = new List<DuAn>();
        BL_NhanVien nv = new BL_NhanVien();
        BL_PhongBan pb = new BL_PhongBan();
        BL_DuAn da = new BL_DuAn();
        public NhanVien_FormTongQuan()
        {
            InitializeComponent();
            this.nhanVienList = nv.LayNhanVien();
            this.phongbanList = pb.LayPhongBan();
            this.duanList = da.LayDuAn();
            lblSLNhanVien.Text = nhanVienList.Count.ToString();
            lblSLPhongBan.Text = phongbanList.Count.ToString();
            lblSLDuAn.Text = duanList.Count.ToString();
        }

        private void NhanVien_FormTongQuan_Load(object sender, EventArgs e)
        {

        }
    }
}
