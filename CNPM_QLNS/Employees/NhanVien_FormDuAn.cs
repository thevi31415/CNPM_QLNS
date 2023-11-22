using System;
using CNPM_QLNS.BS_Layer;
using CNPM_QLNS.Class;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNPM_QLNS.Item;

namespace CNPM_QLNS.Employees
{
    public partial class NhanVien_FormDuAn : Form
    {
        public NhanVien nv;
        public List<DuAn> lisdathamgia = new List<DuAn>();
        BL_DuAn blda = new BL_DuAn();
        public NhanVien_FormDuAn(NhanVien nv)
        {
            InitializeComponent();
            this.nv = nv;
            lisdathamgia = blda.LayDuAnTheoNhanVien(nv.MaNV);
            int daht = 0;
            int dangth = 0;
            int chukhoicong = 0;
            foreach (DuAn duAn in lisdathamgia)
            {
               if(duAn.TrangThai == 0)
                {
                    chukhoicong++;
                }
               if(duAn.TrangThai == 1)
                {
                    dangth++;
                }
               if(duAn.TrangThai== 2)
                {
                    daht++;
                }
            }
            lblSLChuaHoanThanh.Text = chukhoicong.ToString();
            lblSLDaHoanThanh.Text=daht.ToString();
            lblSLDangThucHien.Text = dangth.ToString();
            LoadDataHoanThanh();
        }
        public void LoadDataHoanThanh()
        {

            flowLayoutPanelDA.Controls.Clear();
            lisdathamgia = blda.LayDuAnTheoNhanVien(nv.MaNV);
            //  nvList = nv.LayNhanVien();
            flowLayoutPanelDA.Padding = new Padding(10, 0, 10, 0); ;
            if (lisdathamgia.Count > 0)
            {
                //  MessageBox.Show(nhanVienList.Count().ToString());
                foreach (DuAn duan in lisdathamgia)
                {
                    Item_DuAn item_duan = new Item_DuAn(duan, null, 0) ; // Pass the reference
                    item_duan.TopLevel = false;
                    flowLayoutPanelDA.Controls.Add(item_duan);
                    item_duan.Show();
                }
            }
            else
            {
               // MessageBox.Show("Khong tim thay du an nao =)))");
            }


        }
        private void NhanVien_FormDuAn_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(lisdathamgia.Count().ToString());
        }
    }
}
