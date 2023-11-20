using CNPM_QLNS.BS_Layer;
using CNPM_QLNS.Class;
using CNPM_QLNS.Employees.NV_Luong;
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
    public partial class NhanVien_FormLuong : Form
    {
        public NhanVien nv;
        public NhanVien_FormMain formmain;
        BL_Luong luong = new BL_Luong();
        public List<Luong> luongList = new List<Luong>();
        public List<Luong> filteredLuongList = new List<Luong>();
        public NhanVien_FormLuong(NhanVien nv,  NhanVien_FormMain formmain)
        {
            InitializeComponent();
            this.nv = nv;
            this.formmain = formmain;
            this.dtpHienThiLuong.Format = DateTimePickerFormat.Custom;
            this.dtpHienThiLuong.CustomFormat = "MM/yyyy";
        }
        public void LoadData(List<Luong> luongList)
        {

            panelListLuong.Controls.Clear();
            this.luongList = luong.LayLuongTheoMaNV(this.nv.MaNV);
            //  nvList = nv.LayNhanVien();
            panelListLuong.Padding = new Padding(10, 0, 10, 0); ;
            if (luongList.Count > 0)
            {
                //  MessageBox.Show(nhanVienList.Count().ToString());
                foreach (Luong luong in luongList)
                {
                    Item_Luong item_luong = new Item_Luong(luong, null, 0); // Pass the reference
                    item_luong.TopLevel = false;
                    panelListLuong.Controls.Add(item_luong);
                    item_luong.Show();
                }
            }
            else
            {
                MessageBox.Show("Khong tim thay nhan vien nao");
            }


        }
        private void NhanVien_FormLuong_Load(object sender, EventArgs e)
        {
            this.Width = 1200;
            this.Height = 700;
            this.luongList = luong.LayLuongTheoMaNV(nv.MaNV);
            LoadData(luongList);
        }

        private void dtpHienThiLuong_CloseUp(object sender, EventArgs e)
        {
            this.dtpHienThiLuong.Value = new DateTime(dtpHienThiLuong.Value.Year, dtpHienThiLuong.Value.Month, 1);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            this.Width = 1000;
            this.Height = 700;
            this.filteredLuongList = luong.LayLuong1NVTheoThangNam(this.nv.MaNV, this.dtpHienThiLuong.Value.Month, this.dtpHienThiLuong.Value.Year);
            LoadData(filteredLuongList);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Width = 1000;
            this.Height = 700;
            LoadData(luongList);
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            NhanVien_FormTinhLuong nv_formTinhLuong = new NhanVien_FormTinhLuong(nv, formmain);
            nv_formTinhLuong.ShowDialog();
        }
    }
}
