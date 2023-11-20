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
    public partial class NhanVien_FormPhuCap : Form
    {
        public NhanVien nv;
        List<PhuCapNhanVien> phucapchonv = new List<PhuCapNhanVien>();
        BL_PhuCapChoNhanVien blpcchonv = new BL_PhuCapChoNhanVien();

        public NhanVien_FormPhuCap(NhanVien nv)
        {
            InitializeComponent();
            this.nv = nv;
            LoadDataHoanThanh2();
        }
        public void LoadDataHoanThanh2()
        {

            panelPhuCapNhanVien.Controls.Clear();

            phucapchonv = blpcchonv.LayDanhSachPhuCapNhanVienTheoMaNV(nv.MaNV);

            //  nvList = nv.LayNhanVien();
            panelPhuCapNhanVien.Padding = new Padding(10, 0, 10, 0); ;
            if (phucapchonv.Count > 0)
            {
                //  MessageBox.Show(nhanVienList.Count().ToString());
                foreach (PhuCapNhanVien phucapnv in phucapchonv)
                {
                    Item_PhuCapChoNhanVien item_duan = new Item_PhuCapChoNhanVien(null, phucapnv); // Pass the reference
                    item_duan.TopLevel = false;
                    panelPhuCapNhanVien.Controls.Add(item_duan);
                    item_duan.Show();
                }
                //  MessageBox.Show("XYX" + phucapchonv.Count().ToString());
            }
            else
            {
                MessageBox.Show("Khong tim thay phu cap nao =)))");
            }


        }
        private void NhanVien_FormPhuCap_Load(object sender, EventArgs e)
        {

        }
    }
}
