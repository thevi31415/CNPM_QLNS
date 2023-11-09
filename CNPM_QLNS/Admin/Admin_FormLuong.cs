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
    public partial class Admin_FormLuong : Form
    {
        public List<Luong> luongList = new List<Luong>();
        public List<NhanVien> ketquatimkiemnv = new List<NhanVien>();
        BL_Luong luong = new BL_Luong();
        BL_TimKiem timKiem = new BL_TimKiem();
        public Admin_FormMain formmain;
        int check = 0;
        public Admin_FormLuong()
        {
            InitializeComponent();
        }
        public void LoadData(List<Luong> luongList)
        {

            panelListLuong.Controls.Clear();
            this.luongList = luong.LayLuong();
            //  nvList = nv.LayNhanVien();
             panelListLuong.Padding = new Padding(10, 0, 10, 0); ;
            if (luongList.Count > 0)
            {
                //  MessageBox.Show(nhanVienList.Count().ToString());
                foreach (Luong luong in luongList)
                {
                   Item_Luong item_luong = new Item_Luong(luong, formmain); // Pass the reference
                   item_luong.TopLevel = false;
                   panelListLuong.Controls.Add(item_luong);
                   item_luong.Show();
                }
            }
            else
            {
                MessageBox.Show("Khong tim thay nhan vien nao =)))");
            }


        }

        private void Admin_FormLuong_Load(object sender, EventArgs e)
        {
            this.luongList = luong.LayLuong();
            LoadData(luongList);
        }
    }
}
