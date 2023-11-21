using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_QLNS.Admin.KyLuat
{
    public partial class Admin_FormKyLuat : Form
    {
        public Admin_FormMain formain;
        public Admin_FormKyLuat(Admin_FormMain formMain)
        {
            InitializeComponent();
            this.formain = formMain;
        }

        private void Admin_FormKyLuat_Load(object sender, EventArgs e)
        {

        }
    }
}
