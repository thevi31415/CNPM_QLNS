using CNPM_QLNS.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_QLNS.Item
{
    public partial class Item_LoaiKyLuat : Form
    {

        public KyLuatNV kyluat;
        public Admin_FormMain formain;
        public Item_LoaiKyLuat(KyLuatNV kyluat, Admin_FormMain formMain)
        {
            InitializeComponent();
            this.kyluat = kyluat;
            this.formain = formMain;    
        }

        private void Item_LoaiKyLuat_Load(object sender, EventArgs e)
        {

        }
    }
}
