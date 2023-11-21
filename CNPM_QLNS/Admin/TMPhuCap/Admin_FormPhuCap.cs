using CNPM_QLNS.Admin.PhuCap;
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

namespace CNPM_QLNS.Admin
{
    public partial class Admin_FormPhuCap : Form
    {
        List<PhuCapNV> loaiphucap = new List<PhuCapNV>(); 
        List<PhuCapNhanVien> phucapchonv = new List<PhuCapNhanVien>();
        BL_PhuCap blpc = new BL_PhuCap();
        BL_PhuCapChoNhanVien blpcchonv = new BL_PhuCapChoNhanVien();
        public Admin_FormMain formMain;
        public Admin_FormPhuCap(Admin_FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
            LoadDataHoanThanh();
            LoadDataHoanThanh2();
        }

        private void Admin_FormPhuCap_Load(object sender, EventArgs e)
        {

        }
        public void LoadDataHoanThanh()
        {

            panelLoaiPhuCap.Controls.Clear();
            loaiphucap= blpc.LayDanhSachTatCaPhuCap();
            //  nvList = nv.LayNhanVien();
            panelLoaiPhuCap.Padding = new Padding(10, 0, 10, 0); ;
            if (loaiphucap.Count > 0)
            {
                //  MessageBox.Show(nhanVienList.Count().ToString());
                foreach (PhuCapNV phucap in loaiphucap)
                {
                    Item_LoaiPhuCap item_duan = new Item_LoaiPhuCap(phucap, this.formMain) ; // Pass the reference
                    item_duan.TopLevel = false;
                    panelLoaiPhuCap.Controls.Add(item_duan);
                    item_duan.Show();
                }
            }
            else
            {
                MessageBox.Show("Khong tim thay du an nao =)))");
            }


        }
        public void LoadDataHoanThanh2()
        {

            panelPhuCapNhanVien.Controls.Clear();
           
            phucapchonv = blpcchonv.LayDanhSachTatCaPhuCapNhanVien();
          
            //  nvList = nv.LayNhanVien();
           panelPhuCapNhanVien.Padding = new Padding(10, 0, 10, 0); ;
            if (phucapchonv.Count > 0)
            {
                //  MessageBox.Show(nhanVienList.Count().ToString());
                foreach (PhuCapNhanVien phucapnv in phucapchonv)
                {
                    Item_PhuCapChoNhanVien item_duan = new Item_PhuCapChoNhanVien(this.formMain, phucapnv); // Pass the reference
                    item_duan.TopLevel = false;
                   panelPhuCapNhanVien.Controls.Add(item_duan);
                    item_duan.Show();
                }
              //  MessageBox.Show("XYX" + phucapchonv.Count().ToString());
            }
            else
            {
                MessageBox.Show("Khong tim thay du an nao =)))");
            }


        }

        private void btnThemPhuCap_Click(object sender, EventArgs e)
        {
            Admin_FormThemPhuCap frphucap = new Admin_FormThemPhuCap(formMain);
            frphucap.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_FormThemPhuCapChoNhanVien fr = new Admin_FormThemPhuCapChoNhanVien(formMain); 
            fr.ShowDialog();
        }

        private void panelPhuCapNhanVien_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
