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
    public class Sql_CaiDat
    {
        public static void CaiDat_insert(En_CaiDat s)
        {
            SqlConnection conn = sqlConnectionData.KetNoi();
            SqlCommand cmd = new SqlCommand("CAIDAT_INSERT", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@STT", SqlDbType.Int);
            cmd.Parameters.Add("@DoTuoiToiThieu", SqlDbType.Int);
            cmd.Parameters.Add("@DoTuoiToiDa", SqlDbType.Int);
            cmd.Parameters.Add("@ThoiHanThe", SqlDbType.Int);
            cmd.Parameters.Add("@KhoangCachNamXB", SqlDbType.Int);
            cmd.Parameters.Add("@SachMuonToiDa", SqlDbType.Int);
            cmd.Parameters.Add("@SoNgayMuonToiDa", SqlDbType.Int);
            cmd.Parameters.Add("@SoTienNoToiDa", SqlDbType.Int);
            cmd.Parameters.Add("@NgaySuaDoi", SqlDbType.SmallDateTime);

            cmd.Parameters["@STT"].Value = s.STT;
            cmd.Parameters["@DoTuoiToiThieu"].Value = s.DoTuoiToiThieu;
            cmd.Parameters["@DoTuoiToiDa"].Value = s.DoTuoiToiDa;
            cmd.Parameters["@ThoiHanThe"].Value = s.ThoiHanThe;
            cmd.Parameters["@KhoangCachNamXB"].Value = s.KhoangCachNamXB;
            cmd.Parameters["@SachMuonToiDa"].Value = s.SachMuonToiDa;
            cmd.Parameters["@SoNgayMuonToiDa"].Value = s.SoNgayMuonToiDa;
            cmd.Parameters["@SoTienNoToiDa"].Value = s.SoTienNoToiDa;
            cmd.Parameters["@NgaySuaDoi"].Value = s.NgaySuaDoi;
           

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static DataTable CaiDat_select()
        {
            SqlConnection conn = sqlConnectionData.KetNoi();
            SqlCommand cmd = new SqlCommand("CAIDAT_SELECT", conn);
            cmd.CommandType = CommandType.StoredProcedure;
           
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            return dt;
        }
    }
}
