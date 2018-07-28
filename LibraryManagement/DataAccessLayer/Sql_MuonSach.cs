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
    public class Sql_MuonSach
    {
        public static void MuonSach(En_MuonSach s)
        {
            SqlConnection conn = sqlConnectionData.KetNoi();
            SqlCommand cmd = new SqlCommand("PHIEUMUON_INSERT", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaPM", SqlDbType.Char, 5);
            cmd.Parameters.Add("@MaThe", SqlDbType.Char, 5);
            cmd.Parameters.Add("@MaSach", SqlDbType.Char, 5);
            cmd.Parameters.Add("@NgayMuon", SqlDbType.SmallDateTime);
            cmd.Parameters.Add("@HanTra", SqlDbType.SmallDateTime);
            
            cmd.Parameters["@MaPM"].Value = s.MaPM;
            cmd.Parameters["@MaThe"].Value = s.MaThe;
            cmd.Parameters["@MaSach"].Value = s.MaSach;
            cmd.Parameters["@NgayMuon"].Value = s.NgayMuon;
            cmd.Parameters["@HanTra"].Value = s.HanTra;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static DataTable SelectMaThe()
        {
            SqlConnection conn = sqlConnectionData.KetNoi();
            SqlCommand cmd = new SqlCommand("PHIEUMUON_SELECTMATHE", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            return dt;
        }

        public static DataTable TimKiemSach(string key)
        {
            SqlConnection conn = sqlConnectionData.KetNoi();
            SqlCommand cmd = new SqlCommand("TimKiemSach", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Key", SqlDbType.NVarChar, 100);
            cmd.Parameters["@Key"].Value = key;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            return dt;
        }

        public static DataTable ThongTinDocGia(string maThe)
        {
            return Sql_TimTV.TraCuuTV(maThe);
        }

        public static bool KiemTraDocGia(string maThe)
        {
            SqlConnection conn = sqlConnectionData.KetNoi();
            SqlCommand cmd = new SqlCommand("KIEMTRADOCGIA", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaThe", SqlDbType.Char, 5);
            cmd.Parameters["@MaThe"].Value = maThe;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            bool laThanhVien = false;
            if (dt.Rows.Count > 0)
                laThanhVien = true;
            return laThanhVien;
        }

        public static bool KiemTraSachDaMuon(string maThe, string maSach)
        {
            SqlConnection conn = sqlConnectionData.KetNoi();
            SqlCommand cmd = new SqlCommand("KIEMTRASACHDAMUON", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaThe", SqlDbType.Char, 5);
            cmd.Parameters.Add("@MaSach", SqlDbType.Char, 5);

            cmd.Parameters["@MaThe"].Value = maThe;
            cmd.Parameters["@MaSach"].Value = maSach;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            bool sachNayDaMuon = false;
            if (dt.Rows.Count > 0)
                sachNayDaMuon = true;
            return sachNayDaMuon;
        }
        /*
         dung de dem so sach DG da muon: 
         * tao 1 datatable chua tat ca cac MAPM cua DG do
         * voi moi MAPM trong datatable, kiem tra MAPM do co ton tai trong PHIEUTRA hay khong: neu khong: soSachDaMuon++, neu khong thi k sao
         
         */
        public static int SoSachDaMuon(string maDG)
        {
            int sosachdamuon = 0;
            SqlConnection conn = sqlConnectionData.KetNoi();
            SqlCommand cmd = new SqlCommand("DANHSACHPHIEUMUON", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaThe", SqlDbType.Char, 5);

            cmd.Parameters["@MaThe"].Value = maDG;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count > 0 )
            {
                for(int i =0; i < dt.Rows.Count; i++)
                {
                    SqlConnection _conn = sqlConnectionData.KetNoi();
                    SqlCommand _cmd = new SqlCommand("KIEMTRAPHIEUMUON", _conn);
                    _cmd.CommandType = CommandType.StoredProcedure;
                    _cmd.Parameters.Add("@MaPM", SqlDbType.Char, 5);

                    _cmd.Parameters["@MaPM"].Value = dt.Rows[i][0];
                  
                    SqlDataAdapter _da = new SqlDataAdapter(_cmd);
                    DataTable _dt = new DataTable();
                    _da.Fill(_dt);

                    // neu trong bang PHIEUTRA khong chua MAPM nay thi sach nay chua tra
                    if (_dt.Rows.Count <= 0)
                        sosachdamuon++;
                }
            }


            return sosachdamuon;
        }
        /*
         dung de kiem tra xem sach nay da tra hay chua
         * tao 1 datatable chua MAPM cua DG vs MASACH
         * voi moi MAPM, kiem tra xem co ton tai trong PHIEUTRA hay khong, neu khong -> chuaTra = true + return, neu co ->chuaTra = true
         */
        public static bool SachDaMuon(string maDG, string maSach)
        {
            bool  chuaTra = false;
            SqlConnection conn = sqlConnectionData.KetNoi();
            SqlCommand cmd = new SqlCommand("SACHDAMUON", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaThe", SqlDbType.Char, 5);
            cmd.Parameters.Add("@MaSach", SqlDbType.Char, 5);

            cmd.Parameters["@MaThe"].Value = maDG;
            cmd.Parameters["@MaSach"].Value = maSach;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // neu dt co > 1 row --> sach nay DG da muon nhung chua biet da tra hay chua
           

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    SqlConnection _conn = sqlConnectionData.KetNoi();
                    SqlCommand _cmd = new SqlCommand("KIEMTRAPHIEUMUON", _conn);
                    _cmd.CommandType = CommandType.StoredProcedure;
                    _cmd.Parameters.Add("@MaPM", SqlDbType.Char, 5);

                    _cmd.Parameters["@MaPM"].Value = dt.Rows[i][0];

                    SqlDataAdapter _da = new SqlDataAdapter(_cmd);
                    DataTable _dt = new DataTable();
                    _da.Fill(_dt);
                    // neu trong bang PHIEUTRA khong chua MAPM nay thi sach nay chua tra, break vong for
                    if (_dt.Rows.Count <= 0)
                    {
                        chuaTra = true;
                        break;
                    }
                }
            }

            // nguoc lai --> sach nay DG chua muon

            return chuaTra;
        }


        public static void Giam_SLSACH(string maSach)
        {
            SqlConnection conn = sqlConnectionData.KetNoi();
            SqlCommand cmd = new SqlCommand("GIAMSOLUONGSACH", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaSach", SqlDbType.Char, 5);

            cmd.Parameters["@MaSach"].Value = maSach;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
