using CNPM_QLNS.BS_Layer;
using CNPM_QLNS.Class;
using System;
using System.Collections;
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
    public partial class Admin_FormPhanCongDuAn: Form
    {
        public DuAn da;
        public Admin_FormXemChiTietDuAn ctda;
        BL_NhanVien blnv = new BL_NhanVien();
        BL_PhanCong blpc = new BL_PhanCong();
        List<NhanVien> NhanVienList = new List<NhanVien>();
        List<PhanCong> pclist = new List<PhanCong>();
        BL_NhanVien bvlnv = new BL_NhanVien();
        List<NhanVien> nvthamgialist = new List<NhanVien>();
        public Admin_FormPhanCongDuAn(DuAn da, Admin_FormXemChiTietDuAn ctda)
        {
            InitializeComponent();
            this.da = da;
            this.ctda = ctda;
            NhanVienList = blnv.LayNhanVienKhongThamGiaDuAn(da.MaDA.Trim());
            cmbMaNV.DropDownStyle = ComboBoxStyle.DropDownList;
            //  MessageBox.Show(NhanVienList.Count().ToString());
            foreach (NhanVien nv in NhanVienList)
            {
               cmbMaNV.Items.Add(nv.MaNV);
            }
        }

        private void Admin_FormPhanCongDuAn_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (blpc.ThemPhanCong(cmbMaNV.Text.Trim(), da.MaDA.Trim(), 3))
            {

                pclist = blpc.LayPhanCongTheoMaDA(da.MaDA.Trim());
                foreach (var phanCong in pclist)
                {
                    NhanVien nv = new NhanVien();
                    nv = bvlnv.LayNhanVienTheoMa(phanCong.MaNV);
                    nvthamgialist.Add(nv);
                }
                ctda.LoadData(nvthamgialist);
                this.Close();
                MessageBox.Show("Thêm thành công !");
                    

            };


        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
