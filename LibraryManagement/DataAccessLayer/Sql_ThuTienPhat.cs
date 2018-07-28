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
    public class Sql_ThuTienPhat
    {
        public static void ThuTienPhat(En_ThuTienPhat s)
        {
            SqlConnection conn = sqlConnectionData.KetNoi();
            SqlCommand cmd = new SqlCommand("PHIEUTHUTIENPHAT_insert", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaPTT", SqlDbType.Char, 5);
            cmd.Parameters.Add("@MaThe", SqlDbType.Char, 5);
            cmd.Parameters.Add("@SoTienThu", SqlDbType.Int);
            cmd.Parameters.Add("@ConLai", SqlDbType.Int);
            cmd.Parameters.Add("@NgayThu", SqlDbType.SmallDateTime);

            cmd.Parameters["@MaPTT"].Value = s.MaPTT;
            cmd.Parameters["@MaThe"].Value = s.MaDG;
            cmd.Parameters["@SoTienThu"].Value = s.SoTienThu;
            cmd.Parameters["@ConLai"].Value = s.ConLai;
            cmd.Parameters["@NgayThu"].Value = s.NgayThu;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static DataTable TimHoTen_TienNo(string maThe)
        {
            return Sql_TimTV.TraCuuTV(maThe);
        }
    }
}
