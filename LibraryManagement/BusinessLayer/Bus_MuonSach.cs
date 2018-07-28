using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;
using DataAccessLayer;
using System.Data;
namespace BusinessLayer
{
    public class Bus_MuonSach
    {
        public static void MuonSach(En_MuonSach s)
        {
            Sql_MuonSach.MuonSach(s);
        }

        public static DataTable TimKiemSach(string key)
        {
            return Sql_MuonSach.TimKiemSach(key);
        }

        public static bool KiemTraDocGia(string maThe)
        {
            return Sql_MuonSach.KiemTraDocGia(maThe);
        }

        public static bool KiemTraSachDaMuon(string maThe, string maSach)
        {
            return Sql_MuonSach.KiemTraSachDaMuon(maThe, maSach);
        }
        public static DataTable ThongTinDocGia(string key)
        {
            return Sql_MuonSach.ThongTinDocGia(key);
        }

        public static int SoSachDaMuon(string maDG)
        {
            return Sql_MuonSach.SoSachDaMuon(maDG);
        }

        public static bool SachDaMuon(string maDG,string maSach)
        {
            return Sql_MuonSach.SachDaMuon(maDG, maSach);
        }

        public static void Giam_SLSACH(string maSach)
        {
            Sql_MuonSach.Giam_SLSACH(maSach);
        }
    }
}
