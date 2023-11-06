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
    public partial class Admin_FormTaiKhoan : Form
    {
        public List<TaiKhoan> taikhoanlist;
        BL_TaiKhoan tk = new BL_TaiKhoan();
        public Admin_FormMain formain;
        public Admin_FormTaiKhoan(Admin_FormMain formmain)
        {
            InitializeComponent();
            this.formain = formmain;
            this.taikhoanlist = tk.LayTaiKhoan();
        }
        public void LoadData(List<TaiKhoan> tkList)
        {

            panelListTaiKhoan.Controls.Clear();
          
            //  nvList = nv.LayNhanVien();
            panelListTaiKhoan.Padding = new Padding(10, 0, 10, 0);
           // MessageBox.Show(taikhoanlist.Count().ToString());
            if (taikhoanlist.Count > 0)
            {
                //  MessageBox.Show(nhanVienList.Count().ToString());
                foreach (TaiKhoan taikhoan in taikhoanlist)
                {
                    Item_TaiKhoan item_taikhoan = new Item_TaiKhoan(formain, taikhoan); // Pass the reference
                    item_taikhoan.TopLevel = false;
                    panelListTaiKhoan.Controls.Add(item_taikhoan);
                    item_taikhoan.Show();
                }
            }
            else
            {
                MessageBox.Show("Khong tim thay nhan vien nao =)))");
            }


        }
        private void Admin_FormTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadData(this.taikhoanlist);
        }
    }
}
