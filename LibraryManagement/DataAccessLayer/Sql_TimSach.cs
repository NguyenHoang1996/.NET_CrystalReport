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
    public class Sql_TimSach
    {
        public static DataTable TimSach(string key)
        {
            SqlConnection conn = sqlConnectionData.KetNoi();
            SqlCommand cmd = new SqlCommand("TIMSACH", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Key", SqlDbType.NVarChar, 100);
            cmd.Parameters["@Key"].Value = key;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            return dt;
        }

        public static DataTable TraCuuSach(string maSach)
        {
            SqlConnection conn = sqlConnectionData.KetNoi();
            SqlCommand cmd = new SqlCommand("TRACUUSACH", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaSach", SqlDbType.Char, 5);
            cmd.Parameters["@MaSach"].Value = maSach;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            return dt;
        }

        public static void CapNhatSach(En_NhanSach sach)
        {
            SqlConnection conn = sqlConnectionData.KetNoi();
            SqlCommand cmd = new SqlCommand("CAPNHATSACH", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaSach", SqlDbType.Char, 5);
            cmd.Parameters.Add("@TenSach", SqlDbType.NVarChar, 200);
            cmd.Parameters.Add("@TheLoai", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@TacGia", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@NhaXB", SqlDbType.NVarChar, 200);
            cmd.Parameters.Add("@NXB", SqlDbType.NVarChar, 20);
            cmd.Parameters.Add("@TriGia", SqlDbType.Int, 5);
            cmd.Parameters.Add("@NgayNhap", SqlDbType.SmallDateTime);
            cmd.Parameters.Add("@SoLuong", SqlDbType.NVarChar, 20);

            cmd.Parameters["@MaSach"].Value = sach.MaSach;
            cmd.Parameters["@TenSach"].Value = sach.TenSach;
            cmd.Parameters["@TheLoai"].Value = sach.TheLoai;
            cmd.Parameters["@TacGia"].Value = sach.TacGia;
            cmd.Parameters["@NhaXB"].Value = sach.NhaXB;
            cmd.Parameters["@NXB"].Value = sach.NXB.ToString();
            cmd.Parameters["@TriGia"].Value = sach.TriGia;
            cmd.Parameters["@NgayNhap"].Value = sach.NgayNhap;
            cmd.Parameters["@SoLuong"].Value = sach.SoLuong.ToString();

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public static bool XoaSach(string maSach)
        {
            bool canDelete = true;
            SqlConnection conn = sqlConnectionData.KetNoi();
            SqlCommand cmd = new SqlCommand("XOASACH", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaSach", SqlDbType.Char, 5);

            cmd.Parameters["@MaSach"].Value = maSach;
          
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception)
            {
                canDelete = false;  
            }
            conn.Close();
            return canDelete;
        }
    }
}
