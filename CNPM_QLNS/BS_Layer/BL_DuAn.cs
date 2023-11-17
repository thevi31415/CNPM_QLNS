using CNPM_QLNS.Class;
using CNPM_QLNS.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_QLNS.BS_Layer
{
	public class BL_DuAn
	{
		DBMain db = null;
		public BL_DuAn()
		{
			db = new DBMain();
		}
		public bool ThemDuAn(DuAn da)
		{
			db.OpenConnect();
			SqlCommand cmd = new SqlCommand("EXEC Proc_ThemDuAn @MaDA, @TenDA, @GiaTri, @NgayBatDau, @TrangThai ", db.OpenConnect());
			cmd.Parameters.AddWithValue("@MaDA", da.MaDa);
			cmd.Parameters.AddWithValue("@TenDA", da.TenDa);
			cmd.Parameters.AddWithValue("@GiaTri", da.GiaTri);
			cmd.Parameters.AddWithValue("@NgayBatDau", da.NgayBatDau);
			cmd.Parameters.AddWithValue("@TrangThai", da.TrangThai);
			int rowsAffected = cmd.ExecuteNonQuery();
			db.CloseConnect();
			return rowsAffected > 0;
		}

		public bool XoaDuAn(DuAn da)
		{
			db.OpenConnect();
			SqlCommand cmd = new SqlCommand("EXEC Proc_XoaDuAn @MaDA", db.OpenConnect());
			cmd.Parameters.AddWithValue("@MaDA", da.MaDa);
			int rowsAffected = cmd.ExecuteNonQuery();
			db.CloseConnect();
			return rowsAffected > 0;
		}
		public List<DuAn> LayDuAn()
		{
			List<DuAn> danhsachDuAn = new List<DuAn>();

			string query = "SELECT * FROM DUAN";

			DataSet result = db.ExecuteQueryDataSet(query, CommandType.Text, null);

			if (result != null && result.Tables.Count > 0)
			{
				foreach (DataRow row in result.Tables[0].Rows)
				{
					DuAn Da = new DuAn
					{
						MaDa = row["MaDA"].ToString(),
						TenDa = row["TenDA"].ToString().Trim(),
						GiaTri = row["GiaTri"].ToString(), 
						NgayBatDau = (DateTime)row["NgayBatDau"],
						TrangThai = row["TrangThai"].ToString()
					};

					danhsachDuAn.Add(Da);
				}
			}
			return danhsachDuAn;

		}
		public bool CapNhatTrangThaiDuAn(DuAn da)
		{
			db.OpenConnect();
			SqlCommand cmd = new SqlCommand("EXEC Proc_CapNhatTrangThaiDuAn @MaDA, @TrangThai", db.OpenConnect());
			cmd.Parameters.AddWithValue("@MaDA", da.MaDa);
			cmd.Parameters.AddWithValue("@TrangThai", da.TrangThai);
			int rowsAffected = cmd.ExecuteNonQuery();
			db.CloseConnect();
			return rowsAffected > 0;
		}
		public DataTable layMaNV()
		{
			DataSet ds = new DataSet();
			ds = db.ExecuteQueryDataSet("SELECT MaNV FROM NHANVIEN", CommandType.Text, null);
			return ds.Tables[0];
		}
		public DataTable layMaDA()
		{
			DataSet ds = new DataSet();
			ds = db.ExecuteQueryDataSet("SELECT MaDA FROM DUAN", CommandType.Text, null);
			return ds.Tables[0];
		}
	}
}
