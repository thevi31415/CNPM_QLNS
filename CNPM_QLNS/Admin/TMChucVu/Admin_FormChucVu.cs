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
    public partial class Admin_FormChucVu : Form
    {

        BL_ChucVu blcv = new BL_ChucVu();

        public List<ChucVuNV> chucVuList = new List<ChucVuNV>();
        public Admin_FormMain formMain;
        public Admin_FormChucVu(Admin_FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
            LoadData(chucVuList);
        }
        public void LoadData(List<ChucVuNV> chucvuList)
        {

            flowLayoutPanelCV.Controls.Clear();
            this.chucVuList= blcv.LayDanhSachTatCaChucVu();
            //  nvList = nv.LayNhanVien();
            flowLayoutPanelCV.Padding = new Padding(10, 0, 10, 0); ;
            if (chucVuList.Count > 0)
            {
                //  MessageBox.Show(nhanVienList.Count().ToString());
                foreach (ChucVuNV cv in chucVuList)
                {
                    Item_ChucVu item_cv= new Item_ChucVu(cv, formMain); // Pass the reference
                    item_cv.TopLevel = false;
                    flowLayoutPanelCV.Controls.Add(item_cv);
                    item_cv.Show();
                }
            }
            else
            {
                MessageBox.Show("Khong tim thay nhan vien nao =)))");
            }


        }

        private void Admin_FormChucVu_Load(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Admin_FormThemChucVu themcv = new Admin_FormThemChucVu(formMain);
            themcv.ShowDialog();
        }

        private void flowLayoutPanelCV_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
