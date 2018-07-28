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
    public class Sql_TraSach
    {
        public static void TraSach(En_TraSach s)
        {
            SqlConnection conn = sqlConnectionData.KetNoi();
            SqlCommand cmd = new SqlCommand("TraSach_insert", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaPT", SqlDbType.Char, 5);
            cmd.Parameters.Add("@MaPM", SqlDbType.Char, 5);
            cmd.Parameters.Add("@SoNgayMuon", SqlDbType.Int);
            cmd.Parameters.Add("@SoNgayTre", SqlDbType.Int);
            cmd.Parameters.Add("@TienPhat", SqlDbType.Int);
            cmd.Parameters.Add("@NgayTra", SqlDbType.SmallDateTime);

            cmd.Parameters["@MaPT"].Value = s.MaPT;
            cmd.Parameters["@MaPM"].Value = s.MaPM;
            cmd.Parameters["@SoNgayMuon"].Value = s.SoNgayMuon;
            cmd.Parameters["@SoNgayTre"].Value = s.SoNgayTre;
            cmd.Parameters["@TienPhat"].Value = s.TienPhat;
            cmd.Parameters["@NgayTra"].Value = s.NgayTra;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static int LayTienNo(String MaThe)
        {
            DataTable dt = Sql_TimTV.TraCuuTV(MaThe);
            int tienNo = 0;
            if (dt.Rows.Count > 0)
                tienNo = int.Parse(dt.Rows[0][7].ToString());
            return tienNo;
        }

        public static DataTable ThongTinSachMuon(string MaThe)
        {
            SqlConnection conn = sqlConnectionData.KetNoi();
            SqlCommand cmd = new SqlCommand("ThongTinSachDaMuon", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaThe", SqlDbType.Char, 5);
            cmd.Parameters["@MaThe"].Value = MaThe;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            return dt;
        }

        public static void TaiKhoanNo_update(string maThe, string money)
        {
            SqlConnection conn = sqlConnectionData.KetNoi();
            SqlCommand cmd = new SqlCommand("TAIKHOANNO_UPDATE", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaThe", SqlDbType.Char, 5);
            cmd.Parameters.Add("@TaiKhoanNo", SqlDbType.Money);

            cmd.Parameters["@MaThe"].Value = maThe;
            cmd.Parameters["@TaiKhoanNo"].Value = int.Parse(money);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void Tang_SLSACH(string maSach)
        {
            SqlConnection conn = sqlConnectionData.KetNoi();
            SqlCommand cmd = new SqlCommand("TANGSOLUONGSACH", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaSach", SqlDbType.Char, 5);

            cmd.Parameters["@MaSach"].Value = maSach;
            
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
