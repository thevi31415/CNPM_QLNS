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
    public partial class NhanVien_FormKyLuat : Form
    {
        BL_KyLuatMotNhanVien blktmotnv = new BL_KyLuatMotNhanVien();
        List<KyLuatChoNhanVien> listkylyluat = new List<KyLuatChoNhanVien>();
        public NhanVien nv;
        public NhanVien_FormKyLuat(NhanVien nv)
        {
            InitializeComponent();
            this.nv = nv;
            LoadDataHoanThanh2();
        }
        public void LoadDataHoanThanh2()
        {

            panelKyLuatNhanVien.Controls.Clear();

            listkylyluat = blktmotnv.LayKyLuatTheoMaNV(nv.MaNV);

            //  nvList = nv.LayNhanVien();
           panelKyLuatNhanVien.Padding = new Padding(10, 0, 10, 0); ;
            if (listkylyluat.Count > 0)
            {
                //  MessageBox.Show(nhanVienList.Count().ToString());
                foreach (KyLuatChoNhanVien kyluat in listkylyluat)
                {
                   Item_KyLuatMotNhanVien item_duan = new Item_KyLuatMotNhanVien(null, kyluat); // Pass the reference
                    item_duan.TopLevel = false;
                    panelKyLuatNhanVien.Controls.Add(item_duan);
                    item_duan.Show();
                }
                //  MessageBox.Show("XYX" + phucapchonv.Count().ToString());
            }
            else
            {
                // MessageBox.Show("Khong tim thay phu cap nao =)))");
            }


        }
        private void NhanVien_FormKyLuat_Load(object sender, EventArgs e)
        {

        }
    }
}
