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
        public List<TaiKhoan> taikhoanlist;
        BL_TaiKhoan tk = new BL_TaiKhoan();
        public NhanVien_FormMain nv_formMain;
        int check = 0;
        public NhanVien_FormTaiKhoan(NhanVien_FormMain nvFormMain)
        {
            InitializeComponent();
            this.nv_formMain = nvFormMain;
            this.taikhoanlist = tk.Lay1TaiKhoan(this.nv_formMain.MaNV);
            check = 1;
        }
        public void LoadData(List<TaiKhoan> tkList)
        {

            panelListTaiKhoan.Controls.Clear();

            //  nvList = nv.LayNhanVien();
            panelListTaiKhoan.Padding = new Padding(10, 0, 10, 0);
            // MessageBox.Show(taikhoanlist.Count().ToString());
            if (tkList.Count > 0)
            {
                //  MessageBox.Show(nhanVienList.Count().ToString());
                foreach (TaiKhoan taikhoan in tkList)
                {
                    Item_TaiKhoan item_taikhoan = new Item_TaiKhoan(nv_formMain, taikhoan); // Pass the reference
                    item_taikhoan.TopLevel = false;
                    panelListTaiKhoan.Controls.Add(item_taikhoan);
                    item_taikhoan.Show();
                }
            }
            else
            {
                MessageBox.Show("Khong tim thay nhan vien nao =)))");
            }


        }
        private void Admin_FormTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadData(this.taikhoanlist);
        }
        private void NhanVien_FormTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhanVien_FormSuaTaiKhoan formSuaTK = new NhanVien_FormSuaTaiKhoan();
            formSuaTK.ShowDialog();
        }
    }
}
