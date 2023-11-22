using CNPM_QLNS.Admin.TMKyLuat;
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

namespace CNPM_QLNS.Admin.KyLuat
{
    public partial class Admin_FormKyLuat : Form
    {
        public Admin_FormMain formain;
        BL_KyLuat blkl = new BL_KyLuat();
        BL_KyLuatMotNhanVien blklmotnv = new BL_KyLuatMotNhanVien();
        List<KyLuatNV> loaikyluat = new List<KyLuatNV>();
        List<KyLuatChoNhanVien> kyluatchonv = new List<KyLuatChoNhanVien>() ;
      
        public Admin_FormKyLuat(Admin_FormMain formMain)
        {
            InitializeComponent();
            this.formain = formMain;
            LoadDataHoanThanh();
            LoadDataHoanThanh2();
        }
        public void LoadDataHoanThanh()
        {

            panelLoaKyLuat.Controls.Clear();
            loaikyluat = blkl.LayDanhSachTatCaKyLuat();
            //  nvList = nv.LayNhanVien();
            panelLoaKyLuat.Padding = new Padding(10, 0, 10, 0); ;
            if (loaikyluat.Count > 0)
            {
                //  MessageBox.Show(nhanVienList.Count().ToString());
                foreach (KyLuatNV kyluat in loaikyluat)
                {
                    Item_LoaiKyLuat item_duan = new Item_LoaiKyLuat(kyluat, this.formain); // Pass the reference
                    item_duan.TopLevel = false;
                    panelLoaKyLuat.Controls.Add(item_duan);
                    item_duan.Show();
                }
            }
            else
            {
              //  MessageBox.Show("Khong tim thay du an nao =)))");
            }


        }
        public void LoadDataHoanThanh2()
        {

           panelKyLuatChoNhanVien.Controls.Clear();

           kyluatchonv = blklmotnv.LayDanhSachTatCaKyLuatNhanVien();

            //  nvList = nv.LayNhanVien();
            panelKyLuatChoNhanVien.Padding = new Padding(10, 0, 10, 0); ;
            if (kyluatchonv.Count > 0)
            {
                //  MessageBox.Show(nhanVienList.Count().ToString());
                foreach (KyLuatChoNhanVien kyluatnv in kyluatchonv)
                {
                   Item_KyLuatMotNhanVien item_duan = new Item_KyLuatMotNhanVien(this.formain, kyluatnv); // Pass the reference
                    item_duan.TopLevel = false;
                    panelKyLuatChoNhanVien.Controls.Add(item_duan);
                    item_duan.Show();
                }
                //  MessageBox.Show("XYX" + phucapchonv.Count().ToString());
            }
            else
            {
              //  MessageBox.Show("Khong tim thay du an nao =)))");
            }


        }
        private void Admin_FormKyLuat_Load(object sender, EventArgs e)
        {

        }

        private void btnThemKyLuat_Click(object sender, EventArgs e)
        {
            Admin_FormThemKyLuat themkl = new Admin_FormThemKyLuat(formain);
            themkl.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_FormThemKyLuatMotNhanVien thmklmotnv = new Admin_FormThemKyLuatMotNhanVien(formain);
            thmklmotnv.ShowDialog();
        }
    }
}
