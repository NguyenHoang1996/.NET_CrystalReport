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
    public class Sql_TimTV
    {
        public static DataTable TimTV(string key)
        {
            SqlConnection conn = sqlConnectionData.KetNoi();
            SqlCommand cmd = new SqlCommand("THEDOCGIA_Timkiem", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Key", SqlDbType.NVarChar, 100);
            cmd.Parameters["@Key"].Value = key;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            return dt;
        }

        public static DataTable TraCuuTV(string maThe)
        {
            SqlConnection conn = sqlConnectionData.KetNoi();
            SqlCommand cmd = new SqlCommand("THEDOCGIA_Tracuu", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaThe", SqlDbType.Char, 5);
            cmd.Parameters["@MaThe"].Value = maThe;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            return dt;
        }

        public static void CapNhatTV(En_LapThe dg)
        {
            SqlConnection conn = sqlConnectionData.KetNoi();
            SqlCommand cmd = new SqlCommand("THEDOCGIA_Update", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaThe", SqlDbType.Char, 5);
            cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 100);
            cmd.Parameters.Add("@LoaiDocGia", SqlDbType.NVarChar);
            cmd.Parameters.Add("@NgaySinh", SqlDbType.SmallDateTime);
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 200);
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 20);
            cmd.Parameters.Add("@NgayLapThe", SqlDbType.SmallDateTime);
            cmd.Parameters.Add("@TaikhoanNo", SqlDbType.Money);


            cmd.Parameters["@MaThe"].Value = dg.MaThe;
            cmd.Parameters["@HoTen"].Value = dg.HoTen;
            cmd.Parameters["@LoaiDocGia"].Value = dg.LoaiDocGia;
            cmd.Parameters["@NgaySinh"].Value = dg.NgaySinh;
            cmd.Parameters["@DiaChi"].Value = dg.DiaChi;
            cmd.Parameters["@Email"].Value = dg.Email;
            cmd.Parameters["@NgayLapThe"].Value = dg.NgayLapThe;
            cmd.Parameters["@TaikhoanNo"].Value = dg.TaiKhoanNo;


            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public static bool XoaTV(string maThe)
        {
            bool canDelete = true;
            SqlConnection conn = sqlConnectionData.KetNoi();
            SqlCommand cmd = new SqlCommand("THEDOCGIA_Delete", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaThe", SqlDbType.Char, 5);

            cmd.Parameters["@MaThe"].Value = maThe;

            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                canDelete = false;
            }
            conn.Close();
            return canDelete;
        }
    }
}
