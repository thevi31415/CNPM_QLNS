using CNPM_QLNS.Class;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_QLNS.BS_Layer
{
    public class BL_XuatExcel
    {
        public void ExportToExcel(List<NhanVien> nhanViens, string filePath)
        {
            // Tạo một FileInfo object từ đường dẫn file
            var file = new FileInfo(filePath);

            using (ExcelPackage package = new ExcelPackage(file))
            {
                // Tạo một sheet có tên "NhanVien"
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("NhanVien");

                // Tiêu đề cột
                worksheet.Cells[1, 1].Value = "MaNV";
                worksheet.Cells[1, 2].Value = "HoTen";
                worksheet.Cells[1, 3].Value = "CMND";
                worksheet.Cells[1, 4].Value = "GioiTinh";
                worksheet.Cells[1, 5].Value = "NgaySinh";
                worksheet.Cells[1, 6].Value = "QueQuan";
                worksheet.Cells[1, 7].Value = "TonGiao";
                worksheet.Cells[1, 8].Value = "DiaChi";
                worksheet.Cells[1, 9].Value = "TrangThai";
                // Thêm các tiêu đề cột khác ở đây...

                // Dữ liệu từ danh sách các nhân viên
                for (int i = 0; i < nhanViens.Count; i++)
                {
                    var nhanVien = nhanViens[i];
                    worksheet.Cells[i + 2, 1].Value = nhanVien.MaNV;
                    worksheet.Cells[i + 2, 2].Value = nhanVien.HoTen;
                    worksheet.Cells[i + 2, 3].Value = nhanVien.CMND;
                    worksheet.Cells[i + 2, 4].Value = nhanVien.GioiTinh;
                    worksheet.Cells[i + 2, 5].Value = nhanVien.NgaySinh.ToString("yyyy-MM-dd HH:mm:ss");
                    worksheet.Cells[i + 2, 6].Value = nhanVien.QueQuan;
                    worksheet.Cells[i + 2, 7].Value = nhanVien.TonGiao;
                    worksheet.Cells[i + 2, 8].Value = nhanVien.DiaChi;
                    worksheet.Cells[i + 2, 9].Value = nhanVien.TrangThai;
                    // Thêm dữ liệu các cột khác ở đây...
                }

                // Lưu file Excel
                package.Save();
            }
        }
    }

}
