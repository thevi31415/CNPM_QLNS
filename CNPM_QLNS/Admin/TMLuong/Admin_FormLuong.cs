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
        public List<Luong> luongListloc = new List<Luong>();
        public List<NhanVien> ketquatimkiemnv = new List<NhanVien>();
        BL_Luong luong = new BL_Luong();
        BL_TimKiem timKiem = new BL_TimKiem();
        public Admin_FormMain formmain;
        int check = 0;
        public Admin_FormLuong(Admin_FormMain formMain)
        {
            InitializeComponent();
            dtpHienThiLuong.Format = DateTimePickerFormat.Custom;
            dtpHienThiLuong.CustomFormat = "MM/yyyy";
            this.formmain = formMain;
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
                   Item_Luong item_luong = new Item_Luong(luong, formmain, 1); // Pass the reference
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

        private void dtpHienThiLuong_CloseUp(object sender, EventArgs e)
        {
            dtpHienThiLuong.Value = new DateTime(dtpHienThiLuong.Value.Year, dtpHienThiLuong.Value.Month, 1);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            luongListloc = luong.LayLuongTheoThangNam(dtpHienThiLuong.Value.Month, dtpHienThiLuong.Value.Year);
            LoadData(luongListloc);
           
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            Admin_FormTinhLuong formtinhluong = new Admin_FormTinhLuong(this.formmain);
            formtinhluong.ShowDialog(this);

        }

        private void btnReportLuong_Click(object sender, EventArgs e)
        {
            Admin_FormReportLuong admin_FormReportLuong = new Admin_FormReportLuong();
            admin_FormReportLuong.ShowDialog(this);
        }
    }
}
