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
    public partial class Admin_FormNhanVien : Form
    {
        public List<NhanVien> nhanVienList = new List<NhanVien>();
        BL_NhanVien nv = new BL_NhanVien();
        public Admin_FormNhanVien()
        {
            InitializeComponent();
       

        }
        public void LoadData()
        {
            this.nhanVienList = nv.GetNhanViensFromDatabase();
            panelListNhanVien.Padding = new Padding(10, 0, 10, 0); ;
            if(nhanVienList.Count > 0)
            {
                // MessageBox.Show(nhanVienList.Count().ToString());
                foreach (NhanVien nhanVien in nhanVienList)
                {
                    Item_NhanVien item_nhanvien = new Item_NhanVien(nhanVien); // Pass the reference
                    item_nhanvien.TopLevel = false;
                    panelListNhanVien.Controls.Add(item_nhanvien);
                    item_nhanvien.Show();
                }
            }
            else
            {
                MessageBox.Show("Khong tim thay nhan vien nao =)))");
            }
          

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_FormNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
