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
    public partial class Admin_FormDuAn : Form
    {
        BL_DuAn blda = new BL_DuAn();
        List<DuAn> dahoanthanhlist = new List<DuAn>();
        List<DuAn> dadangthuchienlist = new List<DuAn>();
        List<DuAn> dachuakhoicong = new List<DuAn>();
        List<DuAn> tatcaduan = new List<DuAn>();
        public Admin_FormMain formmain;
        public Admin_FormDuAn(Admin_FormMain formmain)
        {
            InitializeComponent();
            tatcaduan = blda.LayDuAn();
            dahoanthanhlist = blda.LayDuAnTheoTrangThai(2);
            dadangthuchienlist = blda.LayDuAnTheoTrangThai(1);
            dachuakhoicong = blda.LayDuAnTheoTrangThai(0);
         //   lblSLDaHoanThanh.Text = dahoanthanhlist.Count.ToString();

            lblSLDaHoanThanh.Text = dadangthuchienlist.Count.ToString();
            lblSLDangThucHien.Text = dadangthuchienlist.Count.ToString();
            lblSLChuaHoanThanh.Text = dachuakhoicong.Count.ToString();
            LoadDataHoanThanh();
        }
        public void LoadDataHoanThanh()
        {

            flowLayoutPanelDA.Controls.Clear();
            dahoanthanhlist = blda.LayDuAn();
            //  nvList = nv.LayNhanVien();
            flowLayoutPanelDA.Padding = new Padding(10, 0, 10, 0); ;
            if (dahoanthanhlist.Count > 0)
            {
                //  MessageBox.Show(nhanVienList.Count().ToString());
                foreach (DuAn duan in dahoanthanhlist)
                {
                    Item_DuAn item_duan = new Item_DuAn(duan, this.formmain); // Pass the reference
                    item_duan.TopLevel = false;
                    flowLayoutPanelDA.Controls.Add(item_duan);
                    item_duan.Show();
                }
            }
            else
            {
                MessageBox.Show("Khong tim thay nhan vien nao =)))");
            }


        }
        private void Admin_FormDuAn_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblSLDangThucHien_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
