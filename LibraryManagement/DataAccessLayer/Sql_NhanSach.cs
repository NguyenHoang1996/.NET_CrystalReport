using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Sql_NhanSach
    {
        public static void ThemSach(En_NhanSach s)
        {
            SqlConnection conn = sqlConnectionData.KetNoi();
            SqlCommand cmd = new SqlCommand("SACH_Insert", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaSach", SqlDbType.Char, 5);
            cmd.Parameters.Add("@TenSach", SqlDbType.NVarChar, 200);
            cmd.Parameters.Add("@TheLoai", SqlDbType.NVarChar, 1);
            cmd.Parameters.Add("@TacGia", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@NhaXB", SqlDbType.NVarChar, 200);
            cmd.Parameters.Add("@NXB", SqlDbType.Int);
            cmd.Parameters.Add("@TriGia", SqlDbType.Int);
            cmd.Parameters.Add("@NgayNhap", SqlDbType.SmallDateTime);
            cmd.Parameters.Add("@TinhTrang", SqlDbType.NVarChar);
            cmd.Parameters["@MaSach"].Value = s.MaSach;
            cmd.Parameters["@TenSach"].Value = s.TenSach;
            cmd.Parameters["@TheLoai"].Value = s.TheLoai;
            cmd.Parameters["@TacGia"].Value = s.TacGia;
            cmd.Parameters["@NhaXB"].Value = s.NhaXB;
            cmd.Parameters["@NXB"].Value = s.NXB;
            cmd.Parameters["@TriGia"].Value = s.TriGia;
            cmd.Parameters["@NgayNhap"].Value = s.NgayNhap;
            cmd.Parameters["@TinhTrang"].Value = s.SoLuong;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
