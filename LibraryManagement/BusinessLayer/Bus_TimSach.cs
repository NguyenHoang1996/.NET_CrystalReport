using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;
using ValueObject;

namespace BusinessLayer
{
    public class Bus_TimSach
    {
        public static DataTable TimSach(string key)
        {
            return Sql_TimSach.TimSach(key);
        }

        public static DataTable TraCuuSach(string maSach)
        {
            return Sql_TimSach.TraCuuSach(maSach);
        }

        public static void CapNhatSach(En_NhanSach sach)
        {
            Sql_TimSach.CapNhatSach(sach);
        }

        public static bool XoaSach(string maSach)
        {
            return Sql_TimSach.XoaSach(maSach);
        }
    }
}
