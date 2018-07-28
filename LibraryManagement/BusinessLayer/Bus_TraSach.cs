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
    public class Bus_TraSach
    {
        public static void TraSach(En_TraSach s)
        {
            Sql_TraSach.TraSach(s);
        }

        public static int LayTienNo(String MaThe)
        {
            return Sql_TraSach.LayTienNo(MaThe);
        }

        public static DataTable ThongTinSachMuon(string MaThe)
        {
            return Sql_TraSach.ThongTinSachMuon(MaThe);
        }

        public static void TaiKhoanNo_update(string maThe, string money)
        {
            Sql_TraSach.TaiKhoanNo_update(maThe, money);
        }

        public static void Tang_SLSACH(string maSach)
        {
            Sql_TraSach.Tang_SLSACH(maSach);
        }
    }
}
