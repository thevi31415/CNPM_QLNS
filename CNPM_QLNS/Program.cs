﻿using CNPM_QLNS.Admin;
using CNPM_QLNS.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_QLNS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
  // Application.Run(new Admin_FormMain("NV01"));
// Application.Run(new NhanVien_FormMain("NV10"));
   Application.Run(new FormDangNhap());
        }
    }
}
