using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ValueObject;

namespace DataAccessLayer
{
    public class sqlConnectionData
    {
        public static SqlConnection KetNoi()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-QGD8DGD;Initial Catalog=QLTHUVIEN;Integrated Security=True");
            return conn;
        }
    }

    public class Sql_LapThe
    {
        public static void ThemTheDocGia(En_LapThe tdg)
        {
            SqlConnection conn = sqlConnectionData.KetNoi();
            SqlCommand cmd = new SqlCommand("THEDOCGIA_Insert", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaThe", SqlDbType.Char, 5);
            cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 100);
            cmd.Parameters.Add("@LoaiDocGia", SqlDbType.NVarChar, 1);
            cmd.Parameters.Add("@NgaySinh", SqlDbType.SmallDateTime);
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 200);
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 20);
            cmd.Parameters.Add("@NgayLapThe", SqlDbType.SmallDateTime);
            cmd.Parameters.Add("@TaiKhoanNo", SqlDbType.Int);

            cmd.Parameters["@MaThe"].Value = tdg.MaThe;
            cmd.Parameters["@HoTen"].Value = tdg.HoTen;
            cmd.Parameters["@LoaiDocGia"].Value = tdg.LoaiDocGia;
            cmd.Parameters["@NgaySinh"].Value = tdg.NgaySinh;
            cmd.Parameters["@DiaChi"].Value = tdg.DiaChi;
            cmd.Parameters["@Email"].Value = tdg.Email;
            cmd.Parameters["@NgayLapThe"].Value = tdg.NgayLapThe;
            cmd.Parameters["@TaiKhoanNo"].Value = tdg.TaiKhoanNo;

            

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static DataTable ChonThe()
        {
            SqlConnection conn = sqlConnectionData.KetNoi();
            SqlCommand cmd = new SqlCommand("THEDOCGIA_Select", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "TheDocGia");
            return ds.Tables[0];
        }
    }
}
