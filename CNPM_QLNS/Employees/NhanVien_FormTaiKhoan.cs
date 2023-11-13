using CNPM_QLNS.Admin;
using CNPM_QLNS.BS_Layer;
using CNPM_QLNS.Class;
using CNPM_QLNS.Item;
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
    public partial class NhanVien_FormTaiKhoan : Form
    {
        public TaiKhoan taiKhoan;
        BL_TaiKhoan tk = new BL_TaiKhoan();
        public NhanVien_FormMain nv_formMain;
        public Admin_FormMain formMain;
        public NhanVien_FormTaiKhoan(NhanVien_FormMain nvFormMain)
        {
            InitializeComponent();
            this.nv_formMain = nvFormMain;
        }
        public void LoadData()
        {

            panelListTaiKhoan.Controls.Clear();

            //  nvList = nv.LayNhanVien();
            panelListTaiKhoan.Padding = new Padding(10, 0, 10, 0);
            // MessageBox.Show(taikhoanlist.Count().ToString());
            
                //  MessageBox.Show(nhanVienList.Count().ToString());
            Item_TaiKhoan item_taikhoan = new Item_TaiKhoan(formMain, nv_formMain, taiKhoan); // Pass the reference
            item_taikhoan.TopLevel = false;
            panelListTaiKhoan.Controls.Add(item_taikhoan);
            item_taikhoan.Show();
        }
        private void NhanVien_FormTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhanVien_FormSuaTaiKhoan formSuaTK = new NhanVien_FormSuaTaiKhoan(taiKhoan);
            formSuaTK.ShowDialog();
        }
    }
}
